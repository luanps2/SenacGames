# 🚀 Guia de Deploy no Azure — SenacGames

> **Aplicação:** SenacGames · **Stack:** .NET 8 · ASP.NET Core · SQL Server · Azure
>
> Este guia cobre o deploy completo e na ordem certa:
> 1. **Banco de Dados** → Azure SQL Database
> 2. **API** → Azure App Service
> 3. **UI** → Azure App Service (separado)

---

## 📋 Pré-requisitos

Antes de começar, certifique-se de ter:

| Requisito | Verificação |
|---|---|
| Conta Azure ativa | [portal.azure.com](https://portal.azure.com) |
| Azure CLI instalado | `az --version` |
| .NET 8 SDK instalado | `dotnet --version` (deve ser 8.x) |
| Git configurado | `git --version` |
| Acesso ao repositório | Clone local funcionando |

### Instalar o Azure CLI (se necessário)

```powershell
# Via winget (Windows)
winget install -e --id Microsoft.AzureCLI

# Verificar instalação
az --version
```

### Login no Azure

```powershell
az login
```

> O navegador será aberto. Faça login com sua conta Azure. Após o login, você verá a lista de assinaturas disponíveis no terminal.

### Definir a assinatura correta (se tiver mais de uma)

```powershell
az account list --output table
az account set --subscription "<ID-DA-SUA-ASSINATURA>"
```

---

## 🗂️ Definindo as Variáveis do Deploy

Execute os comandos abaixo no PowerShell para configurar todas as variáveis de uma vez. **Substitua os valores entre `<>` pelos seus dados reais.**

```powershell
# =============================================
# CONFIGURAÇÃO GERAL
# =============================================
$RESOURCE_GROUP = "rg-senacgames"
$LOCATION       = "brazilsouth"          # Região do Azure (mais próxima do Brasil)

# =============================================
# BANCO DE DADOS
# =============================================
$SQL_SERVER_NAME = "sql-senacgames"      # Nome único global
$SQL_DB_NAME     = "SenacGamesDb"
$SQL_ADMIN_USER  = "sqladmin"
$SQL_ADMIN_PASS  = "<SUA-SENHA-FORTE>"   # Mín. 8 chars, maiúsc., minúsc., número e símbolo

# =============================================
# API
# =============================================
$API_APP_NAME    = "app-senacgames-api"  # Nome único global
$API_PLAN_NAME   = "plan-senacgames-api"

# =============================================
# UI (Front-end MVC)
# =============================================
$UI_APP_NAME     = "app-senacgames-ui"   # Nome único global
$UI_PLAN_NAME    = "plan-senacgames-ui"
```

> ⚠️ **Atenção:** Os nomes de App Service e SQL Server precisam ser **globalmente únicos** no Azure.
> Se receber erro de nome já existente, adicione um sufixo (ex.: `app-senacgames-api-2025`).

---

## ETAPA 1 — Criar o Resource Group

O Resource Group é o contêiner lógico de todos os recursos do projeto.

```powershell
az group create `
  --name $RESOURCE_GROUP `
  --location $LOCATION
```

**Saída esperada:**
```json
{
  "location": "brazilsouth",
  "name": "rg-senacgames",
  "properties": { "provisioningState": "Succeeded" }
}
```

---

## ETAPA 2 — Banco de Dados (Azure SQL Database)

### 2.1 — Criar o SQL Server

```powershell
az sql server create `
  --name $SQL_SERVER_NAME `
  --resource-group $RESOURCE_GROUP `
  --location $LOCATION `
  --admin-user $SQL_ADMIN_USER `
  --admin-password $SQL_ADMIN_PASS
```

### 2.2 — Criar o banco de dados

```powershell
az sql db create `
  --resource-group $RESOURCE_GROUP `
  --server $SQL_SERVER_NAME `
  --name $SQL_DB_NAME `
  --edition GeneralPurpose `
  --compute-model Serverless `
  --family Gen5 `
  --capacity 2 `
  --auto-pause-delay 60
```

> 💡 **Serverless** pausa automaticamente o banco quando não está em uso, economizando custos.

### 2.3 — Liberar acesso dos App Services ao banco

```powershell
# Permite que os serviços do Azure (App Services) acessem o SQL Server
az sql server firewall-rule create `
  --resource-group $RESOURCE_GROUP `
  --server $SQL_SERVER_NAME `
  --name "AllowAzureServices" `
  --start-ip-address 0.0.0.0 `
  --end-ip-address 0.0.0.0
```

> 🔐 A regra `0.0.0.0 - 0.0.0.0` é especial: **não abre para a internet**, apenas permite tráfego de dentro da rede Azure.

### 2.4 — Obter a Connection String

```powershell
$SQL_CONNECTION_STRING = az sql db show-connection-string `
  --server $SQL_SERVER_NAME `
  --name $SQL_DB_NAME `
  --client ado.net `
  --output tsv

# Substituir placeholders pelo usuário e senha reais
$SQL_CONNECTION_STRING = $SQL_CONNECTION_STRING `
  -replace "<username>", $SQL_ADMIN_USER `
  -replace "<password>", $SQL_ADMIN_PASS

# Exibir a string para copiar
Write-Host "Connection String: $SQL_CONNECTION_STRING"
```

**Guarde essa connection string** — ela será usada nas próximas etapas.

---

## ETAPA 3 — Deploy da API (SenacGames.API)

### 3.1 — Criar o App Service Plan da API

```powershell
az appservice plan create `
  --name $API_PLAN_NAME `
  --resource-group $RESOURCE_GROUP `
  --location $LOCATION `
  --sku B1 `
  --is-linux
```

> O plano **B1 (Basic)** é o mínimo recomendado para produção. Para testes, use `F1` (gratuito), mas com limitações de CPU.

### 3.2 — Criar o App Service da API

```powershell
az webapp create `
  --resource-group $RESOURCE_GROUP `
  --plan $API_PLAN_NAME `
  --name $API_APP_NAME `
  --runtime "DOTNETCORE:8.0"
```

### 3.3 — Configurar as variáveis de ambiente da API

```powershell
az webapp config appsettings set `
  --resource-group $RESOURCE_GROUP `
  --name $API_APP_NAME `
  --settings `
    "ConnectionStrings__DefaultConnection=$SQL_CONNECTION_STRING" `
    "ASPNETCORE_ENVIRONMENT=Production"
```

> ⚠️ **Por que usar `ConnectionStrings__DefaultConnection`?**
> O Azure traduz `__` (duplo underscore) para `:` ao ler a configuração, equivalendo a
> `ConnectionStrings:DefaultConnection` no `appsettings.json`. Isso substitui a connection string local
> sem precisar alterar o código.

### 3.4 — Publicar a API

Navegue até a raiz do repositório e execute:

```powershell
# A partir da raiz do repositório:
cd c:\Users\Dell\source\repos\SenacGames

# Publicar a API em modo Release
dotnet publish SenacGames.API/SenacGames.API.csproj `
  --configuration Release `
  --output ./publish/api `
  --runtime linux-x64 `
  --self-contained false

# Compactar para envio
Compress-Archive -Path ./publish/api/* -DestinationPath ./publish/api.zip -Force

# Fazer o deploy via ZIP
az webapp deployment source config-zip `
  --resource-group $RESOURCE_GROUP `
  --name $API_APP_NAME `
  --src ./publish/api.zip
```

### 3.5 — Executar as Migrations (criar o banco)

Após o deploy da API, as migrations precisam ser aplicadas para criar as tabelas no Azure SQL.

**Opção A — Via EF Core CLI local apontando para o Azure SQL (recomendado)**

```powershell
# Instalar o EF Core Tools (caso não tenha)
dotnet tool install --global dotnet-ef

# Aplicar migrations apontando diretamente para o Azure SQL
dotnet ef database update `
  --project SenacGames.Infrastructure/SenacGames.Infrastructure.csproj `
  --startup-project SenacGames.API/SenacGames.API.csproj `
  --connection "$SQL_CONNECTION_STRING"
```

**Opção B — Startup automático (já configurado no código)**

A API já possui `SeedData.SeedAsync(app.Services)` no `Program.cs`, que será executado na primeira inicialização.
O Entity Framework aplicará as migrations automaticamente se a API estiver configurada para isso.

> ✅ **Recomendamos a Opção A** para ter controle explícito sobre quando o schema é modificado.

### 3.6 — Verificar o deploy da API

```powershell
# Obter a URL da API
$API_URL = "https://$API_APP_NAME.azurewebsites.net"
Write-Host "URL da API: $API_URL"

# Testar se a aplicação responde
Invoke-WebRequest -Uri "$API_URL" -UseBasicParsing
```

Acesse `https://<API_APP_NAME>.azurewebsites.net/swagger` no navegador para confirmar que a API está online.

> ⚠️ **O Swagger está desabilitado em produção por padrão** (ver Program.cs).
> Para habilitá-lo temporariamente durante a validação, adicione esta configuração:

```powershell
az webapp config appsettings set `
  --resource-group $RESOURCE_GROUP `
  --name $API_APP_NAME `
  --settings "ASPNETCORE_ENVIRONMENT=Development"
```

> Após a validação, reverta para `Production`.

---

## ETAPA 4 — Deploy da UI (SenacGames.UI)

### 4.1 — Criar o App Service Plan da UI

```powershell
az appservice plan create `
  --name $UI_PLAN_NAME `
  --resource-group $RESOURCE_GROUP `
  --location $LOCATION `
  --sku B1 `
  --is-linux
```

### 4.2 — Criar o App Service da UI

```powershell
az webapp create `
  --resource-group $RESOURCE_GROUP `
  --plan $UI_PLAN_NAME `
  --name $UI_APP_NAME `
  --runtime "DOTNETCORE:8.0"
```

### 4.3 — Configurar a URL da API para a UI

A UI precisa saber onde a API está. O `ApiEndpointResolver.cs` lê `ApiSettings:BaseUrl` do `appsettings.json`,
que no Azure é sobrescrito por variável de ambiente.

```powershell
$API_URL = "https://$API_APP_NAME.azurewebsites.net"

az webapp config appsettings set `
  --resource-group $RESOURCE_GROUP `
  --name $UI_APP_NAME `
  --settings `
    "ApiSettings__BaseUrl=$API_URL" `
    "ASPNETCORE_ENVIRONMENT=Production"
```

> 🔑 **Importante:** O `ApiEndpointResolver.cs` tenta primeiro ler o `launchSettings.json` (que não existe no servidor)
> e depois cai no fallback de `appsettings.json -> ApiSettings:BaseUrl`. Por isso, a variável
> `ApiSettings__BaseUrl` **deve estar configurada** no App Service da UI.

### 4.4 — Publicar a UI

```powershell
# A partir da raiz do repositório:
dotnet publish SenacGames.UI/SenacGames.UI.csproj `
  --configuration Release `
  --output ./publish/ui `
  --runtime linux-x64 `
  --self-contained false

# Compactar
Compress-Archive -Path ./publish/ui/* -DestinationPath ./publish/ui.zip -Force

# Deploy
az webapp deployment source config-zip `
  --resource-group $RESOURCE_GROUP `
  --name $UI_APP_NAME `
  --src ./publish/ui.zip
```

### 4.5 — Verificar o deploy da UI

```powershell
$UI_URL = "https://$UI_APP_NAME.azurewebsites.net"
Write-Host "URL da UI: $UI_URL"

Invoke-WebRequest -Uri $UI_URL -UseBasicParsing
```

Acesse `https://<UI_APP_NAME>.azurewebsites.net` no navegador. A página inicial do SenacGames deve aparecer.

---

## ETAPA 5 — Atualizar o CORS da API

Por padrão a API está com `AllowAll` CORS (ver `Program.cs`), que funciona. Para produção com mais segurança,
restrinja ao domínio da UI:

```powershell
# Opcional — restringir CORS ao domínio da UI
az webapp cors add `
  --resource-group $RESOURCE_GROUP `
  --name $API_APP_NAME `
  --allowed-origins "https://$UI_APP_NAME.azurewebsites.net"
```

---

## ETAPA 6 — Checklist de Validação Final

Execute este checklist depois do deploy para garantir que tudo está funcionando:

### Banco de Dados
- [ ] Azure SQL Server criado com sucesso
- [ ] Banco de dados `SenacGamesDb` criado
- [ ] Regra de firewall `AllowAzureServices` configurada
- [ ] Migrations aplicadas (tabelas existem no banco)
- [ ] Seed data executado (usuário admin criado)

### API
- [ ] App Service da API online: `https://<API_APP_NAME>.azurewebsites.net`
- [ ] Variável `ConnectionStrings__DefaultConnection` configurada
- [ ] Aplicação responde sem erros 500
- [ ] Endpoint de login funciona (teste via Swagger ou curl)

### UI
- [ ] App Service da UI online: `https://<UI_APP_NAME>.azurewebsites.net`
- [ ] Variável `ApiSettings__BaseUrl` aponta para a URL correta da API
- [ ] Página inicial carrega sem erros
- [ ] Login de usuário funciona
- [ ] Listagem de games carrega corretamente

---

## Diagnóstico de Problemas Comuns

### Erro 502 Bad Gateway

A aplicação não subiu corretamente. Verifique os logs:

```powershell
# Logs em tempo real da API
az webapp log tail --resource-group $RESOURCE_GROUP --name $API_APP_NAME

# Logs em tempo real da UI
az webapp log tail --resource-group $RESOURCE_GROUP --name $UI_APP_NAME
```

### Erro de conexão com banco (Cannot connect to SQL Server)

1. Confirme que a connection string está correta:
```powershell
az webapp config appsettings list --resource-group $RESOURCE_GROUP --name $API_APP_NAME --output table
```
2. Confirme que a regra de firewall `AllowAzureServices` existe:
```powershell
az sql server firewall-rule list --resource-group $RESOURCE_GROUP --server $SQL_SERVER_NAME --output table
```

### UI mostra erro ao conectar à API

O `ApiEndpointResolver` não encontrou a URL da API. Verifique:
```powershell
az webapp config appsettings list --resource-group $RESOURCE_GROUP --name $UI_APP_NAME --output table
# Deve existir: ApiSettings__BaseUrl = https://<API_APP_NAME>.azurewebsites.net
```

### Erro 401 em todas as chamadas da UI à API

O cookie de autenticação pode estar sendo bloqueado por HTTPS. Verifique se ambos os App Services
estão usando HTTPS (padrão no Azure) e se o CORS está configurado corretamente.

### Migrations não aplicadas (tabelas não existem)

Execute manualmente:
```powershell
dotnet ef database update `
  --project SenacGames.Infrastructure/SenacGames.Infrastructure.csproj `
  --startup-project SenacGames.API/SenacGames.API.csproj `
  --connection "$SQL_CONNECTION_STRING"
```

---

## Atualizando o Deploy (Re-deploy)

Para atualizar a aplicação após mudanças no código:

```powershell
# Re-publicar a API
dotnet publish SenacGames.API/SenacGames.API.csproj -c Release -o ./publish/api --runtime linux-x64 --self-contained false
Compress-Archive -Path ./publish/api/* -DestinationPath ./publish/api.zip -Force
az webapp deployment source config-zip --resource-group $RESOURCE_GROUP --name $API_APP_NAME --src ./publish/api.zip

# Re-publicar a UI
dotnet publish SenacGames.UI/SenacGames.UI.csproj -c Release -o ./publish/ui --runtime linux-x64 --self-contained false
Compress-Archive -Path ./publish/ui/* -DestinationPath ./publish/ui.zip -Force
az webapp deployment source config-zip --resource-group $RESOURCE_GROUP --name $UI_APP_NAME --src ./publish/ui.zip
```

Se houver novas migrations, execute o `dotnet ef database update` novamente antes de re-deployar a API.

---

## Estimativa de Custo (Plano B1)

| Recurso | Tipo | Custo aprox./mês |
|---|---|---|
| Azure SQL Database | Serverless Gen5 2vCores | ~$15-30 (conforme uso) |
| App Service API | B1 Linux | ~$13 |
| App Service UI | B1 Linux | ~$13 |
| **Total estimado** | | **~$40-55/mês** |

> Para ambientes de desenvolvimento/teste, use `F1` (gratuito) nos App Services e `Basic` no SQL.

---

## Limpeza de Recursos (Remover tudo)

Para excluir todos os recursos e parar de ser cobrado:

```powershell
az group delete --name $RESOURCE_GROUP --yes --no-wait
```

> ⚠️ **Essa operação é irreversível.** Todos os dados do banco serão perdidos.

---

## Resumo das URLs Finais

Após o deploy bem-sucedido, você terá:

| Componente | URL |
|---|---|
| **UI (SenacGames)** | `https://<UI_APP_NAME>.azurewebsites.net` |
| **API (SenacGames.API)** | `https://<API_APP_NAME>.azurewebsites.net` |
| **Swagger (API)** | `https://<API_APP_NAME>.azurewebsites.net/swagger` *(somente em Development)* |
| **Azure Portal** | [portal.azure.com](https://portal.azure.com) → Resource Group `rg-senacgames` |

// =============================================================================
// SenacGames.Desktop - Forms/LoginForm.Designer.cs
// =============================================================================
// ️ ARQUIVO GERADO PELO DESIGNER — NÃO EDITE MANUALMENTE
// Toda lógica de negócio deve estar em LoginForm.cs
// =============================================================================

namespace SenacGames.Desktop.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        // =====================================================================
        // DECLARAÇÕES DOS CONTROLES — todos como campos privados
        // =====================================================================

        // Lado esquerdo — branding
        private System.Windows.Forms.Panel pnlDetalhe;
        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblVersao;

        // Card direito
        private Guna.UI2.WinForms.Guna2Panel pnlCard;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Label lblSubCard;
        private System.Windows.Forms.Panel pnlSep;
        private System.Windows.Forms.Label lblEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label lblSenha;
        private Guna.UI2.WinForms.Guna2TextBox txtSenha;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.Label lblCarregando;
        private Guna.UI2.WinForms.Guna2Button btnEntrar;
        private System.Windows.Forms.Panel pnlSep2;
        private System.Windows.Forms.Label lblAjuda;
        private System.Windows.Forms.Label lblApi;

        // =====================================================================
        // INITIALIZECOMPONENT — formato padrão do Windows Forms Designer
        // =====================================================================
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlDetalhe = new Panel();
            lblApp = new Label();
            lblSubtitulo = new Label();
            lblInfo = new Label();
            lblVersao = new Label();
            pnlCard = new Guna.UI2.WinForms.Guna2Panel();
            lblBemVindo = new Label();
            lblSubCard = new Label();
            pnlSep = new Panel();
            lblEmail = new Label();
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            lblSenha = new Label();
            txtSenha = new Guna.UI2.WinForms.Guna2TextBox();
            lblErro = new Label();
            lblCarregando = new Label();
            btnEntrar = new Guna.UI2.WinForms.Guna2Button();
            pnlSep2 = new Panel();
            lblAjuda = new Label();
            lblApi = new Label();
            pnlCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDetalhe
            // 
            pnlDetalhe.BackColor = Color.FromArgb(255, 102, 0);
            pnlDetalhe.Location = new Point(60, 110);
            pnlDetalhe.Name = "pnlDetalhe";
            pnlDetalhe.Size = new Size(4, 80);
            pnlDetalhe.TabIndex = 0;
            // 
            // lblApp
            // 
            lblApp.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblApp.ForeColor = Color.White;
            lblApp.Location = new Point(60, 120);
            lblApp.Name = "lblApp";
            lblApp.Size = new Size(380, 60);
            lblApp.TabIndex = 1;
            lblApp.Text = "SenacGames";
            lblApp.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Font = new Font("Segoe UI", 12F);
            lblSubtitulo.ForeColor = Color.FromArgb(200, 220, 255);
            lblSubtitulo.Location = new Point(60, 190);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(380, 60);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Sistema de Gerenciamento\r\nde Jogos Educacionais";
            // 
            // lblInfo
            // 
            lblInfo.Font = new Font("Segoe UI", 9.5F);
            lblInfo.ForeColor = Color.FromArgb(180, 210, 255);
            lblInfo.Location = new Point(60, 290);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(380, 120);
            lblInfo.TabIndex = 3;
            lblInfo.Text = "• Cliente administrativo Windows\r\n• Gerenciamento completo de games\r\n• Controle de categorias e usuários\r\n• Dashboard com estatísticas";
            // 
            // lblVersao
            // 
            lblVersao.Font = new Font("Segoe UI", 8F);
            lblVersao.ForeColor = Color.FromArgb(140, 170, 210);
            lblVersao.Location = new Point(60, 580);
            lblVersao.Name = "lblVersao";
            lblVersao.Size = new Size(380, 25);
            lblVersao.TabIndex = 4;
            lblVersao.Text = "Versão 1.0.0 | © SENAC-SP";
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.Transparent;
            pnlCard.BorderRadius = 16;
            pnlCard.Controls.Add(lblBemVindo);
            pnlCard.Controls.Add(lblSubCard);
            pnlCard.Controls.Add(pnlSep);
            pnlCard.Controls.Add(lblEmail);
            pnlCard.Controls.Add(txtEmail);
            pnlCard.Controls.Add(lblSenha);
            pnlCard.Controls.Add(txtSenha);
            pnlCard.Controls.Add(lblErro);
            pnlCard.Controls.Add(lblCarregando);
            pnlCard.Controls.Add(btnEntrar);
            pnlCard.Controls.Add(pnlSep2);
            pnlCard.Controls.Add(lblAjuda);
            pnlCard.Controls.Add(lblApi);
            pnlCard.CustomizableEdges = customizableEdges7;
            pnlCard.FillColor = Color.White;
            pnlCard.Location = new Point(490, 45);
            pnlCard.Name = "pnlCard";
            pnlCard.ShadowDecoration.Color = Color.FromArgb(50, 0, 0, 0);
            pnlCard.ShadowDecoration.CustomizableEdges = customizableEdges8;
            pnlCard.ShadowDecoration.Depth = 20;
            pnlCard.ShadowDecoration.Enabled = true;
            pnlCard.Size = new Size(420, 560);
            pnlCard.TabIndex = 5;
            // 
            // lblBemVindo
            // 
            lblBemVindo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblBemVindo.ForeColor = Color.FromArgb(0, 75, 135);
            lblBemVindo.Location = new Point(30, 40);
            lblBemVindo.Name = "lblBemVindo";
            lblBemVindo.Size = new Size(360, 45);
            lblBemVindo.TabIndex = 0;
            lblBemVindo.Text = "Bem-vindo!";
            lblBemVindo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSubCard
            // 
            lblSubCard.Font = new Font("Segoe UI", 9.5F);
            lblSubCard.ForeColor = Color.FromArgb(150, 160, 175);
            lblSubCard.Location = new Point(30, 88);
            lblSubCard.Name = "lblSubCard";
            lblSubCard.Size = new Size(360, 25);
            lblSubCard.TabIndex = 1;
            lblSubCard.Text = "Faça login com sua conta SENAC";
            lblSubCard.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlSep
            // 
            pnlSep.BackColor = Color.FromArgb(224, 228, 235);
            pnlSep.Location = new Point(30, 125);
            pnlSep.Name = "pnlSep";
            pnlSep.Size = new Size(360, 1);
            pnlSep.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(51, 61, 75);
            lblEmail.Location = new Point(30, 148);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(360, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "E-MAIL";
            // 
            // txtEmail
            // 
            txtEmail.BorderColor = Color.FromArgb(224, 228, 235);
            txtEmail.BorderRadius = 8;
            txtEmail.BorderThickness = 2;
            txtEmail.CustomizableEdges = customizableEdges1;
            txtEmail.DefaultText = "admin@senacgames.com";
            txtEmail.FillColor = Color.FromArgb(245, 247, 250);
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.ForeColor = Color.FromArgb(51, 61, 75);
            txtEmail.Location = new Point(30, 170);
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(10, 0, 10, 0);
            txtEmail.PlaceholderForeColor = Color.FromArgb(150, 160, 175);
            txtEmail.PlaceholderText = "seu@email.com.br";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtEmail.Size = new Size(360, 42);
            txtEmail.TabIndex = 4;
            txtEmail.KeyDown += TxtEmail_KeyDown;
            // 
            // lblSenha
            // 
            lblSenha.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblSenha.ForeColor = Color.FromArgb(51, 61, 75);
            lblSenha.Location = new Point(30, 233);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(360, 20);
            lblSenha.TabIndex = 5;
            lblSenha.Text = "SENHA";
            // 
            // txtSenha
            // 
            txtSenha.BorderColor = Color.FromArgb(224, 228, 235);
            txtSenha.BorderRadius = 8;
            txtSenha.BorderThickness = 2;
            txtSenha.CustomizableEdges = customizableEdges3;
            txtSenha.DefaultText = "Admin@123";
            txtSenha.FillColor = Color.FromArgb(245, 247, 250);
            txtSenha.Font = new Font("Segoe UI", 10F);
            txtSenha.ForeColor = Color.FromArgb(51, 61, 75);
            txtSenha.Location = new Point(30, 255);
            txtSenha.Name = "txtSenha";
            txtSenha.Padding = new Padding(10, 0, 10, 0);
            txtSenha.PlaceholderForeColor = Color.FromArgb(150, 160, 175);
            txtSenha.PlaceholderText = "••••••••";
            txtSenha.SelectedText = "";
            txtSenha.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtSenha.Size = new Size(360, 42);
            txtSenha.TabIndex = 6;
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.KeyDown += TxtSenha_KeyDown;
            // 
            // lblErro
            // 
            lblErro.Font = new Font("Segoe UI", 9F);
            lblErro.ForeColor = Color.FromArgb(220, 53, 69);
            lblErro.Location = new Point(30, 310);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(360, 36);
            lblErro.TabIndex = 7;
            lblErro.TextAlign = ContentAlignment.MiddleLeft;
            lblErro.Visible = false;
            // 
            // lblCarregando
            // 
            lblCarregando.Font = new Font("Segoe UI", 9F);
            lblCarregando.ForeColor = Color.FromArgb(0, 102, 204);
            lblCarregando.Location = new Point(30, 318);
            lblCarregando.Name = "lblCarregando";
            lblCarregando.Size = new Size(360, 25);
            lblCarregando.TabIndex = 8;
            lblCarregando.Text = "⏳ Autenticando...";
            lblCarregando.TextAlign = ContentAlignment.MiddleCenter;
            lblCarregando.Visible = false;
            // 
            // btnEntrar
            // 
            btnEntrar.Animated = true;
            btnEntrar.BorderRadius = 8;
            btnEntrar.CustomizableEdges = customizableEdges5;
            btnEntrar.FillColor = Color.FromArgb(0, 75, 135);
            btnEntrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.HoverState.FillColor = Color.FromArgb(0, 102, 204);
            btnEntrar.Location = new Point(30, 360);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnEntrar.Size = new Size(360, 46);
            btnEntrar.TabIndex = 9;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.Click += BtnEntrar_Click;
            // 
            // pnlSep2
            // 
            pnlSep2.BackColor = Color.FromArgb(224, 228, 235);
            pnlSep2.Location = new Point(30, 430);
            pnlSep2.Name = "pnlSep2";
            pnlSep2.Size = new Size(360, 1);
            pnlSep2.TabIndex = 10;
            // 
            // lblAjuda
            // 
            lblAjuda.Font = new Font("Segoe UI", 8.5F);
            lblAjuda.ForeColor = Color.FromArgb(150, 160, 175);
            lblAjuda.Location = new Point(30, 445);
            lblAjuda.Name = "lblAjuda";
            lblAjuda.Size = new Size(360, 40);
            lblAjuda.TabIndex = 11;
            lblAjuda.Text = "Problemas para acessar? Contate o administrador do sistema.";
            lblAjuda.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblApi
            // 
            lblApi.Font = new Font("Segoe UI", 8F);
            lblApi.ForeColor = Color.FromArgb(150, 160, 175);
            lblApi.Location = new Point(30, 510);
            lblApi.Name = "lblApi";
            lblApi.Size = new Size(360, 20);
            lblApi.TabIndex = 12;
            lblApi.Text = "🌐 API: ...";
            lblApi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 650);
            Controls.Add(pnlDetalhe);
            Controls.Add(lblApp);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblInfo);
            Controls.Add(lblVersao);
            Controls.Add(pnlCard);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SenacGames - Login";
            Load += LoginForm_Load;
            pnlCard.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}

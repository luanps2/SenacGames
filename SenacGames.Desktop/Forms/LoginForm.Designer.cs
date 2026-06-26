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
            this.components = new System.ComponentModel.Container();

            // ─── Instanciar todos os controles ────────────────────────────────
            this.pnlDetalhe = new System.Windows.Forms.Panel();
            this.lblApp = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.pnlCard = new Guna.UI2.WinForms.Guna2Panel();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.lblSubCard = new System.Windows.Forms.Label();
            this.pnlSep = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblErro = new System.Windows.Forms.Label();
            this.lblCarregando = new System.Windows.Forms.Label();
            this.btnEntrar = new Guna.UI2.WinForms.Guna2Button();
            this.pnlSep2 = new System.Windows.Forms.Panel();
            this.lblAjuda = new System.Windows.Forms.Label();
            this.lblApi = new System.Windows.Forms.Label();

            // SuspendLayout
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();

            // ─── pnlDetalhe ───────────────────────────────────────────────────
            this.pnlDetalhe.BackColor = System.Drawing.Color.FromArgb(255, 102, 0);
            this.pnlDetalhe.Location = new System.Drawing.Point(60, 110);
            this.pnlDetalhe.Name = "pnlDetalhe";
            this.pnlDetalhe.Size = new System.Drawing.Size(4, 80);
            this.pnlDetalhe.TabIndex = 0;

            // ─── lblApp ───────────────────────────────────────────────────────
            this.lblApp.AutoSize = false;
            this.lblApp.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblApp.ForeColor = System.Drawing.Color.White;
            this.lblApp.Location = new System.Drawing.Point(60, 120);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(380, 60);
            this.lblApp.TabIndex = 1;
            this.lblApp.Text = "SenacGames";
            this.lblApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ─── lblSubtitulo ─────────────────────────────────────────────────
            this.lblSubtitulo.AutoSize = false;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(200, 220, 255);
            this.lblSubtitulo.Location = new System.Drawing.Point(60, 190);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(380, 60);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Sistema de Gerenciamento\r\nde Jogos Educacionais";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.TopLeft;

            // ─── lblInfo ──────────────────────────────────────────────────────
            this.lblInfo.AutoSize = false;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(180, 210, 255);
            this.lblInfo.Location = new System.Drawing.Point(60, 290);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(380, 120);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "• Cliente administrativo Windows\r\n• Gerenciamento completo de games\r\n• Controle de categorias e usuários\r\n• Dashboard com estatísticas";

            // ─── lblVersao ────────────────────────────────────────────────────
            this.lblVersao.AutoSize = false;
            this.lblVersao.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblVersao.ForeColor = System.Drawing.Color.FromArgb(140, 170, 210);
            this.lblVersao.Location = new System.Drawing.Point(60, 580);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(380, 25);
            this.lblVersao.TabIndex = 4;
            this.lblVersao.Text = "Versão 1.0.0 | © SENAC-SP";

            // ─── pnlCard ──────────────────────────────────────────────────────
            this.pnlCard.BorderRadius = 16;
            this.pnlCard.FillColor = System.Drawing.Color.White;
            this.pnlCard.Location = new System.Drawing.Point(490, 45);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.ShadowDecoration.Color = System.Drawing.Color.FromArgb(50, 0, 0, 0);
            this.pnlCard.ShadowDecoration.Depth = 20;
            this.pnlCard.ShadowDecoration.Enabled = true;
            this.pnlCard.Size = new System.Drawing.Size(420, 560);
            this.pnlCard.TabIndex = 5;

            // ─── lblBemVindo ──────────────────────────────────────────────────
            this.lblBemVindo.AutoSize = false;
            this.lblBemVindo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblBemVindo.ForeColor = System.Drawing.Color.FromArgb(0, 75, 135);
            this.lblBemVindo.Location = new System.Drawing.Point(30, 40);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(360, 45);
            this.lblBemVindo.TabIndex = 0;
            this.lblBemVindo.Text = "Bem-vindo!";
            this.lblBemVindo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ─── lblSubCard ───────────────────────────────────────────────────
            this.lblSubCard.AutoSize = false;
            this.lblSubCard.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubCard.ForeColor = System.Drawing.Color.FromArgb(150, 160, 175);
            this.lblSubCard.Location = new System.Drawing.Point(30, 88);
            this.lblSubCard.Name = "lblSubCard";
            this.lblSubCard.Size = new System.Drawing.Size(360, 25);
            this.lblSubCard.TabIndex = 1;
            this.lblSubCard.Text = "Faça login com sua conta SENAC";
            this.lblSubCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ─── pnlSep ───────────────────────────────────────────────────────
            this.pnlSep.BackColor = System.Drawing.Color.FromArgb(224, 228, 235);
            this.pnlSep.Location = new System.Drawing.Point(30, 125);
            this.pnlSep.Name = "pnlSep";
            this.pnlSep.Size = new System.Drawing.Size(360, 1);
            this.pnlSep.TabIndex = 2;

            // ─── lblEmail ─────────────────────────────────────────────────────
            this.lblEmail.AutoSize = false;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(51, 61, 75);
            this.lblEmail.Location = new System.Drawing.Point(30, 148);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(360, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-MAIL";

            // ─── txtEmail ─────────────────────────────────────────────────────
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(224, 228, 235);
            this.txtEmail.BorderRadius = 8;
            this.txtEmail.BorderThickness = 2;
            this.txtEmail.FillColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(51, 61, 75);
            this.txtEmail.Location = new System.Drawing.Point(30, 170);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.FromArgb(150, 160, 175);
            this.txtEmail.PlaceholderText = "seu@email.com.br";
            this.txtEmail.Size = new System.Drawing.Size(360, 42);
            this.txtEmail.TabIndex = 4;

            // ─── lblSenha ─────────────────────────────────────────────────────
            this.lblSenha.AutoSize = false;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(51, 61, 75);
            this.lblSenha.Location = new System.Drawing.Point(30, 233);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(360, 20);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "SENHA";

            // ─── txtSenha ─────────────────────────────────────────────────────
            this.txtSenha.BorderColor = System.Drawing.Color.FromArgb(224, 228, 235);
            this.txtSenha.BorderRadius = 8;
            this.txtSenha.BorderThickness = 2;
            this.txtSenha.FillColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(51, 61, 75);
            this.txtSenha.Location = new System.Drawing.Point(30, 255);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtSenha.PlaceholderForeColor = System.Drawing.Color.FromArgb(150, 160, 175);
            this.txtSenha.PlaceholderText = "••••••••";
            this.txtSenha.Size = new System.Drawing.Size(360, 42);
            this.txtSenha.TabIndex = 6;
            this.txtSenha.UseSystemPasswordChar = true;

            // ─── lblErro ──────────────────────────────────────────────────────
            this.lblErro.AutoSize = false;
            this.lblErro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblErro.ForeColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.lblErro.Location = new System.Drawing.Point(30, 310);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(360, 36);
            this.lblErro.TabIndex = 7;
            this.lblErro.Text = "";
            this.lblErro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErro.Visible = false;

            // ─── lblCarregando ────────────────────────────────────────────────
            this.lblCarregando.AutoSize = false;
            this.lblCarregando.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCarregando.ForeColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.lblCarregando.Location = new System.Drawing.Point(30, 318);
            this.lblCarregando.Name = "lblCarregando";
            this.lblCarregando.Size = new System.Drawing.Size(360, 25);
            this.lblCarregando.TabIndex = 8;
            this.lblCarregando.Text = "⏳ Autenticando...";
            this.lblCarregando.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCarregando.Visible = false;

            // ─── btnEntrar ────────────────────────────────────────────────────
            this.btnEntrar.Animated = true;
            this.btnEntrar.FillColor = System.Drawing.Color.FromArgb(0, 75, 135);
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.HoverState.FillColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.btnEntrar.BorderRadius = 8;
            this.btnEntrar.Location = new System.Drawing.Point(30, 360);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(360, 46);
            this.btnEntrar.TabIndex = 9;
            this.btnEntrar.Text = "ENTRAR";

            // ─── pnlSep2 ──────────────────────────────────────────────────────
            this.pnlSep2.BackColor = System.Drawing.Color.FromArgb(224, 228, 235);
            this.pnlSep2.Location = new System.Drawing.Point(30, 430);
            this.pnlSep2.Name = "pnlSep2";
            this.pnlSep2.Size = new System.Drawing.Size(360, 1);
            this.pnlSep2.TabIndex = 10;

            // ─── lblAjuda ─────────────────────────────────────────────────────
            this.lblAjuda.AutoSize = false;
            this.lblAjuda.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblAjuda.ForeColor = System.Drawing.Color.FromArgb(150, 160, 175);
            this.lblAjuda.Location = new System.Drawing.Point(30, 445);
            this.lblAjuda.Name = "lblAjuda";
            this.lblAjuda.Size = new System.Drawing.Size(360, 40);
            this.lblAjuda.TabIndex = 11;
            this.lblAjuda.Text = "Problemas para acessar? Contate o administrador do sistema.";
            this.lblAjuda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ─── lblApi ───────────────────────────────────────────────────────
            this.lblApi.AutoSize = false;
            this.lblApi.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblApi.ForeColor = System.Drawing.Color.FromArgb(150, 160, 175);
            this.lblApi.Location = new System.Drawing.Point(30, 510);
            this.lblApi.Name = "lblApi";
            this.lblApi.Size = new System.Drawing.Size(360, 20);
            this.lblApi.TabIndex = 12;
            this.lblApi.Text = "🌐 API: ...";
            this.lblApi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ─── Montar pnlCard ───────────────────────────────────────────────
            this.pnlCard.Controls.Add(this.lblBemVindo);
            this.pnlCard.Controls.Add(this.lblSubCard);
            this.pnlCard.Controls.Add(this.pnlSep);
            this.pnlCard.Controls.Add(this.lblEmail);
            this.pnlCard.Controls.Add(this.txtEmail);
            this.pnlCard.Controls.Add(this.lblSenha);
            this.pnlCard.Controls.Add(this.txtSenha);
            this.pnlCard.Controls.Add(this.lblErro);
            this.pnlCard.Controls.Add(this.lblCarregando);
            this.pnlCard.Controls.Add(this.btnEntrar);
            this.pnlCard.Controls.Add(this.pnlSep2);
            this.pnlCard.Controls.Add(this.lblAjuda);
            this.pnlCard.Controls.Add(this.lblApi);

            // ─── Configuração do Form ─────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.pnlDetalhe);
            this.Controls.Add(this.lblApp);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.pnlCard);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SenacGames - Login";

            // ─── Eventos ──────────────────────────────────────────────────────
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.btnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtEmail_KeyDown);
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSenha_KeyDown);

            // ResumeLayout
            this.pnlCard.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}

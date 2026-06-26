// =============================================================================
// SenacGames.Desktop - Forms/MainForm.Designer.cs
// =============================================================================
// ️ ARQUIVO GERADO PELO DESIGNER — NÃO EDITE MANUALMENTE
// Toda lógica de negócio deve estar em MainForm.cs
// =============================================================================

namespace SenacGames.Desktop.Forms
{
    partial class MainForm
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

        // Header
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTituloApp;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPerfil;
        private Guna.UI2.WinForms.Guna2Button btnLogout;

        // Sidebar
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblSidebarLogo;
        private System.Windows.Forms.Label lblSidebarSub;
        private System.Windows.Forms.Panel pnlLogoDivisor;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnGames;
        private Guna.UI2.WinForms.Guna2Button btnCategorias;
        private Guna.UI2.WinForms.Guna2Button btnUsuarios;
        private Guna.UI2.WinForms.Guna2Button btnPerfil;
        private System.Windows.Forms.Label lblSessao;

        // Conteúdo
        private System.Windows.Forms.Panel pnlConteudo;

        // =====================================================================
        // INITIALIZECOMPONENT — formato padrão do Windows Forms Designer
        // =====================================================================
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ─── Instanciar todos os controles ────────────────────────────────
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTituloApp = new System.Windows.Forms.Label();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblSidebarLogo = new System.Windows.Forms.Label();
            this.lblSidebarSub = new System.Windows.Forms.Label();
            this.pnlLogoDivisor = new System.Windows.Forms.Panel();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.btnGames = new Guna.UI2.WinForms.Guna2Button();
            this.btnCategorias = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsuarios = new Guna.UI2.WinForms.Guna2Button();
            this.btnPerfil = new Guna.UI2.WinForms.Guna2Button();
            this.lblSessao = new System.Windows.Forms.Label();
            this.pnlConteudo = new System.Windows.Forms.Panel();

            // SuspendLayout
            this.pnlHeader.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.SuspendLayout();

            // ─── pnlHeader ────────────────────────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTituloApp);
            this.pnlHeader.Controls.Add(this.pnlUsuario);
            this.pnlHeader.Controls.Add(this.btnLogout);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 60;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.pnlHeader.TabIndex = 0;

            // ─── lblTituloApp ─────────────────────────────────────────────────
            this.lblTituloApp.AutoSize = true;
            this.lblTituloApp.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTituloApp.ForeColor = System.Drawing.Color.FromArgb(0, 75, 135);
            this.lblTituloApp.Location = new System.Drawing.Point(230, 0);
            this.lblTituloApp.Name = "lblTituloApp";
            this.lblTituloApp.TabIndex = 0;
            this.lblTituloApp.Text = "⬡ SenacGames";

            // ─── pnlUsuario ───────────────────────────────────────────────────
            this.pnlUsuario.AutoSize = true;
            this.pnlUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pnlUsuario.Controls.Add(this.lblUsuario);
            this.pnlUsuario.Controls.Add(this.lblPerfil);
            this.pnlUsuario.Location = new System.Drawing.Point(0, 0);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.TabIndex = 1;

            // ─── lblUsuario ───────────────────────────────────────────────────
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(30, 38, 50);
            this.lblUsuario.Location = new System.Drawing.Point(0, 12);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "👤 Usuário";

            // ─── lblPerfil ────────────────────────────────────────────────────
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblPerfil.ForeColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.lblPerfil.Location = new System.Drawing.Point(0, 32);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.TabIndex = 1;
            this.lblPerfil.Text = "Perfil";

            // ─── btnLogout ────────────────────────────────────────────────────
            this.btnLogout.Animated = true;
            this.btnLogout.BorderColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnLogout.BorderRadius = 6;
            this.btnLogout.BorderThickness = 1;
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnLogout.Location = new System.Drawing.Point(800, 13);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(80, 34);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Sair";

            // ─── pnlSidebar ───────────────────────────────────────────────────
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(0, 75, 135);
            this.pnlSidebar.Controls.Add(this.btnPerfil);
            this.pnlSidebar.Controls.Add(this.btnUsuarios);
            this.pnlSidebar.Controls.Add(this.btnCategorias);
            this.pnlSidebar.Controls.Add(this.btnGames);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.pnlLogoDivisor);
            this.pnlSidebar.Controls.Add(this.pnlLogo);
            this.pnlSidebar.Controls.Add(this.lblSessao);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.TabIndex = 1;
            this.pnlSidebar.Width = 220;

            // ─── pnlLogo ──────────────────────────────────────────────────────
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(0, 40, 100);
            this.pnlLogo.Controls.Add(this.lblSidebarLogo);
            this.pnlLogo.Controls.Add(this.lblSidebarSub);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Height = 60;
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.pnlLogo.TabIndex = 0;

            // ─── lblSidebarLogo ───────────────────────────────────────────────
            this.lblSidebarLogo.AutoSize = true;
            this.lblSidebarLogo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSidebarLogo.ForeColor = System.Drawing.Color.White;
            this.lblSidebarLogo.Location = new System.Drawing.Point(16, 10);
            this.lblSidebarLogo.Name = "lblSidebarLogo";
            this.lblSidebarLogo.TabIndex = 0;
            this.lblSidebarLogo.Text = "SENAC";

            // ─── lblSidebarSub ────────────────────────────────────────────────
            this.lblSidebarSub.AutoSize = true;
            this.lblSidebarSub.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSidebarSub.ForeColor = System.Drawing.Color.FromArgb(160, 200, 255);
            this.lblSidebarSub.Location = new System.Drawing.Point(17, 36);
            this.lblSidebarSub.Name = "lblSidebarSub";
            this.lblSidebarSub.TabIndex = 1;
            this.lblSidebarSub.Text = "Games Desktop";

            // ─── pnlLogoDivisor ───────────────────────────────────────────────
            this.pnlLogoDivisor.BackColor = System.Drawing.Color.FromArgb(0, 55, 115);
            this.pnlLogoDivisor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogoDivisor.Height = 1;
            this.pnlLogoDivisor.Name = "pnlLogoDivisor";
            this.pnlLogoDivisor.TabIndex = 1;

            // ─── btnDashboard ─────────────────────────────────────────────────
            this.btnDashboard.Animated = true;
            this.btnDashboard.BorderRadius = 0;
            this.btnDashboard.FillColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(0, 95, 165);
            this.btnDashboard.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 68);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(220, 46);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "  📊  Dashboard";

            // ─── btnGames ─────────────────────────────────────────────────────
            this.btnGames.Animated = true;
            this.btnGames.BorderRadius = 0;
            this.btnGames.FillColor = System.Drawing.Color.Transparent;
            this.btnGames.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnGames.ForeColor = System.Drawing.Color.White;
            this.btnGames.HoverState.FillColor = System.Drawing.Color.FromArgb(0, 95, 165);
            this.btnGames.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnGames.Location = new System.Drawing.Point(0, 120);
            this.btnGames.Name = "btnGames";
            this.btnGames.Size = new System.Drawing.Size(220, 46);
            this.btnGames.TabIndex = 3;
            this.btnGames.Text = "  🎮  Games";

            // ─── btnCategorias ────────────────────────────────────────────────
            this.btnCategorias.Animated = true;
            this.btnCategorias.BorderRadius = 0;
            this.btnCategorias.FillColor = System.Drawing.Color.Transparent;
            this.btnCategorias.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnCategorias.ForeColor = System.Drawing.Color.White;
            this.btnCategorias.HoverState.FillColor = System.Drawing.Color.FromArgb(0, 95, 165);
            this.btnCategorias.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnCategorias.Location = new System.Drawing.Point(0, 172);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(220, 46);
            this.btnCategorias.TabIndex = 4;
            this.btnCategorias.Text = "  🏷️  Categorias";

            // ─── btnUsuarios ──────────────────────────────────────────────────
            this.btnUsuarios.Animated = true;
            this.btnUsuarios.BorderRadius = 0;
            this.btnUsuarios.FillColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.HoverState.FillColor = System.Drawing.Color.FromArgb(0, 95, 165);
            this.btnUsuarios.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 224);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(220, 46);
            this.btnUsuarios.TabIndex = 5;
            this.btnUsuarios.Text = "  👥  Usuários";

            // ─── btnPerfil ────────────────────────────────────────────────────
            this.btnPerfil.Animated = true;
            this.btnPerfil.BorderRadius = 0;
            this.btnPerfil.FillColor = System.Drawing.Color.Transparent;
            this.btnPerfil.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnPerfil.ForeColor = System.Drawing.Color.White;
            this.btnPerfil.HoverState.FillColor = System.Drawing.Color.FromArgb(0, 95, 165);
            this.btnPerfil.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnPerfil.Location = new System.Drawing.Point(0, 276);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(220, 46);
            this.btnPerfil.TabIndex = 6;
            this.btnPerfil.Text = "  ⚙️  Meu Perfil";

            // ─── lblSessao ────────────────────────────────────────────────────
            this.lblSessao.AutoSize = false;
            this.lblSessao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSessao.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblSessao.ForeColor = System.Drawing.Color.FromArgb(140, 180, 240);
            this.lblSessao.Height = 40;
            this.lblSessao.Name = "lblSessao";
            this.lblSessao.Padding = new System.Windows.Forms.Padding(4);
            this.lblSessao.TabIndex = 7;
            this.lblSessao.Text = "🟢 ...";
            this.lblSessao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ─── pnlConteudo ──────────────────────────────────────────────────
            this.pnlConteudo.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.TabIndex = 2;

            // ─── Configuração do Form ─────────────────────────────────────────
            // IMPORTANTE: ordem de adição ao Form importa para DockStyle funcionar
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.pnlConteudo);    // Fill (deve vir primeiro)
            this.Controls.Add(this.pnlSidebar);     // Left
            this.Controls.Add(this.pnlHeader);      // Top
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SenacGames Desktop";

            // ─── Eventos ──────────────────────────────────────────────────────
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlHeader_Paint);
            this.pnlHeader.Resize += new System.EventHandler(this.PnlHeader_Resize);
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            this.btnGames.Click += new System.EventHandler(this.BtnGames_Click);
            this.btnCategorias.Click += new System.EventHandler(this.BtnCategorias_Click);
            this.btnUsuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
            this.btnPerfil.Click += new System.EventHandler(this.BtnPerfil_Click);

            // ResumeLayout
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}

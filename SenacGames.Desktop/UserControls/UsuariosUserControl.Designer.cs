// =============================================================================
// SenacGames.Desktop - UserControls/UsuariosUserControl.Designer.cs
// =============================================================================
// ️ ARQUIVO GERADO PELO DESIGNER — NÃO EDITE MANUALMENTE
// Toda lógica de negócio deve estar em UsuariosUserControl.cs
// =============================================================================

namespace SenacGames.Desktop.UserControls
{
    partial class UsuariosUserControl
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
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel pnlToolbar;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisa;
        private Guna.UI2.WinForms.Guna2Button btnNovo;
        private Guna.UI2.WinForms.Guna2Button btnExcluir;
        private Guna.UI2.WinForms.Guna2Button btnAtualizar;
        private System.Windows.Forms.DataGridView gridUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPerfil;

        // =====================================================================
        // INITIALIZECOMPONENT — formato padrão do Windows Forms Designer
        // =====================================================================
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ─── Instanciar todos os controles ────────────────────────────────
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.txtPesquisa = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnNovo = new Guna.UI2.WinForms.Guna2Button();
            this.btnExcluir = new Guna.UI2.WinForms.Guna2Button();
            this.btnAtualizar = new Guna.UI2.WinForms.Guna2Button();
            this.gridUsuarios = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // SuspendLayout
            this.pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).BeginInit();
            this.SuspendLayout();

            // ─── lblTitulo ────────────────────────────────────────────────────
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(30, 38, 50);
            this.lblTitulo.Location = new System.Drawing.Point(24, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(500, 36);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "👥 Gerenciamento de Usuários";

            // ─── lblInfo ──────────────────────────────────────────────────────
            this.lblInfo.AutoSize = false;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(150, 160, 175);
            this.lblInfo.Location = new System.Drawing.Point(24, 54);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(700, 24);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "ℹ Gerencia usuários do ASP.NET Core Identity registrados na aplicação.";

            // ─── pnlToolbar ───────────────────────────────────────────────────
            this.pnlToolbar.BackColor = System.Drawing.Color.White;
            this.pnlToolbar.Controls.Add(this.txtPesquisa);
            this.pnlToolbar.Controls.Add(this.btnNovo);
            this.pnlToolbar.Controls.Add(this.btnExcluir);
            this.pnlToolbar.Controls.Add(this.btnAtualizar);
            this.pnlToolbar.Location = new System.Drawing.Point(24, 88);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(900, 56);
            this.pnlToolbar.TabIndex = 2;

            // ─── txtPesquisa ──────────────────────────────────────────────────
            this.txtPesquisa.BorderColor = System.Drawing.Color.FromArgb(224, 228, 235);
            this.txtPesquisa.BorderRadius = 6;
            this.txtPesquisa.FillColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.txtPesquisa.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtPesquisa.Location = new System.Drawing.Point(8, 9);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.PlaceholderText = "🔍 Pesquisar por email...";
            this.txtPesquisa.Size = new System.Drawing.Size(250, 38);
            this.txtPesquisa.TabIndex = 0;

            // ─── btnNovo ──────────────────────────────────────────────────────
            this.btnNovo.Animated = true;
            this.btnNovo.BorderRadius = 6;
            this.btnNovo.FillColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(270, 9);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(140, 38);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "+ Novo Usuário";

            // ─── btnExcluir ───────────────────────────────────────────────────
            this.btnExcluir.Animated = true;
            this.btnExcluir.BorderRadius = 6;
            this.btnExcluir.FillColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(422, 9);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 38);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "🗑 Excluir";

            // ─── btnAtualizar ─────────────────────────────────────────────────
            this.btnAtualizar.Animated = true;
            this.btnAtualizar.BorderRadius = 6;
            this.btnAtualizar.FillColor = System.Drawing.Color.FromArgb(150, 160, 175);
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Location = new System.Drawing.Point(534, 9);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(110, 38);
            this.btnAtualizar.TabIndex = 3;
            this.btnAtualizar.Text = "↺ Atualizar";

            // ─── Colunas da grid ──────────────────────────────────────────────
            this.colId.HeaderText = "ID";
            this.colId.Name = "Id";
            this.colId.Width = 200;

            this.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEmail.HeaderText = "E-mail / Usuário";
            this.colEmail.Name = "Email";
            this.colEmail.Width = 300;

            this.colPerfil.HeaderText = "Perfil";
            this.colPerfil.Name = "Perfil";
            this.colPerfil.Width = 160;

            // ─── gridUsuarios ─────────────────────────────────────────────────
            this.gridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                this.colId,
                this.colEmail,
                this.colPerfil
            });
            this.gridUsuarios.Location = new System.Drawing.Point(24, 154);
            this.gridUsuarios.Name = "gridUsuarios";
            this.gridUsuarios.Size = new System.Drawing.Size(900, 460);
            this.gridUsuarios.TabIndex = 3;

            // ─── Configuração do UserControl ──────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.gridUsuarios);
            this.Name = "UsuariosUserControl";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.Size = new System.Drawing.Size(980, 650);

            // ─── Eventos ──────────────────────────────────────────────────────
            this.Load += new System.EventHandler(this.UsuariosUserControl_Load);
            this.txtPesquisa.TextChanged += new System.EventHandler(this.TxtPesquisa_TextChanged);
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            this.btnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);

            // ResumeLayout
            this.pnlToolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

// =============================================================================
// SenacGames.Desktop - UserControls/GamesUserControl.Designer.cs
// =============================================================================
// ️ ARQUIVO GERADO PELO DESIGNER — NÃO EDITE MANUALMENTE
// Toda lógica de negócio deve estar em GamesUserControl.cs
// =============================================================================

namespace SenacGames.Desktop.UserControls
{
    partial class GamesUserControl
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
        private System.Windows.Forms.Panel pnlToolbar;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisa;
        private Guna.UI2.WinForms.Guna2Button btnPesquisar;
        private Guna.UI2.WinForms.Guna2Button btnNovo;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private Guna.UI2.WinForms.Guna2Button btnExcluir;
        private Guna.UI2.WinForms.Guna2Button btnAtualizar;
        private System.Windows.Forms.DataGridView gridGames;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReleaseYear;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsFeatured;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedAt;

        // =====================================================================
        // INITIALIZECOMPONENT — formato padrão do Windows Forms Designer
        // =====================================================================
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ─── Instanciar todos os controles ────────────────────────────────
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.txtPesquisa = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnPesquisar = new Guna.UI2.WinForms.Guna2Button();
            this.btnNovo = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.btnExcluir = new Guna.UI2.WinForms.Guna2Button();
            this.btnAtualizar = new Guna.UI2.WinForms.Guna2Button();
            this.gridGames = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReleaseYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsFeatured = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colCreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // SuspendLayout
            this.pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGames)).BeginInit();
            this.SuspendLayout();

            // ─── lblTitulo ────────────────────────────────────────────────────
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(30, 38, 50);
            this.lblTitulo.Location = new System.Drawing.Point(24, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(500, 36);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "🎮 Gerenciamento de Games";

            // ─── pnlToolbar ───────────────────────────────────────────────────
            this.pnlToolbar.BackColor = System.Drawing.Color.White;
            this.pnlToolbar.Controls.Add(this.txtPesquisa);
            this.pnlToolbar.Controls.Add(this.btnPesquisar);
            this.pnlToolbar.Controls.Add(this.btnNovo);
            this.pnlToolbar.Controls.Add(this.btnEditar);
            this.pnlToolbar.Controls.Add(this.btnExcluir);
            this.pnlToolbar.Controls.Add(this.btnAtualizar);
            this.pnlToolbar.Location = new System.Drawing.Point(24, 60);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Padding = new System.Windows.Forms.Padding(8);
            this.pnlToolbar.Size = new System.Drawing.Size(950, 56);
            this.pnlToolbar.TabIndex = 1;

            // ─── txtPesquisa ──────────────────────────────────────────────────
            this.txtPesquisa.BorderColor = System.Drawing.Color.FromArgb(224, 228, 235);
            this.txtPesquisa.BorderRadius = 6;
            this.txtPesquisa.FillColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.txtPesquisa.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtPesquisa.Location = new System.Drawing.Point(8, 9);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.PlaceholderText = "🔍 Pesquisar por título...";
            this.txtPesquisa.Size = new System.Drawing.Size(280, 38);
            this.txtPesquisa.TabIndex = 0;

            // ─── btnPesquisar ─────────────────────────────────────────────────
            this.btnPesquisar.Animated = true;
            this.btnPesquisar.BorderRadius = 6;
            this.btnPesquisar.FillColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(300, 9);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 38);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";

            // ─── btnNovo ──────────────────────────────────────────────────────
            this.btnNovo.Animated = true;
            this.btnNovo.BorderRadius = 6;
            this.btnNovo.FillColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(415, 9);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(120, 38);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "+ Novo Game";

            // ─── btnEditar ────────────────────────────────────────────────────
            this.btnEditar.Animated = true;
            this.btnEditar.BorderRadius = 6;
            this.btnEditar.FillColor = System.Drawing.Color.FromArgb(0, 75, 135);
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(545, 9);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 38);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "✏ Editar";

            // ─── btnExcluir ───────────────────────────────────────────────────
            this.btnExcluir.Animated = true;
            this.btnExcluir.BorderRadius = 6;
            this.btnExcluir.FillColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(655, 9);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 38);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "🗑 Excluir";

            // ─── btnAtualizar ─────────────────────────────────────────────────
            this.btnAtualizar.Animated = true;
            this.btnAtualizar.BorderRadius = 6;
            this.btnAtualizar.FillColor = System.Drawing.Color.FromArgb(150, 160, 175);
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Location = new System.Drawing.Point(765, 9);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(110, 38);
            this.btnAtualizar.TabIndex = 5;
            this.btnAtualizar.Text = "↺ Atualizar";

            // ─── Colunas da grid ──────────────────────────────────────────────
            this.colId.HeaderText = "ID";
            this.colId.Name = "Id";
            this.colId.Width = 50;

            this.colTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTitle.HeaderText = "Título";
            this.colTitle.Name = "Title";
            this.colTitle.Width = 220;

            this.colCategoryName.HeaderText = "Categoria";
            this.colCategoryName.Name = "CategoryName";
            this.colCategoryName.Width = 130;

            this.colReleaseYear.HeaderText = "Ano";
            this.colReleaseYear.Name = "ReleaseYear";
            this.colReleaseYear.Width = 70;

            this.colIsFeatured.HeaderText = "Destaque";
            this.colIsFeatured.Name = "IsFeatured";
            this.colIsFeatured.Width = 80;

            this.colCreatedAt.HeaderText = "Cadastrado em";
            this.colCreatedAt.Name = "CreatedAt";
            this.colCreatedAt.Width = 130;

            // ─── gridGames ────────────────────────────────────────────────────
            this.gridGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                this.colId,
                this.colTitle,
                this.colCategoryName,
                this.colReleaseYear,
                this.colIsFeatured,
                this.colCreatedAt
            });
            this.gridGames.Location = new System.Drawing.Point(24, 126);
            this.gridGames.Name = "gridGames";
            this.gridGames.Size = new System.Drawing.Size(950, 460);
            this.gridGames.TabIndex = 2;

            // ─── Configuração do UserControl ──────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.gridGames);
            this.Name = "GamesUserControl";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.Size = new System.Drawing.Size(1024, 620);

            // ─── Eventos ──────────────────────────────────────────────────────
            this.Load += new System.EventHandler(this.GamesUserControl_Load);
            this.txtPesquisa.TextChanged += new System.EventHandler(this.TxtPesquisa_TextChanged);
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            this.btnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            this.gridGames.SelectionChanged += new System.EventHandler(this.GridGames_SelectionChanged);
            this.gridGames.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridGames_CellDoubleClick);

            // ResumeLayout
            this.pnlToolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGames)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

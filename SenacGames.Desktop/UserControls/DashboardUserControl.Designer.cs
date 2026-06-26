// =============================================================================
// SenacGames.Desktop - UserControls/DashboardUserControl.Designer.cs
// =============================================================================
// ️ ARQUIVO GERADO PELO DESIGNER — NÃO EDITE MANUALMENTE
// Toda lógica de negócio deve estar em DashboardUserControl.cs
// =============================================================================

namespace SenacGames.Desktop.UserControls
{
    partial class DashboardUserControl
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

        // Cabeçalho
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblCarregando;

        // Card Games
        private Guna.UI2.WinForms.Guna2Panel cardGames;
        private System.Windows.Forms.Panel cardGamesBarraTop;
        private System.Windows.Forms.Label cardGamesLblTitulo;
        private System.Windows.Forms.Label cardGamesLblNumero;
        private System.Windows.Forms.Label cardGamesLblDesc;

        // Card Categorias
        private Guna.UI2.WinForms.Guna2Panel cardCategorias;
        private System.Windows.Forms.Panel cardCategoriasBarraTop;
        private System.Windows.Forms.Label cardCategoriasLblTitulo;
        private System.Windows.Forms.Label cardCategoriasLblNumero;
        private System.Windows.Forms.Label cardCategoriasLblDesc;

        // Grid
        private System.Windows.Forms.Label lblUltimosGames;
        private System.Windows.Forms.DataGridView gridUltimosGames;
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
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblCarregando = new System.Windows.Forms.Label();

            this.cardGames = new Guna.UI2.WinForms.Guna2Panel();
            this.cardGamesBarraTop = new System.Windows.Forms.Panel();
            this.cardGamesLblTitulo = new System.Windows.Forms.Label();
            this.cardGamesLblNumero = new System.Windows.Forms.Label();
            this.cardGamesLblDesc = new System.Windows.Forms.Label();

            this.cardCategorias = new Guna.UI2.WinForms.Guna2Panel();
            this.cardCategoriasBarraTop = new System.Windows.Forms.Panel();
            this.cardCategoriasLblTitulo = new System.Windows.Forms.Label();
            this.cardCategoriasLblNumero = new System.Windows.Forms.Label();
            this.cardCategoriasLblDesc = new System.Windows.Forms.Label();

            this.lblUltimosGames = new System.Windows.Forms.Label();
            this.gridUltimosGames = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReleaseYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsFeatured = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colCreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // SuspendLayout
            this.cardGames.SuspendLayout();
            this.cardCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUltimosGames)).BeginInit();
            this.SuspendLayout();

            // ─── lblTitulo ────────────────────────────────────────────────────
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(30, 38, 50);
            this.lblTitulo.Location = new System.Drawing.Point(24, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(600, 36);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Olá! 👋";

            // ─── lblSubtitulo ─────────────────────────────────────────────────
            this.lblSubtitulo.AutoSize = false;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(150, 160, 175);
            this.lblSubtitulo.Location = new System.Drawing.Point(24, 62);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(700, 24);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Bem-vindo ao SenacGames Desktop";

            // ─── lblCarregando ────────────────────────────────────────────────
            this.lblCarregando.AutoSize = false;
            this.lblCarregando.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCarregando.ForeColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.lblCarregando.Location = new System.Drawing.Point(24, 110);
            this.lblCarregando.Name = "lblCarregando";
            this.lblCarregando.Size = new System.Drawing.Size(400, 30);
            this.lblCarregando.TabIndex = 2;
            this.lblCarregando.Text = "⏳ Carregando dados da API...";
            this.lblCarregando.Visible = false;

            // ─── cardGames ────────────────────────────────────────────────────
            this.cardGames.BorderRadius = 12;
            this.cardGames.FillColor = System.Drawing.Color.White;
            this.cardGames.Location = new System.Drawing.Point(24, 110);
            this.cardGames.Name = "cardGames";
            this.cardGames.ShadowDecoration.Color = System.Drawing.Color.FromArgb(15, 0, 0, 0);
            this.cardGames.ShadowDecoration.Depth = 12;
            this.cardGames.ShadowDecoration.Enabled = true;
            this.cardGames.Size = new System.Drawing.Size(210, 120);
            this.cardGames.TabIndex = 3;
            this.cardGames.Controls.Add(this.cardGamesBarraTop);
            this.cardGames.Controls.Add(this.cardGamesLblTitulo);
            this.cardGames.Controls.Add(this.cardGamesLblNumero);
            this.cardGames.Controls.Add(this.cardGamesLblDesc);

            // ─── cardGamesBarraTop ────────────────────────────────────────────
            this.cardGamesBarraTop.BackColor = System.Drawing.Color.FromArgb(0, 75, 135);
            this.cardGamesBarraTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardGamesBarraTop.Location = new System.Drawing.Point(0, 0);
            this.cardGamesBarraTop.Name = "cardGamesBarraTop";
            this.cardGamesBarraTop.Size = new System.Drawing.Size(210, 4);
            this.cardGamesBarraTop.TabIndex = 0;

            // ─── cardGamesLblTitulo ───────────────────────────────────────────
            this.cardGamesLblTitulo.AutoSize = false;
            this.cardGamesLblTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cardGamesLblTitulo.ForeColor = System.Drawing.Color.FromArgb(0, 75, 135);
            this.cardGamesLblTitulo.Location = new System.Drawing.Point(14, 16);
            this.cardGamesLblTitulo.Name = "cardGamesLblTitulo";
            this.cardGamesLblTitulo.Size = new System.Drawing.Size(180, 24);
            this.cardGamesLblTitulo.TabIndex = 1;
            this.cardGamesLblTitulo.Tag = "titulo";
            this.cardGamesLblTitulo.Text = "🎮 Games";

            // ─── cardGamesLblNumero ───────────────────────────────────────────
            this.cardGamesLblNumero.AutoSize = false;
            this.cardGamesLblNumero.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.cardGamesLblNumero.ForeColor = System.Drawing.Color.FromArgb(30, 38, 50);
            this.cardGamesLblNumero.Location = new System.Drawing.Point(14, 40);
            this.cardGamesLblNumero.Name = "cardGamesLblNumero";
            this.cardGamesLblNumero.Size = new System.Drawing.Size(180, 40);
            this.cardGamesLblNumero.TabIndex = 2;
            this.cardGamesLblNumero.Tag = "numero";
            this.cardGamesLblNumero.Text = "0";

            // ─── cardGamesLblDesc ─────────────────────────────────────────────
            this.cardGamesLblDesc.AutoSize = false;
            this.cardGamesLblDesc.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cardGamesLblDesc.ForeColor = System.Drawing.Color.FromArgb(150, 160, 175);
            this.cardGamesLblDesc.Location = new System.Drawing.Point(14, 84);
            this.cardGamesLblDesc.Name = "cardGamesLblDesc";
            this.cardGamesLblDesc.Size = new System.Drawing.Size(180, 20);
            this.cardGamesLblDesc.TabIndex = 3;
            this.cardGamesLblDesc.Text = "Total de games cadastrados";

            // ─── cardCategorias ───────────────────────────────────────────────
            this.cardCategorias.BorderRadius = 12;
            this.cardCategorias.FillColor = System.Drawing.Color.White;
            this.cardCategorias.Location = new System.Drawing.Point(250, 110);
            this.cardCategorias.Name = "cardCategorias";
            this.cardCategorias.ShadowDecoration.Color = System.Drawing.Color.FromArgb(15, 0, 0, 0);
            this.cardCategorias.ShadowDecoration.Depth = 12;
            this.cardCategorias.ShadowDecoration.Enabled = true;
            this.cardCategorias.Size = new System.Drawing.Size(210, 120);
            this.cardCategorias.TabIndex = 4;
            this.cardCategorias.Controls.Add(this.cardCategoriasBarraTop);
            this.cardCategorias.Controls.Add(this.cardCategoriasLblTitulo);
            this.cardCategorias.Controls.Add(this.cardCategoriasLblNumero);
            this.cardCategorias.Controls.Add(this.cardCategoriasLblDesc);

            // ─── cardCategoriasBarraTop ───────────────────────────────────────
            this.cardCategoriasBarraTop.BackColor = System.Drawing.Color.FromArgb(255, 102, 0);
            this.cardCategoriasBarraTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardCategoriasBarraTop.Location = new System.Drawing.Point(0, 0);
            this.cardCategoriasBarraTop.Name = "cardCategoriasBarraTop";
            this.cardCategoriasBarraTop.Size = new System.Drawing.Size(210, 4);
            this.cardCategoriasBarraTop.TabIndex = 0;

            // ─── cardCategoriasLblTitulo ──────────────────────────────────────
            this.cardCategoriasLblTitulo.AutoSize = false;
            this.cardCategoriasLblTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cardCategoriasLblTitulo.ForeColor = System.Drawing.Color.FromArgb(255, 102, 0);
            this.cardCategoriasLblTitulo.Location = new System.Drawing.Point(14, 16);
            this.cardCategoriasLblTitulo.Name = "cardCategoriasLblTitulo";
            this.cardCategoriasLblTitulo.Size = new System.Drawing.Size(180, 24);
            this.cardCategoriasLblTitulo.TabIndex = 1;
            this.cardCategoriasLblTitulo.Tag = "titulo";
            this.cardCategoriasLblTitulo.Text = "🏷️ Categorias";

            // ─── cardCategoriasLblNumero ──────────────────────────────────────
            this.cardCategoriasLblNumero.AutoSize = false;
            this.cardCategoriasLblNumero.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.cardCategoriasLblNumero.ForeColor = System.Drawing.Color.FromArgb(30, 38, 50);
            this.cardCategoriasLblNumero.Location = new System.Drawing.Point(14, 40);
            this.cardCategoriasLblNumero.Name = "cardCategoriasLblNumero";
            this.cardCategoriasLblNumero.Size = new System.Drawing.Size(180, 40);
            this.cardCategoriasLblNumero.TabIndex = 2;
            this.cardCategoriasLblNumero.Tag = "numero";
            this.cardCategoriasLblNumero.Text = "0";

            // ─── cardCategoriasLblDesc ────────────────────────────────────────
            this.cardCategoriasLblDesc.AutoSize = false;
            this.cardCategoriasLblDesc.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cardCategoriasLblDesc.ForeColor = System.Drawing.Color.FromArgb(150, 160, 175);
            this.cardCategoriasLblDesc.Location = new System.Drawing.Point(14, 84);
            this.cardCategoriasLblDesc.Name = "cardCategoriasLblDesc";
            this.cardCategoriasLblDesc.Size = new System.Drawing.Size(180, 20);
            this.cardCategoriasLblDesc.TabIndex = 3;
            this.cardCategoriasLblDesc.Text = "Total de categorias";

            // ─── lblUltimosGames ──────────────────────────────────────────────
            this.lblUltimosGames.AutoSize = false;
            this.lblUltimosGames.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblUltimosGames.ForeColor = System.Drawing.Color.FromArgb(30, 38, 50);
            this.lblUltimosGames.Location = new System.Drawing.Point(24, 264);
            this.lblUltimosGames.Name = "lblUltimosGames";
            this.lblUltimosGames.Size = new System.Drawing.Size(400, 30);
            this.lblUltimosGames.TabIndex = 5;
            this.lblUltimosGames.Text = "📋 Últimos Games Cadastrados";

            // ─── Colunas da grid ──────────────────────────────────────────────
            this.colId.HeaderText = "ID";
            this.colId.Name = "Id";
            this.colId.Width = 50;

            this.colTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTitle.HeaderText = "Título";
            this.colTitle.Name = "Title";
            this.colTitle.Width = 200;

            this.colCategoryName.HeaderText = "Categoria";
            this.colCategoryName.Name = "CategoryName";
            this.colCategoryName.Width = 150;

            this.colReleaseYear.HeaderText = "Ano";
            this.colReleaseYear.Name = "ReleaseYear";
            this.colReleaseYear.Width = 80;

            this.colIsFeatured.HeaderText = "Destaque";
            this.colIsFeatured.Name = "IsFeatured";
            this.colIsFeatured.Width = 80;

            this.colCreatedAt.HeaderText = "Cadastrado em";
            this.colCreatedAt.Name = "CreatedAt";
            this.colCreatedAt.Width = 140;

            // ─── gridUltimosGames ─────────────────────────────────────────────
            this.gridUltimosGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUltimosGames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                this.colId,
                this.colTitle,
                this.colCategoryName,
                this.colReleaseYear,
                this.colIsFeatured,
                this.colCreatedAt
            });
            this.gridUltimosGames.Location = new System.Drawing.Point(24, 300);
            this.gridUltimosGames.Name = "gridUltimosGames";
            this.gridUltimosGames.Size = new System.Drawing.Size(900, 320);
            this.gridUltimosGames.TabIndex = 6;

            // ─── Configuração do UserControl ──────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblCarregando);
            this.Controls.Add(this.cardGames);
            this.Controls.Add(this.cardCategorias);
            this.Controls.Add(this.lblUltimosGames);
            this.Controls.Add(this.gridUltimosGames);
            this.Name = "DashboardUserControl";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.Size = new System.Drawing.Size(980, 660);

            // ─── Eventos ──────────────────────────────────────────────────────
            this.Load += new System.EventHandler(this.DashboardUserControl_Load);

            // ResumeLayout
            this.cardGames.ResumeLayout(false);
            this.cardCategorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUltimosGames)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

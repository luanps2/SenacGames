// =============================================================================
// SenacGames.Desktop - UserControls/CategoriasUserControl.Designer.cs
// =============================================================================
// ️ ARQUIVO GERADO PELO DESIGNER — NÃO EDITE MANUALMENTE
// Toda lógica de negócio deve estar em CategoriasUserControl.cs
// =============================================================================

namespace SenacGames.Desktop.UserControls
{
    partial class CategoriasUserControl
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
        private Guna.UI2.WinForms.Guna2Button btnNova;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private Guna.UI2.WinForms.Guna2Button btnExcluir;
        private Guna.UI2.WinForms.Guna2Button btnAtualizar;
        private System.Windows.Forms.DataGridView gridCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGameCount;
        private Guna.UI2.WinForms.Guna2Panel pnlForm;
        private System.Windows.Forms.Label lblFormTitulo;
        private System.Windows.Forms.Label lblNome;
        private Guna.UI2.WinForms.Guna2TextBox txtNome;
        private Guna.UI2.WinForms.Guna2Button btnSalvar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;

        // =====================================================================
        // INITIALIZECOMPONENT — formato padrão do Windows Forms Designer
        // =====================================================================
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ─── Instanciar todos os controles ────────────────────────────────
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.btnNova = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.btnExcluir = new Guna.UI2.WinForms.Guna2Button();
            this.btnAtualizar = new Guna.UI2.WinForms.Guna2Button();
            this.gridCategorias = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGameCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlForm = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFormTitulo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSalvar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();

            // SuspendLayout
            this.pnlToolbar.SuspendLayout();
            this.pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategorias)).BeginInit();
            this.SuspendLayout();

            // ─── lblTitulo ────────────────────────────────────────────────────
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(30, 38, 50);
            this.lblTitulo.Location = new System.Drawing.Point(24, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(500, 36);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "🏷️ Gerenciamento de Categorias";

            // ─── pnlToolbar ───────────────────────────────────────────────────
            this.pnlToolbar.BackColor = System.Drawing.Color.White;
            this.pnlToolbar.Controls.Add(this.btnNova);
            this.pnlToolbar.Controls.Add(this.btnEditar);
            this.pnlToolbar.Controls.Add(this.btnExcluir);
            this.pnlToolbar.Controls.Add(this.btnAtualizar);
            this.pnlToolbar.Location = new System.Drawing.Point(24, 60);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(700, 56);
            this.pnlToolbar.TabIndex = 1;

            // ─── btnNova ──────────────────────────────────────────────────────
            this.btnNova.Animated = true;
            this.btnNova.BorderRadius = 6;
            this.btnNova.FillColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnNova.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNova.ForeColor = System.Drawing.Color.White;
            this.btnNova.Location = new System.Drawing.Point(8, 9);
            this.btnNova.Name = "btnNova";
            this.btnNova.Size = new System.Drawing.Size(150, 38);
            this.btnNova.TabIndex = 0;
            this.btnNova.Text = "+ Nova Categoria";

            // ─── btnEditar ────────────────────────────────────────────────────
            this.btnEditar.Animated = true;
            this.btnEditar.BorderRadius = 6;
            this.btnEditar.FillColor = System.Drawing.Color.FromArgb(0, 75, 135);
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(170, 9);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 38);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "✏ Editar";

            // ─── btnExcluir ───────────────────────────────────────────────────
            this.btnExcluir.Animated = true;
            this.btnExcluir.BorderRadius = 6;
            this.btnExcluir.FillColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(282, 9);
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
            this.btnAtualizar.Location = new System.Drawing.Point(394, 9);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(110, 38);
            this.btnAtualizar.TabIndex = 3;
            this.btnAtualizar.Text = "↺ Atualizar";

            // ─── Colunas da grid ──────────────────────────────────────────────
            this.colId.HeaderText = "ID";
            this.colId.Name = "Id";
            this.colId.Width = 70;

            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.HeaderText = "Nome da Categoria";
            this.colName.Name = "Name";
            this.colName.Width = 300;

            this.colGameCount.HeaderText = "Total de Games";
            this.colGameCount.Name = "GameCount";
            this.colGameCount.Width = 140;

            // ─── gridCategorias ───────────────────────────────────────────────
            this.gridCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                this.colId,
                this.colName,
                this.colGameCount
            });
            this.gridCategorias.Location = new System.Drawing.Point(24, 126);
            this.gridCategorias.Name = "gridCategorias";
            this.gridCategorias.Size = new System.Drawing.Size(700, 420);
            this.gridCategorias.TabIndex = 2;

            // ─── pnlForm ──────────────────────────────────────────────────────
            this.pnlForm.BorderRadius = 10;
            this.pnlForm.Controls.Add(this.lblFormTitulo);
            this.pnlForm.Controls.Add(this.lblNome);
            this.pnlForm.Controls.Add(this.txtNome);
            this.pnlForm.Controls.Add(this.btnSalvar);
            this.pnlForm.Controls.Add(this.btnCancelar);
            this.pnlForm.FillColor = System.Drawing.Color.White;
            this.pnlForm.Location = new System.Drawing.Point(740, 126);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.ShadowDecoration.Color = System.Drawing.Color.FromArgb(10, 0, 0, 0);
            this.pnlForm.ShadowDecoration.Depth = 8;
            this.pnlForm.ShadowDecoration.Enabled = true;
            this.pnlForm.Size = new System.Drawing.Size(280, 420);
            this.pnlForm.TabIndex = 3;
            this.pnlForm.Visible = false;

            // ─── lblFormTitulo ────────────────────────────────────────────────
            this.lblFormTitulo.AutoSize = false;
            this.lblFormTitulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFormTitulo.ForeColor = System.Drawing.Color.FromArgb(0, 75, 135);
            this.lblFormTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblFormTitulo.Name = "lblFormTitulo";
            this.lblFormTitulo.Size = new System.Drawing.Size(240, 30);
            this.lblFormTitulo.TabIndex = 0;
            this.lblFormTitulo.Text = "Nova Categoria";

            // ─── lblNome ──────────────────────────────────────────────────────
            this.lblNome.AutoSize = false;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(51, 61, 75);
            this.lblNome.Location = new System.Drawing.Point(20, 70);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(240, 20);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "NOME DA CATEGORIA";

            // ─── txtNome ──────────────────────────────────────────────────────
            this.txtNome.BorderColor = System.Drawing.Color.FromArgb(224, 228, 235);
            this.txtNome.BorderRadius = 6;
            this.txtNome.FillColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNome.Location = new System.Drawing.Point(20, 92);
            this.txtNome.Name = "txtNome";
            this.txtNome.PlaceholderText = "Ex: Ação, Aventura, RPG...";
            this.txtNome.Size = new System.Drawing.Size(240, 40);
            this.txtNome.TabIndex = 2;

            // ─── btnSalvar ────────────────────────────────────────────────────
            this.btnSalvar.Animated = true;
            this.btnSalvar.BorderRadius = 6;
            this.btnSalvar.FillColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(20, 155);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(115, 38);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "💾 Salvar";

            // ─── btnCancelar ──────────────────────────────────────────────────
            this.btnCancelar.Animated = true;
            this.btnCancelar.BorderRadius = 6;
            this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(150, 160, 175);
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(145, 155);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 38);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";

            // ─── Configuração do UserControl ──────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.gridCategorias);
            this.Controls.Add(this.pnlForm);
            this.Name = "CategoriasUserControl";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.Size = new System.Drawing.Size(1060, 580);

            // ─── Eventos ──────────────────────────────────────────────────────
            this.Load += new System.EventHandler(this.CategoriasUserControl_Load);
            this.btnNova.Click += new System.EventHandler(this.BtnNova_Click);
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            this.btnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);

            // ResumeLayout
            this.pnlToolbar.ResumeLayout(false);
            this.pnlForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCategorias)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

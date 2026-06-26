// =============================================================================
// SenacGames.Desktop - UserControls/PerfilUserControl.Designer.cs
// =============================================================================
// ️ ARQUIVO GERADO PELO DESIGNER — NÃO EDITE MANUALMENTE
// Toda lógica de negócio deve estar em PerfilUserControl.cs
// =============================================================================

namespace SenacGames.Desktop.UserControls
{
    partial class PerfilUserControl
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
        private Guna.UI2.WinForms.Guna2Panel card;
        private Guna.UI2.WinForms.Guna2Panel pnlAvatar;
        private System.Windows.Forms.Label lblAvatar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblBadge;
        private System.Windows.Forms.Panel sep;
        private System.Windows.Forms.Label lblEmailLabel;
        private System.Windows.Forms.Label lblEmailValor;
        private System.Windows.Forms.Label lblApiLabel;
        private System.Windows.Forms.Label lblApiValor;
        private System.Windows.Forms.Label lblRolesLabel;
        private System.Windows.Forms.Label lblRolesValor;

        // =====================================================================
        // INITIALIZECOMPONENT — formato padrão do Windows Forms Designer
        // =====================================================================
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ─── Instanciar todos os controles ────────────────────────────────
            this.lblTitulo = new System.Windows.Forms.Label();
            this.card = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlAvatar = new Guna.UI2.WinForms.Guna2Panel();
            this.lblAvatar = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblBadge = new System.Windows.Forms.Label();
            this.sep = new System.Windows.Forms.Panel();
            this.lblEmailLabel = new System.Windows.Forms.Label();
            this.lblEmailValor = new System.Windows.Forms.Label();
            this.lblApiLabel = new System.Windows.Forms.Label();
            this.lblApiValor = new System.Windows.Forms.Label();
            this.lblRolesLabel = new System.Windows.Forms.Label();
            this.lblRolesValor = new System.Windows.Forms.Label();

            // SuspendLayout
            this.card.SuspendLayout();
            this.pnlAvatar.SuspendLayout();
            this.SuspendLayout();

            // ─── lblTitulo ────────────────────────────────────────────────────
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(30, 38, 50);
            this.lblTitulo.Location = new System.Drawing.Point(24, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(400, 36);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "⚙️ Meu Perfil";

            // ─── card ─────────────────────────────────────────────────────────
            this.card.BorderRadius = 12;
            this.card.Controls.Add(this.pnlAvatar);
            this.card.Controls.Add(this.lblNome);
            this.card.Controls.Add(this.lblBadge);
            this.card.Controls.Add(this.sep);
            this.card.Controls.Add(this.lblEmailLabel);
            this.card.Controls.Add(this.lblEmailValor);
            this.card.Controls.Add(this.lblApiLabel);
            this.card.Controls.Add(this.lblApiValor);
            this.card.Controls.Add(this.lblRolesLabel);
            this.card.Controls.Add(this.lblRolesValor);
            this.card.FillColor = System.Drawing.Color.White;
            this.card.Location = new System.Drawing.Point(24, 64);
            this.card.Name = "card";
            this.card.ShadowDecoration.Color = System.Drawing.Color.FromArgb(10, 0, 0, 0);
            this.card.ShadowDecoration.Depth = 10;
            this.card.ShadowDecoration.Enabled = true;
            this.card.Size = new System.Drawing.Size(500, 380);
            this.card.TabIndex = 1;

            // ─── pnlAvatar ────────────────────────────────────────────────────
            this.pnlAvatar.BorderRadius = 40;
            this.pnlAvatar.Controls.Add(this.lblAvatar);
            this.pnlAvatar.FillColor = System.Drawing.Color.FromArgb(0, 75, 135);
            this.pnlAvatar.Location = new System.Drawing.Point(210, 24);
            this.pnlAvatar.Name = "pnlAvatar";
            this.pnlAvatar.Size = new System.Drawing.Size(80, 80);
            this.pnlAvatar.TabIndex = 0;

            // ─── lblAvatar ────────────────────────────────────────────────────
            this.lblAvatar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvatar.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblAvatar.ForeColor = System.Drawing.Color.White;
            this.lblAvatar.Name = "lblAvatar";
            this.lblAvatar.TabIndex = 0;
            this.lblAvatar.Text = "U";
            this.lblAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ─── lblNome ──────────────────────────────────────────────────────
            this.lblNome.AutoSize = false;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(30, 38, 50);
            this.lblNome.Location = new System.Drawing.Point(20, 118);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(460, 30);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Usuário";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ─── lblBadge ─────────────────────────────────────────────────────
            this.lblBadge.AutoSize = false;
            this.lblBadge.BackColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.lblBadge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBadge.ForeColor = System.Drawing.Color.White;
            this.lblBadge.Location = new System.Drawing.Point(170, 150);
            this.lblBadge.Name = "lblBadge";
            this.lblBadge.Size = new System.Drawing.Size(160, 28);
            this.lblBadge.TabIndex = 2;
            this.lblBadge.Text = "Perfil";
            this.lblBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ─── sep ──────────────────────────────────────────────────────────
            this.sep.BackColor = System.Drawing.Color.FromArgb(224, 228, 235);
            this.sep.Location = new System.Drawing.Point(20, 196);
            this.sep.Name = "sep";
            this.sep.Size = new System.Drawing.Size(460, 1);
            this.sep.TabIndex = 3;

            // ─── lblEmailLabel ────────────────────────────────────────────────
            this.lblEmailLabel.AutoSize = false;
            this.lblEmailLabel.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblEmailLabel.ForeColor = System.Drawing.Color.FromArgb(150, 160, 175);
            this.lblEmailLabel.Location = new System.Drawing.Point(20, 216);
            this.lblEmailLabel.Name = "lblEmailLabel";
            this.lblEmailLabel.Size = new System.Drawing.Size(460, 18);
            this.lblEmailLabel.TabIndex = 4;
            this.lblEmailLabel.Text = "E-MAIL";

            // ─── lblEmailValor ────────────────────────────────────────────────
            this.lblEmailValor.AutoSize = false;
            this.lblEmailValor.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblEmailValor.ForeColor = System.Drawing.Color.FromArgb(51, 61, 75);
            this.lblEmailValor.Location = new System.Drawing.Point(20, 234);
            this.lblEmailValor.Name = "lblEmailValor";
            this.lblEmailValor.Size = new System.Drawing.Size(460, 22);
            this.lblEmailValor.TabIndex = 5;
            this.lblEmailValor.Text = "...";

            // ─── lblApiLabel ──────────────────────────────────────────────────
            this.lblApiLabel.AutoSize = false;
            this.lblApiLabel.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblApiLabel.ForeColor = System.Drawing.Color.FromArgb(150, 160, 175);
            this.lblApiLabel.Location = new System.Drawing.Point(20, 268);
            this.lblApiLabel.Name = "lblApiLabel";
            this.lblApiLabel.Size = new System.Drawing.Size(460, 18);
            this.lblApiLabel.TabIndex = 6;
            this.lblApiLabel.Text = "API CONECTADA";

            // ─── lblApiValor ──────────────────────────────────────────────────
            this.lblApiValor.AutoSize = false;
            this.lblApiValor.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblApiValor.ForeColor = System.Drawing.Color.FromArgb(51, 61, 75);
            this.lblApiValor.Location = new System.Drawing.Point(20, 286);
            this.lblApiValor.Name = "lblApiValor";
            this.lblApiValor.Size = new System.Drawing.Size(460, 22);
            this.lblApiValor.TabIndex = 7;
            this.lblApiValor.Text = "...";

            // ─── lblRolesLabel ────────────────────────────────────────────────
            this.lblRolesLabel.AutoSize = false;
            this.lblRolesLabel.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblRolesLabel.ForeColor = System.Drawing.Color.FromArgb(150, 160, 175);
            this.lblRolesLabel.Location = new System.Drawing.Point(20, 320);
            this.lblRolesLabel.Name = "lblRolesLabel";
            this.lblRolesLabel.Size = new System.Drawing.Size(460, 18);
            this.lblRolesLabel.TabIndex = 8;
            this.lblRolesLabel.Text = "PERMISSÕES";

            // ─── lblRolesValor ────────────────────────────────────────────────
            this.lblRolesValor.AutoSize = false;
            this.lblRolesValor.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRolesValor.ForeColor = System.Drawing.Color.FromArgb(51, 61, 75);
            this.lblRolesValor.Location = new System.Drawing.Point(20, 338);
            this.lblRolesValor.Name = "lblRolesValor";
            this.lblRolesValor.Size = new System.Drawing.Size(460, 22);
            this.lblRolesValor.TabIndex = 9;
            this.lblRolesValor.Text = "...";

            // ─── Configuração do UserControl ──────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.card);
            this.Name = "PerfilUserControl";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.Size = new System.Drawing.Size(600, 500);

            // ─── Eventos ──────────────────────────────────────────────────────
            this.Load += new System.EventHandler(this.PerfilUserControl_Load);

            // ResumeLayout
            this.pnlAvatar.ResumeLayout(false);
            this.card.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}

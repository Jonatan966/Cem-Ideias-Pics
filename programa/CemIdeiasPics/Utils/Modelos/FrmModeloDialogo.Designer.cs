namespace CemIdeiasPics.Utils.Modelos
{
    partial class FrmModeloDialogo : FrmModeloBase
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModeloDialogo));
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.pbxCemIdeias = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCemIdeias)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.Yellow;
            this.btnMinimizar.Location = new System.Drawing.Point(380, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(51, 32);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.Text = "_";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximizar.ForeColor = System.Drawing.Color.Yellow;
            this.btnMaximizar.Location = new System.Drawing.Point(431, 0);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(51, 32);
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.Text = "❏";
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.Yellow;
            this.btnFechar.Location = new System.Drawing.Point(482, 0);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(51, 32);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.Black;
            this.pnlBarraTitulo.Controls.Add(this.lblTitulo);
            this.pnlBarraTitulo.Controls.Add(this.pbxCemIdeias);
            this.pnlBarraTitulo.Controls.Add(this.btnMinimizar);
            this.pnlBarraTitulo.Controls.Add(this.btnMaximizar);
            this.pnlBarraTitulo.Controls.Add(this.btnFechar);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(533, 32);
            this.pnlBarraTitulo.TabIndex = 4;
            this.pnlBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseDown);
            // 
            // pbxCemIdeias
            // 
            this.pbxCemIdeias.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxCemIdeias.Image = global::CemIdeiasPics.Properties.Resources.cemideiaspicks;
            this.pbxCemIdeias.Location = new System.Drawing.Point(0, 0);
            this.pbxCemIdeias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxCemIdeias.Name = "pbxCemIdeias";
            this.pbxCemIdeias.Size = new System.Drawing.Size(145, 32);
            this.pbxCemIdeias.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCemIdeias.TabIndex = 4;
            this.pbxCemIdeias.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(145, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(235, 32);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Formulário";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmModeloDialogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(533, 324);
            this.Controls.Add(this.pnlBarraTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "FrmModeloDialogo";
            this.Load += new System.EventHandler(this.FrmModeloDialogo_Load);
            this.pnlBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCemIdeias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.PictureBox pbxCemIdeias;
        private System.Windows.Forms.Label lblTitulo;
    }
}

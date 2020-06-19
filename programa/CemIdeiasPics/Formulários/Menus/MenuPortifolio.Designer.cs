namespace CemIdeiasPics.Formulários.Menus
{
    partial class MenuPortifolio
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblContagem = new System.Windows.Forms.Label();
            this.pbxImagem = new System.Windows.Forms.PictureBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.cbxEnsaios = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblContagem
            // 
            this.lblContagem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblContagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContagem.Location = new System.Drawing.Point(129, 105);
            this.lblContagem.Name = "lblContagem";
            this.lblContagem.Size = new System.Drawing.Size(678, 40);
            this.lblContagem.TabIndex = 14;
            this.lblContagem.Text = "0 de 0";
            this.lblContagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxImagem
            // 
            this.pbxImagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxImagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pbxImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImagem.Location = new System.Drawing.Point(129, 148);
            this.pbxImagem.Name = "pbxImagem";
            this.pbxImagem.Size = new System.Drawing.Size(678, 395);
            this.pbxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagem.TabIndex = 13;
            this.pbxImagem.TabStop = false;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAnterior.BackColor = System.Drawing.Color.Black;
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.Color.Yellow;
            this.btnAnterior.Location = new System.Drawing.Point(129, 549);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(337, 50);
            this.btnAnterior.TabIndex = 15;
            this.btnAnterior.Tag = "-1";
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnControle_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnProximo.BackColor = System.Drawing.Color.Black;
            this.btnProximo.FlatAppearance.BorderSize = 0;
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.ForeColor = System.Drawing.Color.Yellow;
            this.btnProximo.Location = new System.Drawing.Point(472, 549);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(335, 50);
            this.btnProximo.TabIndex = 16;
            this.btnProximo.Tag = "1";
            this.btnProximo.Text = ">";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnControle_Click);
            // 
            // cbxEnsaios
            // 
            this.cbxEnsaios.DisplayMember = "DESC";
            this.cbxEnsaios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEnsaios.FormattingEnabled = true;
            this.cbxEnsaios.Location = new System.Drawing.Point(6, 29);
            this.cbxEnsaios.Name = "cbxEnsaios";
            this.cbxEnsaios.Size = new System.Drawing.Size(666, 28);
            this.cbxEnsaios.TabIndex = 17;
            this.cbxEnsaios.ValueMember = "ID";
            this.cbxEnsaios.SelectedIndexChanged += new System.EventHandler(this.cbxEnsaios_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.cbxEnsaios);
            this.groupBox1.Location = new System.Drawing.Point(129, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 69);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ensaios";
            // 
            // MenuPortifolio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblContagem);
            this.Controls.Add(this.pbxImagem);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnProximo);
            this.Name = "MenuPortifolio";
            this.Size = new System.Drawing.Size(960, 619);
            this.Load += new System.EventHandler(this.MenuPortifolio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblContagem;
        private System.Windows.Forms.PictureBox pbxImagem;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.ComboBox cbxEnsaios;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

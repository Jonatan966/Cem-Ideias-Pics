namespace CemIdeiasPics.Formulários.Menus
{
    partial class MenuCadastroPortifolio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbxImagem = new System.Windows.Forms.PictureBox();
            this.lblContagem = new System.Windows.Forms.Label();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbrProgresso = new System.Windows.Forms.ProgressBar();
            this.btnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagem)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxImagem
            // 
            this.pbxImagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pbxImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImagem.Location = new System.Drawing.Point(12, 52);
            this.pbxImagem.Name = "pbxImagem";
            this.pbxImagem.Size = new System.Drawing.Size(522, 333);
            this.pbxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagem.TabIndex = 1;
            this.pbxImagem.TabStop = false;
            // 
            // lblContagem
            // 
            this.lblContagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContagem.Location = new System.Drawing.Point(12, 9);
            this.lblContagem.Name = "lblContagem";
            this.lblContagem.Size = new System.Drawing.Size(522, 40);
            this.lblContagem.TabIndex = 9;
            this.lblContagem.Text = "0 de 0";
            this.lblContagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.Black;
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.Color.Yellow;
            this.btnAnterior.Location = new System.Drawing.Point(3, 227);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(118, 50);
            this.btnAnterior.TabIndex = 11;
            this.btnAnterior.Tag = "-1";
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnControle_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.Color.Black;
            this.btnProximo.FlatAppearance.BorderSize = 0;
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.ForeColor = System.Drawing.Color.Yellow;
            this.btnProximo.Location = new System.Drawing.Point(133, 227);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(117, 50);
            this.btnProximo.TabIndex = 12;
            this.btnProximo.Tag = "1";
            this.btnProximo.Text = ">";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnControle_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Black;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.Yellow;
            this.btnExcluir.Location = new System.Drawing.Point(3, 115);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(247, 50);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Black;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.Yellow;
            this.btnAdicionar.Location = new System.Drawing.Point(3, 3);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(247, 50);
            this.btnAdicionar.TabIndex = 14;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Black;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.Yellow;
            this.btnAlterar.Location = new System.Drawing.Point(3, 59);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(247, 50);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVoltar.BackColor = System.Drawing.Color.Black;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.Yellow;
            this.btnVoltar.Location = new System.Drawing.Point(12, 403);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(781, 50);
            this.btnVoltar.TabIndex = 17;
            this.btnVoltar.Text = "OK";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Imagens|*.jpg;*.png";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExportar);
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnAnterior);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnProximo);
            this.panel1.Location = new System.Drawing.Point(540, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 285);
            this.panel1.TabIndex = 18;
            // 
            // pbrProgresso
            // 
            this.pbrProgresso.Enabled = false;
            this.pbrProgresso.Location = new System.Drawing.Point(543, 52);
            this.pbrProgresso.Name = "pbrProgresso";
            this.pbrProgresso.Size = new System.Drawing.Size(250, 42);
            this.pbrProgresso.TabIndex = 19;
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.Black;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.Yellow;
            this.btnExportar.Location = new System.Drawing.Point(3, 171);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(247, 50);
            this.btnExportar.TabIndex = 16;
            this.btnExportar.Text = "Exportar Tudo";
            this.btnExportar.UseVisualStyleBackColor = false;
            // 
            // MenuCadastroPortifolio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(805, 465);
            this.Controls.Add(this.pbrProgresso);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblContagem);
            this.Controls.Add(this.pbxImagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuCadastroPortifolio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuCadastroPortifolio";
            this.Load += new System.EventHandler(this.MenuCadastroPortifolio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxImagem;
        private System.Windows.Forms.Label lblContagem;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar pbrProgresso;
        private System.Windows.Forms.Button btnExportar;
    }
}
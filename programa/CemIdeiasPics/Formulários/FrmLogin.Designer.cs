namespace CemIdeiasPics.Formulários
{
    partial class FrmLogin : CemIdeiasPics.FrmModeloBase
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbcPassos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ciP_Label3 = new CemIdeiasPics.Utils.Controles.CIP_Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tlpInferior = new System.Windows.Forms.TableLayoutPanel();
            this.ciP_Label1 = new CemIdeiasPics.Utils.Controles.CIP_Label();
            this.txbSenha = new CemIdeiasPics.Utils.Controles.CIP_CaixaDeTexto();
            this.ciP_Label2 = new CemIdeiasPics.Utils.Controles.CIP_Label();
            this.txbUsuario = new CemIdeiasPics.Utils.Controles.CIP_CaixaDeTexto();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ciP_Label4 = new CemIdeiasPics.Utils.Controles.CIP_Label();
            this.btnReiniciar = new CemIdeiasPics.Controles.CIP_Botao();
            this.btnSairErro = new CemIdeiasPics.Controles.CIP_Botao();
            this.lblErro = new CemIdeiasPics.Utils.Controles.CIP_Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new CemIdeiasPics.Controles.CIP_Botao();
            this.btnSair = new CemIdeiasPics.Controles.CIP_Botao();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tbcPassos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tlpInferior.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(350, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 450);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbcPassos);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 430);
            this.panel1.TabIndex = 1;
            // 
            // tbcPassos
            // 
            this.tbcPassos.Controls.Add(this.tabPage1);
            this.tbcPassos.Controls.Add(this.tabPage2);
            this.tbcPassos.Controls.Add(this.tabPage3);
            this.tbcPassos.Location = new System.Drawing.Point(10, 143);
            this.tbcPassos.Margin = new System.Windows.Forms.Padding(10);
            this.tbcPassos.Name = "tbcPassos";
            this.tbcPassos.SelectedIndex = 0;
            this.tbcPassos.Size = new System.Drawing.Size(310, 277);
            this.tbcPassos.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.ciP_Label3);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(302, 244);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Carregando";
            // 
            // ciP_Label3
            // 
            this.ciP_Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ciP_Label3.Location = new System.Drawing.Point(18, 71);
            this.ciP_Label3.Name = "ciP_Label3";
            this.ciP_Label3.Size = new System.Drawing.Size(261, 44);
            this.ciP_Label3.TabIndex = 1;
            this.ciP_Label3.Text = "Carregando. . .";
            this.ciP_Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(23, 118);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(256, 37);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 50;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tlpInferior);
            this.tabPage2.Controls.Add(this.ciP_Label1);
            this.tabPage2.Controls.Add(this.txbSenha);
            this.tabPage2.Controls.Add(this.ciP_Label2);
            this.tabPage2.Controls.Add(this.txbUsuario);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(302, 244);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Login";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tlpInferior
            // 
            this.tlpInferior.ColumnCount = 2;
            this.tlpInferior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.81081F));
            this.tlpInferior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.18919F));
            this.tlpInferior.Controls.Add(this.btnSair, 1, 0);
            this.tlpInferior.Controls.Add(this.btnLogin, 0, 0);
            this.tlpInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpInferior.Location = new System.Drawing.Point(3, 188);
            this.tlpInferior.Name = "tlpInferior";
            this.tlpInferior.RowCount = 1;
            this.tlpInferior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInferior.Size = new System.Drawing.Size(296, 53);
            this.tlpInferior.TabIndex = 13;
            // 
            // ciP_Label1
            // 
            this.ciP_Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ciP_Label1.Location = new System.Drawing.Point(15, 5);
            this.ciP_Label1.Name = "ciP_Label1";
            this.ciP_Label1.Size = new System.Drawing.Size(276, 31);
            this.ciP_Label1.TabIndex = 9;
            this.ciP_Label1.Text = "Usuário";
            this.ciP_Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbSenha
            // 
            this.txbSenha.BackColor = System.Drawing.Color.LightYellow;
            this.txbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbSenha.Location = new System.Drawing.Point(15, 132);
            this.txbSenha.Margin = new System.Windows.Forms.Padding(10);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(276, 30);
            this.txbSenha.TabIndex = 8;
            this.txbSenha.UseSystemPasswordChar = true;
            // 
            // ciP_Label2
            // 
            this.ciP_Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ciP_Label2.Location = new System.Drawing.Point(15, 91);
            this.ciP_Label2.Name = "ciP_Label2";
            this.ciP_Label2.Size = new System.Drawing.Size(276, 31);
            this.ciP_Label2.TabIndex = 10;
            this.ciP_Label2.Text = "Senha";
            this.ciP_Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbUsuario
            // 
            this.txbUsuario.BackColor = System.Drawing.Color.LightYellow;
            this.txbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbUsuario.Location = new System.Drawing.Point(15, 46);
            this.txbUsuario.Margin = new System.Windows.Forms.Padding(10);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(276, 30);
            this.txbUsuario.TabIndex = 7;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ciP_Label4);
            this.tabPage3.Controls.Add(this.btnReiniciar);
            this.tabPage3.Controls.Add(this.btnSairErro);
            this.tabPage3.Controls.Add(this.lblErro);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(302, 244);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Erro";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ciP_Label4
            // 
            this.ciP_Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ciP_Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ciP_Label4.Location = new System.Drawing.Point(6, 3);
            this.ciP_Label4.Name = "ciP_Label4";
            this.ciP_Label4.Size = new System.Drawing.Size(290, 39);
            this.ciP_Label4.TabIndex = 15;
            this.ciP_Label4.Text = "Erro";
            this.ciP_Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnReiniciar.FlatAppearance.BorderSize = 0;
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnReiniciar.ForeColor = System.Drawing.Color.Black;
            this.btnReiniciar.Fundo = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnReiniciar.Location = new System.Drawing.Point(18, 181);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(15, 15, 5, 15);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(159, 45);
            this.btnReiniciar.TabIndex = 14;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnSairErro
            // 
            this.btnSairErro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSairErro.FlatAppearance.BorderSize = 0;
            this.btnSairErro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSairErro.ForeColor = System.Drawing.Color.Black;
            this.btnSairErro.Fundo = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSairErro.Location = new System.Drawing.Point(187, 181);
            this.btnSairErro.Margin = new System.Windows.Forms.Padding(5, 15, 15, 15);
            this.btnSairErro.Name = "btnSairErro";
            this.btnSairErro.Size = new System.Drawing.Size(97, 45);
            this.btnSairErro.TabIndex = 13;
            this.btnSairErro.Text = "Sair";
            this.btnSairErro.UseVisualStyleBackColor = false;
            this.btnSairErro.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // lblErro
            // 
            this.lblErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblErro.Location = new System.Drawing.Point(6, 57);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(290, 76);
            this.lblErro.TabIndex = 0;
            this.lblErro.Text = "Ocorreu um erro";
            this.lblErro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CemIdeiasPics.Properties.Resources.CemIdeiasPics_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(107, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Yellow;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Fundo = System.Drawing.Color.Yellow;
            this.btnLogin.Location = new System.Drawing.Point(3, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(173, 47);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Fazer Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnFazerLogin_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Fundo = System.Drawing.Color.Yellow;
            this.btnSair.Location = new System.Drawing.Point(182, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(111, 47);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmLogin";
            this.Text = "Cem Idéias Pics - Fazer Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tbcPassos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tlpInferior.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabControl tbcPassos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Utils.Controles.CIP_Label ciP_Label1;
        private Utils.Controles.CIP_CaixaDeTexto txbSenha;
        private Utils.Controles.CIP_Label ciP_Label2;
        private Utils.Controles.CIP_CaixaDeTexto txbUsuario;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private Utils.Controles.CIP_Label ciP_Label3;
        private Controles.CIP_Botao btnReiniciar;
        private Controles.CIP_Botao btnSairErro;
        private Utils.Controles.CIP_Label lblErro;
        private Utils.Controles.CIP_Label ciP_Label4;
        private System.Windows.Forms.TableLayoutPanel tlpInferior;
        private Controles.CIP_Botao btnSair;
        private Controles.CIP_Botao btnLogin;
    }
}

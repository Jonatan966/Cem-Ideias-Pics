namespace CemIdeiasPics.Formulários
{
    partial class FrmPainel
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblNomeUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSair = new System.Windows.Forms.Button();
            this.rbnClientes = new System.Windows.Forms.RadioButton();
            this.rbnEnsaios = new System.Windows.Forms.RadioButton();
            this.rbnPortifolio = new System.Windows.Forms.RadioButton();
            this.rbnConfig = new System.Windows.Forms.RadioButton();
            this.lblUsuario = new CemIdeiasPics.Utils.Controles.CIP_Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.Color.Black;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblNomeUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 678);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1093, 37);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(87, 30);
            this.lblNomeUsuario.Text = "Um coiso";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.ImageLocation = "https://pbs.twimg.com/profile_images/1017511506253139969/q6FOlpkP.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 628);
            this.panel1.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnSair, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.rbnClientes, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rbnEnsaios, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.rbnPortifolio, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbnConfig, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 231);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(217, 397);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(152)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Gray;
            this.btnSair.Location = new System.Drawing.Point(0, 316);
            this.btnSair.Margin = new System.Windows.Forms.Padding(0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(217, 81);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // rbnClientes
            // 
            this.rbnClientes.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbnClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbnClientes.FlatAppearance.BorderSize = 0;
            this.rbnClientes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rbnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.rbnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(152)))));
            this.rbnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnClientes.ForeColor = System.Drawing.Color.Gray;
            this.rbnClientes.Image = global::CemIdeiasPics.Properties.Resources.Clientes_Icon;
            this.rbnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbnClientes.Location = new System.Drawing.Point(0, 79);
            this.rbnClientes.Margin = new System.Windows.Forms.Padding(0);
            this.rbnClientes.Name = "rbnClientes";
            this.rbnClientes.Size = new System.Drawing.Size(217, 79);
            this.rbnClientes.TabIndex = 8;
            this.rbnClientes.Text = "Clientes";
            this.rbnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbnClientes.UseVisualStyleBackColor = true;
            // 
            // rbnEnsaios
            // 
            this.rbnEnsaios.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbnEnsaios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbnEnsaios.FlatAppearance.BorderSize = 0;
            this.rbnEnsaios.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rbnEnsaios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.rbnEnsaios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(152)))));
            this.rbnEnsaios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbnEnsaios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnEnsaios.ForeColor = System.Drawing.Color.Gray;
            this.rbnEnsaios.Image = global::CemIdeiasPics.Properties.Resources.Camera_Icone;
            this.rbnEnsaios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbnEnsaios.Location = new System.Drawing.Point(0, 158);
            this.rbnEnsaios.Margin = new System.Windows.Forms.Padding(0);
            this.rbnEnsaios.Name = "rbnEnsaios";
            this.rbnEnsaios.Size = new System.Drawing.Size(217, 79);
            this.rbnEnsaios.TabIndex = 9;
            this.rbnEnsaios.Text = "Ensaios";
            this.rbnEnsaios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbnEnsaios.UseVisualStyleBackColor = true;
            // 
            // rbnPortifolio
            // 
            this.rbnPortifolio.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbnPortifolio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbnPortifolio.FlatAppearance.BorderSize = 0;
            this.rbnPortifolio.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rbnPortifolio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.rbnPortifolio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(152)))));
            this.rbnPortifolio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbnPortifolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnPortifolio.ForeColor = System.Drawing.Color.Gray;
            this.rbnPortifolio.Image = global::CemIdeiasPics.Properties.Resources.Portifolio_Icone;
            this.rbnPortifolio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbnPortifolio.Location = new System.Drawing.Point(0, 0);
            this.rbnPortifolio.Margin = new System.Windows.Forms.Padding(0);
            this.rbnPortifolio.Name = "rbnPortifolio";
            this.rbnPortifolio.Size = new System.Drawing.Size(217, 79);
            this.rbnPortifolio.TabIndex = 10;
            this.rbnPortifolio.Text = "Portifólio";
            this.rbnPortifolio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbnPortifolio.UseVisualStyleBackColor = true;
            // 
            // rbnConfig
            // 
            this.rbnConfig.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbnConfig.BackColor = System.Drawing.Color.Black;
            this.rbnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbnConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbnConfig.FlatAppearance.BorderSize = 0;
            this.rbnConfig.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rbnConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.rbnConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(152)))));
            this.rbnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnConfig.ForeColor = System.Drawing.Color.Gray;
            this.rbnConfig.Image = global::CemIdeiasPics.Properties.Resources.Configs_Icone;
            this.rbnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbnConfig.Location = new System.Drawing.Point(0, 237);
            this.rbnConfig.Margin = new System.Windows.Forms.Padding(0);
            this.rbnConfig.Name = "rbnConfig";
            this.rbnConfig.Size = new System.Drawing.Size(217, 79);
            this.rbnConfig.TabIndex = 11;
            this.rbnConfig.Text = "Opções";
            this.rbnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbnConfig.UseVisualStyleBackColor = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(0, 191);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(217, 40);
            this.lblUsuario.TabIndex = 13;
            this.lblUsuario.Text = "Nome de Usuário";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPainel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(1093, 715);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.IsMdiContainer = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1020);
            this.Name = "FrmPainel";
            this.Load += new System.EventHandler(this.FrmPainel_Load);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblNomeUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbnConfig;
        private System.Windows.Forms.RadioButton rbnClientes;
        private System.Windows.Forms.RadioButton rbnPortifolio;
        private System.Windows.Forms.RadioButton rbnEnsaios;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSair;
        private Utils.Controles.CIP_Label lblUsuario;
    }
}

namespace CemIdeiasPics.Formulários.Menus
{
    partial class MenuClientes
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbPesquisa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxFiltro = new System.Windows.Forms.ComboBox();
            this.btnRecarregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDesmarcar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mdlEndereco1 = new CemIdeiasPics.Utils.Modelos.MdlEndereco();
            this.cbxComplemento = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbNumResidencia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.rbnSexo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rbnFeminino = new System.Windows.Forms.RadioButton();
            this.rbnMasculino = new System.Windows.Forms.RadioButton();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbCPF = new System.Windows.Forms.MaskedTextBox();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.rbnSexo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.btnRecarregar);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnDesmarcar);
            this.panel2.Controls.Add(this.dgvClientes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(500, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(593, 653);
            this.panel2.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txbPesquisa);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(6, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(584, 91);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtragem";
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPesquisa.BackColor = System.Drawing.Color.Silver;
            this.txbPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPesquisa.Location = new System.Drawing.Point(6, 48);
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.Size = new System.Drawing.Size(413, 26);
            this.txbPesquisa.TabIndex = 2;
            this.txbPesquisa.TextChanged += new System.EventHandler(this.txbPesquisa_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbxFiltro);
            this.groupBox1.Location = new System.Drawing.Point(425, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 60);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por";
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltro.FormattingEnabled = true;
            this.cbxFiltro.Location = new System.Drawing.Point(3, 22);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(147, 28);
            this.cbxFiltro.TabIndex = 0;
            this.cbxFiltro.SelectedIndexChanged += new System.EventHandler(this.txbPesquisa_TextChanged);
            // 
            // btnRecarregar
            // 
            this.btnRecarregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecarregar.BackColor = System.Drawing.Color.Black;
            this.btnRecarregar.FlatAppearance.BorderSize = 0;
            this.btnRecarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecarregar.ForeColor = System.Drawing.Color.Yellow;
            this.btnRecarregar.Location = new System.Drawing.Point(435, 600);
            this.btnRecarregar.Name = "btnRecarregar";
            this.btnRecarregar.Size = new System.Drawing.Size(155, 50);
            this.btnRecarregar.TabIndex = 10;
            this.btnRecarregar.Text = "Recarregar";
            this.btnRecarregar.UseVisualStyleBackColor = false;
            this.btnRecarregar.Click += new System.EventHandler(this.btnRecarregar_Click);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(593, 40);
            this.label6.TabIndex = 9;
            this.label6.Text = "Consulta";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDesmarcar
            // 
            this.btnDesmarcar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesmarcar.BackColor = System.Drawing.Color.Black;
            this.btnDesmarcar.FlatAppearance.BorderSize = 0;
            this.btnDesmarcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesmarcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesmarcar.ForeColor = System.Drawing.Color.Yellow;
            this.btnDesmarcar.Location = new System.Drawing.Point(3, 600);
            this.btnDesmarcar.Name = "btnDesmarcar";
            this.btnDesmarcar.Size = new System.Drawing.Size(426, 50);
            this.btnDesmarcar.TabIndex = 1;
            this.btnDesmarcar.Text = "Desmarcar";
            this.btnDesmarcar.UseVisualStyleBackColor = false;
            this.btnDesmarcar.Click += new System.EventHandler(this.btnDesmarcar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(3, 151);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowHeadersWidth = 62;
            this.dgvClientes.RowTemplate.Height = 28;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(587, 443);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.mdlEndereco1);
            this.panel1.Controls.Add(this.cbxComplemento);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txbNumResidencia);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txbEmail);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtpNascimento);
            this.panel1.Controls.Add(this.rbnSexo);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbTelefone);
            this.panel1.Controls.Add(this.txbNome);
            this.panel1.Controls.Add(this.txbCPF);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 653);
            this.panel1.TabIndex = 2;
            // 
            // mdlEndereco1
            // 
            this.mdlEndereco1.AutoSize = true;
            this.mdlEndereco1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mdlEndereco1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mdlEndereco1.Location = new System.Drawing.Point(32, 212);
            this.mdlEndereco1.Name = "mdlEndereco1";
            this.mdlEndereco1.Size = new System.Drawing.Size(432, 175);
            this.mdlEndereco1.TabIndex = 23;
            // 
            // cbxComplemento
            // 
            this.cbxComplemento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxComplemento.BackColor = System.Drawing.Color.Silver;
            this.cbxComplemento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxComplemento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxComplemento.FormattingEnabled = true;
            this.cbxComplemento.Items.AddRange(new object[] {
            "Casa",
            "Apartamento"});
            this.cbxComplemento.Location = new System.Drawing.Point(331, 395);
            this.cbxComplemento.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cbxComplemento.Name = "cbxComplemento";
            this.cbxComplemento.Size = new System.Drawing.Size(155, 33);
            this.cbxComplemento.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(244, 403);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "Comp.:";
            // 
            // txbNumResidencia
            // 
            this.txbNumResidencia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbNumResidencia.BackColor = System.Drawing.Color.Silver;
            this.txbNumResidencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNumResidencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumResidencia.Location = new System.Drawing.Point(100, 398);
            this.txbNumResidencia.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txbNumResidencia.Name = "txbNumResidencia";
            this.txbNumResidencia.Size = new System.Drawing.Size(126, 30);
            this.txbNumResidencia.TabIndex = 20;
            this.txbNumResidencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 403);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Número:";
            // 
            // txbEmail
            // 
            this.txbEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbEmail.BackColor = System.Drawing.Color.Silver;
            this.txbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(102, 174);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(392, 30);
            this.txbEmail.TabIndex = 16;
            this.txbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 179);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "E-Mail:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 139);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nasc.:";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNascimento.CalendarMonthBackground = System.Drawing.Color.Silver;
            this.dtpNascimento.CalendarTitleBackColor = System.Drawing.Color.Yellow;
            this.dtpNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(83, 134);
            this.dtpNascimento.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(136, 30);
            this.dtpNascimento.TabIndex = 12;
            this.dtpNascimento.Value = new System.DateTime(2019, 12, 1, 0, 0, 0, 0);
            // 
            // rbnSexo
            // 
            this.rbnSexo.Controls.Add(this.tableLayoutPanel1);
            this.rbnSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnSexo.Location = new System.Drawing.Point(10, 438);
            this.rbnSexo.Margin = new System.Windows.Forms.Padding(5);
            this.rbnSexo.Name = "rbnSexo";
            this.rbnSexo.Size = new System.Drawing.Size(480, 71);
            this.rbnSexo.TabIndex = 11;
            this.rbnSexo.TabStop = false;
            this.rbnSexo.Text = "Sexo";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.rbnFeminino, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbnMasculino, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(474, 42);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // rbnFeminino
            // 
            this.rbnFeminino.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbnFeminino.BackColor = System.Drawing.Color.Black;
            this.rbnFeminino.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbnFeminino.FlatAppearance.BorderSize = 0;
            this.rbnFeminino.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.rbnFeminino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbnFeminino.ForeColor = System.Drawing.Color.Yellow;
            this.rbnFeminino.Location = new System.Drawing.Point(240, 3);
            this.rbnFeminino.Name = "rbnFeminino";
            this.rbnFeminino.Size = new System.Drawing.Size(231, 36);
            this.rbnFeminino.TabIndex = 1;
            this.rbnFeminino.TabStop = true;
            this.rbnFeminino.Text = "Feminino";
            this.rbnFeminino.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbnFeminino.UseVisualStyleBackColor = false;
            // 
            // rbnMasculino
            // 
            this.rbnMasculino.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbnMasculino.BackColor = System.Drawing.Color.Black;
            this.rbnMasculino.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbnMasculino.FlatAppearance.BorderSize = 0;
            this.rbnMasculino.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.rbnMasculino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbnMasculino.ForeColor = System.Drawing.Color.Yellow;
            this.rbnMasculino.Location = new System.Drawing.Point(3, 3);
            this.rbnMasculino.Name = "rbnMasculino";
            this.rbnMasculino.Size = new System.Drawing.Size(231, 36);
            this.rbnMasculino.TabIndex = 0;
            this.rbnMasculino.TabStop = true;
            this.rbnMasculino.Text = "Masculino";
            this.rbnMasculino.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbnMasculino.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLimpar.BackColor = System.Drawing.Color.Black;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Yellow;
            this.btnLimpar.Location = new System.Drawing.Point(249, 600);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(246, 50);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRegistrar.BackColor = System.Drawing.Color.Black;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Yellow;
            this.btnRegistrar.Location = new System.Drawing.Point(5, 600);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(238, 50);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(500, 40);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dados do Cliente";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(236, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "CPF:";
            // 
            // txbTelefone
            // 
            this.txbTelefone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbTelefone.BackColor = System.Drawing.Color.Silver;
            this.txbTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTelefone.Location = new System.Drawing.Point(339, 134);
            this.txbTelefone.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txbTelefone.Mask = "(00)00000000";
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(155, 30);
            this.txbTelefone.TabIndex = 3;
            this.txbTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbNome
            // 
            this.txbNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbNome.BackColor = System.Drawing.Color.Silver;
            this.txbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(96, 94);
            this.txbNome.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(398, 30);
            this.txbNome.TabIndex = 1;
            this.txbNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbCPF
            // 
            this.txbCPF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbCPF.BackColor = System.Drawing.Color.Silver;
            this.txbCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCPF.Location = new System.Drawing.Point(78, 54);
            this.txbCPF.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txbCPF.Mask = "000,000,000-00";
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(417, 30);
            this.txbCPF.TabIndex = 0;
            this.txbCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MenuClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MenuClientes";
            this.Size = new System.Drawing.Size(1093, 653);
            this.Load += new System.EventHandler(this.MenuClientes_Load);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.rbnSexo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbPesquisa;
        private System.Windows.Forms.Button btnDesmarcar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbNumResidencia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.GroupBox rbnSexo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton rbnFeminino;
        private System.Windows.Forms.RadioButton rbnMasculino;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txbTelefone;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.MaskedTextBox txbCPF;
        private Utils.Modelos.MdlEndereco mdlEndereco1;
        private System.Windows.Forms.ComboBox cbxComplemento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRecarregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxFiltro;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

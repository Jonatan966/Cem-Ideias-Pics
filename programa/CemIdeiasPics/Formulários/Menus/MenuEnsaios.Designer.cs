namespace CemIdeiasPics.Formulários.Menus
{
    partial class MenuEnsaios
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxFiltro = new System.Windows.Forms.ComboBox();
            this.btnRecarregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDesmarcar = new System.Windows.Forms.Button();
            this.dgvEnsaios = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mdlEndereco1 = new CemIdeiasPics.Utils.Modelos.MdlEndereco();
            this.txbNumeroRes = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPortifolio = new System.Windows.Forms.Button();
            this.cbxTipoAlbum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTipoEnsaio = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDataEnsaio = new System.Windows.Forms.DateTimePicker();
            this.cbxClientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnsaios)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.btnRecarregar);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnDesmarcar);
            this.panel2.Controls.Add(this.dgvEnsaios);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(352, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 453);
            this.panel2.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txbPesquisa);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(5, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(389, 59);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtragem";
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPesquisa.BackColor = System.Drawing.Color.Silver;
            this.txbPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPesquisa.Location = new System.Drawing.Point(4, 31);
            this.txbPesquisa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.Size = new System.Drawing.Size(276, 20);
            this.txbPesquisa.TabIndex = 2;
            this.txbPesquisa.TextChanged += new System.EventHandler(this.txbPesquisa_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cbxFiltro);
            this.groupBox3.Location = new System.Drawing.Point(283, 16);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(102, 39);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtrar por";
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltro.FormattingEnabled = true;
            this.cbxFiltro.Location = new System.Drawing.Point(2, 15);
            this.cbxFiltro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(98, 21);
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
            this.btnRecarregar.Location = new System.Drawing.Point(295, 419);
            this.btnRecarregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRecarregar.Name = "btnRecarregar";
            this.btnRecarregar.Size = new System.Drawing.Size(103, 32);
            this.btnRecarregar.TabIndex = 11;
            this.btnRecarregar.Text = "Recarregar";
            this.btnRecarregar.UseVisualStyleBackColor = false;
            this.btnRecarregar.Click += new System.EventHandler(this.btnRecarregar_Click);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(400, 26);
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
            this.btnDesmarcar.Location = new System.Drawing.Point(2, 419);
            this.btnDesmarcar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDesmarcar.Name = "btnDesmarcar";
            this.btnDesmarcar.Size = new System.Drawing.Size(289, 32);
            this.btnDesmarcar.TabIndex = 1;
            this.btnDesmarcar.Text = "Desmarcar";
            this.btnDesmarcar.UseVisualStyleBackColor = false;
            this.btnDesmarcar.Click += new System.EventHandler(this.btnDesmarcar_Click);
            // 
            // dgvEnsaios
            // 
            this.dgvEnsaios.AllowUserToAddRows = false;
            this.dgvEnsaios.AllowUserToDeleteRows = false;
            this.dgvEnsaios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEnsaios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEnsaios.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvEnsaios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnsaios.Location = new System.Drawing.Point(2, 91);
            this.dgvEnsaios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEnsaios.MultiSelect = false;
            this.dgvEnsaios.Name = "dgvEnsaios";
            this.dgvEnsaios.ReadOnly = true;
            this.dgvEnsaios.RowHeadersVisible = false;
            this.dgvEnsaios.RowHeadersWidth = 62;
            this.dgvEnsaios.RowTemplate.Height = 28;
            this.dgvEnsaios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnsaios.Size = new System.Drawing.Size(396, 324);
            this.dgvEnsaios.TabIndex = 0;
            this.dgvEnsaios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnsaios_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnPortifolio);
            this.panel1.Controls.Add(this.cbxTipoAlbum);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbxTipoEnsaio);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtpDataEnsaio);
            this.panel1.Controls.Add(this.cbxClientes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 453);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mdlEndereco1);
            this.groupBox1.Controls.Add(this.txbNumeroRes);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(23, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(303, 159);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Local do Ensaio";
            // 
            // mdlEndereco1
            // 
            this.mdlEndereco1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mdlEndereco1.AutoSize = true;
            this.mdlEndereco1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mdlEndereco1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mdlEndereco1.Location = new System.Drawing.Point(7, 14);
            this.mdlEndereco1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.mdlEndereco1.Name = "mdlEndereco1";
            this.mdlEndereco1.Size = new System.Drawing.Size(290, 117);
            this.mdlEndereco1.TabIndex = 30;
            // 
            // txbNumeroRes
            // 
            this.txbNumeroRes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbNumeroRes.BackColor = System.Drawing.Color.Silver;
            this.txbNumeroRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNumeroRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumeroRes.Location = new System.Drawing.Point(71, 132);
            this.txbNumeroRes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbNumeroRes.Name = "txbNumeroRes";
            this.txbNumeroRes.Size = new System.Drawing.Size(218, 23);
            this.txbNumeroRes.TabIndex = 22;
            this.txbNumeroRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 135);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 3, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Número:";
            // 
            // btnPortifolio
            // 
            this.btnPortifolio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPortifolio.BackColor = System.Drawing.Color.Black;
            this.btnPortifolio.FlatAppearance.BorderSize = 0;
            this.btnPortifolio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPortifolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPortifolio.ForeColor = System.Drawing.Color.Yellow;
            this.btnPortifolio.Location = new System.Drawing.Point(5, 383);
            this.btnPortifolio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPortifolio.Name = "btnPortifolio";
            this.btnPortifolio.Size = new System.Drawing.Size(343, 32);
            this.btnPortifolio.TabIndex = 10;
            this.btnPortifolio.Text = "Abrir Portifolio";
            this.btnPortifolio.UseVisualStyleBackColor = false;
            this.btnPortifolio.Click += new System.EventHandler(this.btnPortifolio_Click);
            // 
            // cbxTipoAlbum
            // 
            this.cbxTipoAlbum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxTipoAlbum.BackColor = System.Drawing.Color.Silver;
            this.cbxTipoAlbum.DisplayMember = "tipo";
            this.cbxTipoAlbum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxTipoAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoAlbum.FormattingEnabled = true;
            this.cbxTipoAlbum.Items.AddRange(new object[] {
            "Album Fisico"});
            this.cbxTipoAlbum.Location = new System.Drawing.Point(91, 276);
            this.cbxTipoAlbum.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.cbxTipoAlbum.Name = "cbxTipoAlbum";
            this.cbxTipoAlbum.Size = new System.Drawing.Size(257, 24);
            this.cbxTipoAlbum.TabIndex = 28;
            this.cbxTipoAlbum.ValueMember = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 281);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tip. Album:";
            // 
            // cbxTipoEnsaio
            // 
            this.cbxTipoEnsaio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxTipoEnsaio.BackColor = System.Drawing.Color.Silver;
            this.cbxTipoEnsaio.DisplayMember = "tipo";
            this.cbxTipoEnsaio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoEnsaio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxTipoEnsaio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoEnsaio.FormattingEnabled = true;
            this.cbxTipoEnsaio.Items.AddRange(new object[] {
            "Casamento"});
            this.cbxTipoEnsaio.Location = new System.Drawing.Point(94, 249);
            this.cbxTipoEnsaio.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.cbxTipoEnsaio.Name = "cbxTipoEnsaio";
            this.cbxTipoEnsaio.Size = new System.Drawing.Size(254, 24);
            this.cbxTipoEnsaio.TabIndex = 26;
            this.cbxTipoEnsaio.ValueMember = "ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 254);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 3, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Tip. Ensaio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 226);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Data:";
            // 
            // dtpDataEnsaio
            // 
            this.dtpDataEnsaio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpDataEnsaio.CalendarMonthBackground = System.Drawing.Color.Silver;
            this.dtpDataEnsaio.CalendarTitleBackColor = System.Drawing.Color.Yellow;
            this.dtpDataEnsaio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataEnsaio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEnsaio.Location = new System.Drawing.Point(65, 223);
            this.dtpDataEnsaio.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.dtpDataEnsaio.Name = "dtpDataEnsaio";
            this.dtpDataEnsaio.Size = new System.Drawing.Size(283, 23);
            this.dtpDataEnsaio.TabIndex = 23;
            this.dtpDataEnsaio.Value = new System.DateTime(2019, 12, 1, 0, 0, 0, 0);
            // 
            // cbxClientes
            // 
            this.cbxClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxClientes.DisplayMember = "NOME";
            this.cbxClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxClientes.FormattingEnabled = true;
            this.cbxClientes.Location = new System.Drawing.Point(61, 31);
            this.cbxClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxClientes.Name = "cbxClientes";
            this.cbxClientes.Size = new System.Drawing.Size(288, 24);
            this.cbxClientes.TabIndex = 12;
            this.cbxClientes.ValueMember = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cliente:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLimpar.BackColor = System.Drawing.Color.Black;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Yellow;
            this.btnLimpar.Location = new System.Drawing.Point(175, 419);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(164, 32);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRegistrar.BackColor = System.Drawing.Color.Black;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Yellow;
            this.btnRegistrar.Location = new System.Drawing.Point(13, 419);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(159, 32);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(352, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dados do Ensaio";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuEnsaios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MenuEnsaios";
            this.Size = new System.Drawing.Size(752, 453);
            this.Load += new System.EventHandler(this.MenuEnsaios_Load);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnsaios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDesmarcar;
        private System.Windows.Forms.DataGridView dgvEnsaios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPortifolio;
        private System.Windows.Forms.ComboBox cbxTipoAlbum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTipoEnsaio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDataEnsaio;
        private System.Windows.Forms.TextBox txbNumeroRes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRecarregar;
        private Utils.Modelos.MdlEndereco mdlEndereco1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbPesquisa;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbxFiltro;
    }
}

namespace CemIdeiasPics.Formulários.Configs
{
    partial class ConfigGerenciaUsuarios
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
            this.cbxUsuarios = new System.Windows.Forms.ComboBox();
            this.gbxListaUsuarios = new System.Windows.Forms.GroupBox();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.gbxDadosPessoais = new System.Windows.Forms.GroupBox();
            this.txbCPF = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxFotoPerfil = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.MaskedTextBox();
            this.rbnFeminino = new System.Windows.Forms.RadioButton();
            this.lblSexo = new System.Windows.Forms.Label();
            this.rbnMasculino = new System.Windows.Forms.RadioButton();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.gbxDadosAcesso = new System.Windows.Forms.GroupBox();
            this.lblTipoAcesso = new System.Windows.Forms.Label();
            this.cbxTipoAcesso = new System.Windows.Forms.ComboBox();
            this.txbConfSenha = new System.Windows.Forms.TextBox();
            this.lblConfSenha = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimparTudo = new System.Windows.Forms.Button();
            this.objEscolheImg = new System.Windows.Forms.OpenFileDialog();
            this.gbxListaUsuarios.SuspendLayout();
            this.gbxDadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotoPerfil)).BeginInit();
            this.gbxDadosAcesso.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxUsuarios
            // 
            this.cbxUsuarios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxUsuarios.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxUsuarios.BackColor = System.Drawing.Color.Silver;
            this.cbxUsuarios.DisplayMember = "user";
            this.cbxUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUsuarios.FormattingEnabled = true;
            this.cbxUsuarios.Items.AddRange(new object[] {
            "Album Fisico"});
            this.cbxUsuarios.Location = new System.Drawing.Point(8, 23);
            this.cbxUsuarios.Margin = new System.Windows.Forms.Padding(5);
            this.cbxUsuarios.Name = "cbxUsuarios";
            this.cbxUsuarios.Size = new System.Drawing.Size(606, 24);
            this.cbxUsuarios.TabIndex = 29;
            this.cbxUsuarios.ValueMember = "id";
            this.cbxUsuarios.SelectedIndexChanged += new System.EventHandler(this.cbxUsuarios_SelectedIndexChanged);
            // 
            // gbxListaUsuarios
            // 
            this.gbxListaUsuarios.Controls.Add(this.cbxUsuarios);
            this.gbxListaUsuarios.Location = new System.Drawing.Point(12, 37);
            this.gbxListaUsuarios.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.gbxListaUsuarios.Name = "gbxListaUsuarios";
            this.gbxListaUsuarios.Size = new System.Drawing.Size(622, 55);
            this.gbxListaUsuarios.TabIndex = 30;
            this.gbxListaUsuarios.TabStop = false;
            this.gbxListaUsuarios.Text = "Lista de Usuários";
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Location = new System.Drawing.Point(35, 59);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(38, 13);
            this.lblNomeUsuario.TabIndex = 31;
            this.lblNomeUsuario.Text = "Nome:";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(79, 52);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(142, 20);
            this.txbNome.TabIndex = 32;
            this.txbNome.Enter += new System.EventHandler(this.VerificaMudanca);
            // 
            // gbxDadosPessoais
            // 
            this.gbxDadosPessoais.Controls.Add(this.txbCPF);
            this.gbxDadosPessoais.Controls.Add(this.label1);
            this.gbxDadosPessoais.Controls.Add(this.pbxFotoPerfil);
            this.gbxDadosPessoais.Controls.Add(this.lblEmail);
            this.gbxDadosPessoais.Controls.Add(this.txbEmail);
            this.gbxDadosPessoais.Controls.Add(this.rbnFeminino);
            this.gbxDadosPessoais.Controls.Add(this.lblSexo);
            this.gbxDadosPessoais.Controls.Add(this.rbnMasculino);
            this.gbxDadosPessoais.Controls.Add(this.lblTelefone);
            this.gbxDadosPessoais.Controls.Add(this.txbTelefone);
            this.gbxDadosPessoais.Controls.Add(this.txbNome);
            this.gbxDadosPessoais.Controls.Add(this.lblNomeUsuario);
            this.gbxDadosPessoais.Location = new System.Drawing.Point(12, 100);
            this.gbxDadosPessoais.Name = "gbxDadosPessoais";
            this.gbxDadosPessoais.Size = new System.Drawing.Size(622, 121);
            this.gbxDadosPessoais.TabIndex = 33;
            this.gbxDadosPessoais.TabStop = false;
            this.gbxDadosPessoais.Text = "Dados Pessoais";
            // 
            // txbCPF
            // 
            this.txbCPF.Location = new System.Drawing.Point(198, 26);
            this.txbCPF.Mask = "000,000,000-00";
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(148, 20);
            this.txbCPF.TabIndex = 42;
            this.txbCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbCPF.Enter += new System.EventHandler(this.VerificaMudanca);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "CPF:";
            // 
            // pbxFotoPerfil
            // 
            this.pbxFotoPerfil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxFotoPerfil.Location = new System.Drawing.Point(481, 15);
            this.pbxFotoPerfil.Name = "pbxFotoPerfil";
            this.pbxFotoPerfil.Size = new System.Drawing.Size(100, 96);
            this.pbxFotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFotoPerfil.TabIndex = 40;
            this.pbxFotoPerfil.TabStop = false;
            this.pbxFotoPerfil.DoubleClick += new System.EventHandler(this.pbxFotoPerfil_DoubleClick);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(244, 82);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 39;
            this.lblEmail.Text = "Email:";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(285, 75);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(148, 20);
            this.txbEmail.TabIndex = 38;
            this.txbEmail.Enter += new System.EventHandler(this.VerificaMudanca);
            // 
            // rbnFeminino
            // 
            this.rbnFeminino.AutoSize = true;
            this.rbnFeminino.Location = new System.Drawing.Point(158, 78);
            this.rbnFeminino.Name = "rbnFeminino";
            this.rbnFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbnFeminino.TabIndex = 37;
            this.rbnFeminino.TabStop = true;
            this.rbnFeminino.Text = "Feminino";
            this.rbnFeminino.UseVisualStyleBackColor = true;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(35, 82);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 36;
            this.lblSexo.Text = "Sexo:";
            // 
            // rbnMasculino
            // 
            this.rbnMasculino.AutoSize = true;
            this.rbnMasculino.Location = new System.Drawing.Point(79, 78);
            this.rbnMasculino.Name = "rbnMasculino";
            this.rbnMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbnMasculino.TabIndex = 35;
            this.rbnMasculino.TabStop = true;
            this.rbnMasculino.Text = "Masculino";
            this.rbnMasculino.UseVisualStyleBackColor = true;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(227, 59);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 34;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(285, 52);
            this.txbTelefone.Mask = "(00)00000000";
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(148, 20);
            this.txbTelefone.TabIndex = 33;
            this.txbTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbTelefone.Enter += new System.EventHandler(this.VerificaMudanca);
            // 
            // gbxDadosAcesso
            // 
            this.gbxDadosAcesso.Controls.Add(this.lblTipoAcesso);
            this.gbxDadosAcesso.Controls.Add(this.cbxTipoAcesso);
            this.gbxDadosAcesso.Controls.Add(this.txbConfSenha);
            this.gbxDadosAcesso.Controls.Add(this.lblConfSenha);
            this.gbxDadosAcesso.Controls.Add(this.txbSenha);
            this.gbxDadosAcesso.Controls.Add(this.lblSenha);
            this.gbxDadosAcesso.Controls.Add(this.txbLogin);
            this.gbxDadosAcesso.Controls.Add(this.lblLogin);
            this.gbxDadosAcesso.Location = new System.Drawing.Point(12, 228);
            this.gbxDadosAcesso.Name = "gbxDadosAcesso";
            this.gbxDadosAcesso.Size = new System.Drawing.Size(622, 76);
            this.gbxDadosAcesso.TabIndex = 34;
            this.gbxDadosAcesso.TabStop = false;
            this.gbxDadosAcesso.Text = "Dados de Acesso";
            // 
            // lblTipoAcesso
            // 
            this.lblTipoAcesso.AutoSize = true;
            this.lblTipoAcesso.Location = new System.Drawing.Point(28, 53);
            this.lblTipoAcesso.Name = "lblTipoAcesso";
            this.lblTipoAcesso.Size = new System.Drawing.Size(84, 13);
            this.lblTipoAcesso.TabIndex = 48;
            this.lblTipoAcesso.Text = "Tipo de Acesso:";
            // 
            // cbxTipoAcesso
            // 
            this.cbxTipoAcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoAcesso.FormattingEnabled = true;
            this.cbxTipoAcesso.Items.AddRange(new object[] {
            "Comum",
            "Administrador"});
            this.cbxTipoAcesso.Location = new System.Drawing.Point(118, 45);
            this.cbxTipoAcesso.Name = "cbxTipoAcesso";
            this.cbxTipoAcesso.Size = new System.Drawing.Size(468, 21);
            this.cbxTipoAcesso.TabIndex = 47;
            this.cbxTipoAcesso.Enter += new System.EventHandler(this.VerificaMudanca);
            // 
            // txbConfSenha
            // 
            this.txbConfSenha.Location = new System.Drawing.Point(463, 19);
            this.txbConfSenha.Name = "txbConfSenha";
            this.txbConfSenha.Size = new System.Drawing.Size(123, 20);
            this.txbConfSenha.TabIndex = 46;
            this.txbConfSenha.UseSystemPasswordChar = true;
            this.txbConfSenha.Enter += new System.EventHandler(this.VerificaMudanca);
            // 
            // lblConfSenha
            // 
            this.lblConfSenha.AutoSize = true;
            this.lblConfSenha.Location = new System.Drawing.Point(379, 26);
            this.lblConfSenha.Name = "lblConfSenha";
            this.lblConfSenha.Size = new System.Drawing.Size(78, 13);
            this.lblConfSenha.TabIndex = 45;
            this.lblConfSenha.Text = "Repetir Senha:";
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(250, 19);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(123, 20);
            this.txbSenha.TabIndex = 44;
            this.txbSenha.UseSystemPasswordChar = true;
            this.txbSenha.Enter += new System.EventHandler(this.VerificaMudanca);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(203, 26);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 43;
            this.lblSenha.Text = "Senha:";
            // 
            // txbLogin
            // 
            this.txbLogin.Location = new System.Drawing.Point(72, 19);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(123, 20);
            this.txbLogin.TabIndex = 42;
            this.txbLogin.Enter += new System.EventHandler(this.VerificaMudanca);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(28, 26);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(36, 13);
            this.lblLogin.TabIndex = 41;
            this.lblLogin.Text = "Login:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSalvar.BackColor = System.Drawing.Color.Black;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Yellow;
            this.btnSalvar.Location = new System.Drawing.Point(174, 321);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(461, 32);
            this.btnSalvar.TabIndex = 36;
            this.btnSalvar.Text = "OK";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimparTudo
            // 
            this.btnLimparTudo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLimparTudo.BackColor = System.Drawing.Color.Black;
            this.btnLimparTudo.FlatAppearance.BorderSize = 0;
            this.btnLimparTudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparTudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparTudo.ForeColor = System.Drawing.Color.Yellow;
            this.btnLimparTudo.Location = new System.Drawing.Point(11, 321);
            this.btnLimparTudo.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimparTudo.Name = "btnLimparTudo";
            this.btnLimparTudo.Size = new System.Drawing.Size(159, 32);
            this.btnLimparTudo.TabIndex = 35;
            this.btnLimparTudo.Text = "Limpar Tudo";
            this.btnLimparTudo.UseVisualStyleBackColor = false;
            this.btnLimparTudo.Click += new System.EventHandler(this.btnLimparTudo_Click);
            // 
            // objEscolheImg
            // 
            this.objEscolheImg.Filter = "Imagens|*.jpg;*.jpeg";
            // 
            // ConfigGerenciaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(646, 364);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimparTudo);
            this.Controls.Add(this.gbxDadosAcesso);
            this.Controls.Add(this.gbxDadosPessoais);
            this.Controls.Add(this.gbxListaUsuarios);
            this.MinimumSize = new System.Drawing.Size(533, 324);
            this.Name = "ConfigGerenciaUsuarios";
            this.Text = "Gerenciamento de Usuários";
            this.TipoDoDialogo = CemIdeiasPics.Utils.Modelos.TipoDialogo.Simples;
            this.Load += new System.EventHandler(this.ConfigGerenciaUsuarios_Load);
            this.Controls.SetChildIndex(this.gbxListaUsuarios, 0);
            this.Controls.SetChildIndex(this.gbxDadosPessoais, 0);
            this.Controls.SetChildIndex(this.gbxDadosAcesso, 0);
            this.Controls.SetChildIndex(this.btnLimparTudo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.gbxListaUsuarios.ResumeLayout(false);
            this.gbxDadosPessoais.ResumeLayout(false);
            this.gbxDadosPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotoPerfil)).EndInit();
            this.gbxDadosAcesso.ResumeLayout(false);
            this.gbxDadosAcesso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxUsuarios;
        private System.Windows.Forms.GroupBox gbxListaUsuarios;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.GroupBox gbxDadosPessoais;
        private System.Windows.Forms.PictureBox pbxFotoPerfil;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox txbEmail;
        private System.Windows.Forms.RadioButton rbnFeminino;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.RadioButton rbnMasculino;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox txbTelefone;
        private System.Windows.Forms.GroupBox gbxDadosAcesso;
        private System.Windows.Forms.Label lblTipoAcesso;
        private System.Windows.Forms.ComboBox cbxTipoAcesso;
        private System.Windows.Forms.TextBox txbConfSenha;
        private System.Windows.Forms.Label lblConfSenha;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimparTudo;
        private System.Windows.Forms.MaskedTextBox txbCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog objEscolheImg;
    }
}

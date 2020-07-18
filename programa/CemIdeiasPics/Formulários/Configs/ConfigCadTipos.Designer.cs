namespace CemIdeiasPics.Formulários.Configs
{
    partial class ConfigCadTipos
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
            this.gbxListaUsuarios = new System.Windows.Forms.GroupBox();
            this.cbxTipos = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimparTudo = new System.Windows.Forms.Button();
            this.txbNomeTipo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbValorTipo = new System.Windows.Forms.MaskedTextBox();
            this.gbxListaUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxListaUsuarios
            // 
            this.gbxListaUsuarios.Controls.Add(this.cbxTipos);
            this.gbxListaUsuarios.Location = new System.Drawing.Point(12, 37);
            this.gbxListaUsuarios.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.gbxListaUsuarios.Name = "gbxListaUsuarios";
            this.gbxListaUsuarios.Size = new System.Drawing.Size(509, 55);
            this.gbxListaUsuarios.TabIndex = 31;
            this.gbxListaUsuarios.TabStop = false;
            this.gbxListaUsuarios.Text = "Lista de Tipos";
            // 
            // cbxTipos
            // 
            this.cbxTipos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxTipos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxTipos.BackColor = System.Drawing.Color.Silver;
            this.cbxTipos.DisplayMember = "tipo";
            this.cbxTipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxTipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipos.FormattingEnabled = true;
            this.cbxTipos.Items.AddRange(new object[] {
            "Album Fisico"});
            this.cbxTipos.Location = new System.Drawing.Point(8, 23);
            this.cbxTipos.Margin = new System.Windows.Forms.Padding(5);
            this.cbxTipos.Name = "cbxTipos";
            this.cbxTipos.Size = new System.Drawing.Size(493, 24);
            this.cbxTipos.TabIndex = 29;
            this.cbxTipos.ValueMember = "id";
            this.cbxTipos.SelectedIndexChanged += new System.EventHandler(this.cbxTipos_SelectedIndexChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSalvar.BackColor = System.Drawing.Color.Black;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Yellow;
            this.btnSalvar.Location = new System.Drawing.Point(174, 281);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(348, 32);
            this.btnSalvar.TabIndex = 38;
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
            this.btnLimparTudo.Location = new System.Drawing.Point(11, 281);
            this.btnLimparTudo.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimparTudo.Name = "btnLimparTudo";
            this.btnLimparTudo.Size = new System.Drawing.Size(159, 32);
            this.btnLimparTudo.TabIndex = 37;
            this.btnLimparTudo.Text = "Limpar Tudo";
            this.btnLimparTudo.UseVisualStyleBackColor = false;
            this.btnLimparTudo.Click += new System.EventHandler(this.btnLimparTudo_Click);
            // 
            // txbNomeTipo
            // 
            this.txbNomeTipo.Location = new System.Drawing.Point(61, 152);
            this.txbNomeTipo.Name = "txbNomeTipo";
            this.txbNomeTipo.Size = new System.Drawing.Size(452, 20);
            this.txbNomeTipo.TabIndex = 39;
            this.txbNomeTipo.Enter += new System.EventHandler(this.VerificaMudanca);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Valor R$:";
            // 
            // txbValorTipo
            // 
            this.txbValorTipo.Location = new System.Drawing.Point(74, 178);
            this.txbValorTipo.Mask = "000,00";
            this.txbValorTipo.Name = "txbValorTipo";
            this.txbValorTipo.Size = new System.Drawing.Size(439, 20);
            this.txbValorTipo.TabIndex = 42;
            this.txbValorTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbValorTipo.Enter += new System.EventHandler(this.VerificaMudanca);
            // 
            // ConfigCadTipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(533, 324);
            this.Controls.Add(this.txbValorTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbNomeTipo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimparTudo);
            this.Controls.Add(this.gbxListaUsuarios);
            this.MinimumSize = new System.Drawing.Size(533, 324);
            this.Name = "ConfigCadTipos";
            this.Text = "Tipos";
            this.TipoDoDialogo = CemIdeiasPics.Utils.Modelos.TipoDialogo.Simples;
            this.Load += new System.EventHandler(this.ConfigCadTipos_Load);
            this.Controls.SetChildIndex(this.gbxListaUsuarios, 0);
            this.Controls.SetChildIndex(this.btnLimparTudo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txbNomeTipo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txbValorTipo, 0);
            this.gbxListaUsuarios.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxListaUsuarios;
        private System.Windows.Forms.ComboBox cbxTipos;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimparTudo;
        private System.Windows.Forms.TextBox txbNomeTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txbValorTipo;
    }
}

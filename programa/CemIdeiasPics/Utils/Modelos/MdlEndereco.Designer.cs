namespace CemIdeiasPics.Utils.Modelos
{
    partial class MdlEndereco
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
            this.txbCEP = new CemIdeiasPics.Utils.Controles.CIP_CaixaDeTexto();
            this.ciP_Label1 = new CemIdeiasPics.Utils.Controles.CIP_Label();
            this.btnBuscar = new CemIdeiasPics.Controles.CIP_Botao();
            this.txbUF = new CemIdeiasPics.Utils.Controles.CIP_CaixaDeTexto();
            this.ciP_Label2 = new CemIdeiasPics.Utils.Controles.CIP_Label();
            this.txbCidade = new CemIdeiasPics.Utils.Controles.CIP_CaixaDeTexto();
            this.ciP_Label3 = new CemIdeiasPics.Utils.Controles.CIP_Label();
            this.txbBairro = new CemIdeiasPics.Utils.Controles.CIP_CaixaDeTexto();
            this.ciP_Label4 = new CemIdeiasPics.Utils.Controles.CIP_Label();
            this.txbLogradouro = new CemIdeiasPics.Utils.Controles.CIP_CaixaDeTexto();
            this.ciP_Label5 = new CemIdeiasPics.Utils.Controles.CIP_Label();
            this.SuspendLayout();
            // 
            // txbCEP
            // 
            this.txbCEP.BackColor = System.Drawing.Color.LightYellow;
            this.txbCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbCEP.Location = new System.Drawing.Point(84, 12);
            this.txbCEP.Margin = new System.Windows.Forms.Padding(10);
            this.txbCEP.MaxLength = 8;
            this.txbCEP.Name = "txbCEP";
            this.txbCEP.ShortcutsEnabled = false;
            this.txbCEP.Size = new System.Drawing.Size(174, 30);
            this.txbCEP.TabIndex = 0;
            this.txbCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BloqueiaNumeros_Event);
            // 
            // ciP_Label1
            // 
            this.ciP_Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ciP_Label1.Location = new System.Drawing.Point(3, 11);
            this.ciP_Label1.Name = "ciP_Label1";
            this.ciP_Label1.Size = new System.Drawing.Size(68, 31);
            this.ciP_Label1.TabIndex = 1;
            this.ciP_Label1.Text = "CEP:";
            this.ciP_Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Yellow;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Fundo = System.Drawing.Color.Yellow;
            this.btnBuscar.Location = new System.Drawing.Point(271, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(158, 31);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txbUF
            // 
            this.txbUF.BackColor = System.Drawing.Color.LightYellow;
            this.txbUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbUF.Location = new System.Drawing.Point(380, 54);
            this.txbUF.Margin = new System.Windows.Forms.Padding(10);
            this.txbUF.Name = "txbUF";
            this.txbUF.ReadOnly = true;
            this.txbUF.Size = new System.Drawing.Size(42, 30);
            this.txbUF.TabIndex = 3;
            // 
            // ciP_Label2
            // 
            this.ciP_Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ciP_Label2.Location = new System.Drawing.Point(312, 54);
            this.ciP_Label2.Name = "ciP_Label2";
            this.ciP_Label2.Size = new System.Drawing.Size(55, 31);
            this.ciP_Label2.TabIndex = 4;
            this.ciP_Label2.Text = "UF:";
            this.ciP_Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbCidade
            // 
            this.txbCidade.BackColor = System.Drawing.Color.LightYellow;
            this.txbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbCidade.Location = new System.Drawing.Point(116, 55);
            this.txbCidade.Margin = new System.Windows.Forms.Padding(10);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.ReadOnly = true;
            this.txbCidade.Size = new System.Drawing.Size(183, 30);
            this.txbCidade.TabIndex = 5;
            // 
            // ciP_Label3
            // 
            this.ciP_Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ciP_Label3.Location = new System.Drawing.Point(3, 54);
            this.ciP_Label3.Name = "ciP_Label3";
            this.ciP_Label3.Size = new System.Drawing.Size(100, 31);
            this.ciP_Label3.TabIndex = 6;
            this.ciP_Label3.Text = "Cidade:";
            this.ciP_Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbBairro
            // 
            this.txbBairro.BackColor = System.Drawing.Color.LightYellow;
            this.txbBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbBairro.Location = new System.Drawing.Point(102, 95);
            this.txbBairro.Margin = new System.Windows.Forms.Padding(10);
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.ReadOnly = true;
            this.txbBairro.Size = new System.Drawing.Size(320, 30);
            this.txbBairro.TabIndex = 7;
            // 
            // ciP_Label4
            // 
            this.ciP_Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ciP_Label4.Location = new System.Drawing.Point(3, 94);
            this.ciP_Label4.Name = "ciP_Label4";
            this.ciP_Label4.Size = new System.Drawing.Size(86, 31);
            this.ciP_Label4.TabIndex = 8;
            this.ciP_Label4.Text = "Bairro:";
            this.ciP_Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbLogradouro
            // 
            this.txbLogradouro.BackColor = System.Drawing.Color.LightYellow;
            this.txbLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbLogradouro.Location = new System.Drawing.Point(160, 135);
            this.txbLogradouro.Margin = new System.Windows.Forms.Padding(10);
            this.txbLogradouro.Name = "txbLogradouro";
            this.txbLogradouro.ReadOnly = true;
            this.txbLogradouro.Size = new System.Drawing.Size(262, 30);
            this.txbLogradouro.TabIndex = 9;
            // 
            // ciP_Label5
            // 
            this.ciP_Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ciP_Label5.Location = new System.Drawing.Point(3, 135);
            this.ciP_Label5.Name = "ciP_Label5";
            this.ciP_Label5.Size = new System.Drawing.Size(144, 31);
            this.ciP_Label5.TabIndex = 10;
            this.ciP_Label5.Text = "Logradouro:";
            this.ciP_Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MdlEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.ciP_Label5);
            this.Controls.Add(this.txbLogradouro);
            this.Controls.Add(this.ciP_Label4);
            this.Controls.Add(this.txbBairro);
            this.Controls.Add(this.ciP_Label3);
            this.Controls.Add(this.txbCidade);
            this.Controls.Add(this.ciP_Label2);
            this.Controls.Add(this.txbUF);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.ciP_Label1);
            this.Controls.Add(this.txbCEP);
            this.Name = "MdlEndereco";
            this.Size = new System.Drawing.Size(432, 175);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.CIP_CaixaDeTexto txbCEP;
        private Controles.CIP_Label ciP_Label1;
        private CemIdeiasPics.Controles.CIP_Botao btnBuscar;
        private Controles.CIP_CaixaDeTexto txbUF;
        private Controles.CIP_Label ciP_Label2;
        private Controles.CIP_CaixaDeTexto txbCidade;
        private Controles.CIP_Label ciP_Label3;
        private Controles.CIP_CaixaDeTexto txbBairro;
        private Controles.CIP_Label ciP_Label4;
        private Controles.CIP_CaixaDeTexto txbLogradouro;
        private Controles.CIP_Label ciP_Label5;
    }
}

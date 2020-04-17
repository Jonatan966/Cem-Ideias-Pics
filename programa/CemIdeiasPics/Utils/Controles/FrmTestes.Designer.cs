namespace CemIdeiasPics.Utils.Controles
{
    partial class FrmTestes
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
            this.ciP_CaixaDeTexto1 = new CemIdeiasPics.Utils.Controles.CIP_CaixaDeTexto();
            this.ciP_Botao1 = new CemIdeiasPics.Controles.CIP_Botao();
            this.SuspendLayout();
            // 
            // ciP_CaixaDeTexto1
            // 
            this.ciP_CaixaDeTexto1.BackColor = System.Drawing.Color.LightYellow;
            this.ciP_CaixaDeTexto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ciP_CaixaDeTexto1.Location = new System.Drawing.Point(574, 296);
            this.ciP_CaixaDeTexto1.Name = "ciP_CaixaDeTexto1";
            this.ciP_CaixaDeTexto1.Size = new System.Drawing.Size(100, 35);
            this.ciP_CaixaDeTexto1.TabIndex = 1;
            // 
            // ciP_Botao1
            // 
            this.ciP_Botao1.BackColor = System.Drawing.Color.Yellow;
            this.ciP_Botao1.FlatAppearance.BorderSize = 2;
            this.ciP_Botao1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ciP_Botao1.Font = new System.Drawing.Font("Courier New", 10F);
            this.ciP_Botao1.ForeColor = System.Drawing.Color.Black;
            this.ciP_Botao1.Location = new System.Drawing.Point(233, 189);
            this.ciP_Botao1.Name = "ciP_Botao1";
            this.ciP_Botao1.Size = new System.Drawing.Size(175, 57);
            this.ciP_Botao1.TabIndex = 0;
            this.ciP_Botao1.Text = "ciP_Botao1";
            this.ciP_Botao1.UseVisualStyleBackColor = false;
            // 
            // FrmTestes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ciP_CaixaDeTexto1);
            this.Controls.Add(this.ciP_Botao1);
            this.Name = "FrmTestes";
            this.Text = "FrmTestes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CemIdeiasPics.Controles.CIP_Botao ciP_Botao1;
        private CIP_CaixaDeTexto ciP_CaixaDeTexto1;
    }
}
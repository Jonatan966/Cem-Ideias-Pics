﻿namespace CemIdeiasPics.Formulários
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSair = new System.Windows.Forms.Button();
            this.rbnClientes = new System.Windows.Forms.RadioButton();
            this.rbnEnsaios = new System.Windows.Forms.RadioButton();
            this.rbnPortifolio = new System.Windows.Forms.RadioButton();
            this.rbnConfig = new System.Windows.Forms.RadioButton();
            this.lblUsuario = new CemIdeiasPics.Utils.Controles.CIP_Label();
            this.pbxImgUsuario = new System.Windows.Forms.PictureBox();
            this.pnlMenus = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.pbxImgUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 468);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 150);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(145, 318);
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
            this.btnSair.Image = global::CemIdeiasPics.Properties.Resources.exit_icon2;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(0, 252);
            this.btnSair.Margin = new System.Windows.Forms.Padding(0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(145, 66);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
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
            this.rbnClientes.Location = new System.Drawing.Point(0, 63);
            this.rbnClientes.Margin = new System.Windows.Forms.Padding(0);
            this.rbnClientes.Name = "rbnClientes";
            this.rbnClientes.Size = new System.Drawing.Size(145, 63);
            this.rbnClientes.TabIndex = 8;
            this.rbnClientes.Tag = "1";
            this.rbnClientes.Text = "Clientes";
            this.rbnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbnClientes.UseVisualStyleBackColor = true;
            this.rbnClientes.Click += new System.EventHandler(this.RbnMenus_Click);
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
            this.rbnEnsaios.Location = new System.Drawing.Point(0, 126);
            this.rbnEnsaios.Margin = new System.Windows.Forms.Padding(0);
            this.rbnEnsaios.Name = "rbnEnsaios";
            this.rbnEnsaios.Size = new System.Drawing.Size(145, 63);
            this.rbnEnsaios.TabIndex = 9;
            this.rbnEnsaios.Tag = "2";
            this.rbnEnsaios.Text = "Ensaios";
            this.rbnEnsaios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbnEnsaios.UseVisualStyleBackColor = true;
            this.rbnEnsaios.Click += new System.EventHandler(this.RbnMenus_Click);
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
            this.rbnPortifolio.Size = new System.Drawing.Size(145, 63);
            this.rbnPortifolio.TabIndex = 10;
            this.rbnPortifolio.Tag = "0";
            this.rbnPortifolio.Text = "Portifólio";
            this.rbnPortifolio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbnPortifolio.UseVisualStyleBackColor = true;
            this.rbnPortifolio.Click += new System.EventHandler(this.RbnMenus_Click);
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
            this.rbnConfig.Location = new System.Drawing.Point(0, 189);
            this.rbnConfig.Margin = new System.Windows.Forms.Padding(0);
            this.rbnConfig.Name = "rbnConfig";
            this.rbnConfig.Size = new System.Drawing.Size(145, 63);
            this.rbnConfig.TabIndex = 11;
            this.rbnConfig.Tag = "3";
            this.rbnConfig.Text = "Opções";
            this.rbnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbnConfig.UseVisualStyleBackColor = false;
            this.rbnConfig.Click += new System.EventHandler(this.RbnMenus_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(0, 124);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(145, 26);
            this.lblUsuario.TabIndex = 13;
            this.lblUsuario.Text = "Nome de Usuário";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxImgUsuario
            // 
            this.pbxImgUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbxImgUsuario.Image = global::CemIdeiasPics.Properties.Resources._default;
            this.pbxImgUsuario.InitialImage = global::CemIdeiasPics.Properties.Resources._default;
            this.pbxImgUsuario.Location = new System.Drawing.Point(0, 0);
            this.pbxImgUsuario.Name = "pbxImgUsuario";
            this.pbxImgUsuario.Size = new System.Drawing.Size(145, 124);
            this.pbxImgUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImgUsuario.TabIndex = 0;
            this.pbxImgUsuario.TabStop = false;
            // 
            // pnlMenus
            // 
            this.pnlMenus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenus.Location = new System.Drawing.Point(145, 32);
            this.pnlMenus.Margin = new System.Windows.Forms.Padding(7, 6, 3, 6);
            this.pnlMenus.Name = "pnlMenus";
            this.pnlMenus.Padding = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.pnlMenus.Size = new System.Drawing.Size(729, 468);
            this.pnlMenus.TabIndex = 7;
            // 
            // FrmPainel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(874, 500);
            this.Controls.Add(this.pnlMenus);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1218, 702);
            this.MinimumSize = new System.Drawing.Size(533, 324);
            this.Name = "FrmPainel";
            this.Text = "Painel Principal";
            this.Load += new System.EventHandler(this.FrmPainel_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.pnlMenus, 0);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbnConfig;
        private System.Windows.Forms.RadioButton rbnClientes;
        private System.Windows.Forms.RadioButton rbnPortifolio;
        private System.Windows.Forms.RadioButton rbnEnsaios;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSair;
        private Utils.Controles.CIP_Label lblUsuario;
        private System.Windows.Forms.Panel pnlMenus;
        private System.Windows.Forms.PictureBox pbxImgUsuario;
    }
}

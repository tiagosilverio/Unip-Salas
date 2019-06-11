namespace pim2019_desk.Apresentacao
{
    partial class frmEditarSigla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarSigla));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcluirSigla = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditarSigla = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txbNomeSigla = new System.Windows.Forms.TextBox();
            this.lblNomeSigla = new System.Windows.Forms.Label();
            this.txbIdSigla = new System.Windows.Forms.TextBox();
            this.lblIdSigla = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnExcluirSigla);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnEditarSigla);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.txbNomeSigla);
            this.panel1.Controls.Add(this.lblNomeSigla);
            this.panel1.Controls.Add(this.txbIdSigla);
            this.panel1.Controls.Add(this.lblIdSigla);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 242);
            this.panel1.TabIndex = 0;
            // 
            // btnExcluirSigla
            // 
            this.btnExcluirSigla.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirSigla.Image")));
            this.btnExcluirSigla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirSigla.Location = new System.Drawing.Point(8, 202);
            this.btnExcluirSigla.Name = "btnExcluirSigla";
            this.btnExcluirSigla.Size = new System.Drawing.Size(87, 37);
            this.btnExcluirSigla.TabIndex = 8;
            this.btnExcluirSigla.Text = "Excluir";
            this.btnExcluirSigla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirSigla.UseVisualStyleBackColor = true;
            this.btnExcluirSigla.Click += new System.EventHandler(this.btnExcluirSigla_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(143, 202);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 37);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditarSigla
            // 
            this.btnEditarSigla.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarSigla.Image")));
            this.btnEditarSigla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarSigla.Location = new System.Drawing.Point(247, 202);
            this.btnEditarSigla.Name = "btnEditarSigla";
            this.btnEditarSigla.Size = new System.Drawing.Size(87, 37);
            this.btnEditarSigla.TabIndex = 6;
            this.btnEditarSigla.Text = "Salvar";
            this.btnEditarSigla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarSigla.UseVisualStyleBackColor = true;
            this.btnEditarSigla.Click += new System.EventHandler(this.btnEditarSigla_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Location = new System.Drawing.Point(309, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 25);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txbNomeSigla
            // 
            this.txbNomeSigla.Location = new System.Drawing.Point(38, 125);
            this.txbNomeSigla.Name = "txbNomeSigla";
            this.txbNomeSigla.Size = new System.Drawing.Size(260, 20);
            this.txbNomeSigla.TabIndex = 4;
            // 
            // lblNomeSigla
            // 
            this.lblNomeSigla.AutoSize = true;
            this.lblNomeSigla.Location = new System.Drawing.Point(35, 109);
            this.lblNomeSigla.Name = "lblNomeSigla";
            this.lblNomeSigla.Size = new System.Drawing.Size(30, 13);
            this.lblNomeSigla.TabIndex = 3;
            this.lblNomeSigla.Text = "Sigla";
            // 
            // txbIdSigla
            // 
            this.txbIdSigla.Enabled = false;
            this.txbIdSigla.Location = new System.Drawing.Point(38, 73);
            this.txbIdSigla.Name = "txbIdSigla";
            this.txbIdSigla.ReadOnly = true;
            this.txbIdSigla.Size = new System.Drawing.Size(67, 20);
            this.txbIdSigla.TabIndex = 2;
            // 
            // lblIdSigla
            // 
            this.lblIdSigla.AutoSize = true;
            this.lblIdSigla.Location = new System.Drawing.Point(35, 57);
            this.lblIdSigla.Name = "lblIdSigla";
            this.lblIdSigla.Size = new System.Drawing.Size(18, 13);
            this.lblIdSigla.TabIndex = 1;
            this.lblIdSigla.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editar Sigla";
            // 
            // frmEditarSigla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(362, 267);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditarSigla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditarSigla";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExcluirSigla;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditarSigla;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblNomeSigla;
        private System.Windows.Forms.Label lblIdSigla;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txbNomeSigla;
        public System.Windows.Forms.TextBox txbIdSigla;
    }
}
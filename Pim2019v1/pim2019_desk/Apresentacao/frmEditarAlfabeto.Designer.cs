namespace pim2019_desk.Apresentacao
{
    partial class frmEditarAlfabeto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarAlfabeto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcluirAlfabeto = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditarAlfabeto = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txbNomeAlfabeto = new System.Windows.Forms.TextBox();
            this.lblNomeAlfabeto = new System.Windows.Forms.Label();
            this.txbIdAlfabeto = new System.Windows.Forms.TextBox();
            this.IdAlfabeto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnExcluirAlfabeto);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnEditarAlfabeto);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.txbNomeAlfabeto);
            this.panel1.Controls.Add(this.lblNomeAlfabeto);
            this.panel1.Controls.Add(this.txbIdAlfabeto);
            this.panel1.Controls.Add(this.IdAlfabeto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 242);
            this.panel1.TabIndex = 0;
            // 
            // btnExcluirAlfabeto
            // 
            this.btnExcluirAlfabeto.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirAlfabeto.Image")));
            this.btnExcluirAlfabeto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirAlfabeto.Location = new System.Drawing.Point(8, 202);
            this.btnExcluirAlfabeto.Name = "btnExcluirAlfabeto";
            this.btnExcluirAlfabeto.Size = new System.Drawing.Size(87, 37);
            this.btnExcluirAlfabeto.TabIndex = 8;
            this.btnExcluirAlfabeto.Text = "Excluir";
            this.btnExcluirAlfabeto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirAlfabeto.UseVisualStyleBackColor = true;
            this.btnExcluirAlfabeto.Click += new System.EventHandler(this.btnExcluirAlfabeto_Click);
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
            // btnEditarAlfabeto
            // 
            this.btnEditarAlfabeto.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarAlfabeto.Image")));
            this.btnEditarAlfabeto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarAlfabeto.Location = new System.Drawing.Point(247, 202);
            this.btnEditarAlfabeto.Name = "btnEditarAlfabeto";
            this.btnEditarAlfabeto.Size = new System.Drawing.Size(87, 37);
            this.btnEditarAlfabeto.TabIndex = 6;
            this.btnEditarAlfabeto.Text = "Salvar";
            this.btnEditarAlfabeto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarAlfabeto.UseVisualStyleBackColor = true;
            this.btnEditarAlfabeto.Click += new System.EventHandler(this.btnEditarAlfabeto_Click);
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
            // txbNomeAlfabeto
            // 
            this.txbNomeAlfabeto.Location = new System.Drawing.Point(38, 125);
            this.txbNomeAlfabeto.Name = "txbNomeAlfabeto";
            this.txbNomeAlfabeto.Size = new System.Drawing.Size(260, 20);
            this.txbNomeAlfabeto.TabIndex = 4;
            // 
            // lblNomeAlfabeto
            // 
            this.lblNomeAlfabeto.AutoSize = true;
            this.lblNomeAlfabeto.Location = new System.Drawing.Point(35, 109);
            this.lblNomeAlfabeto.Name = "lblNomeAlfabeto";
            this.lblNomeAlfabeto.Size = new System.Drawing.Size(53, 13);
            this.lblNomeAlfabeto.TabIndex = 3;
            this.lblNomeAlfabeto.Text = "Caractere";
            // 
            // txbIdAlfabeto
            // 
            this.txbIdAlfabeto.Enabled = false;
            this.txbIdAlfabeto.Location = new System.Drawing.Point(38, 73);
            this.txbIdAlfabeto.Name = "txbIdAlfabeto";
            this.txbIdAlfabeto.ReadOnly = true;
            this.txbIdAlfabeto.Size = new System.Drawing.Size(67, 20);
            this.txbIdAlfabeto.TabIndex = 2;
            // 
            // IdAlfabeto
            // 
            this.IdAlfabeto.AutoSize = true;
            this.IdAlfabeto.Location = new System.Drawing.Point(35, 57);
            this.IdAlfabeto.Name = "IdAlfabeto";
            this.IdAlfabeto.Size = new System.Drawing.Size(18, 13);
            this.IdAlfabeto.TabIndex = 1;
            this.IdAlfabeto.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editar Caractere";
            // 
            // frmEditarAlfabeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(362, 267);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditarAlfabeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditarAlfabeto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExcluirAlfabeto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditarAlfabeto;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblNomeAlfabeto;
        private System.Windows.Forms.Label IdAlfabeto;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txbNomeAlfabeto;
        public System.Windows.Forms.TextBox txbIdAlfabeto;
    }
}
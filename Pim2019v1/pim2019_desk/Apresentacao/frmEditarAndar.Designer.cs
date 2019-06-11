namespace pim2019_desk.Apresentacao
{
    partial class frmEditarAndar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarAndar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditarAndar = new System.Windows.Forms.Button();
            this.btnExluirAndar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txbAndar = new System.Windows.Forms.TextBox();
            this.lblAndar = new System.Windows.Forms.Label();
            this.txbIdAndar = new System.Windows.Forms.TextBox();
            this.lblIdAndar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnEditarAndar);
            this.panel1.Controls.Add(this.btnExluirAndar);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.txbAndar);
            this.panel1.Controls.Add(this.lblAndar);
            this.panel1.Controls.Add(this.txbIdAndar);
            this.panel1.Controls.Add(this.lblIdAndar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 242);
            this.panel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(143, 202);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 37);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditarAndar
            // 
            this.btnEditarAndar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarAndar.Image")));
            this.btnEditarAndar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarAndar.Location = new System.Drawing.Point(247, 202);
            this.btnEditarAndar.Name = "btnEditarAndar";
            this.btnEditarAndar.Size = new System.Drawing.Size(87, 37);
            this.btnEditarAndar.TabIndex = 7;
            this.btnEditarAndar.Text = "Salvar";
            this.btnEditarAndar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarAndar.UseVisualStyleBackColor = true;
            this.btnEditarAndar.Click += new System.EventHandler(this.btnEditarAndar_Click);
            // 
            // btnExluirAndar
            // 
            this.btnExluirAndar.Image = ((System.Drawing.Image)(resources.GetObject("btnExluirAndar.Image")));
            this.btnExluirAndar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExluirAndar.Location = new System.Drawing.Point(8, 202);
            this.btnExluirAndar.Name = "btnExluirAndar";
            this.btnExluirAndar.Size = new System.Drawing.Size(87, 37);
            this.btnExluirAndar.TabIndex = 6;
            this.btnExluirAndar.Text = "Excluir";
            this.btnExluirAndar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExluirAndar.UseVisualStyleBackColor = true;
            this.btnExluirAndar.Click += new System.EventHandler(this.btnExluirAndar_Click);
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
            // txbAndar
            // 
            this.txbAndar.Location = new System.Drawing.Point(38, 125);
            this.txbAndar.Name = "txbAndar";
            this.txbAndar.Size = new System.Drawing.Size(260, 20);
            this.txbAndar.TabIndex = 4;
            // 
            // lblAndar
            // 
            this.lblAndar.AutoSize = true;
            this.lblAndar.Location = new System.Drawing.Point(35, 109);
            this.lblAndar.Name = "lblAndar";
            this.lblAndar.Size = new System.Drawing.Size(35, 13);
            this.lblAndar.TabIndex = 3;
            this.lblAndar.Text = "Andar";
            // 
            // txbIdAndar
            // 
            this.txbIdAndar.Enabled = false;
            this.txbIdAndar.Location = new System.Drawing.Point(38, 73);
            this.txbIdAndar.Name = "txbIdAndar";
            this.txbIdAndar.ReadOnly = true;
            this.txbIdAndar.Size = new System.Drawing.Size(67, 20);
            this.txbIdAndar.TabIndex = 2;
            // 
            // lblIdAndar
            // 
            this.lblIdAndar.AutoSize = true;
            this.lblIdAndar.Location = new System.Drawing.Point(35, 57);
            this.lblIdAndar.Name = "lblIdAndar";
            this.lblIdAndar.Size = new System.Drawing.Size(18, 13);
            this.lblIdAndar.TabIndex = 1;
            this.lblIdAndar.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editar Andar";
            // 
            // frmEditarAndar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(362, 267);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditarAndar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditarAndar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditarAndar;
        private System.Windows.Forms.Button btnExluirAndar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblAndar;
        private System.Windows.Forms.Label lblIdAndar;
        public System.Windows.Forms.TextBox txbAndar;
        public System.Windows.Forms.TextBox txbIdAndar;
    }
}
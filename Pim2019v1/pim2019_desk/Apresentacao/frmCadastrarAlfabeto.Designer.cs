namespace pim2019_desk.Apresentacao
{
    partial class frmCadastrarAlfabeto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarAlfabeto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadastrarAlfabeto = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txbAlfabeto = new System.Windows.Forms.TextBox();
            this.lblCaractere = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnCadastrarAlfabeto);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.txbAlfabeto);
            this.panel1.Controls.Add(this.lblCaractere);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 242);
            this.panel1.TabIndex = 0;
            // 
            // btnCadastrarAlfabeto
            // 
            this.btnCadastrarAlfabeto.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarAlfabeto.Image")));
            this.btnCadastrarAlfabeto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarAlfabeto.Location = new System.Drawing.Point(247, 202);
            this.btnCadastrarAlfabeto.Name = "btnCadastrarAlfabeto";
            this.btnCadastrarAlfabeto.Size = new System.Drawing.Size(87, 37);
            this.btnCadastrarAlfabeto.TabIndex = 5;
            this.btnCadastrarAlfabeto.Text = "Salvar";
            this.btnCadastrarAlfabeto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrarAlfabeto.UseVisualStyleBackColor = true;
            this.btnCadastrarAlfabeto.Click += new System.EventHandler(this.btnCadastrarAlfabeto_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(143, 202);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 37);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Location = new System.Drawing.Point(309, 4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 25);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txbAlfabeto
            // 
            this.txbAlfabeto.Location = new System.Drawing.Point(36, 109);
            this.txbAlfabeto.Name = "txbAlfabeto";
            this.txbAlfabeto.Size = new System.Drawing.Size(260, 20);
            this.txbAlfabeto.TabIndex = 2;
            // 
            // lblCaractere
            // 
            this.lblCaractere.AutoSize = true;
            this.lblCaractere.Location = new System.Drawing.Point(33, 93);
            this.lblCaractere.Name = "lblCaractere";
            this.lblCaractere.Size = new System.Drawing.Size(53, 13);
            this.lblCaractere.TabIndex = 1;
            this.lblCaractere.Text = "Caractere";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novo Caractere";
            // 
            // frmCadastrarAlfabeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(362, 267);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastrarAlfabeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastrarAlfabeto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCadastrarAlfabeto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txbAlfabeto;
        private System.Windows.Forms.Label lblCaractere;
        private System.Windows.Forms.Label label1;
    }
}
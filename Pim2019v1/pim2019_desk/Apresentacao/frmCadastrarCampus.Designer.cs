namespace pim2019_desk.Apresentacao
{
    partial class frmCadastrarCampus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarCampus));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumeroCampus = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNomeCampus = new System.Windows.Forms.Label();
            this.txbNomeCampus = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbNumeroCampus = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblNumeroCampus);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.lblNomeCampus);
            this.panel1.Controls.Add(this.txbNomeCampus);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.txbNumeroCampus);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 226);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Novo Campus";
            // 
            // lblNumeroCampus
            // 
            this.lblNumeroCampus.AutoSize = true;
            this.lblNumeroCampus.Location = new System.Drawing.Point(11, 47);
            this.lblNumeroCampus.Name = "lblNumeroCampus";
            this.lblNumeroCampus.Size = new System.Drawing.Size(44, 13);
            this.lblNumeroCampus.TabIndex = 0;
            this.lblNumeroCampus.Text = "Número";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(177, 186);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 37);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNomeCampus
            // 
            this.lblNomeCampus.AutoSize = true;
            this.lblNomeCampus.Location = new System.Drawing.Point(11, 98);
            this.lblNomeCampus.Name = "lblNomeCampus";
            this.lblNomeCampus.Size = new System.Drawing.Size(91, 13);
            this.lblNomeCampus.TabIndex = 2;
            this.lblNomeCampus.Text = "Nome do Campus";
            // 
            // txbNomeCampus
            // 
            this.txbNomeCampus.Location = new System.Drawing.Point(14, 114);
            this.txbNomeCampus.Name = "txbNomeCampus";
            this.txbNomeCampus.Size = new System.Drawing.Size(340, 20);
            this.txbNomeCampus.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(280, 186);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(87, 37);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Salvar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbNumeroCampus
            // 
            this.txbNumeroCampus.Location = new System.Drawing.Point(14, 63);
            this.txbNumeroCampus.Name = "txbNumeroCampus";
            this.txbNumeroCampus.Size = new System.Drawing.Size(79, 20);
            this.txbNumeroCampus.TabIndex = 1;
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Location = new System.Drawing.Point(342, 4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 25);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmCadastrarCampus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(394, 250);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastrarCampus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Campus";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNumeroCampus;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNomeCampus;
        private System.Windows.Forms.TextBox txbNomeCampus;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txbNumeroCampus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFechar;
    }
}
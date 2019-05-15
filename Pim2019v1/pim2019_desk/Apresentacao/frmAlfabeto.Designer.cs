namespace pim2019_desk.Apresentacao
{
    partial class frmAlfabeto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlfabeto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbAlfabetoResultado = new System.Windows.Forms.GroupBox();
            this.dgvAlfabeto = new System.Windows.Forms.DataGridView();
            this.lblIdAlfabeto = new System.Windows.Forms.Label();
            this.lblNomeAlfabeto = new System.Windows.Forms.Label();
            this.lblIdAlfabetoResultado = new System.Windows.Forms.Label();
            this.lblNomeAlfabetoResultado = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnNovoAlfabeto = new System.Windows.Forms.Button();
            this.btnEditarAlfabeto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gpbAlfabetoResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlfabeto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnEditarAlfabeto);
            this.panel1.Controls.Add(this.btnNovoAlfabeto);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.dgvAlfabeto);
            this.panel1.Controls.Add(this.gpbAlfabetoResultado);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 297);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caracteres";
            // 
            // gpbAlfabetoResultado
            // 
            this.gpbAlfabetoResultado.Controls.Add(this.lblNomeAlfabetoResultado);
            this.gpbAlfabetoResultado.Controls.Add(this.lblIdAlfabetoResultado);
            this.gpbAlfabetoResultado.Controls.Add(this.lblNomeAlfabeto);
            this.gpbAlfabetoResultado.Controls.Add(this.lblIdAlfabeto);
            this.gpbAlfabetoResultado.Location = new System.Drawing.Point(65, 145);
            this.gpbAlfabetoResultado.Name = "gpbAlfabetoResultado";
            this.gpbAlfabetoResultado.Size = new System.Drawing.Size(259, 99);
            this.gpbAlfabetoResultado.TabIndex = 1;
            this.gpbAlfabetoResultado.TabStop = false;
            // 
            // dgvAlfabeto
            // 
            this.dgvAlfabeto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlfabeto.Location = new System.Drawing.Point(3, 48);
            this.dgvAlfabeto.Name = "dgvAlfabeto";
            this.dgvAlfabeto.Size = new System.Drawing.Size(378, 91);
            this.dgvAlfabeto.TabIndex = 2;
            // 
            // lblIdAlfabeto
            // 
            this.lblIdAlfabeto.AutoSize = true;
            this.lblIdAlfabeto.Location = new System.Drawing.Point(61, 33);
            this.lblIdAlfabeto.Name = "lblIdAlfabeto";
            this.lblIdAlfabeto.Size = new System.Drawing.Size(21, 13);
            this.lblIdAlfabeto.TabIndex = 0;
            this.lblIdAlfabeto.Text = "ID:";
            // 
            // lblNomeAlfabeto
            // 
            this.lblNomeAlfabeto.AutoSize = true;
            this.lblNomeAlfabeto.Location = new System.Drawing.Point(26, 61);
            this.lblNomeAlfabeto.Name = "lblNomeAlfabeto";
            this.lblNomeAlfabeto.Size = new System.Drawing.Size(56, 13);
            this.lblNomeAlfabeto.TabIndex = 1;
            this.lblNomeAlfabeto.Text = "Caractere:";
            // 
            // lblIdAlfabetoResultado
            // 
            this.lblIdAlfabetoResultado.AutoSize = true;
            this.lblIdAlfabetoResultado.Location = new System.Drawing.Point(88, 33);
            this.lblIdAlfabetoResultado.Name = "lblIdAlfabetoResultado";
            this.lblIdAlfabetoResultado.Size = new System.Drawing.Size(10, 13);
            this.lblIdAlfabetoResultado.TabIndex = 2;
            this.lblIdAlfabetoResultado.Text = "-";
            // 
            // lblNomeAlfabetoResultado
            // 
            this.lblNomeAlfabetoResultado.AutoSize = true;
            this.lblNomeAlfabetoResultado.Location = new System.Drawing.Point(88, 61);
            this.lblNomeAlfabetoResultado.Name = "lblNomeAlfabetoResultado";
            this.lblNomeAlfabetoResultado.Size = new System.Drawing.Size(10, 13);
            this.lblNomeAlfabetoResultado.TabIndex = 3;
            this.lblNomeAlfabetoResultado.Text = "-";
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Location = new System.Drawing.Point(356, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 25);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnNovoAlfabeto
            // 
            this.btnNovoAlfabeto.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoAlfabeto.Image")));
            this.btnNovoAlfabeto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoAlfabeto.Location = new System.Drawing.Point(3, 257);
            this.btnNovoAlfabeto.Name = "btnNovoAlfabeto";
            this.btnNovoAlfabeto.Size = new System.Drawing.Size(119, 37);
            this.btnNovoAlfabeto.TabIndex = 4;
            this.btnNovoAlfabeto.Text = "Novo Caractere";
            this.btnNovoAlfabeto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoAlfabeto.UseVisualStyleBackColor = true;
            this.btnNovoAlfabeto.Click += new System.EventHandler(this.btnNovoAlfabeto_Click);
            // 
            // btnEditarAlfabeto
            // 
            this.btnEditarAlfabeto.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarAlfabeto.Image")));
            this.btnEditarAlfabeto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarAlfabeto.Location = new System.Drawing.Point(262, 257);
            this.btnEditarAlfabeto.Name = "btnEditarAlfabeto";
            this.btnEditarAlfabeto.Size = new System.Drawing.Size(119, 37);
            this.btnEditarAlfabeto.TabIndex = 5;
            this.btnEditarAlfabeto.Text = "Editar Caractere";
            this.btnEditarAlfabeto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarAlfabeto.UseVisualStyleBackColor = true;
            this.btnEditarAlfabeto.Click += new System.EventHandler(this.btnEditarAlfabeto_Click);
            // 
            // frmAlfabeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(408, 321);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlfabeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlfabeto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpbAlfabetoResultado.ResumeLayout(false);
            this.gpbAlfabetoResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlfabeto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAlfabeto;
        private System.Windows.Forms.GroupBox gpbAlfabetoResultado;
        private System.Windows.Forms.Button btnEditarAlfabeto;
        private System.Windows.Forms.Button btnNovoAlfabeto;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblNomeAlfabetoResultado;
        private System.Windows.Forms.Label lblIdAlfabetoResultado;
        private System.Windows.Forms.Label lblNomeAlfabeto;
        private System.Windows.Forms.Label lblIdAlfabeto;
    }
}
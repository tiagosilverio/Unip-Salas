namespace pim2019_desk.Apresentacao
{
    partial class frmSigla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSigla));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.dgvSigla = new System.Windows.Forms.DataGridView();
            this.btnNovaSigla = new System.Windows.Forms.Button();
            this.btnEditarSigla = new System.Windows.Forms.Button();
            this.gpbSigla = new System.Windows.Forms.GroupBox();
            this.lblIdSigla = new System.Windows.Forms.Label();
            this.lblIdSiglaResultado = new System.Windows.Forms.Label();
            this.lblNomeSigla = new System.Windows.Forms.Label();
            this.lblNomeSiglaResultado = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSigla)).BeginInit();
            this.gpbSigla.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.gpbSigla);
            this.panel1.Controls.Add(this.btnEditarSigla);
            this.panel1.Controls.Add(this.btnNovaSigla);
            this.panel1.Controls.Add(this.dgvSigla);
            this.panel1.Controls.Add(this.btnFechar);
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
            this.label1.Size = new System.Drawing.Size(57, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sigla";
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Location = new System.Drawing.Point(356, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 25);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // dgvSigla
            // 
            this.dgvSigla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSigla.Location = new System.Drawing.Point(3, 48);
            this.dgvSigla.Name = "dgvSigla";
            this.dgvSigla.Size = new System.Drawing.Size(378, 91);
            this.dgvSigla.TabIndex = 2;
            // 
            // btnNovaSigla
            // 
            this.btnNovaSigla.Image = ((System.Drawing.Image)(resources.GetObject("btnNovaSigla.Image")));
            this.btnNovaSigla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovaSigla.Location = new System.Drawing.Point(3, 257);
            this.btnNovaSigla.Name = "btnNovaSigla";
            this.btnNovaSigla.Size = new System.Drawing.Size(99, 37);
            this.btnNovaSigla.TabIndex = 3;
            this.btnNovaSigla.Text = "Nova Sigla";
            this.btnNovaSigla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovaSigla.UseVisualStyleBackColor = true;
            this.btnNovaSigla.Click += new System.EventHandler(this.btnNovaSigla_Click);
            // 
            // btnEditarSigla
            // 
            this.btnEditarSigla.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarSigla.Image")));
            this.btnEditarSigla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarSigla.Location = new System.Drawing.Point(282, 257);
            this.btnEditarSigla.Name = "btnEditarSigla";
            this.btnEditarSigla.Size = new System.Drawing.Size(99, 37);
            this.btnEditarSigla.TabIndex = 4;
            this.btnEditarSigla.Text = "EditarSigla";
            this.btnEditarSigla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarSigla.UseVisualStyleBackColor = true;
            this.btnEditarSigla.Click += new System.EventHandler(this.btnEditarSigla_Click);
            // 
            // gpbSigla
            // 
            this.gpbSigla.Controls.Add(this.lblNomeSiglaResultado);
            this.gpbSigla.Controls.Add(this.lblNomeSigla);
            this.gpbSigla.Controls.Add(this.lblIdSiglaResultado);
            this.gpbSigla.Controls.Add(this.lblIdSigla);
            this.gpbSigla.Location = new System.Drawing.Point(65, 145);
            this.gpbSigla.Name = "gpbSigla";
            this.gpbSigla.Size = new System.Drawing.Size(259, 99);
            this.gpbSigla.TabIndex = 5;
            this.gpbSigla.TabStop = false;
            // 
            // lblIdSigla
            // 
            this.lblIdSigla.AutoSize = true;
            this.lblIdSigla.Location = new System.Drawing.Point(61, 33);
            this.lblIdSigla.Name = "lblIdSigla";
            this.lblIdSigla.Size = new System.Drawing.Size(21, 13);
            this.lblIdSigla.TabIndex = 0;
            this.lblIdSigla.Text = "ID:";
            // 
            // lblIdSiglaResultado
            // 
            this.lblIdSiglaResultado.AutoSize = true;
            this.lblIdSiglaResultado.Location = new System.Drawing.Point(88, 33);
            this.lblIdSiglaResultado.Name = "lblIdSiglaResultado";
            this.lblIdSiglaResultado.Size = new System.Drawing.Size(10, 13);
            this.lblIdSiglaResultado.TabIndex = 1;
            this.lblIdSiglaResultado.Text = "-";
            // 
            // lblNomeSigla
            // 
            this.lblNomeSigla.AutoSize = true;
            this.lblNomeSigla.Location = new System.Drawing.Point(49, 60);
            this.lblNomeSigla.Name = "lblNomeSigla";
            this.lblNomeSigla.Size = new System.Drawing.Size(33, 13);
            this.lblNomeSigla.TabIndex = 2;
            this.lblNomeSigla.Text = "Sigla:";
            // 
            // lblNomeSiglaResultado
            // 
            this.lblNomeSiglaResultado.AutoSize = true;
            this.lblNomeSiglaResultado.Location = new System.Drawing.Point(88, 60);
            this.lblNomeSiglaResultado.Name = "lblNomeSiglaResultado";
            this.lblNomeSiglaResultado.Size = new System.Drawing.Size(10, 13);
            this.lblNomeSiglaResultado.TabIndex = 3;
            this.lblNomeSiglaResultado.Text = "-";
            // 
            // frmSigla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(408, 321);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSigla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSigla";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSigla)).EndInit();
            this.gpbSigla.ResumeLayout(false);
            this.gpbSigla.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSigla;
        private System.Windows.Forms.GroupBox gpbSigla;
        private System.Windows.Forms.Label lblNomeSiglaResultado;
        private System.Windows.Forms.Label lblNomeSigla;
        private System.Windows.Forms.Label lblIdSiglaResultado;
        private System.Windows.Forms.Label lblIdSigla;
        private System.Windows.Forms.Button btnEditarSigla;
        private System.Windows.Forms.Button btnNovaSigla;
    }
}
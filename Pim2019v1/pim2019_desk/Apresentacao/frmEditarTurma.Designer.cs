namespace pim2019_desk.Apresentacao
{
    partial class frmEditarTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarTurma));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnEditarTurma = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExluirTurma = new System.Windows.Forms.Button();
            this.lblIdTurma = new System.Windows.Forms.Label();
            this.txbIdTurma = new System.Windows.Forms.TextBox();
            this.txbNumeroTurma = new System.Windows.Forms.TextBox();
            this.lblNumeroTurma = new System.Windows.Forms.Label();
            this.txbAnoInicio = new System.Windows.Forms.TextBox();
            this.lblAnoInicioTurma = new System.Windows.Forms.Label();
            this.lblSemestreInicio = new System.Windows.Forms.Label();
            this.lblSigla = new System.Windows.Forms.Label();
            this.cmbSigla = new System.Windows.Forms.ComboBox();
            this.cmbAlfabeto = new System.Windows.Forms.ComboBox();
            this.lblAlfabeto = new System.Windows.Forms.Label();
            this.cmbCampus = new System.Windows.Forms.ComboBox();
            this.lblCampus = new System.Windows.Forms.Label();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.cmbSemestreInicio = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cmbSemestreInicio);
            this.panel1.Controls.Add(this.cmbCurso);
            this.panel1.Controls.Add(this.lblCurso);
            this.panel1.Controls.Add(this.cmbCampus);
            this.panel1.Controls.Add(this.lblCampus);
            this.panel1.Controls.Add(this.cmbAlfabeto);
            this.panel1.Controls.Add(this.lblAlfabeto);
            this.panel1.Controls.Add(this.cmbSigla);
            this.panel1.Controls.Add(this.lblSigla);
            this.panel1.Controls.Add(this.lblSemestreInicio);
            this.panel1.Controls.Add(this.txbAnoInicio);
            this.panel1.Controls.Add(this.lblAnoInicioTurma);
            this.panel1.Controls.Add(this.txbNumeroTurma);
            this.panel1.Controls.Add(this.lblNumeroTurma);
            this.panel1.Controls.Add(this.txbIdTurma);
            this.panel1.Controls.Add(this.lblIdTurma);
            this.panel1.Controls.Add(this.btnExluirTurma);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnEditarTurma);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 304);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editar Turma";
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Location = new System.Drawing.Point(411, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 25);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnEditarTurma
            // 
            this.btnEditarTurma.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarTurma.Image")));
            this.btnEditarTurma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarTurma.Location = new System.Drawing.Point(349, 264);
            this.btnEditarTurma.Name = "btnEditarTurma";
            this.btnEditarTurma.Size = new System.Drawing.Size(87, 37);
            this.btnEditarTurma.TabIndex = 2;
            this.btnEditarTurma.Text = "Salvar";
            this.btnEditarTurma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarTurma.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(239, 264);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 37);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExluirTurma
            // 
            this.btnExluirTurma.Image = ((System.Drawing.Image)(resources.GetObject("btnExluirTurma.Image")));
            this.btnExluirTurma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExluirTurma.Location = new System.Drawing.Point(3, 264);
            this.btnExluirTurma.Name = "btnExluirTurma";
            this.btnExluirTurma.Size = new System.Drawing.Size(87, 37);
            this.btnExluirTurma.TabIndex = 4;
            this.btnExluirTurma.Text = "Excluir";
            this.btnExluirTurma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExluirTurma.UseVisualStyleBackColor = true;
            // 
            // lblIdTurma
            // 
            this.lblIdTurma.AutoSize = true;
            this.lblIdTurma.Location = new System.Drawing.Point(54, 51);
            this.lblIdTurma.Name = "lblIdTurma";
            this.lblIdTurma.Size = new System.Drawing.Size(18, 13);
            this.lblIdTurma.TabIndex = 5;
            this.lblIdTurma.Text = "ID";
            // 
            // txbIdTurma
            // 
            this.txbIdTurma.Enabled = false;
            this.txbIdTurma.Location = new System.Drawing.Point(57, 67);
            this.txbIdTurma.Name = "txbIdTurma";
            this.txbIdTurma.ReadOnly = true;
            this.txbIdTurma.Size = new System.Drawing.Size(57, 20);
            this.txbIdTurma.TabIndex = 6;
            // 
            // txbNumeroTurma
            // 
            this.txbNumeroTurma.Location = new System.Drawing.Point(57, 208);
            this.txbNumeroTurma.Name = "txbNumeroTurma";
            this.txbNumeroTurma.Size = new System.Drawing.Size(93, 20);
            this.txbNumeroTurma.TabIndex = 8;
            // 
            // lblNumeroTurma
            // 
            this.lblNumeroTurma.AutoSize = true;
            this.lblNumeroTurma.Location = new System.Drawing.Point(54, 191);
            this.lblNumeroTurma.Name = "lblNumeroTurma";
            this.lblNumeroTurma.Size = new System.Drawing.Size(100, 13);
            this.lblNumeroTurma.TabIndex = 7;
            this.lblNumeroTurma.Text = "Número do Campus";
            // 
            // txbAnoInicio
            // 
            this.txbAnoInicio.Location = new System.Drawing.Point(57, 110);
            this.txbAnoInicio.Name = "txbAnoInicio";
            this.txbAnoInicio.Size = new System.Drawing.Size(68, 20);
            this.txbAnoInicio.TabIndex = 10;
            // 
            // lblAnoInicioTurma
            // 
            this.lblAnoInicioTurma.AutoSize = true;
            this.lblAnoInicioTurma.Location = new System.Drawing.Point(54, 94);
            this.lblAnoInicioTurma.Name = "lblAnoInicioTurma";
            this.lblAnoInicioTurma.Size = new System.Drawing.Size(71, 13);
            this.lblAnoInicioTurma.TabIndex = 9;
            this.lblAnoInicioTurma.Text = "Ano de Início";
            // 
            // lblSemestreInicio
            // 
            this.lblSemestreInicio.AutoSize = true;
            this.lblSemestreInicio.Location = new System.Drawing.Point(54, 142);
            this.lblSemestreInicio.Name = "lblSemestreInicio";
            this.lblSemestreInicio.Size = new System.Drawing.Size(96, 13);
            this.lblSemestreInicio.TabIndex = 11;
            this.lblSemestreInicio.Text = "Semestre de Início";
            // 
            // lblSigla
            // 
            this.lblSigla.AutoSize = true;
            this.lblSigla.Location = new System.Drawing.Point(206, 49);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(30, 13);
            this.lblSigla.TabIndex = 13;
            this.lblSigla.Text = "Sigla";
            // 
            // cmbSigla
            // 
            this.cmbSigla.FormattingEnabled = true;
            this.cmbSigla.Location = new System.Drawing.Point(209, 66);
            this.cmbSigla.Name = "cmbSigla";
            this.cmbSigla.Size = new System.Drawing.Size(50, 21);
            this.cmbSigla.TabIndex = 14;
            // 
            // cmbAlfabeto
            // 
            this.cmbAlfabeto.FormattingEnabled = true;
            this.cmbAlfabeto.Location = new System.Drawing.Point(209, 109);
            this.cmbAlfabeto.Name = "cmbAlfabeto";
            this.cmbAlfabeto.Size = new System.Drawing.Size(50, 21);
            this.cmbAlfabeto.TabIndex = 16;
            // 
            // lblAlfabeto
            // 
            this.lblAlfabeto.AutoSize = true;
            this.lblAlfabeto.Location = new System.Drawing.Point(206, 92);
            this.lblAlfabeto.Name = "lblAlfabeto";
            this.lblAlfabeto.Size = new System.Drawing.Size(53, 13);
            this.lblAlfabeto.TabIndex = 15;
            this.lblAlfabeto.Text = "Caractere";
            // 
            // cmbCampus
            // 
            this.cmbCampus.FormattingEnabled = true;
            this.cmbCampus.Location = new System.Drawing.Point(209, 158);
            this.cmbCampus.Name = "cmbCampus";
            this.cmbCampus.Size = new System.Drawing.Size(167, 21);
            this.cmbCampus.TabIndex = 18;
            // 
            // lblCampus
            // 
            this.lblCampus.AutoSize = true;
            this.lblCampus.Location = new System.Drawing.Point(206, 141);
            this.lblCampus.Name = "lblCampus";
            this.lblCampus.Size = new System.Drawing.Size(45, 13);
            this.lblCampus.TabIndex = 17;
            this.lblCampus.Text = "Campus";
            // 
            // cmbCurso
            // 
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(209, 207);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(167, 21);
            this.cmbCurso.TabIndex = 20;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(206, 191);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(34, 13);
            this.lblCurso.TabIndex = 19;
            this.lblCurso.Text = "Curso";
            // 
            // cmbSemestreInicio
            // 
            this.cmbSemestreInicio.FormattingEnabled = true;
            this.cmbSemestreInicio.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbSemestreInicio.Location = new System.Drawing.Point(57, 158);
            this.cmbSemestreInicio.Name = "cmbSemestreInicio";
            this.cmbSemestreInicio.Size = new System.Drawing.Size(93, 21);
            this.cmbSemestreInicio.TabIndex = 21;
            // 
            // frmEditarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(464, 329);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditarTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditarTurma";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExluirTurma;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditarTurma;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblCampus;
        private System.Windows.Forms.Label lblAlfabeto;
        private System.Windows.Forms.Label lblSigla;
        private System.Windows.Forms.Label lblSemestreInicio;
        private System.Windows.Forms.Label lblAnoInicioTurma;
        private System.Windows.Forms.Label lblNumeroTurma;
        private System.Windows.Forms.Label lblIdTurma;
        public System.Windows.Forms.TextBox txbNumeroTurma;
        public System.Windows.Forms.TextBox txbIdTurma;
        public System.Windows.Forms.ComboBox cmbSemestreInicio;
        public System.Windows.Forms.ComboBox cmbCurso;
        public System.Windows.Forms.ComboBox cmbCampus;
        public System.Windows.Forms.ComboBox cmbAlfabeto;
        public System.Windows.Forms.ComboBox cmbSigla;
        public System.Windows.Forms.TextBox txbAnoInicio;
    }
}
namespace pim2019_desk.Apresentacao
{
    partial class frmCadastrarTurma
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarTurma));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.cmbCampus = new System.Windows.Forms.ComboBox();
            this.lblCampus = new System.Windows.Forms.Label();
            this.cmbAlfabeto = new System.Windows.Forms.ComboBox();
            this.lblAlfabeto = new System.Windows.Forms.Label();
            this.cmbSigla = new System.Windows.Forms.ComboBox();
            this.lblSigla = new System.Windows.Forms.Label();
            this.txbAnoInicio = new System.Windows.Forms.TextBox();
            this.lblAnoInicioTurma = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrarTurma = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.unip_salaDataSet9 = new pim2019_desk.unip_salaDataSet9();
            this.tbsiglaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_siglaTableAdapter = new pim2019_desk.unip_salaDataSet9TableAdapters.tb_siglaTableAdapter();
            this.cmbAlfabeto1 = new pim2019_desk.cmbAlfabeto();
            this.tbalfabetoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_alfabetoTableAdapter = new pim2019_desk.cmbAlfabetoTableAdapters.tb_alfabetoTableAdapter();
            this.unip_salaDataSet1 = new pim2019_desk.unip_salaDataSet1();
            this.tbcampusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_campusTableAdapter = new pim2019_desk.unip_salaDataSet1TableAdapters.tb_campusTableAdapter();
            this.unip_salaDataSet = new pim2019_desk.unip_salaDataSet();
            this.tbcursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_cursoTableAdapter = new pim2019_desk.unip_salaDataSetTableAdapters.tb_cursoTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unip_salaDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsiglaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAlfabeto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbalfabetoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unip_salaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcampusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unip_salaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcursoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cmbCurso);
            this.panel1.Controls.Add(this.lblCurso);
            this.panel1.Controls.Add(this.cmbCampus);
            this.panel1.Controls.Add(this.lblCampus);
            this.panel1.Controls.Add(this.cmbAlfabeto);
            this.panel1.Controls.Add(this.lblAlfabeto);
            this.panel1.Controls.Add(this.cmbSigla);
            this.panel1.Controls.Add(this.lblSigla);
            this.panel1.Controls.Add(this.txbAnoInicio);
            this.panel1.Controls.Add(this.lblAnoInicioTurma);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnCadastrarTurma);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 304);
            this.panel1.TabIndex = 0;
            // 
            // cmbCurso
            // 
            this.cmbCurso.DataSource = this.tbcursoBindingSource;
            this.cmbCurso.DisplayMember = "nomeCurso";
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(54, 200);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(331, 21);
            this.cmbCurso.TabIndex = 40;
            this.cmbCurso.ValueMember = "idCurso";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(51, 184);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(34, 13);
            this.lblCurso.TabIndex = 39;
            this.lblCurso.Text = "Curso";
            // 
            // cmbCampus
            // 
            this.cmbCampus.DataSource = this.tbcampusBindingSource;
            this.cmbCampus.DisplayMember = "nomeCampus";
            this.cmbCampus.FormattingEnabled = true;
            this.cmbCampus.Location = new System.Drawing.Point(218, 140);
            this.cmbCampus.Name = "cmbCampus";
            this.cmbCampus.Size = new System.Drawing.Size(167, 21);
            this.cmbCampus.TabIndex = 38;
            this.cmbCampus.ValueMember = "idCampus";
            // 
            // lblCampus
            // 
            this.lblCampus.AutoSize = true;
            this.lblCampus.Location = new System.Drawing.Point(215, 123);
            this.lblCampus.Name = "lblCampus";
            this.lblCampus.Size = new System.Drawing.Size(45, 13);
            this.lblCampus.TabIndex = 37;
            this.lblCampus.Text = "Campus";
            // 
            // cmbAlfabeto
            // 
            this.cmbAlfabeto.DataSource = this.tbalfabetoBindingSource;
            this.cmbAlfabeto.DisplayMember = "nomeAlfabeto";
            this.cmbAlfabeto.FormattingEnabled = true;
            this.cmbAlfabeto.Location = new System.Drawing.Point(317, 82);
            this.cmbAlfabeto.Name = "cmbAlfabeto";
            this.cmbAlfabeto.Size = new System.Drawing.Size(50, 21);
            this.cmbAlfabeto.TabIndex = 36;
            this.cmbAlfabeto.ValueMember = "idAlfabeto";
            // 
            // lblAlfabeto
            // 
            this.lblAlfabeto.AutoSize = true;
            this.lblAlfabeto.Location = new System.Drawing.Point(314, 65);
            this.lblAlfabeto.Name = "lblAlfabeto";
            this.lblAlfabeto.Size = new System.Drawing.Size(53, 13);
            this.lblAlfabeto.TabIndex = 35;
            this.lblAlfabeto.Text = "Caractere";
            // 
            // cmbSigla
            // 
            this.cmbSigla.DataSource = this.tbsiglaBindingSource;
            this.cmbSigla.DisplayMember = "nomeSigla";
            this.cmbSigla.FormattingEnabled = true;
            this.cmbSigla.Location = new System.Drawing.Point(246, 82);
            this.cmbSigla.Name = "cmbSigla";
            this.cmbSigla.Size = new System.Drawing.Size(50, 21);
            this.cmbSigla.TabIndex = 34;
            this.cmbSigla.ValueMember = "idSigla";
            // 
            // lblSigla
            // 
            this.lblSigla.AutoSize = true;
            this.lblSigla.Location = new System.Drawing.Point(243, 65);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(30, 13);
            this.lblSigla.TabIndex = 33;
            this.lblSigla.Text = "Sigla";
            // 
            // txbAnoInicio
            // 
            this.txbAnoInicio.Location = new System.Drawing.Point(54, 83);
            this.txbAnoInicio.Name = "txbAnoInicio";
            this.txbAnoInicio.Size = new System.Drawing.Size(68, 20);
            this.txbAnoInicio.TabIndex = 31;
            // 
            // lblAnoInicioTurma
            // 
            this.lblAnoInicioTurma.AutoSize = true;
            this.lblAnoInicioTurma.Location = new System.Drawing.Point(51, 67);
            this.lblAnoInicioTurma.Name = "lblAnoInicioTurma";
            this.lblAnoInicioTurma.Size = new System.Drawing.Size(71, 13);
            this.lblAnoInicioTurma.TabIndex = 30;
            this.lblAnoInicioTurma.Text = "Ano de Início";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(239, 264);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 37);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCadastrarTurma
            // 
            this.btnCadastrarTurma.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarTurma.Image")));
            this.btnCadastrarTurma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarTurma.Location = new System.Drawing.Point(349, 264);
            this.btnCadastrarTurma.Name = "btnCadastrarTurma";
            this.btnCadastrarTurma.Size = new System.Drawing.Size(87, 37);
            this.btnCadastrarTurma.TabIndex = 23;
            this.btnCadastrarTurma.Text = "Salvar";
            this.btnCadastrarTurma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrarTurma.UseVisualStyleBackColor = true;
            this.btnCadastrarTurma.Click += new System.EventHandler(this.btnCadastrarTurma_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Location = new System.Drawing.Point(411, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 25);
            this.btnFechar.TabIndex = 22;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 28);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nova Turma";
            // 
            // unip_salaDataSet9
            // 
            this.unip_salaDataSet9.DataSetName = "unip_salaDataSet9";
            this.unip_salaDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbsiglaBindingSource
            // 
            this.tbsiglaBindingSource.DataMember = "tb_sigla";
            this.tbsiglaBindingSource.DataSource = this.unip_salaDataSet9;
            // 
            // tb_siglaTableAdapter
            // 
            this.tb_siglaTableAdapter.ClearBeforeFill = true;
            // 
            // cmbAlfabeto1
            // 
            this.cmbAlfabeto1.DataSetName = "cmbAlfabeto";
            this.cmbAlfabeto1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbalfabetoBindingSource
            // 
            this.tbalfabetoBindingSource.DataMember = "tb_alfabeto";
            this.tbalfabetoBindingSource.DataSource = this.cmbAlfabeto1;
            // 
            // tb_alfabetoTableAdapter
            // 
            this.tb_alfabetoTableAdapter.ClearBeforeFill = true;
            // 
            // unip_salaDataSet1
            // 
            this.unip_salaDataSet1.DataSetName = "unip_salaDataSet1";
            this.unip_salaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbcampusBindingSource
            // 
            this.tbcampusBindingSource.DataMember = "tb_campus";
            this.tbcampusBindingSource.DataSource = this.unip_salaDataSet1;
            // 
            // tb_campusTableAdapter
            // 
            this.tb_campusTableAdapter.ClearBeforeFill = true;
            // 
            // unip_salaDataSet
            // 
            this.unip_salaDataSet.DataSetName = "unip_salaDataSet";
            this.unip_salaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbcursoBindingSource
            // 
            this.tbcursoBindingSource.DataMember = "tb_curso";
            this.tbcursoBindingSource.DataSource = this.unip_salaDataSet;
            // 
            // tb_cursoTableAdapter
            // 
            this.tb_cursoTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb2);
            this.groupBox1.Controls.Add(this.rdb1);
            this.groupBox1.Location = new System.Drawing.Point(54, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 55);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Semestre de Início";
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.Location = new System.Drawing.Point(27, 21);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(31, 17);
            this.rdb1.TabIndex = 0;
            this.rdb1.TabStop = true;
            this.rdb1.Text = "1";
            this.rdb1.UseVisualStyleBackColor = true;
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.Location = new System.Drawing.Point(90, 21);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(31, 17);
            this.rdb2.TabIndex = 1;
            this.rdb2.TabStop = true;
            this.rdb2.Text = "2";
            this.rdb2.UseVisualStyleBackColor = true;
            // 
            // frmCadastrarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(464, 329);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastrarTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastrarTurma";
            this.Load += new System.EventHandler(this.frmCadastrarTurma_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unip_salaDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsiglaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAlfabeto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbalfabetoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unip_salaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcampusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unip_salaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcursoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.Label lblCurso;
        public System.Windows.Forms.ComboBox cmbCampus;
        private System.Windows.Forms.Label lblCampus;
        public System.Windows.Forms.ComboBox cmbAlfabeto;
        private System.Windows.Forms.Label lblAlfabeto;
        public System.Windows.Forms.ComboBox cmbSigla;
        private System.Windows.Forms.Label lblSigla;
        public System.Windows.Forms.TextBox txbAnoInicio;
        private System.Windows.Forms.Label lblAnoInicioTurma;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrarTurma;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label1;
        private unip_salaDataSet9 unip_salaDataSet9;
        private System.Windows.Forms.BindingSource tbsiglaBindingSource;
        private unip_salaDataSet9TableAdapters.tb_siglaTableAdapter tb_siglaTableAdapter;
        private cmbAlfabeto cmbAlfabeto1;
        private System.Windows.Forms.BindingSource tbalfabetoBindingSource;
        private cmbAlfabetoTableAdapters.tb_alfabetoTableAdapter tb_alfabetoTableAdapter;
        private unip_salaDataSet1 unip_salaDataSet1;
        private System.Windows.Forms.BindingSource tbcampusBindingSource;
        private unip_salaDataSet1TableAdapters.tb_campusTableAdapter tb_campusTableAdapter;
        private unip_salaDataSet unip_salaDataSet;
        private System.Windows.Forms.BindingSource tbcursoBindingSource;
        private unip_salaDataSetTableAdapters.tb_cursoTableAdapter tb_cursoTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.RadioButton rdb1;
    }
}
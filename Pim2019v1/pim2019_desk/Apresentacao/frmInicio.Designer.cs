namespace pim2019_desk.Apresentacao
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.lblNumeroCampus = new System.Windows.Forms.Label();
            this.lblNomeCampus = new System.Windows.Forms.Label();
            this.txbNomeCampus = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.unip_salaDataSet = new pim2019_desk.unip_salaDataSet();
            this.tbcursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_cursoTableAdapter = new pim2019_desk.unip_salaDataSetTableAdapters.tb_cursoTableAdapter();
            this.dgvCampus = new System.Windows.Forms.DataGridView();
            this.idCampusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCampusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCampusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcampusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unip_salaDataSet1 = new pim2019_desk.unip_salaDataSet1();
            this.tb_campusTableAdapter = new pim2019_desk.unip_salaDataSet1TableAdapters.tb_campusTableAdapter();
            this.lblIdCampus = new System.Windows.Forms.Label();
            this.txbIdCampus = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mskNumero = new System.Windows.Forms.MaskedTextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCampus = new System.Windows.Forms.TabPage();
            this.btnSair = new System.Windows.Forms.Button();
            this.tbpCurso = new System.Windows.Forms.TabPage();
            this.tbpAluno = new System.Windows.Forms.TabPage();
            this.tbpSala = new System.Windows.Forms.TabPage();
            this.tbpTurma = new System.Windows.Forms.TabPage();
            this.dgvCurso = new System.Windows.Forms.DataGridView();
            this.idCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluirCurso = new System.Windows.Forms.Button();
            this.lblNomeCurso = new System.Windows.Forms.Label();
            this.btnLimparCurso = new System.Windows.Forms.Button();
            this.txbNomeCurso = new System.Windows.Forms.TextBox();
            this.btnEditarCurso = new System.Windows.Forms.Button();
            this.btnCadastrarCurso = new System.Windows.Forms.Button();
            this.lblIdCurso = new System.Windows.Forms.Label();
            this.txbIdCurso = new System.Windows.Forms.TextBox();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.unip_salaDataSet2 = new pim2019_desk.unip_salaDataSet2();
            this.tbcursoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tb_cursoTableAdapter1 = new pim2019_desk.unip_salaDataSet2TableAdapters.tb_cursoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.unip_salaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcampusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unip_salaDataSet1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabCampus.SuspendLayout();
            this.tbpCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unip_salaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcursoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumeroCampus
            // 
            this.lblNumeroCampus.AutoSize = true;
            this.lblNumeroCampus.Location = new System.Drawing.Point(88, 241);
            this.lblNumeroCampus.Name = "lblNumeroCampus";
            this.lblNumeroCampus.Size = new System.Drawing.Size(100, 13);
            this.lblNumeroCampus.TabIndex = 0;
            this.lblNumeroCampus.Text = "Número do Campus";
            // 
            // lblNomeCampus
            // 
            this.lblNomeCampus.AutoSize = true;
            this.lblNomeCampus.Location = new System.Drawing.Point(3, 296);
            this.lblNomeCampus.Name = "lblNomeCampus";
            this.lblNomeCampus.Size = new System.Drawing.Size(91, 13);
            this.lblNomeCampus.TabIndex = 2;
            this.lblNomeCampus.Text = "Nome do Campus";
            // 
            // txbNomeCampus
            // 
            this.txbNomeCampus.Location = new System.Drawing.Point(6, 313);
            this.txbNomeCampus.Name = "txbNomeCampus";
            this.txbNomeCampus.Size = new System.Drawing.Size(457, 20);
            this.txbNomeCampus.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(71, 365);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(88, 38);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
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
            // dgvCampus
            // 
            this.dgvCampus.AllowUserToAddRows = false;
            this.dgvCampus.AllowUserToDeleteRows = false;
            this.dgvCampus.AllowUserToResizeColumns = false;
            this.dgvCampus.AllowUserToResizeRows = false;
            this.dgvCampus.AutoGenerateColumns = false;
            this.dgvCampus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCampus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCampusDataGridViewTextBoxColumn,
            this.numeroCampusDataGridViewTextBoxColumn,
            this.nomeCampusDataGridViewTextBoxColumn});
            this.dgvCampus.DataSource = this.tbcampusBindingSource;
            this.dgvCampus.Location = new System.Drawing.Point(6, 6);
            this.dgvCampus.MultiSelect = false;
            this.dgvCampus.Name = "dgvCampus";
            this.dgvCampus.ReadOnly = true;
            this.dgvCampus.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCampus.ShowEditingIcon = false;
            this.dgvCampus.Size = new System.Drawing.Size(460, 221);
            this.dgvCampus.TabIndex = 6;
            this.dgvCampus.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCampus_CellEnter);
            // 
            // idCampusDataGridViewTextBoxColumn
            // 
            this.idCampusDataGridViewTextBoxColumn.DataPropertyName = "idCampus";
            this.idCampusDataGridViewTextBoxColumn.Frozen = true;
            this.idCampusDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idCampusDataGridViewTextBoxColumn.Name = "idCampusDataGridViewTextBoxColumn";
            this.idCampusDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCampusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idCampusDataGridViewTextBoxColumn.Width = 60;
            // 
            // numeroCampusDataGridViewTextBoxColumn
            // 
            this.numeroCampusDataGridViewTextBoxColumn.DataPropertyName = "numeroCampus";
            this.numeroCampusDataGridViewTextBoxColumn.Frozen = true;
            this.numeroCampusDataGridViewTextBoxColumn.HeaderText = "Número";
            this.numeroCampusDataGridViewTextBoxColumn.Name = "numeroCampusDataGridViewTextBoxColumn";
            this.numeroCampusDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroCampusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.numeroCampusDataGridViewTextBoxColumn.Width = 70;
            // 
            // nomeCampusDataGridViewTextBoxColumn
            // 
            this.nomeCampusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeCampusDataGridViewTextBoxColumn.DataPropertyName = "nomeCampus";
            this.nomeCampusDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeCampusDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.nomeCampusDataGridViewTextBoxColumn.Name = "nomeCampusDataGridViewTextBoxColumn";
            this.nomeCampusDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeCampusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tbcampusBindingSource
            // 
            this.tbcampusBindingSource.DataMember = "tb_campus";
            this.tbcampusBindingSource.DataSource = this.unip_salaDataSet1;
            // 
            // unip_salaDataSet1
            // 
            this.unip_salaDataSet1.DataSetName = "unip_salaDataSet1";
            this.unip_salaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_campusTableAdapter
            // 
            this.tb_campusTableAdapter.ClearBeforeFill = true;
            // 
            // lblIdCampus
            // 
            this.lblIdCampus.AutoSize = true;
            this.lblIdCampus.Location = new System.Drawing.Point(6, 242);
            this.lblIdCampus.Name = "lblIdCampus";
            this.lblIdCampus.Size = new System.Drawing.Size(18, 13);
            this.lblIdCampus.TabIndex = 7;
            this.lblIdCampus.Text = "ID";
            // 
            // txbIdCampus
            // 
            this.txbIdCampus.Enabled = false;
            this.txbIdCampus.Location = new System.Drawing.Point(6, 258);
            this.txbIdCampus.Name = "txbIdCampus";
            this.txbIdCampus.ReadOnly = true;
            this.txbIdCampus.Size = new System.Drawing.Size(53, 20);
            this.txbIdCampus.TabIndex = 8;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(165, 365);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(73, 38);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(244, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Limpar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mskNumero
            // 
            this.mskNumero.Location = new System.Drawing.Point(91, 258);
            this.mskNumero.Name = "mskNumero";
            this.mskNumero.Size = new System.Drawing.Size(97, 20);
            this.mskNumero.TabIndex = 11;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Gainsboro;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(319, 365);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(74, 38);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCampus);
            this.tabControl1.Controls.Add(this.tbpCurso);
            this.tabControl1.Controls.Add(this.tbpAluno);
            this.tabControl1.Controls.Add(this.tbpSala);
            this.tabControl1.Controls.Add(this.tbpTurma);
            this.tabControl1.Location = new System.Drawing.Point(12, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(480, 450);
            this.tabControl1.TabIndex = 13;
            // 
            // tabCampus
            // 
            this.tabCampus.Controls.Add(this.btnExcluir);
            this.tabCampus.Controls.Add(this.dgvCampus);
            this.tabCampus.Controls.Add(this.mskNumero);
            this.tabCampus.Controls.Add(this.lblNomeCampus);
            this.tabCampus.Controls.Add(this.button1);
            this.tabCampus.Controls.Add(this.txbNomeCampus);
            this.tabCampus.Controls.Add(this.btnEditar);
            this.tabCampus.Controls.Add(this.btnCadastrar);
            this.tabCampus.Controls.Add(this.lblIdCampus);
            this.tabCampus.Controls.Add(this.lblNumeroCampus);
            this.tabCampus.Controls.Add(this.txbIdCampus);
            this.tabCampus.Location = new System.Drawing.Point(4, 22);
            this.tabCampus.Name = "tabCampus";
            this.tabCampus.Padding = new System.Windows.Forms.Padding(3);
            this.tabCampus.Size = new System.Drawing.Size(472, 424);
            this.tabCampus.TabIndex = 0;
            this.tabCampus.Text = "Campus";
            this.tabCampus.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Location = new System.Drawing.Point(463, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(25, 25);
            this.btnSair.TabIndex = 13;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // tbpCurso
            // 
            this.tbpCurso.Controls.Add(this.btnExcluirCurso);
            this.tbpCurso.Controls.Add(this.lblNomeCurso);
            this.tbpCurso.Controls.Add(this.btnLimparCurso);
            this.tbpCurso.Controls.Add(this.txbNomeCurso);
            this.tbpCurso.Controls.Add(this.btnEditarCurso);
            this.tbpCurso.Controls.Add(this.btnCadastrarCurso);
            this.tbpCurso.Controls.Add(this.lblIdCurso);
            this.tbpCurso.Controls.Add(this.txbIdCurso);
            this.tbpCurso.Controls.Add(this.dgvCurso);
            this.tbpCurso.Location = new System.Drawing.Point(4, 22);
            this.tbpCurso.Name = "tbpCurso";
            this.tbpCurso.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCurso.Size = new System.Drawing.Size(472, 424);
            this.tbpCurso.TabIndex = 1;
            this.tbpCurso.Text = "Curso";
            this.tbpCurso.UseVisualStyleBackColor = true;
            // 
            // tbpAluno
            // 
            this.tbpAluno.Location = new System.Drawing.Point(4, 22);
            this.tbpAluno.Name = "tbpAluno";
            this.tbpAluno.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAluno.Size = new System.Drawing.Size(472, 424);
            this.tbpAluno.TabIndex = 2;
            this.tbpAluno.Text = "Aluno";
            this.tbpAluno.UseVisualStyleBackColor = true;
            // 
            // tbpSala
            // 
            this.tbpSala.Location = new System.Drawing.Point(4, 22);
            this.tbpSala.Name = "tbpSala";
            this.tbpSala.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSala.Size = new System.Drawing.Size(472, 424);
            this.tbpSala.TabIndex = 3;
            this.tbpSala.Text = "Sala";
            this.tbpSala.UseVisualStyleBackColor = true;
            // 
            // tbpTurma
            // 
            this.tbpTurma.Location = new System.Drawing.Point(4, 22);
            this.tbpTurma.Name = "tbpTurma";
            this.tbpTurma.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTurma.Size = new System.Drawing.Size(472, 424);
            this.tbpTurma.TabIndex = 4;
            this.tbpTurma.Text = "Turma";
            this.tbpTurma.UseVisualStyleBackColor = true;
            // 
            // dgvCurso
            // 
            this.dgvCurso.AllowUserToAddRows = false;
            this.dgvCurso.AllowUserToResizeColumns = false;
            this.dgvCurso.AllowUserToResizeRows = false;
            this.dgvCurso.AutoGenerateColumns = false;
            this.dgvCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCursoDataGridViewTextBoxColumn,
            this.nomeCursoDataGridViewTextBoxColumn});
            this.dgvCurso.DataSource = this.tbcursoBindingSource1;
            this.dgvCurso.Location = new System.Drawing.Point(6, 7);
            this.dgvCurso.Name = "dgvCurso";
            this.dgvCurso.ReadOnly = true;
            this.dgvCurso.Size = new System.Drawing.Size(460, 221);
            this.dgvCurso.TabIndex = 0;
            // 
            // idCursoDataGridViewTextBoxColumn
            // 
            this.idCursoDataGridViewTextBoxColumn.DataPropertyName = "idCurso";
            this.idCursoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idCursoDataGridViewTextBoxColumn.Name = "idCursoDataGridViewTextBoxColumn";
            this.idCursoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCursoDataGridViewTextBoxColumn.Width = 60;
            // 
            // nomeCursoDataGridViewTextBoxColumn
            // 
            this.nomeCursoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeCursoDataGridViewTextBoxColumn.DataPropertyName = "nomeCurso";
            this.nomeCursoDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeCursoDataGridViewTextBoxColumn.Name = "nomeCursoDataGridViewTextBoxColumn";
            this.nomeCursoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnExcluirCurso
            // 
            this.btnExcluirCurso.BackColor = System.Drawing.Color.Gainsboro;
            this.btnExcluirCurso.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirCurso.Image")));
            this.btnExcluirCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirCurso.Location = new System.Drawing.Point(319, 365);
            this.btnExcluirCurso.Name = "btnExcluirCurso";
            this.btnExcluirCurso.Size = new System.Drawing.Size(74, 38);
            this.btnExcluirCurso.TabIndex = 23;
            this.btnExcluirCurso.Text = "Excluir";
            this.btnExcluirCurso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirCurso.UseVisualStyleBackColor = false;
            // 
            // lblNomeCurso
            // 
            this.lblNomeCurso.AutoSize = true;
            this.lblNomeCurso.Location = new System.Drawing.Point(3, 296);
            this.lblNomeCurso.Name = "lblNomeCurso";
            this.lblNomeCurso.Size = new System.Drawing.Size(80, 13);
            this.lblNomeCurso.TabIndex = 15;
            this.lblNomeCurso.Text = "Nome do Curso";
            // 
            // btnLimparCurso
            // 
            this.btnLimparCurso.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLimparCurso.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparCurso.Image")));
            this.btnLimparCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparCurso.Location = new System.Drawing.Point(244, 365);
            this.btnLimparCurso.Name = "btnLimparCurso";
            this.btnLimparCurso.Size = new System.Drawing.Size(69, 38);
            this.btnLimparCurso.TabIndex = 21;
            this.btnLimparCurso.Text = "Limpar";
            this.btnLimparCurso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparCurso.UseVisualStyleBackColor = false;
            // 
            // txbNomeCurso
            // 
            this.txbNomeCurso.Location = new System.Drawing.Point(6, 313);
            this.txbNomeCurso.Name = "txbNomeCurso";
            this.txbNomeCurso.Size = new System.Drawing.Size(457, 20);
            this.txbNomeCurso.TabIndex = 16;
            // 
            // btnEditarCurso
            // 
            this.btnEditarCurso.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEditarCurso.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarCurso.Image")));
            this.btnEditarCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarCurso.Location = new System.Drawing.Point(165, 365);
            this.btnEditarCurso.Name = "btnEditarCurso";
            this.btnEditarCurso.Size = new System.Drawing.Size(73, 38);
            this.btnEditarCurso.TabIndex = 20;
            this.btnEditarCurso.Text = "Editar";
            this.btnEditarCurso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarCurso.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarCurso
            // 
            this.btnCadastrarCurso.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCadastrarCurso.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarCurso.Image")));
            this.btnCadastrarCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarCurso.Location = new System.Drawing.Point(71, 365);
            this.btnCadastrarCurso.Name = "btnCadastrarCurso";
            this.btnCadastrarCurso.Size = new System.Drawing.Size(88, 38);
            this.btnCadastrarCurso.TabIndex = 17;
            this.btnCadastrarCurso.Text = "Cadastrar";
            this.btnCadastrarCurso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrarCurso.UseVisualStyleBackColor = false;
            this.btnCadastrarCurso.Click += new System.EventHandler(this.btnCadastrarCurso_Click);
            // 
            // lblIdCurso
            // 
            this.lblIdCurso.AutoSize = true;
            this.lblIdCurso.Location = new System.Drawing.Point(6, 242);
            this.lblIdCurso.Name = "lblIdCurso";
            this.lblIdCurso.Size = new System.Drawing.Size(18, 13);
            this.lblIdCurso.TabIndex = 18;
            this.lblIdCurso.Text = "ID";
            // 
            // txbIdCurso
            // 
            this.txbIdCurso.Enabled = false;
            this.txbIdCurso.Location = new System.Drawing.Point(6, 258);
            this.txbIdCurso.Name = "txbIdCurso";
            this.txbIdCurso.ReadOnly = true;
            this.txbIdCurso.Size = new System.Drawing.Size(53, 20);
            this.txbIdCurso.TabIndex = 19;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.Location = new System.Drawing.Point(432, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.TabIndex = 14;
            this.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // unip_salaDataSet2
            // 
            this.unip_salaDataSet2.DataSetName = "unip_salaDataSet2";
            this.unip_salaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbcursoBindingSource1
            // 
            this.tbcursoBindingSource1.DataMember = "tb_curso";
            this.tbcursoBindingSource1.DataSource = this.unip_salaDataSet2;
            // 
            // tb_cursoTableAdapter1
            // 
            this.tb_cursoTableAdapter1.ClearBeforeFill = true;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(504, 514);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmInicio";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Salas";
            this.Load += new System.EventHandler(this.frmCampus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unip_salaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcampusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unip_salaDataSet1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabCampus.ResumeLayout(false);
            this.tabCampus.PerformLayout();
            this.tbpCurso.ResumeLayout(false);
            this.tbpCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unip_salaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcursoBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txbNomeCampus;
        private System.Windows.Forms.Label lblNomeCampus;
        private System.Windows.Forms.Label lblNumeroCampus;
        private unip_salaDataSet unip_salaDataSet;
        private System.Windows.Forms.BindingSource tbcursoBindingSource;
        private unip_salaDataSetTableAdapters.tb_cursoTableAdapter tb_cursoTableAdapter;
        private System.Windows.Forms.DataGridView dgvCampus;
        private unip_salaDataSet1 unip_salaDataSet1;
        private System.Windows.Forms.BindingSource tbcampusBindingSource;
        private unip_salaDataSet1TableAdapters.tb_campusTableAdapter tb_campusTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCampusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCampusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCampusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblIdCampus;
        private System.Windows.Forms.TextBox txbIdCampus;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mskNumero;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCampus;
        private System.Windows.Forms.TabPage tbpCurso;
        private System.Windows.Forms.TabPage tbpAluno;
        private System.Windows.Forms.TabPage tbpSala;
        private System.Windows.Forms.TabPage tbpTurma;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluirCurso;
        private System.Windows.Forms.Label lblNomeCurso;
        private System.Windows.Forms.Button btnLimparCurso;
        private System.Windows.Forms.TextBox txbNomeCurso;
        private System.Windows.Forms.Button btnEditarCurso;
        private System.Windows.Forms.Button btnCadastrarCurso;
        private System.Windows.Forms.Label lblIdCurso;
        private System.Windows.Forms.TextBox txbIdCurso;
        private System.Windows.Forms.DataGridView dgvCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private unip_salaDataSet2 unip_salaDataSet2;
        private System.Windows.Forms.BindingSource tbcursoBindingSource1;
        private unip_salaDataSet2TableAdapters.tb_cursoTableAdapter tb_cursoTableAdapter1;
    }
}
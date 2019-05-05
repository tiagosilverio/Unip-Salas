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
            ((System.ComponentModel.ISupportInitialize)(this.unip_salaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcampusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unip_salaDataSet1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabCampus.SuspendLayout();
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
            this.btnCadastrar.Location = new System.Drawing.Point(6, 364);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(94, 32);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
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
            this.dgvCampus.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCampus.Size = new System.Drawing.Size(457, 221);
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
            this.lblIdCampus.Location = new System.Drawing.Point(3, 241);
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
            this.btnEditar.Location = new System.Drawing.Point(106, 364);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(94, 32);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(365, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 26);
            this.button1.TabIndex = 10;
            this.button1.Text = "Limpar Formulário";
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
            this.btnExcluir.Location = new System.Drawing.Point(206, 364);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(94, 32);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir";
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
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(480, 450);
            this.tabControl1.TabIndex = 13;
            // 
            // tabCampus
            // 
            this.tabCampus.Controls.Add(this.btnSair);
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
            this.btnSair.Location = new System.Drawing.Point(369, 364);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(94, 32);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // tbpCurso
            // 
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
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(504, 474);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
    }
}
namespace pim2019_desk.Apresentacao
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpAula = new System.Windows.Forms.TabPage();
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.tbpAluno = new System.Windows.Forms.TabPage();
            this.btnEditarAluno = new System.Windows.Forms.Button();
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.gpbResultadoAluno = new System.Windows.Forms.GroupBox();
            this.lblStatusAlunoResultado = new System.Windows.Forms.Label();
            this.lblStatusAluno = new System.Windows.Forms.Label();
            this.lblNomeAlunoResultado = new System.Windows.Forms.Label();
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.lblRaAlunoResultado = new System.Windows.Forms.Label();
            this.lblRaAluno = new System.Windows.Forms.Label();
            this.lblIdAlunoResultado = new System.Windows.Forms.Label();
            this.lblIdAluno = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txbPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.idAlunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raAlunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAlunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusAlunoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbalunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unip_salaDataSet4 = new pim2019_desk.unip_salaDataSet4();
            this.tbpTurma = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.tb_alunoTableAdapter = new pim2019_desk.unip_salaDataSet4TableAdapters.tb_alunoTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tbpAula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            this.tbpAluno.SuspendLayout();
            this.gpbResultadoAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbalunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unip_salaDataSet4)).BeginInit();
            this.tbpTurma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpAula);
            this.tabControl1.Controls.Add(this.tbpAluno);
            this.tabControl1.Controls.Add(this.tbpTurma);
            this.tabControl1.Location = new System.Drawing.Point(13, 89);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(617, 456);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpAula
            // 
            this.tbpAula.Controls.Add(this.dgvAluno);
            this.tbpAula.Location = new System.Drawing.Point(4, 22);
            this.tbpAula.Name = "tbpAula";
            this.tbpAula.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAula.Size = new System.Drawing.Size(609, 430);
            this.tbpAula.TabIndex = 0;
            this.tbpAula.Text = "Aula";
            this.tbpAula.UseVisualStyleBackColor = true;
            // 
            // dgvAluno
            // 
            this.dgvAluno.AllowUserToAddRows = false;
            this.dgvAluno.AllowUserToDeleteRows = false;
            this.dgvAluno.AllowUserToResizeColumns = false;
            this.dgvAluno.AllowUserToResizeRows = false;
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.Location = new System.Drawing.Point(6, 6);
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.ReadOnly = true;
            this.dgvAluno.Size = new System.Drawing.Size(597, 202);
            this.dgvAluno.TabIndex = 1;
            // 
            // tbpAluno
            // 
            this.tbpAluno.Controls.Add(this.btnEditarAluno);
            this.tbpAluno.Controls.Add(this.btnCadastrarAluno);
            this.tbpAluno.Controls.Add(this.gpbResultadoAluno);
            this.tbpAluno.Controls.Add(this.btnPesquisar);
            this.tbpAluno.Controls.Add(this.txbPesquisar);
            this.tbpAluno.Controls.Add(this.lblPesquisar);
            this.tbpAluno.Controls.Add(this.dgvAlunos);
            this.tbpAluno.Location = new System.Drawing.Point(4, 22);
            this.tbpAluno.Name = "tbpAluno";
            this.tbpAluno.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAluno.Size = new System.Drawing.Size(609, 430);
            this.tbpAluno.TabIndex = 1;
            this.tbpAluno.Text = "Aluno";
            this.tbpAluno.UseVisualStyleBackColor = true;
            // 
            // btnEditarAluno
            // 
            this.btnEditarAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarAluno.Image")));
            this.btnEditarAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarAluno.Location = new System.Drawing.Point(494, 387);
            this.btnEditarAluno.Name = "btnEditarAluno";
            this.btnEditarAluno.Size = new System.Drawing.Size(109, 37);
            this.btnEditarAluno.TabIndex = 8;
            this.btnEditarAluno.Text = "Editar Aluno";
            this.btnEditarAluno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarAluno.UseVisualStyleBackColor = true;
            this.btnEditarAluno.Click += new System.EventHandler(this.btnEditarAluno_Click);
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarAluno.Image")));
            this.btnCadastrarAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarAluno.Location = new System.Drawing.Point(6, 387);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(109, 37);
            this.btnCadastrarAluno.TabIndex = 7;
            this.btnCadastrarAluno.Text = "Novo Aluno";
            this.btnCadastrarAluno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrarAluno.UseVisualStyleBackColor = true;
            this.btnCadastrarAluno.Click += new System.EventHandler(this.btnCadastrarAluno_Click);
            // 
            // gpbResultadoAluno
            // 
            this.gpbResultadoAluno.Controls.Add(this.lblStatusAlunoResultado);
            this.gpbResultadoAluno.Controls.Add(this.lblStatusAluno);
            this.gpbResultadoAluno.Controls.Add(this.lblNomeAlunoResultado);
            this.gpbResultadoAluno.Controls.Add(this.lblNomeAluno);
            this.gpbResultadoAluno.Controls.Add(this.lblRaAlunoResultado);
            this.gpbResultadoAluno.Controls.Add(this.lblRaAluno);
            this.gpbResultadoAluno.Controls.Add(this.lblIdAlunoResultado);
            this.gpbResultadoAluno.Controls.Add(this.lblIdAluno);
            this.gpbResultadoAluno.Location = new System.Drawing.Point(118, 246);
            this.gpbResultadoAluno.Name = "gpbResultadoAluno";
            this.gpbResultadoAluno.Size = new System.Drawing.Size(372, 126);
            this.gpbResultadoAluno.TabIndex = 6;
            this.gpbResultadoAluno.TabStop = false;
            // 
            // lblStatusAlunoResultado
            // 
            this.lblStatusAlunoResultado.AutoSize = true;
            this.lblStatusAlunoResultado.Location = new System.Drawing.Point(81, 97);
            this.lblStatusAlunoResultado.Name = "lblStatusAlunoResultado";
            this.lblStatusAlunoResultado.Size = new System.Drawing.Size(10, 13);
            this.lblStatusAlunoResultado.TabIndex = 7;
            this.lblStatusAlunoResultado.Text = "-";
            // 
            // lblStatusAluno
            // 
            this.lblStatusAluno.AutoSize = true;
            this.lblStatusAluno.Location = new System.Drawing.Point(34, 97);
            this.lblStatusAluno.Name = "lblStatusAluno";
            this.lblStatusAluno.Size = new System.Drawing.Size(40, 13);
            this.lblStatusAluno.TabIndex = 6;
            this.lblStatusAluno.Text = "Status:";
            // 
            // lblNomeAlunoResultado
            // 
            this.lblNomeAlunoResultado.AutoSize = true;
            this.lblNomeAlunoResultado.Location = new System.Drawing.Point(81, 72);
            this.lblNomeAlunoResultado.Name = "lblNomeAlunoResultado";
            this.lblNomeAlunoResultado.Size = new System.Drawing.Size(10, 13);
            this.lblNomeAlunoResultado.TabIndex = 5;
            this.lblNomeAlunoResultado.Text = "-";
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.Location = new System.Drawing.Point(36, 72);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(38, 13);
            this.lblNomeAluno.TabIndex = 4;
            this.lblNomeAluno.Text = "Nome:";
            // 
            // lblRaAlunoResultado
            // 
            this.lblRaAlunoResultado.AutoSize = true;
            this.lblRaAlunoResultado.Location = new System.Drawing.Point(81, 46);
            this.lblRaAlunoResultado.Name = "lblRaAlunoResultado";
            this.lblRaAlunoResultado.Size = new System.Drawing.Size(10, 13);
            this.lblRaAlunoResultado.TabIndex = 3;
            this.lblRaAlunoResultado.Text = "-";
            // 
            // lblRaAluno
            // 
            this.lblRaAluno.AutoSize = true;
            this.lblRaAluno.Location = new System.Drawing.Point(49, 46);
            this.lblRaAluno.Name = "lblRaAluno";
            this.lblRaAluno.Size = new System.Drawing.Size(25, 13);
            this.lblRaAluno.TabIndex = 2;
            this.lblRaAluno.Text = "RA:";
            // 
            // lblIdAlunoResultado
            // 
            this.lblIdAlunoResultado.AutoSize = true;
            this.lblIdAlunoResultado.Location = new System.Drawing.Point(81, 20);
            this.lblIdAlunoResultado.Name = "lblIdAlunoResultado";
            this.lblIdAlunoResultado.Size = new System.Drawing.Size(10, 13);
            this.lblIdAlunoResultado.TabIndex = 1;
            this.lblIdAlunoResultado.Text = "-";
            // 
            // lblIdAluno
            // 
            this.lblIdAluno.AutoSize = true;
            this.lblIdAluno.Location = new System.Drawing.Point(53, 20);
            this.lblIdAluno.Name = "lblIdAluno";
            this.lblIdAluno.Size = new System.Drawing.Size(21, 13);
            this.lblIdAluno.TabIndex = 0;
            this.lblIdAluno.Text = "ID:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.BackgroundImage")));
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.Location = new System.Drawing.Point(358, 200);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(25, 25);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txbPesquisar
            // 
            this.txbPesquisar.Location = new System.Drawing.Point(252, 203);
            this.txbPesquisar.Name = "txbPesquisar";
            this.txbPesquisar.Size = new System.Drawing.Size(100, 20);
            this.txbPesquisar.TabIndex = 4;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(193, 205);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisar.TabIndex = 3;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.AllowUserToAddRows = false;
            this.dgvAlunos.AllowUserToDeleteRows = false;
            this.dgvAlunos.AllowUserToResizeColumns = false;
            this.dgvAlunos.AllowUserToResizeRows = false;
            this.dgvAlunos.AutoGenerateColumns = false;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlunoDataGridViewTextBoxColumn,
            this.raAlunoDataGridViewTextBoxColumn,
            this.nomeAlunoDataGridViewTextBoxColumn,
            this.statusAlunoDataGridViewCheckBoxColumn});
            this.dgvAlunos.DataSource = this.tbalunoBindingSource;
            this.dgvAlunos.Location = new System.Drawing.Point(6, 6);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.ReadOnly = true;
            this.dgvAlunos.Size = new System.Drawing.Size(597, 182);
            this.dgvAlunos.TabIndex = 2;
            this.dgvAlunos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlunos_CellEnter);
            // 
            // idAlunoDataGridViewTextBoxColumn
            // 
            this.idAlunoDataGridViewTextBoxColumn.DataPropertyName = "idAluno";
            this.idAlunoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idAlunoDataGridViewTextBoxColumn.Name = "idAlunoDataGridViewTextBoxColumn";
            this.idAlunoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAlunoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idAlunoDataGridViewTextBoxColumn.Width = 60;
            // 
            // raAlunoDataGridViewTextBoxColumn
            // 
            this.raAlunoDataGridViewTextBoxColumn.DataPropertyName = "raAluno";
            this.raAlunoDataGridViewTextBoxColumn.HeaderText = "RA";
            this.raAlunoDataGridViewTextBoxColumn.Name = "raAlunoDataGridViewTextBoxColumn";
            this.raAlunoDataGridViewTextBoxColumn.ReadOnly = true;
            this.raAlunoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.raAlunoDataGridViewTextBoxColumn.Width = 70;
            // 
            // nomeAlunoDataGridViewTextBoxColumn
            // 
            this.nomeAlunoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeAlunoDataGridViewTextBoxColumn.DataPropertyName = "nomeAluno";
            this.nomeAlunoDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeAlunoDataGridViewTextBoxColumn.Name = "nomeAlunoDataGridViewTextBoxColumn";
            this.nomeAlunoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeAlunoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // statusAlunoDataGridViewCheckBoxColumn
            // 
            this.statusAlunoDataGridViewCheckBoxColumn.DataPropertyName = "statusAluno";
            this.statusAlunoDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.statusAlunoDataGridViewCheckBoxColumn.Name = "statusAlunoDataGridViewCheckBoxColumn";
            this.statusAlunoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.statusAlunoDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.statusAlunoDataGridViewCheckBoxColumn.Width = 60;
            // 
            // tbalunoBindingSource
            // 
            this.tbalunoBindingSource.DataMember = "tb_aluno";
            this.tbalunoBindingSource.DataSource = this.unip_salaDataSet4;
            // 
            // unip_salaDataSet4
            // 
            this.unip_salaDataSet4.DataSetName = "unip_salaDataSet4";
            this.unip_salaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbpTurma
            // 
            this.tbpTurma.Controls.Add(this.dataGridView2);
            this.tbpTurma.Location = new System.Drawing.Point(4, 22);
            this.tbpTurma.Name = "tbpTurma";
            this.tbpTurma.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTurma.Size = new System.Drawing.Size(609, 430);
            this.tbpTurma.TabIndex = 2;
            this.tbpTurma.Text = "Turma";
            this.tbpTurma.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(597, 202);
            this.dataGridView2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.Location = new System.Drawing.Point(574, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.TabIndex = 16;
            this.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Location = new System.Drawing.Point(605, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(25, 25);
            this.btnSair.TabIndex = 15;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnConfigurar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfigurar.BackgroundImage")));
            this.btnConfigurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfigurar.Location = new System.Drawing.Point(543, 12);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(25, 25);
            this.btnConfigurar.TabIndex = 17;
            this.btnConfigurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfigurar.UseVisualStyleBackColor = false;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // tb_alunoTableAdapter
            // 
            this.tb_alunoTableAdapter.ClearBeforeFill = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(642, 557);
            this.Controls.Add(this.btnConfigurar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbpAula.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            this.tbpAluno.ResumeLayout(false);
            this.tbpAluno.PerformLayout();
            this.gpbResultadoAluno.ResumeLayout(false);
            this.gpbResultadoAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbalunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unip_salaDataSet4)).EndInit();
            this.tbpTurma.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpAula;
        private System.Windows.Forms.TabPage tbpAluno;
        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tbpTurma;
        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnConfigurar;
        private unip_salaDataSet4 unip_salaDataSet4;
        private System.Windows.Forms.BindingSource tbalunoBindingSource;
        private unip_salaDataSet4TableAdapters.tb_alunoTableAdapter tb_alunoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raAlunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAlunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusAlunoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.GroupBox gpbResultadoAluno;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txbPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Button btnEditarAluno;
        private System.Windows.Forms.Button btnCadastrarAluno;
        private System.Windows.Forms.Label lblNomeAluno;
        private System.Windows.Forms.Label lblRaAlunoResultado;
        private System.Windows.Forms.Label lblRaAluno;
        private System.Windows.Forms.Label lblIdAlunoResultado;
        private System.Windows.Forms.Label lblIdAluno;
        private System.Windows.Forms.Label lblStatusAlunoResultado;
        private System.Windows.Forms.Label lblStatusAluno;
        private System.Windows.Forms.Label lblNomeAlunoResultado;
    }
}
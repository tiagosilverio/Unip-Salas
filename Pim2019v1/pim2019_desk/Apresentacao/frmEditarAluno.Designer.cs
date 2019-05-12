namespace pim2019_desk.Apresentacao
{
    partial class frmEditarAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarAluno));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnEditarAluno = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluirAluno = new System.Windows.Forms.Button();
            this.txbIdAlunoEditar = new System.Windows.Forms.TextBox();
            this.lblIdAluno = new System.Windows.Forms.Label();
            this.lblRaAluno = new System.Windows.Forms.Label();
            this.txbRaAlunoEditar = new System.Windows.Forms.TextBox();
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.txbNomeAlunoEditar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbMatriculado = new System.Windows.Forms.RadioButton();
            this.rdbNaoMatriculado = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lblNomeAluno);
            this.panel1.Controls.Add(this.txbNomeAlunoEditar);
            this.panel1.Controls.Add(this.lblRaAluno);
            this.panel1.Controls.Add(this.txbRaAlunoEditar);
            this.panel1.Controls.Add(this.lblIdAluno);
            this.panel1.Controls.Add(this.txbIdAlunoEditar);
            this.panel1.Controls.Add(this.btnExcluirAluno);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnEditarAluno);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 269);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editar Aluno";
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Location = new System.Drawing.Point(384, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 25);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnEditarAluno
            // 
            this.btnEditarAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarAluno.Image")));
            this.btnEditarAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarAluno.Location = new System.Drawing.Point(322, 229);
            this.btnEditarAluno.Name = "btnEditarAluno";
            this.btnEditarAluno.Size = new System.Drawing.Size(87, 37);
            this.btnEditarAluno.TabIndex = 2;
            this.btnEditarAluno.Text = "Salvar";
            this.btnEditarAluno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarAluno.UseVisualStyleBackColor = true;
            this.btnEditarAluno.Click += new System.EventHandler(this.btnEditarAluno_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(220, 229);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 37);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluirAluno
            // 
            this.btnExcluirAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirAluno.Image")));
            this.btnExcluirAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirAluno.Location = new System.Drawing.Point(3, 229);
            this.btnExcluirAluno.Name = "btnExcluirAluno";
            this.btnExcluirAluno.Size = new System.Drawing.Size(87, 37);
            this.btnExcluirAluno.TabIndex = 4;
            this.btnExcluirAluno.Text = "Excluir";
            this.btnExcluirAluno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirAluno.UseVisualStyleBackColor = true;
            this.btnExcluirAluno.Click += new System.EventHandler(this.btnExcluirAluno_Click);
            // 
            // txbIdAlunoEditar
            // 
            this.txbIdAlunoEditar.Enabled = false;
            this.txbIdAlunoEditar.Location = new System.Drawing.Point(21, 70);
            this.txbIdAlunoEditar.Name = "txbIdAlunoEditar";
            this.txbIdAlunoEditar.ReadOnly = true;
            this.txbIdAlunoEditar.Size = new System.Drawing.Size(86, 20);
            this.txbIdAlunoEditar.TabIndex = 5;
            // 
            // lblIdAluno
            // 
            this.lblIdAluno.AutoSize = true;
            this.lblIdAluno.Location = new System.Drawing.Point(18, 53);
            this.lblIdAluno.Name = "lblIdAluno";
            this.lblIdAluno.Size = new System.Drawing.Size(18, 13);
            this.lblIdAluno.TabIndex = 6;
            this.lblIdAluno.Text = "ID";
            // 
            // lblRaAluno
            // 
            this.lblRaAluno.AutoSize = true;
            this.lblRaAluno.Location = new System.Drawing.Point(134, 54);
            this.lblRaAluno.Name = "lblRaAluno";
            this.lblRaAluno.Size = new System.Drawing.Size(22, 13);
            this.lblRaAluno.TabIndex = 8;
            this.lblRaAluno.Text = "RA";
            // 
            // txbRaAlunoEditar
            // 
            this.txbRaAlunoEditar.Location = new System.Drawing.Point(137, 70);
            this.txbRaAlunoEditar.Name = "txbRaAlunoEditar";
            this.txbRaAlunoEditar.Size = new System.Drawing.Size(86, 20);
            this.txbRaAlunoEditar.TabIndex = 7;
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.Location = new System.Drawing.Point(18, 101);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(35, 13);
            this.lblNomeAluno.TabIndex = 10;
            this.lblNomeAluno.Text = "Nome";
            // 
            // txbNomeAlunoEditar
            // 
            this.txbNomeAlunoEditar.Location = new System.Drawing.Point(21, 118);
            this.txbNomeAlunoEditar.Name = "txbNomeAlunoEditar";
            this.txbNomeAlunoEditar.Size = new System.Drawing.Size(371, 20);
            this.txbNomeAlunoEditar.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbNaoMatriculado);
            this.groupBox1.Controls.Add(this.rdbMatriculado);
            this.groupBox1.Location = new System.Drawing.Point(89, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 60);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // rdbMatriculado
            // 
            this.rdbMatriculado.AutoSize = true;
            this.rdbMatriculado.Location = new System.Drawing.Point(6, 28);
            this.rdbMatriculado.Name = "rdbMatriculado";
            this.rdbMatriculado.Size = new System.Drawing.Size(80, 17);
            this.rdbMatriculado.TabIndex = 0;
            this.rdbMatriculado.TabStop = true;
            this.rdbMatriculado.Text = "Matriculado";
            this.rdbMatriculado.UseVisualStyleBackColor = true;
            // 
            // rdbNaoMatriculado
            // 
            this.rdbNaoMatriculado.AutoSize = true;
            this.rdbNaoMatriculado.Location = new System.Drawing.Point(112, 28);
            this.rdbNaoMatriculado.Name = "rdbNaoMatriculado";
            this.rdbNaoMatriculado.Size = new System.Drawing.Size(103, 17);
            this.rdbNaoMatriculado.TabIndex = 1;
            this.rdbNaoMatriculado.TabStop = true;
            this.rdbNaoMatriculado.Text = "Não Matriculado";
            this.rdbNaoMatriculado.UseVisualStyleBackColor = true;
            // 
            // frmEditarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(436, 293);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditarAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditarAluno";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExcluirAluno;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditarAluno;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNomeAluno;
        private System.Windows.Forms.Label lblRaAluno;
        private System.Windows.Forms.Label lblIdAluno;
        public System.Windows.Forms.TextBox txbNomeAlunoEditar;
        public System.Windows.Forms.TextBox txbRaAlunoEditar;
        public System.Windows.Forms.TextBox txbIdAlunoEditar;
        public System.Windows.Forms.RadioButton rdbNaoMatriculado;
        public System.Windows.Forms.RadioButton rdbMatriculado;
    }
}
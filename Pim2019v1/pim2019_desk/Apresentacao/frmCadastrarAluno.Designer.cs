namespace pim2019_desk.Apresentacao
{
    partial class frmCadastrarAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarAluno));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txbRaAluno = new System.Windows.Forms.TextBox();
            this.txbNomeAluno = new System.Windows.Forms.TextBox();
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.gpbStatusAluno = new System.Windows.Forms.GroupBox();
            this.rdbMatriculado = new System.Windows.Forms.RadioButton();
            this.rdbNaoMatriculado = new System.Windows.Forms.RadioButton();
            this.lblRaAluno = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gpbStatusAluno.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.gpbStatusAluno);
            this.panel1.Controls.Add(this.txbNomeAluno);
            this.panel1.Controls.Add(this.lblNomeAluno);
            this.panel1.Controls.Add(this.txbRaAluno);
            this.panel1.Controls.Add(this.lblRaAluno);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnCadastrarAluno);
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
            this.label1.Size = new System.Drawing.Size(131, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novo Aluno";
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
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarAluno.Image")));
            this.btnCadastrarAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarAluno.Location = new System.Drawing.Point(322, 229);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(87, 37);
            this.btnCadastrarAluno.TabIndex = 2;
            this.btnCadastrarAluno.Text = "Salvar";
            this.btnCadastrarAluno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrarAluno.UseVisualStyleBackColor = true;
            this.btnCadastrarAluno.Click += new System.EventHandler(this.btnCadastrarAluno_Click);
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
            // txbRaAluno
            // 
            this.txbRaAluno.Location = new System.Drawing.Point(21, 70);
            this.txbRaAluno.Name = "txbRaAluno";
            this.txbRaAluno.Size = new System.Drawing.Size(86, 20);
            this.txbRaAluno.TabIndex = 5;
            // 
            // txbNomeAluno
            // 
            this.txbNomeAluno.Location = new System.Drawing.Point(21, 118);
            this.txbNomeAluno.Name = "txbNomeAluno";
            this.txbNomeAluno.Size = new System.Drawing.Size(371, 20);
            this.txbNomeAluno.TabIndex = 7;
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.Location = new System.Drawing.Point(18, 101);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(35, 13);
            this.lblNomeAluno.TabIndex = 6;
            this.lblNomeAluno.Text = "Nome";
            // 
            // gpbStatusAluno
            // 
            this.gpbStatusAluno.Controls.Add(this.rdbNaoMatriculado);
            this.gpbStatusAluno.Controls.Add(this.rdbMatriculado);
            this.gpbStatusAluno.Location = new System.Drawing.Point(89, 153);
            this.gpbStatusAluno.Name = "gpbStatusAluno";
            this.gpbStatusAluno.Size = new System.Drawing.Size(227, 60);
            this.gpbStatusAluno.TabIndex = 8;
            this.gpbStatusAluno.TabStop = false;
            this.gpbStatusAluno.Text = "Status";
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
            // lblRaAluno
            // 
            this.lblRaAluno.AutoSize = true;
            this.lblRaAluno.Location = new System.Drawing.Point(18, 53);
            this.lblRaAluno.Name = "lblRaAluno";
            this.lblRaAluno.Size = new System.Drawing.Size(22, 13);
            this.lblRaAluno.TabIndex = 4;
            this.lblRaAluno.Text = "RA";
            // 
            // frmCadastrarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(436, 293);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastrarAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastrarAluno";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpbStatusAluno.ResumeLayout(false);
            this.gpbStatusAluno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbNomeAluno;
        private System.Windows.Forms.Label lblNomeAluno;
        private System.Windows.Forms.TextBox txbRaAluno;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrarAluno;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbStatusAluno;
        private System.Windows.Forms.RadioButton rdbNaoMatriculado;
        private System.Windows.Forms.RadioButton rdbMatriculado;
        private System.Windows.Forms.Label lblRaAluno;
    }
}
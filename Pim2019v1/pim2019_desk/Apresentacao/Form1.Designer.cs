namespace pim2019_desk
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCampus = new System.Windows.Forms.Button();
            this.btnCurso = new System.Windows.Forms.Button();
            this.btnTurma = new System.Windows.Forms.Button();
            this.btnSala = new System.Windows.Forms.Button();
            this.btnAluno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCampus
            // 
            this.btnCampus.Location = new System.Drawing.Point(29, 112);
            this.btnCampus.Name = "btnCampus";
            this.btnCampus.Size = new System.Drawing.Size(115, 56);
            this.btnCampus.TabIndex = 0;
            this.btnCampus.Text = "Campus";
            this.btnCampus.UseVisualStyleBackColor = true;
            this.btnCampus.Click += new System.EventHandler(this.btnCampus_Click);
            // 
            // btnCurso
            // 
            this.btnCurso.Location = new System.Drawing.Point(150, 112);
            this.btnCurso.Name = "btnCurso";
            this.btnCurso.Size = new System.Drawing.Size(115, 56);
            this.btnCurso.TabIndex = 1;
            this.btnCurso.Text = "Curso";
            this.btnCurso.UseVisualStyleBackColor = true;
            // 
            // btnTurma
            // 
            this.btnTurma.Location = new System.Drawing.Point(271, 112);
            this.btnTurma.Name = "btnTurma";
            this.btnTurma.Size = new System.Drawing.Size(115, 56);
            this.btnTurma.TabIndex = 2;
            this.btnTurma.Text = "Turma";
            this.btnTurma.UseVisualStyleBackColor = true;
            // 
            // btnSala
            // 
            this.btnSala.Location = new System.Drawing.Point(513, 112);
            this.btnSala.Name = "btnSala";
            this.btnSala.Size = new System.Drawing.Size(115, 56);
            this.btnSala.TabIndex = 3;
            this.btnSala.Text = "Sala";
            this.btnSala.UseVisualStyleBackColor = true;
            // 
            // btnAluno
            // 
            this.btnAluno.Location = new System.Drawing.Point(392, 112);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(115, 56);
            this.btnAluno.TabIndex = 4;
            this.btnAluno.Text = "Aluno";
            this.btnAluno.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 286);
            this.Controls.Add(this.btnAluno);
            this.Controls.Add(this.btnSala);
            this.Controls.Add(this.btnTurma);
            this.Controls.Add(this.btnCurso);
            this.Controls.Add(this.btnCampus);
            this.Name = "Form1";
            this.Text = "Gerenciamento de Salas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCampus;
        private System.Windows.Forms.Button btnCurso;
        private System.Windows.Forms.Button btnTurma;
        private System.Windows.Forms.Button btnSala;
        private System.Windows.Forms.Button btnAluno;
    }
}


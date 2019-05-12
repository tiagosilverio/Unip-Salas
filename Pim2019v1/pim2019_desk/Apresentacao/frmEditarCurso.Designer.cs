namespace pim2019_desk.Apresentacao
{
    partial class frmEditarCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarCurso));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcluirCurso = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditarCurso = new System.Windows.Forms.Button();
            this.txbNomeCurso = new System.Windows.Forms.TextBox();
            this.lblNomeCurso = new System.Windows.Forms.Label();
            this.txbIdCurso = new System.Windows.Forms.TextBox();
            this.lblIdCurso = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnExcluirCurso);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnEditarCurso);
            this.panel1.Controls.Add(this.txbNomeCurso);
            this.panel1.Controls.Add(this.lblNomeCurso);
            this.panel1.Controls.Add(this.txbIdCurso);
            this.panel1.Controls.Add(this.lblIdCurso);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 226);
            this.panel1.TabIndex = 0;
            // 
            // btnExcluirCurso
            // 
            this.btnExcluirCurso.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirCurso.Image")));
            this.btnExcluirCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirCurso.Location = new System.Drawing.Point(6, 186);
            this.btnExcluirCurso.Name = "btnExcluirCurso";
            this.btnExcluirCurso.Size = new System.Drawing.Size(87, 37);
            this.btnExcluirCurso.TabIndex = 8;
            this.btnExcluirCurso.Text = "Excluir";
            this.btnExcluirCurso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirCurso.UseVisualStyleBackColor = true;
            this.btnExcluirCurso.Click += new System.EventHandler(this.btnExcluirCurso_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(177, 186);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 37);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditarCurso
            // 
            this.btnEditarCurso.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarCurso.Image")));
            this.btnEditarCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarCurso.Location = new System.Drawing.Point(280, 186);
            this.btnEditarCurso.Name = "btnEditarCurso";
            this.btnEditarCurso.Size = new System.Drawing.Size(87, 37);
            this.btnEditarCurso.TabIndex = 6;
            this.btnEditarCurso.Text = "Salvar";
            this.btnEditarCurso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarCurso.UseVisualStyleBackColor = true;
            this.btnEditarCurso.Click += new System.EventHandler(this.btnEditarCurso_Click);
            // 
            // txbNomeCurso
            // 
            this.txbNomeCurso.Location = new System.Drawing.Point(14, 114);
            this.txbNomeCurso.Name = "txbNomeCurso";
            this.txbNomeCurso.Size = new System.Drawing.Size(340, 20);
            this.txbNomeCurso.TabIndex = 5;
            // 
            // lblNomeCurso
            // 
            this.lblNomeCurso.AutoSize = true;
            this.lblNomeCurso.Location = new System.Drawing.Point(11, 98);
            this.lblNomeCurso.Name = "lblNomeCurso";
            this.lblNomeCurso.Size = new System.Drawing.Size(35, 13);
            this.lblNomeCurso.TabIndex = 4;
            this.lblNomeCurso.Text = "Nome";
            // 
            // txbIdCurso
            // 
            this.txbIdCurso.Enabled = false;
            this.txbIdCurso.Location = new System.Drawing.Point(14, 63);
            this.txbIdCurso.Name = "txbIdCurso";
            this.txbIdCurso.ReadOnly = true;
            this.txbIdCurso.Size = new System.Drawing.Size(79, 20);
            this.txbIdCurso.TabIndex = 3;
            // 
            // lblIdCurso
            // 
            this.lblIdCurso.AutoSize = true;
            this.lblIdCurso.Location = new System.Drawing.Point(11, 47);
            this.lblIdCurso.Name = "lblIdCurso";
            this.lblIdCurso.Size = new System.Drawing.Size(18, 13);
            this.lblIdCurso.TabIndex = 2;
            this.lblIdCurso.Text = "ID";
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Location = new System.Drawing.Point(342, 4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 25);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editar Curso";
            // 
            // frmEditarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(394, 250);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditarCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditarCurso";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluirCurso;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditarCurso;
        private System.Windows.Forms.Label lblNomeCurso;
        private System.Windows.Forms.Label lblIdCurso;
        public System.Windows.Forms.TextBox txbIdCurso;
        public System.Windows.Forms.TextBox txbNomeCurso;
    }
}
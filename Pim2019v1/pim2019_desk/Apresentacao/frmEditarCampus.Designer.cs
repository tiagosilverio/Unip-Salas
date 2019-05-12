namespace pim2019_desk.Apresentacao
{
    partial class frmEditarCampus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarCampus));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluirCampus = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditarCampus = new System.Windows.Forms.Button();
            this.txbNomeCampusEditar = new System.Windows.Forms.TextBox();
            this.lblNomeCampus = new System.Windows.Forms.Label();
            this.txbNumeroCampusEditar = new System.Windows.Forms.TextBox();
            this.lblNumeroCampus = new System.Windows.Forms.Label();
            this.txbIdCampusEditar = new System.Windows.Forms.TextBox();
            this.lblIDCampus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.btnExcluirCampus);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnEditarCampus);
            this.panel1.Controls.Add(this.txbNomeCampusEditar);
            this.panel1.Controls.Add(this.lblNomeCampus);
            this.panel1.Controls.Add(this.txbNumeroCampusEditar);
            this.panel1.Controls.Add(this.lblNumeroCampus);
            this.panel1.Controls.Add(this.txbIdCampusEditar);
            this.panel1.Controls.Add(this.lblIDCampus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 226);
            this.panel1.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Location = new System.Drawing.Point(342, 4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 25);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExcluirCampus
            // 
            this.btnExcluirCampus.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirCampus.Image")));
            this.btnExcluirCampus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirCampus.Location = new System.Drawing.Point(6, 186);
            this.btnExcluirCampus.Name = "btnExcluirCampus";
            this.btnExcluirCampus.Size = new System.Drawing.Size(87, 37);
            this.btnExcluirCampus.TabIndex = 9;
            this.btnExcluirCampus.Text = "Excluir";
            this.btnExcluirCampus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirCampus.UseVisualStyleBackColor = true;
            this.btnExcluirCampus.Click += new System.EventHandler(this.btnExcluirCampus_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(177, 186);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 37);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditarCampus
            // 
            this.btnEditarCampus.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarCampus.Image")));
            this.btnEditarCampus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarCampus.Location = new System.Drawing.Point(280, 186);
            this.btnEditarCampus.Name = "btnEditarCampus";
            this.btnEditarCampus.Size = new System.Drawing.Size(87, 37);
            this.btnEditarCampus.TabIndex = 7;
            this.btnEditarCampus.Text = "Salvar";
            this.btnEditarCampus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarCampus.UseVisualStyleBackColor = true;
            this.btnEditarCampus.Click += new System.EventHandler(this.btnEditarCampus_Click);
            // 
            // txbNomeCampusEditar
            // 
            this.txbNomeCampusEditar.Location = new System.Drawing.Point(14, 114);
            this.txbNomeCampusEditar.Name = "txbNomeCampusEditar";
            this.txbNomeCampusEditar.Size = new System.Drawing.Size(340, 20);
            this.txbNomeCampusEditar.TabIndex = 6;
            // 
            // lblNomeCampus
            // 
            this.lblNomeCampus.AutoSize = true;
            this.lblNomeCampus.Location = new System.Drawing.Point(11, 98);
            this.lblNomeCampus.Name = "lblNomeCampus";
            this.lblNomeCampus.Size = new System.Drawing.Size(35, 13);
            this.lblNomeCampus.TabIndex = 5;
            this.lblNomeCampus.Text = "Nome";
            // 
            // txbNumeroCampusEditar
            // 
            this.txbNumeroCampusEditar.Location = new System.Drawing.Point(109, 63);
            this.txbNumeroCampusEditar.Name = "txbNumeroCampusEditar";
            this.txbNumeroCampusEditar.Size = new System.Drawing.Size(79, 20);
            this.txbNumeroCampusEditar.TabIndex = 4;
            // 
            // lblNumeroCampus
            // 
            this.lblNumeroCampus.AutoSize = true;
            this.lblNumeroCampus.Location = new System.Drawing.Point(106, 47);
            this.lblNumeroCampus.Name = "lblNumeroCampus";
            this.lblNumeroCampus.Size = new System.Drawing.Size(44, 13);
            this.lblNumeroCampus.TabIndex = 3;
            this.lblNumeroCampus.Text = "Número";
            // 
            // txbIdCampusEditar
            // 
            this.txbIdCampusEditar.Enabled = false;
            this.txbIdCampusEditar.Location = new System.Drawing.Point(14, 63);
            this.txbIdCampusEditar.Name = "txbIdCampusEditar";
            this.txbIdCampusEditar.ReadOnly = true;
            this.txbIdCampusEditar.Size = new System.Drawing.Size(79, 20);
            this.txbIdCampusEditar.TabIndex = 2;
            // 
            // lblIDCampus
            // 
            this.lblIDCampus.AutoSize = true;
            this.lblIDCampus.Location = new System.Drawing.Point(11, 47);
            this.lblIDCampus.Name = "lblIDCampus";
            this.lblIDCampus.Size = new System.Drawing.Size(18, 13);
            this.lblIDCampus.TabIndex = 1;
            this.lblIDCampus.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editar Campus";
            // 
            // frmEditarCampus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(394, 250);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditarCampus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditarCampus";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomeCampus;
        private System.Windows.Forms.Label lblNumeroCampus;
        private System.Windows.Forms.Label lblIDCampus;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditarCampus;
        public System.Windows.Forms.TextBox txbIdCampusEditar;
        public System.Windows.Forms.TextBox txbNomeCampusEditar;
        public System.Windows.Forms.TextBox txbNumeroCampusEditar;
        private System.Windows.Forms.Button btnExcluirCampus;
        private System.Windows.Forms.Button btnFechar;
    }
}
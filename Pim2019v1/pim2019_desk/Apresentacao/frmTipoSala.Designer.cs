namespace pim2019_desk.Apresentacao
{
    partial class frmTipoSala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoSala));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gpbTipoSalaResultado = new System.Windows.Forms.GroupBox();
            this.dgvTipoSala = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNovoTipo = new System.Windows.Forms.Button();
            this.btnEditarTipo = new System.Windows.Forms.Button();
            this.lblIdTipoSala = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIdTipoSalaResultado = new System.Windows.Forms.Label();
            this.lblNomeTipoSalaResultado = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gpbTipoSalaResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoSala)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnEditarTipo);
            this.panel1.Controls.Add(this.btnNovoTipo);
            this.panel1.Controls.Add(this.gpbTipoSalaResultado);
            this.panel1.Controls.Add(this.dgvTipoSala);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 297);
            this.panel1.TabIndex = 0;
            // 
            // gpbTipoSalaResultado
            // 
            this.gpbTipoSalaResultado.Controls.Add(this.lblNomeTipoSalaResultado);
            this.gpbTipoSalaResultado.Controls.Add(this.lblIdTipoSalaResultado);
            this.gpbTipoSalaResultado.Controls.Add(this.label3);
            this.gpbTipoSalaResultado.Controls.Add(this.lblIdTipoSala);
            this.gpbTipoSalaResultado.Location = new System.Drawing.Point(65, 145);
            this.gpbTipoSalaResultado.Name = "gpbTipoSalaResultado";
            this.gpbTipoSalaResultado.Size = new System.Drawing.Size(259, 99);
            this.gpbTipoSalaResultado.TabIndex = 3;
            this.gpbTipoSalaResultado.TabStop = false;
            // 
            // dgvTipoSala
            // 
            this.dgvTipoSala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoSala.Location = new System.Drawing.Point(3, 48);
            this.dgvTipoSala.Name = "dgvTipoSala";
            this.dgvTipoSala.Size = new System.Drawing.Size(378, 91);
            this.dgvTipoSala.TabIndex = 2;
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Location = new System.Drawing.Point(356, 3);
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
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Sala";
            // 
            // btnNovoTipo
            // 
            this.btnNovoTipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovoTipo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoTipo.Image")));
            this.btnNovoTipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoTipo.Location = new System.Drawing.Point(3, 257);
            this.btnNovoTipo.Name = "btnNovoTipo";
            this.btnNovoTipo.Size = new System.Drawing.Size(92, 37);
            this.btnNovoTipo.TabIndex = 4;
            this.btnNovoTipo.Text = "Novo Tipo";
            this.btnNovoTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoTipo.UseVisualStyleBackColor = true;
            this.btnNovoTipo.Click += new System.EventHandler(this.btnNovoTipo_Click);
            // 
            // btnEditarTipo
            // 
            this.btnEditarTipo.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarTipo.Image")));
            this.btnEditarTipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarTipo.Location = new System.Drawing.Point(289, 257);
            this.btnEditarTipo.Name = "btnEditarTipo";
            this.btnEditarTipo.Size = new System.Drawing.Size(92, 37);
            this.btnEditarTipo.TabIndex = 5;
            this.btnEditarTipo.Text = "Editar Tipo";
            this.btnEditarTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarTipo.UseVisualStyleBackColor = true;
            this.btnEditarTipo.Click += new System.EventHandler(this.btnEditarTipo_Click);
            // 
            // lblIdTipoSala
            // 
            this.lblIdTipoSala.AutoSize = true;
            this.lblIdTipoSala.Location = new System.Drawing.Point(61, 33);
            this.lblIdTipoSala.Name = "lblIdTipoSala";
            this.lblIdTipoSala.Size = new System.Drawing.Size(21, 13);
            this.lblIdTipoSala.TabIndex = 0;
            this.lblIdTipoSala.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo de Sala:";
            // 
            // lblIdTipoSalaResultado
            // 
            this.lblIdTipoSalaResultado.AutoSize = true;
            this.lblIdTipoSalaResultado.Location = new System.Drawing.Point(88, 33);
            this.lblIdTipoSalaResultado.Name = "lblIdTipoSalaResultado";
            this.lblIdTipoSalaResultado.Size = new System.Drawing.Size(10, 13);
            this.lblIdTipoSalaResultado.TabIndex = 2;
            this.lblIdTipoSalaResultado.Text = "-";
            // 
            // lblNomeTipoSalaResultado
            // 
            this.lblNomeTipoSalaResultado.AutoSize = true;
            this.lblNomeTipoSalaResultado.Location = new System.Drawing.Point(88, 61);
            this.lblNomeTipoSalaResultado.Name = "lblNomeTipoSalaResultado";
            this.lblNomeTipoSalaResultado.Size = new System.Drawing.Size(10, 13);
            this.lblNomeTipoSalaResultado.TabIndex = 3;
            this.lblNomeTipoSalaResultado.Text = "-";
            // 
            // frmTipoSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(408, 321);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTipoSala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTipoSala";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpbTipoSalaResultado.ResumeLayout(false);
            this.gpbTipoSalaResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoSala)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTipoSala;
        private System.Windows.Forms.GroupBox gpbTipoSalaResultado;
        private System.Windows.Forms.Button btnEditarTipo;
        private System.Windows.Forms.Button btnNovoTipo;
        private System.Windows.Forms.Label lblNomeTipoSalaResultado;
        private System.Windows.Forms.Label lblIdTipoSalaResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIdTipoSala;
    }
}
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoSala));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditarTipo = new System.Windows.Forms.Button();
            this.btnNovoTipo = new System.Windows.Forms.Button();
            this.gpbTipoSalaResultado = new System.Windows.Forms.GroupBox();
            this.lblNomeTipoSalaResultado = new System.Windows.Forms.Label();
            this.lblIdTipoSalaResultado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIdTipoSala = new System.Windows.Forms.Label();
            this.dgvTipoSala = new System.Windows.Forms.DataGridView();
            this.idTipoSalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeTipoSalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbtiposalaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unip_salaDataSet7 = new pim2019_desk.unip_salaDataSet7();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_tipo_salaTableAdapter = new pim2019_desk.unip_salaDataSet7TableAdapters.tb_tipo_salaTableAdapter();
            this.panel1.SuspendLayout();
            this.gpbTipoSalaResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoSala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbtiposalaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unip_salaDataSet7)).BeginInit();
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
            // lblNomeTipoSalaResultado
            // 
            this.lblNomeTipoSalaResultado.AutoSize = true;
            this.lblNomeTipoSalaResultado.Location = new System.Drawing.Point(88, 61);
            this.lblNomeTipoSalaResultado.Name = "lblNomeTipoSalaResultado";
            this.lblNomeTipoSalaResultado.Size = new System.Drawing.Size(10, 13);
            this.lblNomeTipoSalaResultado.TabIndex = 3;
            this.lblNomeTipoSalaResultado.Text = "-";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo de Sala:";
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
            // dgvTipoSala
            // 
            this.dgvTipoSala.AllowUserToAddRows = false;
            this.dgvTipoSala.AllowUserToDeleteRows = false;
            this.dgvTipoSala.AllowUserToResizeColumns = false;
            this.dgvTipoSala.AllowUserToResizeRows = false;
            this.dgvTipoSala.AutoGenerateColumns = false;
            this.dgvTipoSala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoSala.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTipoSalaDataGridViewTextBoxColumn,
            this.nomeTipoSalaDataGridViewTextBoxColumn});
            this.dgvTipoSala.DataSource = this.tbtiposalaBindingSource;
            this.dgvTipoSala.Location = new System.Drawing.Point(3, 48);
            this.dgvTipoSala.MultiSelect = false;
            this.dgvTipoSala.Name = "dgvTipoSala";
            this.dgvTipoSala.ReadOnly = true;
            this.dgvTipoSala.Size = new System.Drawing.Size(378, 91);
            this.dgvTipoSala.TabIndex = 2;
            this.dgvTipoSala.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoSala_CellEnter);
            // 
            // idTipoSalaDataGridViewTextBoxColumn
            // 
            this.idTipoSalaDataGridViewTextBoxColumn.DataPropertyName = "idTipoSala";
            this.idTipoSalaDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idTipoSalaDataGridViewTextBoxColumn.Name = "idTipoSalaDataGridViewTextBoxColumn";
            this.idTipoSalaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTipoSalaDataGridViewTextBoxColumn.Width = 60;
            // 
            // nomeTipoSalaDataGridViewTextBoxColumn
            // 
            this.nomeTipoSalaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeTipoSalaDataGridViewTextBoxColumn.DataPropertyName = "nomeTipoSala";
            this.nomeTipoSalaDataGridViewTextBoxColumn.HeaderText = "Tipo de Sala";
            this.nomeTipoSalaDataGridViewTextBoxColumn.Name = "nomeTipoSalaDataGridViewTextBoxColumn";
            this.nomeTipoSalaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tbtiposalaBindingSource
            // 
            this.tbtiposalaBindingSource.DataMember = "tb_tipo_sala";
            this.tbtiposalaBindingSource.DataSource = this.unip_salaDataSet7;
            // 
            // unip_salaDataSet7
            // 
            this.unip_salaDataSet7.DataSetName = "unip_salaDataSet7";
            this.unip_salaDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tb_tipo_salaTableAdapter
            // 
            this.tb_tipo_salaTableAdapter.ClearBeforeFill = true;
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
            this.Load += new System.EventHandler(this.frmTipoSala_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpbTipoSalaResultado.ResumeLayout(false);
            this.gpbTipoSalaResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoSala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbtiposalaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unip_salaDataSet7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbTipoSalaResultado;
        private System.Windows.Forms.Button btnEditarTipo;
        private System.Windows.Forms.Button btnNovoTipo;
        private System.Windows.Forms.Label lblNomeTipoSalaResultado;
        private System.Windows.Forms.Label lblIdTipoSalaResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIdTipoSala;
        private unip_salaDataSet7 unip_salaDataSet7;
        private System.Windows.Forms.BindingSource tbtiposalaBindingSource;
        private unip_salaDataSet7TableAdapters.tb_tipo_salaTableAdapter tb_tipo_salaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoSalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeTipoSalaDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dgvTipoSala;
    }
}
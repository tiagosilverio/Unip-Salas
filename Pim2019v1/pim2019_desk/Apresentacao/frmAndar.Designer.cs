﻿namespace pim2019_desk.Apresentacao
{
    partial class frmAndar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAndar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gpbAndar = new System.Windows.Forms.GroupBox();
            this.lblNomeAndarResultado = new System.Windows.Forms.Label();
            this.lblIdAndarResultado = new System.Windows.Forms.Label();
            this.lblNomeAndar = new System.Windows.Forms.Label();
            this.lblIdAndar = new System.Windows.Forms.Label();
            this.btnEditarAndar = new System.Windows.Forms.Button();
            this.btnNovoAndar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAndar = new System.Windows.Forms.DataGridView();
            this.idAndarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAndarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbandarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unip_salaDataSet6 = new pim2019_desk.unip_salaDataSet6();
            this.tb_andarTableAdapter = new pim2019_desk.unip_salaDataSet6TableAdapters.tb_andarTableAdapter();
            this.panel1.SuspendLayout();
            this.gpbAndar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAndar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbandarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unip_salaDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.gpbAndar);
            this.panel1.Controls.Add(this.btnEditarAndar);
            this.panel1.Controls.Add(this.btnNovoAndar);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvAndar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 297);
            this.panel1.TabIndex = 0;
            // 
            // gpbAndar
            // 
            this.gpbAndar.Controls.Add(this.lblNomeAndarResultado);
            this.gpbAndar.Controls.Add(this.lblIdAndarResultado);
            this.gpbAndar.Controls.Add(this.lblNomeAndar);
            this.gpbAndar.Controls.Add(this.lblIdAndar);
            this.gpbAndar.Location = new System.Drawing.Point(65, 145);
            this.gpbAndar.Name = "gpbAndar";
            this.gpbAndar.Size = new System.Drawing.Size(259, 99);
            this.gpbAndar.TabIndex = 5;
            this.gpbAndar.TabStop = false;
            // 
            // lblNomeAndarResultado
            // 
            this.lblNomeAndarResultado.AutoSize = true;
            this.lblNomeAndarResultado.Location = new System.Drawing.Point(88, 61);
            this.lblNomeAndarResultado.Name = "lblNomeAndarResultado";
            this.lblNomeAndarResultado.Size = new System.Drawing.Size(10, 13);
            this.lblNomeAndarResultado.TabIndex = 3;
            this.lblNomeAndarResultado.Text = "-";
            // 
            // lblIdAndarResultado
            // 
            this.lblIdAndarResultado.AutoSize = true;
            this.lblIdAndarResultado.Location = new System.Drawing.Point(88, 33);
            this.lblIdAndarResultado.Name = "lblIdAndarResultado";
            this.lblIdAndarResultado.Size = new System.Drawing.Size(10, 13);
            this.lblIdAndarResultado.TabIndex = 2;
            this.lblIdAndarResultado.Text = "-";
            // 
            // lblNomeAndar
            // 
            this.lblNomeAndar.AutoSize = true;
            this.lblNomeAndar.Location = new System.Drawing.Point(44, 61);
            this.lblNomeAndar.Name = "lblNomeAndar";
            this.lblNomeAndar.Size = new System.Drawing.Size(38, 13);
            this.lblNomeAndar.TabIndex = 1;
            this.lblNomeAndar.Text = "Andar:";
            // 
            // lblIdAndar
            // 
            this.lblIdAndar.AutoSize = true;
            this.lblIdAndar.Location = new System.Drawing.Point(61, 33);
            this.lblIdAndar.Name = "lblIdAndar";
            this.lblIdAndar.Size = new System.Drawing.Size(21, 13);
            this.lblIdAndar.TabIndex = 0;
            this.lblIdAndar.Text = "ID:";
            // 
            // btnEditarAndar
            // 
            this.btnEditarAndar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarAndar.Image")));
            this.btnEditarAndar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarAndar.Location = new System.Drawing.Point(282, 257);
            this.btnEditarAndar.Name = "btnEditarAndar";
            this.btnEditarAndar.Size = new System.Drawing.Size(99, 37);
            this.btnEditarAndar.TabIndex = 4;
            this.btnEditarAndar.Text = "Editar Andar";
            this.btnEditarAndar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarAndar.UseVisualStyleBackColor = true;
            this.btnEditarAndar.Click += new System.EventHandler(this.btnEditarAndar_Click);
            // 
            // btnNovoAndar
            // 
            this.btnNovoAndar.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoAndar.Image")));
            this.btnNovoAndar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoAndar.Location = new System.Drawing.Point(3, 257);
            this.btnNovoAndar.Name = "btnNovoAndar";
            this.btnNovoAndar.Size = new System.Drawing.Size(99, 37);
            this.btnNovoAndar.TabIndex = 3;
            this.btnNovoAndar.Text = "Novo Andar";
            this.btnNovoAndar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoAndar.UseVisualStyleBackColor = true;
            this.btnNovoAndar.Click += new System.EventHandler(this.btnNovoAndar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Location = new System.Drawing.Point(356, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 25);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Andar";
            // 
            // dgvAndar
            // 
            this.dgvAndar.AllowUserToAddRows = false;
            this.dgvAndar.AllowUserToDeleteRows = false;
            this.dgvAndar.AllowUserToResizeColumns = false;
            this.dgvAndar.AllowUserToResizeRows = false;
            this.dgvAndar.AutoGenerateColumns = false;
            this.dgvAndar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAndar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAndarDataGridViewTextBoxColumn,
            this.nomeAndarDataGridViewTextBoxColumn});
            this.dgvAndar.DataSource = this.tbandarBindingSource;
            this.dgvAndar.Location = new System.Drawing.Point(3, 48);
            this.dgvAndar.MultiSelect = false;
            this.dgvAndar.Name = "dgvAndar";
            this.dgvAndar.ReadOnly = true;
            this.dgvAndar.Size = new System.Drawing.Size(378, 91);
            this.dgvAndar.TabIndex = 0;
            this.dgvAndar.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAndar_CellEnter);
            // 
            // idAndarDataGridViewTextBoxColumn
            // 
            this.idAndarDataGridViewTextBoxColumn.DataPropertyName = "idAndar";
            this.idAndarDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idAndarDataGridViewTextBoxColumn.Name = "idAndarDataGridViewTextBoxColumn";
            this.idAndarDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAndarDataGridViewTextBoxColumn.Width = 60;
            // 
            // nomeAndarDataGridViewTextBoxColumn
            // 
            this.nomeAndarDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeAndarDataGridViewTextBoxColumn.DataPropertyName = "nomeAndar";
            this.nomeAndarDataGridViewTextBoxColumn.HeaderText = "Andar";
            this.nomeAndarDataGridViewTextBoxColumn.Name = "nomeAndarDataGridViewTextBoxColumn";
            this.nomeAndarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tbandarBindingSource
            // 
            this.tbandarBindingSource.DataMember = "tb_andar";
            this.tbandarBindingSource.DataSource = this.unip_salaDataSet6;
            // 
            // unip_salaDataSet6
            // 
            this.unip_salaDataSet6.DataSetName = "unip_salaDataSet6";
            this.unip_salaDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_andarTableAdapter
            // 
            this.tb_andarTableAdapter.ClearBeforeFill = true;
            // 
            // frmAndar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(408, 321);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAndar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAndar";
            this.Load += new System.EventHandler(this.frmAndar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpbAndar.ResumeLayout(false);
            this.gpbAndar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAndar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbandarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unip_salaDataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gpbAndar;
        private System.Windows.Forms.Label lblNomeAndarResultado;
        private System.Windows.Forms.Label lblIdAndarResultado;
        private System.Windows.Forms.Label lblNomeAndar;
        private System.Windows.Forms.Label lblIdAndar;
        private System.Windows.Forms.Button btnEditarAndar;
        private System.Windows.Forms.Button btnNovoAndar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label1;
        private unip_salaDataSet6 unip_salaDataSet6;
        private System.Windows.Forms.BindingSource tbandarBindingSource;
        private unip_salaDataSet6TableAdapters.tb_andarTableAdapter tb_andarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAndarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAndarDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dgvAndar;
    }
}
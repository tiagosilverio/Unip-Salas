namespace pim2019_desk.Apresentacao
{
    partial class frmAlfabeto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlfabeto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditarAlfabeto = new System.Windows.Forms.Button();
            this.btnNovoAlfabeto = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.dgvAlfabeto = new System.Windows.Forms.DataGridView();
            this.tbalfabetoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unip_salaDataSet5 = new pim2019_desk.unip_salaDataSet5();
            this.gpbAlfabetoResultado = new System.Windows.Forms.GroupBox();
            this.lblNomeAlfabetoResultado = new System.Windows.Forms.Label();
            this.lblIdAlfabetoResultado = new System.Windows.Forms.Label();
            this.lblNomeAlfabeto = new System.Windows.Forms.Label();
            this.lblIdAlfabeto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_alfabetoTableAdapter = new pim2019_desk.unip_salaDataSet5TableAdapters.tb_alfabetoTableAdapter();
            this.idAlfabetoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAlfabetoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlfabeto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbalfabetoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unip_salaDataSet5)).BeginInit();
            this.gpbAlfabetoResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnEditarAlfabeto);
            this.panel1.Controls.Add(this.btnNovoAlfabeto);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.dgvAlfabeto);
            this.panel1.Controls.Add(this.gpbAlfabetoResultado);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 297);
            this.panel1.TabIndex = 0;
            // 
            // btnEditarAlfabeto
            // 
            this.btnEditarAlfabeto.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarAlfabeto.Image")));
            this.btnEditarAlfabeto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarAlfabeto.Location = new System.Drawing.Point(262, 257);
            this.btnEditarAlfabeto.Name = "btnEditarAlfabeto";
            this.btnEditarAlfabeto.Size = new System.Drawing.Size(119, 37);
            this.btnEditarAlfabeto.TabIndex = 5;
            this.btnEditarAlfabeto.Text = "Editar Caractere";
            this.btnEditarAlfabeto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarAlfabeto.UseVisualStyleBackColor = true;
            this.btnEditarAlfabeto.Click += new System.EventHandler(this.btnEditarAlfabeto_Click);
            // 
            // btnNovoAlfabeto
            // 
            this.btnNovoAlfabeto.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoAlfabeto.Image")));
            this.btnNovoAlfabeto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoAlfabeto.Location = new System.Drawing.Point(3, 257);
            this.btnNovoAlfabeto.Name = "btnNovoAlfabeto";
            this.btnNovoAlfabeto.Size = new System.Drawing.Size(119, 37);
            this.btnNovoAlfabeto.TabIndex = 4;
            this.btnNovoAlfabeto.Text = "Novo Caractere";
            this.btnNovoAlfabeto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoAlfabeto.UseVisualStyleBackColor = true;
            this.btnNovoAlfabeto.Click += new System.EventHandler(this.btnNovoAlfabeto_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Location = new System.Drawing.Point(356, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 25);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // dgvAlfabeto
            // 
            this.dgvAlfabeto.AllowUserToAddRows = false;
            this.dgvAlfabeto.AllowUserToDeleteRows = false;
            this.dgvAlfabeto.AllowUserToResizeColumns = false;
            this.dgvAlfabeto.AllowUserToResizeRows = false;
            this.dgvAlfabeto.AutoGenerateColumns = false;
            this.dgvAlfabeto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlfabeto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlfabetoDataGridViewTextBoxColumn,
            this.nomeAlfabetoDataGridViewTextBoxColumn});
            this.dgvAlfabeto.DataSource = this.tbalfabetoBindingSource;
            this.dgvAlfabeto.Location = new System.Drawing.Point(3, 48);
            this.dgvAlfabeto.MultiSelect = false;
            this.dgvAlfabeto.Name = "dgvAlfabeto";
            this.dgvAlfabeto.ReadOnly = true;
            this.dgvAlfabeto.Size = new System.Drawing.Size(378, 91);
            this.dgvAlfabeto.TabIndex = 2;
            this.dgvAlfabeto.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlfabeto_CellEnter);
            // 
            // tbalfabetoBindingSource
            // 
            this.tbalfabetoBindingSource.DataMember = "tb_alfabeto";
            this.tbalfabetoBindingSource.DataSource = this.unip_salaDataSet5;
            // 
            // unip_salaDataSet5
            // 
            this.unip_salaDataSet5.DataSetName = "unip_salaDataSet5";
            this.unip_salaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gpbAlfabetoResultado
            // 
            this.gpbAlfabetoResultado.Controls.Add(this.lblNomeAlfabetoResultado);
            this.gpbAlfabetoResultado.Controls.Add(this.lblIdAlfabetoResultado);
            this.gpbAlfabetoResultado.Controls.Add(this.lblNomeAlfabeto);
            this.gpbAlfabetoResultado.Controls.Add(this.lblIdAlfabeto);
            this.gpbAlfabetoResultado.Location = new System.Drawing.Point(65, 145);
            this.gpbAlfabetoResultado.Name = "gpbAlfabetoResultado";
            this.gpbAlfabetoResultado.Size = new System.Drawing.Size(259, 99);
            this.gpbAlfabetoResultado.TabIndex = 1;
            this.gpbAlfabetoResultado.TabStop = false;
            // 
            // lblNomeAlfabetoResultado
            // 
            this.lblNomeAlfabetoResultado.AutoSize = true;
            this.lblNomeAlfabetoResultado.Location = new System.Drawing.Point(88, 61);
            this.lblNomeAlfabetoResultado.Name = "lblNomeAlfabetoResultado";
            this.lblNomeAlfabetoResultado.Size = new System.Drawing.Size(10, 13);
            this.lblNomeAlfabetoResultado.TabIndex = 3;
            this.lblNomeAlfabetoResultado.Text = "-";
            // 
            // lblIdAlfabetoResultado
            // 
            this.lblIdAlfabetoResultado.AutoSize = true;
            this.lblIdAlfabetoResultado.Location = new System.Drawing.Point(88, 33);
            this.lblIdAlfabetoResultado.Name = "lblIdAlfabetoResultado";
            this.lblIdAlfabetoResultado.Size = new System.Drawing.Size(10, 13);
            this.lblIdAlfabetoResultado.TabIndex = 2;
            this.lblIdAlfabetoResultado.Text = "-";
            // 
            // lblNomeAlfabeto
            // 
            this.lblNomeAlfabeto.AutoSize = true;
            this.lblNomeAlfabeto.Location = new System.Drawing.Point(26, 61);
            this.lblNomeAlfabeto.Name = "lblNomeAlfabeto";
            this.lblNomeAlfabeto.Size = new System.Drawing.Size(56, 13);
            this.lblNomeAlfabeto.TabIndex = 1;
            this.lblNomeAlfabeto.Text = "Caractere:";
            // 
            // lblIdAlfabeto
            // 
            this.lblIdAlfabeto.AutoSize = true;
            this.lblIdAlfabeto.Location = new System.Drawing.Point(61, 33);
            this.lblIdAlfabeto.Name = "lblIdAlfabeto";
            this.lblIdAlfabeto.Size = new System.Drawing.Size(21, 13);
            this.lblIdAlfabeto.TabIndex = 0;
            this.lblIdAlfabeto.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caracteres";
            // 
            // tb_alfabetoTableAdapter
            // 
            this.tb_alfabetoTableAdapter.ClearBeforeFill = true;
            // 
            // idAlfabetoDataGridViewTextBoxColumn
            // 
            this.idAlfabetoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idAlfabetoDataGridViewTextBoxColumn.DataPropertyName = "idAlfabeto";
            this.idAlfabetoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idAlfabetoDataGridViewTextBoxColumn.MinimumWidth = 60;
            this.idAlfabetoDataGridViewTextBoxColumn.Name = "idAlfabetoDataGridViewTextBoxColumn";
            this.idAlfabetoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAlfabetoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idAlfabetoDataGridViewTextBoxColumn.Width = 60;
            // 
            // nomeAlfabetoDataGridViewTextBoxColumn
            // 
            this.nomeAlfabetoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nomeAlfabetoDataGridViewTextBoxColumn.DataPropertyName = "nomeAlfabeto";
            this.nomeAlfabetoDataGridViewTextBoxColumn.HeaderText = "Caractere";
            this.nomeAlfabetoDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.nomeAlfabetoDataGridViewTextBoxColumn.Name = "nomeAlfabetoDataGridViewTextBoxColumn";
            this.nomeAlfabetoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeAlfabetoDataGridViewTextBoxColumn.Width = 272;
            // 
            // frmAlfabeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(408, 321);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlfabeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlfabeto";
            this.Load += new System.EventHandler(this.frmAlfabeto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlfabeto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbalfabetoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unip_salaDataSet5)).EndInit();
            this.gpbAlfabetoResultado.ResumeLayout(false);
            this.gpbAlfabetoResultado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbAlfabetoResultado;
        private System.Windows.Forms.Button btnEditarAlfabeto;
        private System.Windows.Forms.Button btnNovoAlfabeto;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblNomeAlfabetoResultado;
        private System.Windows.Forms.Label lblIdAlfabetoResultado;
        private System.Windows.Forms.Label lblNomeAlfabeto;
        private System.Windows.Forms.Label lblIdAlfabeto;
        private unip_salaDataSet5 unip_salaDataSet5;
        private System.Windows.Forms.BindingSource tbalfabetoBindingSource;
        private unip_salaDataSet5TableAdapters.tb_alfabetoTableAdapter tb_alfabetoTableAdapter;
        public System.Windows.Forms.DataGridView dgvAlfabeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlfabetoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAlfabetoDataGridViewTextBoxColumn;
    }
}
namespace pim2019_desk.Apresentacao
{
    partial class frmCadastrarSala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarSala));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAndar = new System.Windows.Forms.Label();
            this.cmbAndar = new System.Windows.Forms.ComboBox();
            this.lblTipoSala = new System.Windows.Forms.Label();
            this.cmbTipoSala = new System.Windows.Forms.ComboBox();
            this.lblAlfabeto = new System.Windows.Forms.Label();
            this.cmbAlfabeto = new System.Windows.Forms.ComboBox();
            this.txbCapacidade = new System.Windows.Forms.TextBox();
            this.lblCapacidade = new System.Windows.Forms.Label();
            this.txbNumeroSala = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrarSala = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.unip_salaDataSet6 = new pim2019_desk.unip_salaDataSet6();
            this.unipsalaDataSet6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unip_salaDataSet7 = new pim2019_desk.unip_salaDataSet7();
            this.unipsalaDataSet7BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbTipoSala1 = new pim2019_desk.cmbTipoSala();
            this.tbtiposalaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_tipo_salaTableAdapter = new pim2019_desk.cmbTipoSalaTableAdapters.tb_tipo_salaTableAdapter();
            this.cmbAndar1 = new pim2019_desk.cmbAndar();
            this.tbandarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_andarTableAdapter = new pim2019_desk.cmbAndarTableAdapters.tb_andarTableAdapter();
            this.cmbAlfabeto1 = new pim2019_desk.cmbAlfabeto();
            this.tbalfabetoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_alfabetoTableAdapter = new pim2019_desk.cmbAlfabetoTableAdapters.tb_alfabetoTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unip_salaDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unipsalaDataSet6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unip_salaDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unipsalaDataSet7BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoSala1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbtiposalaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAndar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbandarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAlfabeto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbalfabetoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblAndar);
            this.panel1.Controls.Add(this.cmbAndar);
            this.panel1.Controls.Add(this.lblTipoSala);
            this.panel1.Controls.Add(this.cmbTipoSala);
            this.panel1.Controls.Add(this.lblAlfabeto);
            this.panel1.Controls.Add(this.cmbAlfabeto);
            this.panel1.Controls.Add(this.txbCapacidade);
            this.panel1.Controls.Add(this.lblCapacidade);
            this.panel1.Controls.Add(this.txbNumeroSala);
            this.panel1.Controls.Add(this.lblNumero);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnCadastrarSala);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 286);
            this.panel1.TabIndex = 0;
            // 
            // lblAndar
            // 
            this.lblAndar.AutoSize = true;
            this.lblAndar.Location = new System.Drawing.Point(200, 172);
            this.lblAndar.Name = "lblAndar";
            this.lblAndar.Size = new System.Drawing.Size(35, 13);
            this.lblAndar.TabIndex = 15;
            this.lblAndar.Text = "Andar";
            // 
            // cmbAndar
            // 
            this.cmbAndar.DataSource = this.tbandarBindingSource;
            this.cmbAndar.DisplayMember = "nomeAndar";
            this.cmbAndar.FormattingEnabled = true;
            this.cmbAndar.Location = new System.Drawing.Point(203, 188);
            this.cmbAndar.Name = "cmbAndar";
            this.cmbAndar.Size = new System.Drawing.Size(121, 21);
            this.cmbAndar.TabIndex = 14;
            this.cmbAndar.ValueMember = "idAndar";
            // 
            // lblTipoSala
            // 
            this.lblTipoSala.AutoSize = true;
            this.lblTipoSala.Location = new System.Drawing.Point(200, 116);
            this.lblTipoSala.Name = "lblTipoSala";
            this.lblTipoSala.Size = new System.Drawing.Size(67, 13);
            this.lblTipoSala.TabIndex = 13;
            this.lblTipoSala.Text = "Tipo de Sala";
            // 
            // cmbTipoSala
            // 
            this.cmbTipoSala.DataSource = this.tbtiposalaBindingSource;
            this.cmbTipoSala.DisplayMember = "nomeTipoSala";
            this.cmbTipoSala.Location = new System.Drawing.Point(203, 132);
            this.cmbTipoSala.Name = "cmbTipoSala";
            this.cmbTipoSala.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoSala.TabIndex = 12;
            this.cmbTipoSala.ValueMember = "idTipoSala";
            // 
            // lblAlfabeto
            // 
            this.lblAlfabeto.AutoSize = true;
            this.lblAlfabeto.Location = new System.Drawing.Point(200, 58);
            this.lblAlfabeto.Name = "lblAlfabeto";
            this.lblAlfabeto.Size = new System.Drawing.Size(34, 13);
            this.lblAlfabeto.TabIndex = 11;
            this.lblAlfabeto.Text = "Bloco";
            // 
            // cmbAlfabeto
            // 
            this.cmbAlfabeto.DataSource = this.tbalfabetoBindingSource;
            this.cmbAlfabeto.DisplayMember = "nomeAlfabeto";
            this.cmbAlfabeto.FormattingEnabled = true;
            this.cmbAlfabeto.Location = new System.Drawing.Point(203, 74);
            this.cmbAlfabeto.Name = "cmbAlfabeto";
            this.cmbAlfabeto.Size = new System.Drawing.Size(72, 21);
            this.cmbAlfabeto.TabIndex = 10;
            this.cmbAlfabeto.ValueMember = "idAlfabeto";
            // 
            // txbCapacidade
            // 
            this.txbCapacidade.Location = new System.Drawing.Point(65, 157);
            this.txbCapacidade.Name = "txbCapacidade";
            this.txbCapacidade.Size = new System.Drawing.Size(100, 20);
            this.txbCapacidade.TabIndex = 7;
            // 
            // lblCapacidade
            // 
            this.lblCapacidade.AutoSize = true;
            this.lblCapacidade.Location = new System.Drawing.Point(62, 140);
            this.lblCapacidade.Name = "lblCapacidade";
            this.lblCapacidade.Size = new System.Drawing.Size(64, 13);
            this.lblCapacidade.TabIndex = 6;
            this.lblCapacidade.Text = "Capacidade";
            // 
            // txbNumeroSala
            // 
            this.txbNumeroSala.Location = new System.Drawing.Point(65, 99);
            this.txbNumeroSala.Name = "txbNumeroSala";
            this.txbNumeroSala.Size = new System.Drawing.Size(100, 20);
            this.txbNumeroSala.TabIndex = 5;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(62, 82);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 4;
            this.lblNumero.Text = "Número";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(188, 246);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 37);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCadastrarSala
            // 
            this.btnCadastrarSala.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarSala.Image")));
            this.btnCadastrarSala.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarSala.Location = new System.Drawing.Point(300, 246);
            this.btnCadastrarSala.Name = "btnCadastrarSala";
            this.btnCadastrarSala.Size = new System.Drawing.Size(87, 37);
            this.btnCadastrarSala.TabIndex = 2;
            this.btnCadastrarSala.Text = "Salvar";
            this.btnCadastrarSala.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrarSala.UseVisualStyleBackColor = true;
            this.btnCadastrarSala.Click += new System.EventHandler(this.btnCadastrarSala_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Location = new System.Drawing.Point(364, 3);
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
            this.label1.Location = new System.Drawing.Point(13, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nova Sala";
            // 
            // unip_salaDataSet6
            // 
            this.unip_salaDataSet6.DataSetName = "unip_salaDataSet6";
            this.unip_salaDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unipsalaDataSet6BindingSource
            // 
            this.unipsalaDataSet6BindingSource.DataSource = this.unip_salaDataSet6;
            this.unipsalaDataSet6BindingSource.Position = 0;
            // 
            // unip_salaDataSet7
            // 
            this.unip_salaDataSet7.DataSetName = "unip_salaDataSet7";
            this.unip_salaDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unipsalaDataSet7BindingSource
            // 
            this.unipsalaDataSet7BindingSource.DataSource = this.unip_salaDataSet7;
            this.unipsalaDataSet7BindingSource.Position = 0;
            // 
            // cmbTipoSala1
            // 
            this.cmbTipoSala1.DataSetName = "cmbTipoSala";
            this.cmbTipoSala1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbtiposalaBindingSource
            // 
            this.tbtiposalaBindingSource.DataMember = "tb_tipo_sala";
            this.tbtiposalaBindingSource.DataSource = this.cmbTipoSala1;
            // 
            // tb_tipo_salaTableAdapter
            // 
            this.tb_tipo_salaTableAdapter.ClearBeforeFill = true;
            // 
            // cmbAndar1
            // 
            this.cmbAndar1.DataSetName = "cmbAndar";
            this.cmbAndar1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbandarBindingSource
            // 
            this.tbandarBindingSource.DataMember = "tb_andar";
            this.tbandarBindingSource.DataSource = this.cmbAndar1;
            // 
            // tb_andarTableAdapter
            // 
            this.tb_andarTableAdapter.ClearBeforeFill = true;
            // 
            // cmbAlfabeto1
            // 
            this.cmbAlfabeto1.DataSetName = "cmbAlfabeto";
            this.cmbAlfabeto1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbalfabetoBindingSource
            // 
            this.tbalfabetoBindingSource.DataMember = "tb_alfabeto";
            this.tbalfabetoBindingSource.DataSource = this.cmbAlfabeto1;
            // 
            // tb_alfabetoTableAdapter
            // 
            this.tb_alfabetoTableAdapter.ClearBeforeFill = true;
            // 
            // frmCadastrarSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(417, 311);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastrarSala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastrarSala";
            this.Load += new System.EventHandler(this.frmCadastrarSala_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unip_salaDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unipsalaDataSet6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unip_salaDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unipsalaDataSet7BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoSala1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbtiposalaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAndar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbandarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAlfabeto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbalfabetoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAndar;
        private System.Windows.Forms.ComboBox cmbAndar;
        private System.Windows.Forms.Label lblTipoSala;
        private System.Windows.Forms.ComboBox cmbTipoSala;
        private System.Windows.Forms.Label lblAlfabeto;
        private System.Windows.Forms.ComboBox cmbAlfabeto;
        private System.Windows.Forms.TextBox txbCapacidade;
        private System.Windows.Forms.Label lblCapacidade;
        private System.Windows.Forms.TextBox txbNumeroSala;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrarSala;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource unipsalaDataSet7BindingSource;
        private unip_salaDataSet7 unip_salaDataSet7;
        private unip_salaDataSet6 unip_salaDataSet6;
        private System.Windows.Forms.BindingSource unipsalaDataSet6BindingSource;
        private cmbTipoSala cmbTipoSala1;
        private System.Windows.Forms.BindingSource tbtiposalaBindingSource;
        private cmbTipoSalaTableAdapters.tb_tipo_salaTableAdapter tb_tipo_salaTableAdapter;
        private cmbAndar cmbAndar1;
        private System.Windows.Forms.BindingSource tbandarBindingSource;
        private cmbAndarTableAdapters.tb_andarTableAdapter tb_andarTableAdapter;
        private cmbAlfabeto cmbAlfabeto1;
        private System.Windows.Forms.BindingSource tbalfabetoBindingSource;
        private cmbAlfabetoTableAdapters.tb_alfabetoTableAdapter tb_alfabetoTableAdapter;
    }
}
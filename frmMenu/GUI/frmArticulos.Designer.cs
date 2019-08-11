namespace frmMenu.GUI
{
    partial class frmArticulos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridCliente = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.radBCodigo = new System.Windows.Forms.RadioButton();
            this.radButDescripcion = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtImp = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.txtExistencia = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.NumericUpDown();
            this.datimeFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtCodArt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecioPub = new System.Windows.Forms.NumericUpDown();
            this.txtUtil = new System.Windows.Forms.NumericUpDown();
            this.rdbImpNo = new System.Windows.Forms.RadioButton();
            this.rdbImpSi = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictLimpiar = new System.Windows.Forms.PictureBox();
            this.pictSave = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioPub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUtil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictSave)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridCliente);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(446, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 531);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Artículo";
            // 
            // dataGridCliente
            // 
            this.dataGridCliente.AllowUserToAddRows = false;
            this.dataGridCliente.AllowUserToDeleteRows = false;
            this.dataGridCliente.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCliente.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridCliente.GridColor = System.Drawing.Color.Black;
            this.dataGridCliente.Location = new System.Drawing.Point(6, 122);
            this.dataGridCliente.Name = "dataGridCliente";
            this.dataGridCliente.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridCliente.Size = new System.Drawing.Size(738, 378);
            this.dataGridCliente.TabIndex = 1;
            this.dataGridCliente.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridCliente_CellMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBuscar);
            this.groupBox2.Controls.Add(this.radBCodigo);
            this.groupBox2.Controls.Add(this.radButDescripcion);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(256, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 85);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Location = new System.Drawing.Point(50, 21);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(250, 30);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // radBCodigo
            // 
            this.radBCodigo.AutoSize = true;
            this.radBCodigo.ForeColor = System.Drawing.Color.White;
            this.radBCodigo.Location = new System.Drawing.Point(201, 53);
            this.radBCodigo.Name = "radBCodigo";
            this.radBCodigo.Size = new System.Drawing.Size(88, 26);
            this.radBCodigo.TabIndex = 1;
            this.radBCodigo.TabStop = true;
            this.radBCodigo.Text = "Código";
            this.radBCodigo.UseVisualStyleBackColor = true;
            // 
            // radButDescripcion
            // 
            this.radButDescripcion.AutoSize = true;
            this.radButDescripcion.ForeColor = System.Drawing.Color.White;
            this.radButDescripcion.Location = new System.Drawing.Point(21, 53);
            this.radButDescripcion.Name = "radButDescripcion";
            this.radButDescripcion.Size = new System.Drawing.Size(138, 26);
            this.radButDescripcion.TabIndex = 0;
            this.radButDescripcion.TabStop = true;
            this.radButDescripcion.Text = "Descripción";
            this.radButDescripcion.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.pictLimpiar);
            this.groupBox3.Controls.Add(this.pictSave);
            this.groupBox3.Controls.Add(this.txtImp);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtExistencia);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtCosto);
            this.groupBox3.Controls.Add(this.datimeFechaCompra);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lblID);
            this.groupBox3.Controls.Add(this.txtCodArt);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtDescp);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtPrecioPub);
            this.groupBox3.Controls.Add(this.txtUtil);
            this.groupBox3.Controls.Add(this.rdbImpNo);
            this.groupBox3.Controls.Add(this.rdbImpSi);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cmbDepartamento);
            this.groupBox3.Controls.Add(this.cmbMarca);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(26, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(414, 570);
            this.groupBox3.TabIndex = 60;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del Artículo";
            // 
            // txtImp
            // 
            this.txtImp.DecimalPlaces = 2;
            this.txtImp.Enabled = false;
            this.txtImp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImp.Location = new System.Drawing.Point(175, 237);
            this.txtImp.Name = "txtImp";
            this.txtImp.Size = new System.Drawing.Size(108, 26);
            this.txtImp.TabIndex = 110;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(6, 239);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 19);
            this.label12.TabIndex = 109;
            this.label12.Text = "I.V 13%:";
            // 
            // txtExistencia
            // 
            this.txtExistencia.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExistencia.Location = new System.Drawing.Point(173, 389);
            this.txtExistencia.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(92, 26);
            this.txtExistencia.TabIndex = 8;
            this.txtExistencia.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtExistencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExistencia_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 19);
            this.label9.TabIndex = 108;
            this.label9.Text = "Existencia:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(6, 429);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 19);
            this.label11.TabIndex = 107;
            this.label11.Text = "Impuesto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 106;
            this.label1.Text = "Marca:";
            // 
            // txtCosto
            // 
            this.txtCosto.DecimalPlaces = 2;
            this.txtCosto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Location = new System.Drawing.Point(175, 159);
            this.txtCosto.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(132, 26);
            this.txtCosto.TabIndex = 3;
            this.txtCosto.ValueChanged += new System.EventHandler(this.txtCosto_ValueChanged);
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
            // 
            // datimeFechaCompra
            // 
            this.datimeFechaCompra.CalendarFont = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datimeFechaCompra.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datimeFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datimeFechaCompra.Location = new System.Drawing.Point(173, 117);
            this.datimeFechaCompra.Name = "datimeFechaCompra";
            this.datimeFechaCompra.Size = new System.Drawing.Size(134, 26);
            this.datimeFechaCompra.TabIndex = 2;
            this.datimeFechaCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.datimeFechaCompra_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 19);
            this.label8.TabIndex = 103;
            this.label8.Text = "Fecha de Creación:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(348, 149);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 22);
            this.lblID.TabIndex = 102;
            // 
            // txtCodArt
            // 
            this.txtCodArt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodArt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodArt.Location = new System.Drawing.Point(173, 41);
            this.txtCodArt.Name = "txtCodArt";
            this.txtCodArt.Size = new System.Drawing.Size(235, 26);
            this.txtCodArt.TabIndex = 0;
            this.txtCodArt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodArt_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 19);
            this.label6.TabIndex = 101;
            this.label6.Text = "Cod Artículo:";
            // 
            // txtDescp
            // 
            this.txtDescp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescp.Location = new System.Drawing.Point(173, 82);
            this.txtDescp.Name = "txtDescp";
            this.txtDescp.Size = new System.Drawing.Size(235, 26);
            this.txtDescp.TabIndex = 1;
            this.txtDescp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescp_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 100;
            this.label3.Text = "Utilidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 99;
            this.label2.Text = "Precio Costo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 19);
            this.label5.TabIndex = 98;
            this.label5.Text = "Descripción Art:";
            // 
            // txtPrecioPub
            // 
            this.txtPrecioPub.DecimalPlaces = 2;
            this.txtPrecioPub.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioPub.Location = new System.Drawing.Point(173, 279);
            this.txtPrecioPub.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtPrecioPub.Name = "txtPrecioPub";
            this.txtPrecioPub.Size = new System.Drawing.Size(134, 26);
            this.txtPrecioPub.TabIndex = 5;
            this.txtPrecioPub.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioPub_KeyPress_1);
            // 
            // txtUtil
            // 
            this.txtUtil.DecimalPlaces = 5;
            this.txtUtil.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtil.Location = new System.Drawing.Point(175, 201);
            this.txtUtil.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtUtil.Name = "txtUtil";
            this.txtUtil.Size = new System.Drawing.Size(84, 26);
            this.txtUtil.TabIndex = 4;
            this.txtUtil.ValueChanged += new System.EventHandler(this.txtUtil_ValueChanged);
            this.txtUtil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUtil_KeyPress);
            // 
            // rdbImpNo
            // 
            this.rdbImpNo.AutoSize = true;
            this.rdbImpNo.BackColor = System.Drawing.Color.Transparent;
            this.rdbImpNo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbImpNo.ForeColor = System.Drawing.Color.White;
            this.rdbImpNo.Location = new System.Drawing.Point(238, 431);
            this.rdbImpNo.Name = "rdbImpNo";
            this.rdbImpNo.Size = new System.Drawing.Size(45, 23);
            this.rdbImpNo.TabIndex = 10;
            this.rdbImpNo.Text = "No";
            this.rdbImpNo.UseVisualStyleBackColor = false;
            this.rdbImpNo.Click += new System.EventHandler(this.rdbImpNo_Click);
            // 
            // rdbImpSi
            // 
            this.rdbImpSi.AutoSize = true;
            this.rdbImpSi.BackColor = System.Drawing.Color.Transparent;
            this.rdbImpSi.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbImpSi.ForeColor = System.Drawing.Color.White;
            this.rdbImpSi.Location = new System.Drawing.Point(173, 432);
            this.rdbImpSi.Name = "rdbImpSi";
            this.rdbImpSi.Size = new System.Drawing.Size(45, 23);
            this.rdbImpSi.TabIndex = 9;
            this.rdbImpSi.Text = "Sí";
            this.rdbImpSi.UseVisualStyleBackColor = false;
            this.rdbImpSi.Click += new System.EventHandler(this.rdbImpSi_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(265, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 19);
            this.label10.TabIndex = 91;
            this.label10.Text = "%";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(173, 349);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(171, 27);
            this.cmbDepartamento.TabIndex = 7;
            this.cmbDepartamento.SelectedIndexChanged += new System.EventHandler(this.cmbDepartamento_SelectedIndexChanged);
            // 
            // cmbMarca
            // 
            this.cmbMarca.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(173, 314);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(171, 27);
            this.cmbMarca.TabIndex = 6;
            this.cmbMarca.SelectedIndexChanged += new System.EventHandler(this.cmbMarca_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 19);
            this.label7.TabIndex = 90;
            this.label7.Text = "Departamento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 19);
            this.label4.TabIndex = 89;
            this.label4.Text = "Precio Público:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(242, 543);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 18);
            this.label13.TabIndex = 129;
            this.label13.Text = "Limpiar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(71, 543);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 18);
            this.label14.TabIndex = 128;
            this.label14.Text = "Agrega/Modifica";
            // 
            // pictLimpiar
            // 
            this.pictLimpiar.BackgroundImage = global::frmMenu.Properties.Resources.limpiar;
            this.pictLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictLimpiar.Location = new System.Drawing.Point(233, 476);
            this.pictLimpiar.Name = "pictLimpiar";
            this.pictLimpiar.Size = new System.Drawing.Size(73, 64);
            this.pictLimpiar.TabIndex = 127;
            this.pictLimpiar.TabStop = false;
            this.pictLimpiar.Click += new System.EventHandler(this.pictLimpiar_Click);
            // 
            // pictSave
            // 
            this.pictSave.BackgroundImage = global::frmMenu.Properties.Resources.save;
            this.pictSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictSave.Location = new System.Drawing.Point(104, 476);
            this.pictSave.Name = "pictSave";
            this.pictSave.Size = new System.Drawing.Size(73, 64);
            this.pictSave.TabIndex = 126;
            this.pictSave.TabStop = false;
            this.pictSave.Click += new System.EventHandler(this.pictSave_Click);
            this.pictSave.MouseLeave += new System.EventHandler(this.pictSave_MouseLeave);
            this.pictSave.MouseHover += new System.EventHandler(this.pictSave_MouseHover);
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::frmMenu.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1208, 606);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmArticulos_FormClosing);
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioPub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUtil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictSave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.RadioButton radBCodigo;
        private System.Windows.Forms.RadioButton radButDescripcion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown txtExistencia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtCosto;
        private System.Windows.Forms.DateTimePicker datimeFechaCompra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtCodArt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txtPrecioPub;
        private System.Windows.Forms.NumericUpDown txtUtil;
        private System.Windows.Forms.RadioButton rdbImpNo;
        private System.Windows.Forms.RadioButton rdbImpSi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtImp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictLimpiar;
        private System.Windows.Forms.PictureBox pictSave;
    }
}
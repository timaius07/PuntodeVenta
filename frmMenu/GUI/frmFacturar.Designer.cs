namespace frmMenu.GUI
{
    partial class frmFacturar
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblDesc = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.dataGridFact = new System.Windows.Forms.DataGridView();
			this.lblDescrip = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblIV = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblSubtotal = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.numcantidad = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.numDesc = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridFact)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numcantidad)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numDesc)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.numDesc);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.lblDesc);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.dataGridFact);
			this.groupBox2.Controls.Add(this.lblDescrip);
			this.groupBox2.Controls.Add(this.lblTotal);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.lblIV);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.lblSubtotal);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.numcantidad);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.txtCodigo);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.Color.White;
			this.groupBox2.Location = new System.Drawing.Point(12, 22);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(865, 512);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Datos de Factura";
			// 
			// lblDesc
			// 
			this.lblDesc.AutoSize = true;
			this.lblDesc.ForeColor = System.Drawing.Color.Black;
			this.lblDesc.Location = new System.Drawing.Point(673, 416);
			this.lblDesc.Name = "lblDesc";
			this.lblDesc.Size = new System.Drawing.Size(81, 19);
			this.lblDesc.TabIndex = 16;
			this.lblDesc.Text = "00.00,00";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(549, 417);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 18);
			this.label7.TabIndex = 15;
			this.label7.Text = "Descuento:";
			// 
			// dataGridFact
			// 
			this.dataGridFact.AllowUserToAddRows = false;
			this.dataGridFact.AllowUserToDeleteRows = false;
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
			this.dataGridFact.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
			this.dataGridFact.BackgroundColor = System.Drawing.Color.LightSkyBlue;
			this.dataGridFact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridFact.DefaultCellStyle = dataGridViewCellStyle8;
			this.dataGridFact.GridColor = System.Drawing.Color.Black;
			this.dataGridFact.Location = new System.Drawing.Point(15, 72);
			this.dataGridFact.Name = "dataGridFact";
			this.dataGridFact.ReadOnly = true;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridFact.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.dataGridFact.Size = new System.Drawing.Size(820, 297);
			this.dataGridFact.TabIndex = 14;
			// 
			// lblDescrip
			// 
			this.lblDescrip.AutoSize = true;
			this.lblDescrip.ForeColor = System.Drawing.Color.Black;
			this.lblDescrip.Location = new System.Drawing.Point(296, 31);
			this.lblDescrip.Name = "lblDescrip";
			this.lblDescrip.Size = new System.Drawing.Size(162, 19);
			this.lblDescrip.TabIndex = 13;
			this.lblDescrip.Text = "Descrip. Articulo";
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.ForeColor = System.Drawing.Color.Black;
			this.lblTotal.Location = new System.Drawing.Point(672, 480);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(81, 19);
			this.lblTotal.TabIndex = 12;
			this.lblTotal.Text = "00.00,00";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(580, 481);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 18);
			this.label6.TabIndex = 11;
			this.label6.Text = "Total:";
			// 
			// lblIV
			// 
			this.lblIV.AutoSize = true;
			this.lblIV.ForeColor = System.Drawing.Color.Black;
			this.lblIV.Location = new System.Drawing.Point(672, 444);
			this.lblIV.Name = "lblIV";
			this.lblIV.Size = new System.Drawing.Size(81, 19);
			this.lblIV.TabIndex = 10;
			this.lblIV.Text = "00.00,00";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(564, 445);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 18);
			this.label5.TabIndex = 9;
			this.label5.Text = "I.V 13%:";
			// 
			// lblSubtotal
			// 
			this.lblSubtotal.AutoSize = true;
			this.lblSubtotal.ForeColor = System.Drawing.Color.Black;
			this.lblSubtotal.Location = new System.Drawing.Point(672, 385);
			this.lblSubtotal.Name = "lblSubtotal";
			this.lblSubtotal.Size = new System.Drawing.Size(81, 19);
			this.lblSubtotal.TabIndex = 8;
			this.lblSubtotal.Text = "00.00,00";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(548, 386);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 18);
			this.label4.TabIndex = 7;
			this.label4.Text = "Sub-Total:";
			// 
			// numcantidad
			// 
			this.numcantidad.DecimalPlaces = 2;
			this.numcantidad.Location = new System.Drawing.Point(624, 24);
			this.numcantidad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numcantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numcantidad.Name = "numcantidad";
			this.numcantidad.Size = new System.Drawing.Size(79, 26);
			this.numcantidad.TabIndex = 6;
			this.numcantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numcantidad_KeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(538, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 18);
			this.label3.TabIndex = 5;
			this.label3.Text = "Cantidad:";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(98, 28);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(178, 26);
			this.txtCodigo.TabIndex = 4;
			this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(20, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 18);
			this.label2.TabIndex = 3;
			this.label2.Text = "Código:";
			// 
			// numDesc
			// 
			this.numDesc.DecimalPlaces = 2;
			this.numDesc.Location = new System.Drawing.Point(205, 382);
			this.numDesc.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numDesc.Name = "numDesc";
			this.numDesc.Size = new System.Drawing.Size(61, 26);
			this.numDesc.TabIndex = 18;
			this.numDesc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(71, 385);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 18);
			this.label1.TabIndex = 17;
			this.label1.Text = "Porc. Descuento";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(272, 385);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(20, 22);
			this.label8.TabIndex = 19;
			this.label8.Text = "%";
			// 
			// frmFacturar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::frmMenu.Properties.Resources.images;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(889, 546);
			this.Controls.Add(this.groupBox2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmFacturar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Formulario Facturación";
			this.Load += new System.EventHandler(this.frmFacturar_Load);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridFact)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numcantidad)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numDesc)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numcantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblIV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDescrip;
        private System.Windows.Forms.DataGridView dataGridFact;
		private System.Windows.Forms.Label lblDesc;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown numDesc;
		private System.Windows.Forms.Label label1;
	}
}
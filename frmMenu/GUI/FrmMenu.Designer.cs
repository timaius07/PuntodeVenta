namespace frmMenu.GUI
{
    partial class FrmMenu
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.ingresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nuevoArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nuevaMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nuevoDepartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panelprincipal = new System.Windows.Forms.Panel();
			this.panelmenu = new System.Windows.Forms.Panel();
			this.pictCliente = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.pictFacturar = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.pictDepa = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.picMarca = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictArticulo = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			this.panelprincipal.SuspendLayout();
			this.panelmenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictCliente)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictFacturar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictDepa)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picMarca)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictArticulo)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(830, 24);
			this.menuStrip1.Stretch = false;
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// ingresarToolStripMenuItem
			// 
			this.ingresarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoArticuloToolStripMenuItem,
            this.nuevaMarcaToolStripMenuItem,
            this.nuevoDepartamentoToolStripMenuItem});
			this.ingresarToolStripMenuItem.Image = global::frmMenu.Properties.Resources.plus_icon;
			this.ingresarToolStripMenuItem.Name = "ingresarToolStripMenuItem";
			this.ingresarToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
			this.ingresarToolStripMenuItem.Text = "Ingresar";
			// 
			// nuevoArticuloToolStripMenuItem
			// 
			this.nuevoArticuloToolStripMenuItem.Name = "nuevoArticuloToolStripMenuItem";
			this.nuevoArticuloToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.nuevoArticuloToolStripMenuItem.Text = "Nuevo Articulo";
			this.nuevoArticuloToolStripMenuItem.Click += new System.EventHandler(this.nuevoArticuloToolStripMenuItem_Click);
			// 
			// nuevaMarcaToolStripMenuItem
			// 
			this.nuevaMarcaToolStripMenuItem.Name = "nuevaMarcaToolStripMenuItem";
			this.nuevaMarcaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.nuevaMarcaToolStripMenuItem.Text = "Nueva Marca";
			this.nuevaMarcaToolStripMenuItem.Click += new System.EventHandler(this.nuevaMarcaToolStripMenuItem_Click);
			// 
			// nuevoDepartamentoToolStripMenuItem
			// 
			this.nuevoDepartamentoToolStripMenuItem.Name = "nuevoDepartamentoToolStripMenuItem";
			this.nuevoDepartamentoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.nuevoDepartamentoToolStripMenuItem.Text = "Nuevo Departamento";
			// 
			// panelprincipal
			// 
			this.panelprincipal.BackColor = System.Drawing.Color.Transparent;
			this.panelprincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelprincipal.Controls.Add(this.panelmenu);
			this.panelprincipal.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelprincipal.Location = new System.Drawing.Point(0, 24);
			this.panelprincipal.Name = "panelprincipal";
			this.panelprincipal.Size = new System.Drawing.Size(830, 113);
			this.panelprincipal.TabIndex = 1;
			// 
			// panelmenu
			// 
			this.panelmenu.Controls.Add(this.pictCliente);
			this.panelmenu.Controls.Add(this.label5);
			this.panelmenu.Controls.Add(this.pictFacturar);
			this.panelmenu.Controls.Add(this.label4);
			this.panelmenu.Controls.Add(this.pictDepa);
			this.panelmenu.Controls.Add(this.label3);
			this.panelmenu.Controls.Add(this.picMarca);
			this.panelmenu.Controls.Add(this.label2);
			this.panelmenu.Controls.Add(this.label1);
			this.panelmenu.Controls.Add(this.pictArticulo);
			this.panelmenu.Location = new System.Drawing.Point(81, 3);
			this.panelmenu.Name = "panelmenu";
			this.panelmenu.Size = new System.Drawing.Size(666, 96);
			this.panelmenu.TabIndex = 0;
			// 
			// pictCliente
			// 
			this.pictCliente.BackgroundImage = global::frmMenu.Properties.Resources.clie1;
			this.pictCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictCliente.Location = new System.Drawing.Point(422, 0);
			this.pictCliente.Name = "pictCliente";
			this.pictCliente.Size = new System.Drawing.Size(73, 64);
			this.pictCliente.TabIndex = 9;
			this.pictCliente.TabStop = false;
			this.pictCliente.Click += new System.EventHandler(this.pictCliente_Click);
			this.pictCliente.MouseLeave += new System.EventHandler(this.pictCliente_MouseLeave);
			this.pictCliente.MouseHover += new System.EventHandler(this.pictCliente_MouseHover);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(423, 76);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 18);
			this.label5.TabIndex = 8;
			this.label5.Text = "Clientes";
			// 
			// pictFacturar
			// 
			this.pictFacturar.BackgroundImage = global::frmMenu.Properties.Resources.shop2;
			this.pictFacturar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictFacturar.Location = new System.Drawing.Point(557, 3);
			this.pictFacturar.Name = "pictFacturar";
			this.pictFacturar.Size = new System.Drawing.Size(73, 64);
			this.pictFacturar.TabIndex = 7;
			this.pictFacturar.TabStop = false;
			this.pictFacturar.Click += new System.EventHandler(this.PictFacturar_Click);
			this.pictFacturar.MouseLeave += new System.EventHandler(this.pictFacturar_MouseLeave);
			this.pictFacturar.MouseHover += new System.EventHandler(this.pictFacturar_MouseHover);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(558, 76);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 18);
			this.label4.TabIndex = 6;
			this.label4.Text = "Facturar";
			// 
			// pictDepa
			// 
			this.pictDepa.BackgroundImage = global::frmMenu.Properties.Resources.depa1;
			this.pictDepa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictDepa.Location = new System.Drawing.Point(282, 3);
			this.pictDepa.Name = "pictDepa";
			this.pictDepa.Size = new System.Drawing.Size(73, 64);
			this.pictDepa.TabIndex = 5;
			this.pictDepa.TabStop = false;
			this.pictDepa.Click += new System.EventHandler(this.pictDepa_Click);
			this.pictDepa.MouseLeave += new System.EventHandler(this.pictDepa_MouseLeave);
			this.pictDepa.MouseHover += new System.EventHandler(this.pictDepa_MouseHover);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(268, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 18);
			this.label3.TabIndex = 4;
			this.label3.Text = "Departamento";
			// 
			// picMarca
			// 
			this.picMarca.BackgroundImage = global::frmMenu.Properties.Resources.marca11;
			this.picMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picMarca.Location = new System.Drawing.Point(151, 3);
			this.picMarca.Name = "picMarca";
			this.picMarca.Size = new System.Drawing.Size(73, 64);
			this.picMarca.TabIndex = 3;
			this.picMarca.TabStop = false;
			this.picMarca.Click += new System.EventHandler(this.picMarca_Click);
			this.picMarca.MouseLeave += new System.EventHandler(this.picMarca_MouseLeave);
			this.picMarca.MouseHover += new System.EventHandler(this.picMarca_MouseHover);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(164, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "Marca";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(32, 76);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "Artículo";
			// 
			// pictArticulo
			// 
			this.pictArticulo.BackgroundImage = global::frmMenu.Properties.Resources.art1;
			this.pictArticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictArticulo.Location = new System.Drawing.Point(31, 3);
			this.pictArticulo.Name = "pictArticulo";
			this.pictArticulo.Size = new System.Drawing.Size(73, 64);
			this.pictArticulo.TabIndex = 0;
			this.pictArticulo.TabStop = false;
			this.pictArticulo.Click += new System.EventHandler(this.pictArticulo_Click);
			this.pictArticulo.MouseLeave += new System.EventHandler(this.pictArticulo_MouseLeave);
			this.pictArticulo.MouseHover += new System.EventHandler(this.pictArticulo_MouseHover);
			// 
			// FrmMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::frmMenu.Properties.Resources.images;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(830, 639);
			this.Controls.Add(this.panelprincipal);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FrmMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Menú Principal";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FrmMenu_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panelprincipal.ResumeLayout(false);
			this.panelmenu.ResumeLayout(false);
			this.panelmenu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictCliente)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictFacturar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictDepa)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picMarca)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictArticulo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoDepartamentoToolStripMenuItem;
        private System.Windows.Forms.Panel panelprincipal;
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictArticulo;
        private System.Windows.Forms.PictureBox picMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictDepa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictFacturar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictCliente;
        private System.Windows.Forms.Label label5;
    }
}
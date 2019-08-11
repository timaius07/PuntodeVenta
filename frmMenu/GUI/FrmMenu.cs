using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmMenu.GUI
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void nuevoArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArticulos frmArt = new frmArticulos();
            frmArt.Show(this);
            this.Enabled = false;
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            //Centrar el Panel
            Size desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize; //Captura el Tamaño del Monitor
            Int32 ancho = (this.Width - panelmenu.Width) / 2;
            panelmenu.Location = new Point(ancho, panelmenu.Location.Y);
        }

        private void pictArticulo_MouseHover(object sender, EventArgs e)
        {
            pictArticulo.BackgroundImageLayout = ImageLayout.Stretch;
            pictArticulo.BackgroundImage = Properties.Resources.art2;
        }

        private void pictArticulo_MouseLeave(object sender, EventArgs e)
        {
            pictArticulo.BackgroundImageLayout = ImageLayout.Stretch;
            pictArticulo.BackgroundImage = Properties.Resources.art1;
        }

        private void nuevaMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void picMarca_MouseHover(object sender, EventArgs e)
        {
            picMarca.BackgroundImageLayout = ImageLayout.Stretch;
            picMarca.BackgroundImage = Properties.Resources.marca21;
        }

        private void picMarca_MouseLeave(object sender, EventArgs e)
        {
            picMarca.BackgroundImageLayout = ImageLayout.Stretch;
            picMarca.BackgroundImage = Properties.Resources.marca11;
        }

        private void pictDepa_MouseHover(object sender, EventArgs e)
        {
            pictDepa.BackgroundImageLayout = ImageLayout.Stretch;
            pictDepa.BackgroundImage = Properties.Resources.depa2;
        }

        private void pictDepa_MouseLeave(object sender, EventArgs e)
        {
            pictDepa.BackgroundImageLayout = ImageLayout.Stretch;
            pictDepa.BackgroundImage = Properties.Resources.depa1;
        }

        private void pictFacturar_MouseHover(object sender, EventArgs e)
        {
            pictFacturar.BackgroundImageLayout = ImageLayout.Stretch;
            pictFacturar.BackgroundImage = Properties.Resources.shop1;
        }

        private void pictFacturar_MouseLeave(object sender, EventArgs e)
        {
            pictFacturar.BackgroundImageLayout = ImageLayout.Stretch;
            pictFacturar.BackgroundImage = Properties.Resources.shop2;
        }

        private void pictArticulo_Click(object sender, EventArgs e)
        {
            frmArticulos frmArt = new frmArticulos();
            frmArt.Show(this);
            this.Enabled = false;
        }

        private void pictCliente_MouseHover(object sender, EventArgs e)
        {
            pictCliente.BackgroundImageLayout = ImageLayout.Stretch;
            pictCliente.BackgroundImage = Properties.Resources.clie2;
        }

        private void pictCliente_MouseLeave(object sender, EventArgs e)
        {
            pictCliente.BackgroundImageLayout = ImageLayout.Stretch;
            pictCliente.BackgroundImage = Properties.Resources.clie1;
        }

        private void picMarca_Click(object sender, EventArgs e)
        {
            frmMarca frmMarca = new frmMarca();
            frmMarca.Show(this);
            this.Enabled = false;
        }

        private void pictDepa_Click(object sender, EventArgs e)
        {
            FrmDepartamento frmDepa = new FrmDepartamento();
            frmDepa.Show(this);
            this.Enabled = false;
        }

        private void pictCliente_Click(object sender, EventArgs e)
        {
            frmClientes frmClient = new frmClientes();
            frmClient.Show(this);
            this.Enabled = false;
        }
    }
}

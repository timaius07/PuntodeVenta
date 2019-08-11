using frmMenu.BO;
using frmMenu.Entidades;
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
    public partial class frmClientes : Form
    {
        private ClienteBO cbo;
        public bool modif = false;

        List<Cliente> lis = new List<Cliente>();
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            radBNomb.Checked = true;
            ClienteBO cl = new ClienteBO();
            dataGridCliente.DataSource= cl.GetCargarClientes();
            this.OcultarDatagrid();
            maskTelcasa.Text = "0000-0000";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cbo = new ClienteBO();

            if (modif == true & lblID.Text != "")
            {
                Cliente pt = new Cliente()
                {

                    Nombre = txtNombre.Text,
                    Apellido = txtApellidos.Text,
                    Cedula = txtNumced.Text,
                    Direccion = txtDireccion.Text,
                    TelefonoCasa = maskTelcasa.Text,
                    TelefonoCel = maskTelCell.Text,
                    Id = Int32.Parse(lblID.Text)
                };
                MessageBox.Show(cbo.ModificarCli(pt), "Modificacion Cliente Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (radBNomb.Checked == true)
                {
                    dataGridCliente.DataSource = cbo.GetCliente(txtBuscar.Text);
                }
                else if (radBCed.Checked == true)
                {
                    dataGridCliente.DataSource = cbo.GetClienteCed(txtBuscar.Text);
                }
            }
            else
            {
                Cliente pt = new Cliente()
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellidos.Text,
                    Cedula = txtNumced.Text,
                    Direccion = txtDireccion.Text,
                    TelefonoCasa = maskTelcasa.Text,
                    TelefonoCel = maskTelCell.Text
                    
                };
                MessageBox.Show(cbo.Validar(pt), "Registro Cliente Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarDatos();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            cbo = new ClienteBO();

            if (radBNomb.Checked == true)
            {
                dataGridCliente.DataSource = cbo.GetCliente(txtBuscar.Text);
            }
            else if (radBCed.Checked == true)
            {
                dataGridCliente.DataSource = cbo.GetClienteCed(txtBuscar.Text);
            }
            modif = true;
            this.OcultarDatagrid();
            if (txtBuscar.Text == "")
            {
                LimpiarDatos();
            }
        }

        private void OcultarDatagrid()
        {
            this.dataGridCliente.Columns[0].Visible = false;
            this.dataGridCliente.Columns[4].Visible = false;
            this.dataGridCliente.Columns[5].Visible = false;

            dataGridCliente.Columns[1].HeaderText = "Nombre";
            dataGridCliente.Columns[2].HeaderText = "Apellidos";
            dataGridCliente.Columns[3].HeaderText = "Cédula";
            dataGridCliente.Columns[6].HeaderText = "Teléfono";


            dataGridCliente.Columns[1].Width = 200;
            dataGridCliente.Columns[2].Width = 200;
            dataGridCliente.Columns[3].Width = 150;
            dataGridCliente.Columns[6].Width = 150;
        }
        private void LimpiarDatos()
        {
            radBNomb.Checked = true;
            lblID.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtNumced.Text = "";
            txtDireccion.Text = "";
            maskTelcasa.Text = "00-00-00-00";
            maskTelCell.Text = "";
            modif = false;
            txtNombre.Focus();
            modif = false;
            pictSave.BackgroundImage = Properties.Resources.save;
        }

        private void frmClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Enabled = true;
        }

        private void dataGridCliente_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                lblID.Text = ((int)dataGridCliente.CurrentRow.Cells["Id"].Value).ToString();
                txtNombre.Text = (string)dataGridCliente.CurrentRow.Cells["Nombre"].Value;
                txtApellidos.Text = (string)dataGridCliente.CurrentRow.Cells["Apellido"].Value;
                txtNumced.Text = (string)dataGridCliente.CurrentRow.Cells["Cedula"].Value;
                txtDireccion.Text = (string)dataGridCliente.CurrentRow.Cells["Direccion"].Value;
                maskTelcasa.Text = (string)dataGridCliente.CurrentRow.Cells["TelefonoCasa"].Value;
                maskTelCell.Text = (string)dataGridCliente.CurrentRow.Cells["TelefonoCel"].Value;
            }
            catch (Exception)
            {

            }
            modif = true;
            txtNumced.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void cargarClientes()
        {
            cbo = new ClienteBO();
            dataGridCliente.DataSource = null;
            lis = cbo.GetCargarClientes();
            dataGridCliente.DataSource = lis;
            this.OcultarDatagrid();
            txtNombre.Focus();

        }

        private void pictSave_Click(object sender, EventArgs e)
        {
            cbo = new ClienteBO();

            if (modif == true & lblID.Text != "")
            {
                Cliente pt = new Cliente()
                {

                    Nombre = txtNombre.Text,
                    Apellido = txtApellidos.Text,
                    Cedula = txtNumced.Text,
                    Direccion = txtDireccion.Text,
                    TelefonoCasa = maskTelcasa.Text,
                    TelefonoCel = maskTelCell.Text,
                    Id = Int32.Parse(lblID.Text)
                };
                MessageBox.Show(cbo.ModificarCli(pt), "Modificacion Cliente Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (radBNomb.Checked == true)
                {
                    dataGridCliente.DataSource = cbo.GetCliente(txtBuscar.Text);
                }
                else if (radBCed.Checked == true)
                {
                    dataGridCliente.DataSource = cbo.GetClienteCed(txtBuscar.Text);
                }
            }
            else
            {
                Cliente pt = new Cliente()
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellidos.Text,
                    Cedula = txtNumced.Text,
                    Direccion = txtDireccion.Text,
                    TelefonoCasa = maskTelcasa.Text,
                    TelefonoCel = maskTelCell.Text

                };
                MessageBox.Show(cbo.Validar(pt), "Registro Cliente Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarDatos();
            }
            this.cargarClientes();
        }

        private void pictSave_MouseHover(object sender, EventArgs e)
        {
            if (modif == true)
            {
                pictSave.BackgroundImageLayout = ImageLayout.Stretch;
                pictSave.BackgroundImage = Properties.Resources.save_as;
            }
        }

        private void pictSave_MouseLeave(object sender, EventArgs e)
        {
            if (modif == false)
            {
                pictSave.BackgroundImageLayout = ImageLayout.Stretch;
                pictSave.BackgroundImage = Properties.Resources.save;
            }
        }

        private void pictLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }
    }
}

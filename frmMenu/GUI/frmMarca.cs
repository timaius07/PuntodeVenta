using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frmMenu.BO;
using frmMenu.Entidades;

namespace frmMenu.GUI
{
    public partial class frmMarca : Form
    {
        private MarcaBO mbo;

        public frmMarca()
        {
            InitializeComponent();
        }

        private void frmMarca_Load(object sender, EventArgs e)
        {
            mbo = new MarcaBO();
            dataGridMarca.DataSource = mbo.GetMarcas();
            this.dataGridMarca.Columns[0].Visible = false;
            dataGridMarca.Columns[1].Width = 210;
            dataGridMarca.Columns[1].HeaderText = "Descripción  Marca";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            mbo = new MarcaBO();

         if (MessageBox.Show("Realmente desea Eliminar la Marca?", " Eliminar Marca",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (lblID.Text != " ")
                {
                    if (mbo.EliminarMarca(Int32.Parse(lblID.Text)) == true)
                    {
                        MessageBox.Show("Se ha eliminado la Marca", "Eliminar Marca Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dataGridMarca.DataSource = mbo.GetMarcas();
                        this.dataGridMarca.Columns[0].Visible = false;
                        this.Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(" No ha seleccionado ningúna Marca, Posiblemente este asignada a un artículo", "Eliminar Marca Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mbo = new MarcaBO();

           
            if (txtMarca.Text == "")
            {
                MessageBox.Show(" No ingreso la Categoría, favor revise la información", "Registro Categoría fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Marca mc = new Marca()
                {
                    NombreMarca = txtMarca.Text,
                };
                MessageBox.Show(mbo.IngresarMarca(mc), "Registro Marca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridMarca.DataSource = mbo.GetMarcas();
                this.dataGridMarca.Columns[0].Visible = false;
                this.Limpiar();

            }
               
           
        }

        private void frmMarca_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Enabled = true;
        }

        private void dataGridMarca_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                lblID.Text = ((int)dataGridMarca.CurrentRow.Cells["Id"].Value).ToString();
                txtMarca.Text = (string)dataGridMarca.CurrentRow.Cells["NombreMarca"].Value;
                btnEliminar.Visible = true;
            }
            catch (Exception)
            {

            }
        }

        private void Limpiar()
        {
            lblID.Text = "# Automático";
            txtMarca.Text = "";
            txtMarca.Focus();
        }
    }
}

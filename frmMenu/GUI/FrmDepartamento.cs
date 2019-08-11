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
    public partial class FrmDepartamento : Form
    {
        private CategoriaBO cbo;

        public FrmDepartamento()
        {
            InitializeComponent();
        }

        private void FrmDepartamento_Load(object sender, EventArgs e)
        {
            cbo = new CategoriaBO();
            dataGridCateg.DataSource = cbo.GetCateg();
            this.dataGridCateg.Columns[0].Visible = false;
            dataGridCateg.Columns[1].Width = 210;
            dataGridCateg.Columns[1].HeaderText = "Descripción  Departamento";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCateg.Text == "")
                {
                    MessageBox.Show(" No ingreso la Categoría, favor revise la información", "Registro Categoría fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cbo = new CategoriaBO();
                    Categoria mc = new Categoria()
                    {
                        NombreCategoria = txtCateg.Text,
                    };
                    MessageBox.Show(cbo.IngresarCategoria(mc), "Registro Departamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridCateg.DataSource = cbo.GetCateg();
                    this.dataGridCateg.Columns[0].Visible = false;
                    this.Limpiar();
                }

            }
            catch (Exception)
            {
                MessageBox.Show(" Faltan datos, favor revise la informacion", "Registro Categoría fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cbo = new CategoriaBO();

            if (MessageBox.Show("Realmente desea Eliminar el Departamento?", " Eliminar Departamento",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (lblID.Text != " ")
                {
                    if (cbo.EliminaCategoria(Int32.Parse(lblID.Text)) == true)
                    {
                        MessageBox.Show("Se ha eliminado el Departamento", "Eliminar Departamento Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dataGridCateg.DataSource = cbo.GetCateg();
                        this.dataGridCateg.Columns[0].Visible = false;
                    }else
                    {
                        MessageBox.Show(" No ha seleccionado ningúna Departamento, Posiblemente este asignado a un artículo", "Eliminar Marca Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void dataGridCateg_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                lblID.Text = ((int)dataGridCateg.CurrentRow.Cells["Id"].Value).ToString();
                txtCateg.Text = (string)dataGridCateg.CurrentRow.Cells["NombreCategoria"].Value;
                btnEliminar.Visible = true;
            }
            catch (Exception)
            {

            }
        }

        private void Limpiar()
        {
            lblID.Text = "# Automático";
            txtCateg.Text = "";
            txtCateg.Focus();
        }

        private void FrmDepartamento_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Enabled = true;
        }
    }
}

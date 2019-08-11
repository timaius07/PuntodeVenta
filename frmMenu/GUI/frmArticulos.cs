using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frmMenu.GUI;
using frmMenu.BO;
using frmMenu.Entidades;

namespace frmMenu.GUI
{
    public partial class frmArticulos : Form
    {

        private MarcaBO mbo;
        private CategoriaBO cbo;
        private ArticuloBO abo;
        public Articulo Articulo { get; set; }
        public bool modif = false;
        private bool busqueda = false;
        private double util = 0;
        private double prec = 0;
        public int idCategoria = 0;
        public int idMarca = 0;
        private double prcosto = 0;
        private double prpubli = 0;
        private double prutil = 0;
        private double priv = 13;
        private double iv = 0;
        private bool impuesto = false;

        List<Articulo> lis = new List<Articulo>();

        public frmArticulos()
        {
            InitializeComponent();
        }

        private void frmArticulos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Enabled=true;
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            
            cbo = new CategoriaBO();
            mbo = new MarcaBO();
            List<Categoria> dims = cbo.GetCateg();
            cmbDepartamento.Items.AddRange(dims.ToArray<Categoria>());
            List<Marca> marc = mbo.GetMarcas();
            cmbMarca.Items.AddRange(marc.ToArray<Marca>());
            rdbImpSi.Checked = true;
            radBCodigo.Checked = true;
            this.cargarArtInv();
           


        }

        private void btnAgrandar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEncoger_Click(object sender, EventArgs e)
        {
         
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void txtCosto_ValueChanged(object sender, EventArgs e)
        {
            prcosto = Double.Parse(txtCosto.Text);
            int porc = 100;
            iv = (priv / porc) * prcosto;
            prcosto += iv;
            txtPrecioPub.Text = prcosto.ToString();
            txtImp.Text = iv.ToString();

        }
        //revisar verificar si se suma el impuesto al precio de venta

        private void Calcular_Util()
        {

            prcosto = Double.Parse(txtCosto.Text);
            prpubli = Double.Parse(txtPrecioPub.Text);
            
            if (rdbImpNo.Checked == true)
            {
                util = prpubli - prcosto;
                prutil = 100 * (util / prcosto);
                txtUtil.Text = prutil.ToString();
            }
            else
            {
                int porc = 100;
                iv = (priv / porc) * prcosto;
                prcosto += iv;
                util = prpubli - prcosto;
                prutil = 100*(util/prcosto);
                txtImp.Text = iv.ToString();
                txtUtil.Text = (prutil.ToString());
            }
                
        }
        private void Cambiar_Costo()
        {
           if (rdbImpNo.Checked == true)
            {
                if (txtUtil.Text != "")
                {
                    prcosto = Double.Parse(txtCosto.Text);
                    prutil = Double.Parse(txtUtil.Value.ToString());

                    int porc = 100;
                    util = (prutil / porc) * prcosto;
                    util = util + prcosto;
                    txtPrecioPub.Text = (util.ToString());
                    txtImp.Value = 0;
                }
            }else if (rdbImpSi.Checked == true){
                if (txtUtil.Text != "")
                {
                    prcosto = Double.Parse(txtCosto.Text);
                    prutil = Double.Parse(txtUtil.Value.ToString());
                    int porc = 100;
                    iv = (priv / porc) * prcosto;
                    prcosto += iv;
                    util = (prutil / porc) * prcosto;
                    txtImp.Text = iv.ToString();
                    util = util + prcosto;

                    txtPrecioPub.Text = (util.ToString());
                    
                    
                }
                
            }
            
        }

        private void buscarArt()
        {
            abo = new ArticuloBO();
            dataGridCliente.DataSource = null;
            try
            {
               if (radButDescripcion.Checked == true)
                {
                    lis = abo.GetDescArt(txtBuscar.Text);
                    idCategoria = lis[0].Cod_Depart.Id;
                    idMarca = lis[0].Cod_Marca.Id;
                    dataGridCliente.DataSource = lis;
                    // dataGridCliente.Columns["Precio_CostDesc"].DisplayIndex = 4;
                }
                else if (radBCodigo.Checked == true)
                {
                    lis = abo.GetArtCod(txtBuscar.Text);
                    idCategoria = lis[0].Cod_Depart.Id;
                    idMarca = lis[0].Cod_Marca.Id;
                    dataGridCliente.DataSource = lis;
                }
                this.OcultarDatagrid();
            }
            catch (Exception ex)
            {


            }
        }

        private void cargarArtInv()
        {
            abo = new ArticuloBO();
            dataGridCliente.DataSource = null;
            lis = abo.GetCargaInv();
            dataGridCliente.DataSource = lis;
            this.OcultarDatagrid();
            txtCodArt.Focus();

        }

        //OCULTA DETERMINADAS COLUMNAS DEL DATAGRID
        private void LimpiarDatos()
        {
            rdbImpSi.Checked = true;
            lblID.Text = "";
            txtCodArt.Text = "";
            txtDescp.Text = "";
            datimeFechaCompra.Text = "";
            txtCosto.Text = "0";
            txtUtil.Text = "0";
            txtPrecioPub.Text = "0";
            txtBuscar.Text = "";
            txtExistencia.Text = "";
            modif = false;
            txtCodArt.Enabled = true;
            txtExistencia.Enabled = true;
            datimeFechaCompra.Enabled = true;
            txtCodArt.Focus();
            modif = false;
            pictSave.BackgroundImage = Properties.Resources.save;
        }

        private void OcultarDatagrid()
        {
            this.dataGridCliente.Columns[2].Visible = false;
            this.dataGridCliente.Columns[6].Visible = false;
            this.dataGridCliente.Columns[7].Visible = false;
           
            
            dataGridCliente.Columns[0].Width = 160;
            dataGridCliente.Columns[1].Width = 229;
            dataGridCliente.Columns[3].Width = 90;
            dataGridCliente.Columns[4].Width = 90;
            dataGridCliente.Columns[5].Width = 90;
            dataGridCliente.Columns[8].Width = 35;

            dataGridCliente.Columns[0].HeaderText = "Codigo";
            dataGridCliente.Columns[1].HeaderText = "Descripción";
            dataGridCliente.Columns[3].HeaderText = "Existencia";
            dataGridCliente.Columns[4].HeaderText = "Costo ¢";
            dataGridCliente.Columns[5].HeaderText = "Venta ¢";
            dataGridCliente.Columns[8].HeaderText = "I.V";

        }

        private void txtUtil_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPrecioPub_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if (txtPrecioPub.Text != "")
                    {
                        prpubli = 0;
                        prpubli = Double.Parse(txtPrecioPub.Text);
                        prcosto = Double.Parse(txtCosto.Text);
                        int porc = 100;
                        prec = porc * (prpubli / prcosto);
                        txtUtil.Text = (prec.ToString());
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dataGridCliente.DataSource = null;
            this.buscarArt();

            modif = true;
            txtCodArt.Enabled = false;

            if (txtBuscar.Text == "")
            {
                LimpiarDatos();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void dataGridCliente_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtCodArt.Text = (string)dataGridCliente.CurrentRow.Cells["Cod_Art"].Value;
                txtDescp.Text = (string)dataGridCliente.CurrentRow.Cells["Descrip"].Value;
                datimeFechaCompra.Text = ((DateTime)dataGridCliente.CurrentRow.Cells["Fecha_Compra"].Value).ToString();
                txtCosto.Value = ((decimal)dataGridCliente.CurrentRow.Cells["Precio_Cost"].Value);
                txtPrecioPub.Value = ((decimal)dataGridCliente.CurrentRow.Cells["Precio_Venta"].Value);
                txtExistencia.Value = ((int)dataGridCliente.CurrentRow.Cells["Cantidad_Invt"].Value);
                impuesto = (bool)dataGridCliente.CurrentRow.Cells["Impuesto"].Value;
                if (impuesto == false)
                {
                    rdbImpNo.Checked = true;
                }
                else
                {
                    rdbImpSi.Checked = true;
                }
                txtCodArt.Enabled = false;
                modif = true;
                datimeFechaCompra.Enabled = false;

                int pos = e.RowIndex;
                idCategoria = lis[pos].Cod_Depart.Id;
                idMarca = lis[pos].Cod_Marca.Id;

                for (int i = 0; i < cmbMarca.Items.Count; i++)
                {
                    if (((Marca)cmbMarca.Items[i]).Id == idMarca)
                    {
                        cmbMarca.SelectedIndex = i;
                    }
                }
                //**************
                for (int i = 0; i < cmbDepartamento.Items.Count; i++)
                {
                    if (((Categoria)cmbDepartamento.Items[i]).Id == idCategoria)
                    {
                        cmbDepartamento.SelectedIndex = i;
                    }
                }
                Calcular_Util();
                this.Cambiar_Costo();
                txtCodArt.Focus();
            }
            catch (Exception)
            {

            }
        }

        private void txtPrecioPub_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                int porc = 100;
                try
                {
                    if (txtPrecioPub.Text != "")
                    {
                        if (rdbImpNo.Checked == true)
                        {
                            prcosto = Double.Parse(txtCosto.Text);
                            prpubli = 0;
                            prpubli = Double.Parse(txtPrecioPub.Text);
                            prec = prpubli - prcosto;
                            prec = porc * (prec / prcosto);
                            txtUtil.Text = (prec.ToString());                       

                        }
                        else if (rdbImpSi.Checked == true)
                        {

                            prcosto = Double.Parse(txtCosto.Text);
                            prpubli = 0;
                            prpubli = Double.Parse(txtPrecioPub.Text);
                            iv = (priv / porc) * prcosto;
                            prcosto += iv;
                            prec = prpubli - prcosto;
                            prec = porc * (prec / prcosto);
                            txtUtil.Text = (prec.ToString());        
                        }
                        
                    }
                }
                catch (Exception)
                {
                }
                cmbMarca.Focus();
            }
        }

        private void txtUtil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.Cambiar_Costo();
                txtPrecioPub.Focus();
            }
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.Cambiar_Costo();
                txtUtil.Focus();
            }            
                
        }

        private void rdbImpSi_Click(object sender, EventArgs e)
        {
            this.Cambiar_Costo();
        }

        private void rdbImpNo_Click(object sender, EventArgs e)
        {
            this.Cambiar_Costo();
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDepartamento.Focus();
        }

        private void txtCodArt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
               txtDescp.Focus();
            }
        }

        private void txtDescp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                datimeFechaCompra.Focus();
            }
        }

        private void datimeFechaCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtCosto.Focus();
            }
        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
                txtExistencia.Focus();
        }

        private void txtExistencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                pictSave.Focus();
            }
        }

        private void pictSave_Click(object sender, EventArgs e)
        {
            prcosto = Convert.ToDouble(txtCosto.Value);
            prpubli = Convert.ToDouble(txtPrecioPub.Value);
            prutil = Convert.ToDouble(txtUtil.Value);
            abo = new ArticuloBO();

            if (modif == true & txtCodArt.Text != "")
            {
                Articulo at = new Articulo()
                {
                    Cod_Art = txtCodArt.Text,
                    Descrip = txtDescp.Text,
                    Fecha_Compra = Convert.ToDateTime(datimeFechaCompra.Text),
                    Precio_Cost = Convert.ToDecimal(prcosto),
                    Precio_Venta = Convert.ToDecimal(prpubli),
                    Cod_Marca = (Marca)cmbMarca.SelectedItem,
                    Cod_Depart = (Categoria)cmbDepartamento.SelectedItem,
                    Cantidad_Invt = Convert.ToInt32(txtExistencia.Text),
                    Impuesto = rdbImpSi.Checked,



                };
                MessageBox.Show(abo.ModificarArt(at), "Modificacion Artículo Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else

            {

                try
                {
                    Articulo at = new Articulo()
                    {

                        Cod_Art = txtCodArt.Text,
                        Descrip = txtDescp.Text,
                        Fecha_Compra = Convert.ToDateTime(datimeFechaCompra.Text),
                        Precio_Cost = Convert.ToDecimal(prcosto),
                        Precio_Venta = Convert.ToDecimal(prpubli),
                        Cod_Marca = (Marca)cmbMarca.SelectedItem,
                        Cod_Depart = (Categoria)cmbDepartamento.SelectedItem,
                        Cantidad_Invt = Convert.ToInt32(txtExistencia.Text),
                        Impuesto = rdbImpSi.Checked,

                    };
                    MessageBox.Show(abo.IngrearArt(at), "Registro Articulo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {

                    throw;
                }

            }

            if (radBCodigo.Checked == true)
            {
                this.buscarArt();
            }
            else if (radButDescripcion.Checked == true)
            {
                this.buscarArt();
            }
        }

        private void pictLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
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
    }
}

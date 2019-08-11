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
    public partial class frmFacturar : Form
    {
        private ArticuloBO abo;
        public Articulo Articulo { get; set; }
        List<Articulo> lis = new List<Articulo>();
        string codigo = "";
        decimal cantidadArt = 0;
        string descripción = "";
        decimal precioVenta = 0;
        decimal subtotal = 0;
		decimal descuento = 0;
        bool impuestoFV = false;
		decimal subtotalfactura = 0;
		decimal	descuentofactura = 0;
		decimal	impuestofactura = 0;
		decimal	totalfinalfactura = 0;


        public frmFacturar()
        {
            InitializeComponent();
         
        }

        private void IniciarDatagrid()
        {

            dataGridFact.ColumnCount = 6;
            DataGridViewCheckBoxColumn col1 = new DataGridViewCheckBoxColumn();
            dataGridFact.Columns[0].Name = "Codigo Art";
            dataGridFact.Columns[1].Name = "Descripción";
            dataGridFact.Columns[2].Name = "Cantidad";
			dataGridFact.Columns[3].Name = "Descuento";
			dataGridFact.Columns[4].Name = "Precio";
            dataGridFact.Columns[5].Name = "SubTotal";
            //agregar columna de impuesto con check
            dataGridFact.Columns.Add(col1);
            dataGridFact.Columns[6].Name = "I.V";
            dataGridFact.Columns[0].Width = 130;
            dataGridFact.Columns[1].Width = 195;
            dataGridFact.Columns[2].Width = 100;
            dataGridFact.Columns[3].Width = 100;
            dataGridFact.Columns[4].Width = 100;
            dataGridFact.Columns[5].Width = 100;
			dataGridFact.Columns[6].Width = 50;

		}
        private void buscarArt()
        {
            abo = new ArticuloBO();
           
            try 
            {
               
            lis = abo.GetArtCod(txtCodigo.Text);
            if (lis.Count>0) {
                    
                    descripción = lis[0].Descrip;
                    lblDescrip.Text = descripción;
                    numcantidad.Select();
                }
                else
                {
                 MessageBox.Show("El articulo ingresado no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //  this.OcultarDatagrid();
            }
            catch (Exception ex)
            {


            }
        }

		private void nuevoArt()
		{
			txtCodigo.Text = "";
			lblDescrip.Text = "";
			txtCodigo.Focus();
		}
		private void SumarTotales()
		{
			decimal impuesto = 0;
			subtotalfactura = 0;
			decimal subtSumar = 0;
			descuentofactura = 0;
			impuestofactura = 0;
			totalfinalfactura = 0;
			foreach (DataGridViewRow row in dataGridFact.Rows)
			{
				//aqui solo validar subtotales.
				//aplicar descuentos individualmente y luego sumarlos
				subtotalfactura = Convert.ToDecimal(row.Cells["SubTotal"].Value);
			    descuentofactura = Convert.ToDecimal(row.Cells["Descuento"].Value);
				impuestoFV = Convert.ToBoolean(row.Cells["I.V"].Value);
				if (impuestoFV == true)
				{
					//impuesto = Convert.ToDecimal(lblDesc.Text) ;
					impuesto = (subtotalfactura-descuentofactura)  ;
					impuestofactura += impuesto * Convert.ToDecimal(0.13);
				    lblIV.Text = (impuestofactura.ToString());
				}
				subtSumar += subtotalfactura;
				totalfinalfactura = subtSumar - descuentofactura+impuestofactura;
			}

			lblSubtotal.Text = (subtSumar.ToString());
			lblDesc.Text = (descuentofactura.ToString());
			lblTotal.Text = (totalfinalfactura.ToString());

		}

		private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
			
			
        }

        private void frmFacturar_Load(object sender, EventArgs e)
        {
            IniciarDatagrid();
        }

        private void numcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                abo = new ArticuloBO();

            try
            {

                lis = abo.GetArtCod(txtCodigo.Text);
                if (lis.Count > 0)
                {
                    codigo = lis[0].Cod_Art;
                    descripción = lis[0].Descrip;
                    cantidadArt = numcantidad.Value;
                    precioVenta = lis[0].Precio_Venta;
					descuento = (precioVenta * numDesc.Value)/100;
                    subtotal = cantidadArt * precioVenta;
                    impuestoFV = lis[0].Impuesto;
                    // dataGridCliente.Columns["Precio_CostDesc"].DisplayIndex = 4;
                    object[] row1 = new object[] { codigo, descripción, cantidadArt,descuento, precioVenta, subtotal, impuestoFV };
                    dataGridFact.Rows.Add(row1);
					this.nuevoArt();
					this.SumarTotales();
					}

                //  this.OcultarDatagrid();
            }
            catch (Exception ex)
            {


            }

            }
        }

		private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == Convert.ToChar(Keys.Enter))
			{
				abo = new ArticuloBO();

				try
				{

					lis = abo.GetArtCod(txtCodigo.Text);
					if (lis.Count > 0)
					{
						this.buscarArt();
						
					}

					//  this.OcultarDatagrid();
				}
				catch (Exception ex)
				{


				}

			}
			
		}
	}
}

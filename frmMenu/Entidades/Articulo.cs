using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmMenu.Entidades
{
    public class Articulo
    {
        public string Cod_Art { get; set; } //0
        public string Descrip { get; set; }//1
        public DateTime Fecha_Compra { get; set; }//2
        public int Cantidad_Invt { get; set; }//3
        public decimal Precio_Cost { get; set; }//4
        public decimal Precio_Venta { get; set; }//5
        public Marca Cod_Marca { get; set; }//6
        public Categoria Cod_Depart { get; set; }//7
        public bool Impuesto { get; set; }//8
       
    }
}

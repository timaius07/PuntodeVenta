using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using frmMenu.DAO;
using frmMenu.Entidades;

namespace frmMenu.BO
{
    public class ArticuloBO
    {
        ArticuloDAO adao;
        /// <summary>
        /// instancia para conectarse al DAO Articulo
        /// </summary>
        public ArticuloBO()
        {
            adao = new ArticuloDAO();
        }
        /// <summary>
        /// ingresar los datos de los articulos
        /// </summary>
        /// <param name="art">entidad con los nombres de los articulos</param>
        /// <returns></returns>
        public string IngrearArt(Articulo art)
        {
            if (!(art.Descrip == "" || art.Cod_Art == "" || art.Precio_Cost <= 0 || art.Precio_Venta <= 0))
            {
                if (art.Cod_Marca != null)
                {
                    if (art.Cod_Depart != null)
                    {
                        if (art.Cantidad_Invt > 0)
                        {
                            return adao.RegistrarArticulo(art) != null ? "Registro con exito" : "Artículo registrado";
                        }
                        return "La cantidad en existencía no es valida";
                    }
                    return "Seleccione una categoria";
                }
                return "Selecciones una Marca";
            }
            return "Hay espacios requeridos vacios";
        }

        /// <summary>
        /// modifica los datos del articulo
        /// </summary>
        /// <param name="art">entidad con los datos del articulo</param>
        /// <returns></returns>
        public string ModificarArt(Articulo art)
        {
            if (!(art.Descrip == "" || art.Precio_Venta <= 0))

            {
                return adao.ModificarArticulo(art).Cod_Art != null ? "Registro con exito" : "Exito al Modificar";
            }
            else
            {
                return "Hay espacios requeridos vacios o erroneos";
            }
        }
        /// <summary>
        /// devuelve los datos del articulo por descripcion
        /// </summary>
        /// <param name="descArt">descripcion del articulo</param>
        /// <returns></returns>
        public List<Articulo> GetDescArt(string descArt)
        {
            adao = new ArticuloDAO();
            return adao.GetArtiDesc(descArt);
        }
        /// <summary>
        /// devuelve los datos del articulo por codigo
        /// </summary>
        /// <param name="codArt">codigo del articulo</param>
        /// <returns></returns>
        public List<Articulo> GetArtCod(string codArt)
        {
            adao = new ArticuloDAO();
            return adao.GetArtCod(codArt);
        }
    
        /// <summary>
        /// manda al dao para cargar los datos del articulo que se modifican cuando
        /// se aplica el inventario
        /// </summary>
        /// <param name="codArt">codigo del articulo</param>
        /// <returns></returns>
        public List<Articulo> GetCargaInv()
        {
            adao = new ArticuloDAO();
            return adao.GetArticuloInv();
        }
        /// <summary>
        /// modifica los datos del articulo despues de aplicar el inventario
        /// </summary>
        /// <param name="art">entidad del articulo con los datos modificados</param>
        /// <returns></returns>
        public bool ModificarArtApliInvent(Articulo art)
        {
            if (!(art.Cod_Art == "" || art.Precio_Cost <= 0 || art.Precio_Venta <= 0))
            {
                adao.ModificarArtCompra(art);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

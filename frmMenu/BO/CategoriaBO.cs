using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frmMenu.DAO;
using frmMenu.Entidades;

namespace frmMenu.BO
{
   public  class CategoriaBO
    {
        CategoriaDAO cdao;
       /// <summary>
       /// iniciamos la entidad de categoria para acceder al DAOCategoria
       /// </summary>
        public CategoriaBO()
        {
            cdao = new CategoriaDAO();
        }
        /// <summary>
        /// ingresamos los datos de la categoria con la entidad categoria
        /// </summary>
        /// <param name="mc">entidad categoria</param>
        /// <returns></returns>
        public string IngresarCategoria(Categoria mc)
        {
            try
            {
                return cdao.RegistrarCliente(mc).Id > 0 ? "Registro con exito" : "Se ingreso el Nuevo Departamento";
            }
            catch (Exception)
            {
               // MessageBox.Show("No se puede Registrar una Marca ya exsitente", "Ingresar Marca Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

        }
        /// <summary>
        /// elimina la categoria del articulo mediante el id
        /// </summary>
        /// <param name="idCat">id de la categoria</param>
        /// <returns></returns>
        public bool EliminaCategoria(int idCat)
        {
            return cdao.Eliminar_Categoria(idCat);
        }
        /// <summary>
        /// carga todos los datos de las categorias
        /// </summary>
        /// <returns></returns>
        public List<Categoria> GetCateg()
        {
            cdao = new CategoriaDAO();
            return cdao.GetCategoria();
        }
    }
}

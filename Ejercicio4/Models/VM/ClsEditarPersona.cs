using Ejercicio4.Models.DAL;
using Ejercicio4.Models.ENTIDADES;

namespace Ejercicio4.Models.VM
{
    
    public class ClsEditarPersona
    {
        #region Atributos
        List<ClsDepartamento>departamentos { get; }
        #endregion

        #region Constructor
        public ClsEditarPersona()
        {

            departamentos = ClsListados.obtenerDepartamentos();
        }
        #endregion
    }
}

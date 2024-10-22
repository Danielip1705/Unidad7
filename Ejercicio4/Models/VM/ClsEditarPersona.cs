using Ejercicio4.Models.DAL;
using Ejercicio4.Models.ENTIDADES;

namespace Ejercicio4.Models.VM
{
    public class ClsEditarPersona
    {
         List<ClsDepartamento>departamentos { get; }



        public ClsEditarPersona()
        {

            departamentos = ClsListados.obtenerDepartamentos();
        }
    }
}

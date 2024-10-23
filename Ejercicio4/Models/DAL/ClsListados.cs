using Ejercicio4.Models.ENTIDADES;

namespace Ejercicio4.Models.DAL
{
    public class ClsListados
    {
        #region Funciones
        /// <summary>
        /// Funcion que inicializa una lista con personas añadidas en la funcion
        /// </summary>
        /// <returns>Lista de personas</returns>
        public static List<ClsPersona> obtenerPersonas()
        {
            List<ClsPersona> listadoPersonas = new List<ClsPersona>() {
               new ClsPersona("Daniel","Iglesias",19,3),
               new ClsPersona("Pablo","Iglesias",19,2),
               new ClsPersona("Martin","Navarra",43,5),
               new ClsPersona("Mac","Clovin",29,1),
               new ClsPersona("Evelyn","Lamarra",22,4),
               new ClsPersona("Sara","Muñoz",26,5),

            };


            return listadoPersonas;
        }
        /// <summary>
        /// Funcion que inicializa una lista con departamentos añadidos en la funcion
        /// </summary>
        /// <returns>Una lista de departamentos</returns>
        public static List<ClsDepartamento> obtenerDepartamentos()
        {
            List<ClsDepartamento> listadoDepartamentos = new List<ClsDepartamento>()
            {
                new ClsDepartamento("Marketing",1),
                new ClsDepartamento("Contabilidad",2),
                new ClsDepartamento("Servicio al cliente",3),
                new ClsDepartamento("Seguridad",4),
                new ClsDepartamento("Ventas",5),
            };

            return listadoDepartamentos;
        }
        #endregion
    }
}

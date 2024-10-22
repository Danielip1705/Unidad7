using Ejercicio4.Models.ENTIDADES;

namespace Ejercicio4.Models.DAL
{
    public class ListadoClsPersona
    {
        public static List<ClsPersona> ObtenerPersonas()
        {
            List<ClsPersona> listadoPersonas = new List<ClsPersona>() {
               new ClsPersona("Daniel","Iglesias",19,3),};
        }
    }
}

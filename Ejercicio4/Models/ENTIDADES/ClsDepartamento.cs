namespace Ejercicio4.Models.ENTIDADES
{
    public class ClsDepartamento
    {
        /// <summary>
        /// Declaracion de atribuos implementados
        /// </summary>
        #region Atributos
        public String NombreDepart {  get; set; }
        public int IdDepart { get; }
        #endregion

        /// <summary>
        /// Declaracion de constructor con parametros
        /// </summary>
        /// <param name="nombre">Nombre del departamento</param>
        /// <param name="id">Id del departamento</param>
        public ClsDepartamento(String nombre,int id){
        NombreDepart = nombre;
        IdDepart = id;
        }
    }
}

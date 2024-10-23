namespace Ejercicio4.Models.ENTIDADES
{
    public class ClsDepartamento
    {
        #region Atributos
        /// <summary>
        /// Declaracion de atribuos implementados
        /// </summary>
        public String NombreDepart {  get; set; }
        public int IdDepart { get; }
        #endregion

        #region Constructores
        /// <summary>
        /// Declaracion de constructor con parametros
        /// </summary>
        /// <param name="nombre">Nombre del departamento</param>
        /// <param name="id">Id del departamento</param>
        public ClsDepartamento(String nombre,int id){
        NombreDepart = nombre;
        IdDepart = id;
        }
        #endregion
    }
}

namespace Ejercicio4.Models.ENTIDADES
{
    public class ClsPersona
    {
        #region 
        /// <summary>
        /// Declaracion de atributos autoimplementados
        /// </summary>
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public int Edad {  get; set; }

        public int IdDepart {  get; }

        /// <summary>
        /// Declaracion del contructor con parametros
        /// </summary>
        /// <param name="nombre">Nombre de la persona</param>
        /// <param name="apellido">Apellido de la persona</param>
        /// <param name="edad">Edad de la persona</param>
        /// <param name="idDepart">Id del departamento</param>
        public ClsPersona(string nombre, string apellido, int edad, int idDepart)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            IdDepart = idDepart;
        }



        #endregion

    }
}

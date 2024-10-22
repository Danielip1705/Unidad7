namespace EjercicioUnidad7.Models
{
    public class ClsPersona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad {  get; set; }
        public ClsPersona(String nombre,String apellido,int edad) { 
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
        }
    }
}


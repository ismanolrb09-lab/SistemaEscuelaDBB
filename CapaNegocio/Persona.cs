namespace CapaNegocio
{
    // Clase abstracta - no se puede instanciar directamente
    // Es la base para Estudiante
    public abstract class Persona
    {
        public string Nombre;
        public string Apellido;

        // Constructor que recibe nombre y apellido
        public Persona(string nombre, string apellido)
        {
            Nombre   = nombre;
            Apellido = apellido;
        }

        // Metodo normal - devuelve nombre completo
        public string NombreCompleto()
        {
            return Nombre + " " + Apellido;
        }

        // Metodo virtual - puede ser sobreescrito por las clases hijas
        public virtual string Descripcion()
        {
            return "Persona: " + NombreCompleto();
        }

        // Metodo abstracto - DEBE ser implementado por las clases hijas
        public abstract string MostrarDatos();
    }
}

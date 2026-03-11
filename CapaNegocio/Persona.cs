namespace CapaNegocio
{
    // Clase abstracta - no se puede instanciar directamente
    // Es la base para Estudiante
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Persona(string nombre, string apellido)
        {
            Nombre   = nombre;
            Apellido = apellido;
        }

        // para que devuelva nombre completo
        public string NombreCompleto()
        {
            return Nombre + " " + Apellido;
        }

        //  este puede ser sobreescrito por las clases hijas
        public virtual string Descripcion()
        {
            return "Persona: " + NombreCompleto();
        }

        // para ser implementado por las clases hija
        public abstract string MostrarDatos();
    }
}

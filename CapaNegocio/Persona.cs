namespace CapaNegocio
{
   
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Persona(string nombre, string apellido)
        {
            Nombre   = nombre;
            Apellido = apellido;
        }
        public Persona()
        {
        }
        public string NombreCompleto()
        {
            return Nombre + " " + Apellido;
        }

        //  este puede ser sobreescrito por las clases hijas
        public virtual string Descripcion()
        {
            return "Persona: " + NombreCompleto();
        }

        public abstract string MostrarDatos();
    }
}

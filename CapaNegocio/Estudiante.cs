namespace CapaNegocio
{
    // Estudiante hereda de Persona (herencia)
    public class Estudiante : Persona
    {
        public int IdEstudiante { get; set; }
        public string Matricula { get; set; }
        public int IdSeccion { get; set; }

        //nose como resolverlo, pero no da error critico
        public Estudiante(string matricula, string nombre, string apellido)
        {
            Matricula = matricula;
            Nombre = nombre;
            Apellido = apellido;
        }

        // Override del metodo abstracto para que sea obligatorio implementarlo
        public override string MostrarDatos()
        {
            return Matricula + " - " + NombreCompleto();
        }

        // Override del metodo virtual de Persona
        public override string Descripcion()
        {
            return "Estudiante: " + MostrarDatos();
        }

        // para modificar 
        public virtual string ObtenerMatricula()
        {
            return Matricula;
        }

        //validacion 
        public string Validar()
        {
            if (Matricula == null || Matricula == "")
                return "La matricula es obligatoria.";

            if (Nombre == null || Nombre == "")
                return "El nombre es obligatorio.";

            if (Apellido == null || Apellido == "")
                return "El apellido es obligatorio.";

            if (IdSeccion == 0)
                return "Debes seleccionar una seccion.";

            return "";
        }
    }
}

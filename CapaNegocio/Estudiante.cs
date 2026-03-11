namespace CapaNegocio
{
    // Estudiante hereda de Persona (herencia)
    public class Estudiante : Persona
    {
        public int    IdEstudiante;
        public string Matricula;
        public int    IdSeccion;

        // Constructor que llama al constructor de Persona con : base()
        public Estudiante(string matricula, string nombre, string apellido)
            : base(nombre, apellido)
        {
            Matricula = matricula;
        }

        // Override del metodo abstracto - obligatorio implementarlo
        public override string MostrarDatos()
        {
            return Matricula + " - " + NombreCompleto();
        }

        // Override del metodo virtual de Persona
        public override string Descripcion()
        {
            return "Estudiante: " + MostrarDatos();
        }

        // Metodo virtual propio - puede ser sobreescrito
        public virtual string ObtenerMatricula()
        {
            return Matricula;
        }

        // Metodo funcion - valida los datos antes de guardar
        public string Validar()
        {
            if (Matricula == null || Matricula.Trim() == "")
                return "La matricula es obligatoria.";

            if (Nombre == null || Nombre.Trim() == "")
                return "El nombre es obligatorio.";

            if (Apellido == null || Apellido.Trim() == "")
                return "El apellido es obligatorio.";

            if (IdSeccion == 0)
                return "Debes seleccionar una seccion.";

            return "";
        }
    }
}

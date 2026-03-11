using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    // Capa negocio para estudiantes
    // Esta clase es la que llama el formulario
    // Nunca el formulario llama directo a CapaDatos
    public class EstudianteNegocio
    {
        EstudianteDatos datos = new EstudianteDatos();

        // Obtiene todos los estudiantes
        public DataTable MostrarEstudiantes()
        {
            return datos.ObtenerEstudiantes();
        }

        // Obtiene cursos para el ComboBox
        public DataTable ObtenerCursos()
        {
            return datos.ObtenerCursos();
        }

        // Obtiene secciones por curso para el ComboBox
        public DataTable ObtenerSecciones(int idCurso)
        {
            return datos.ObtenerSecciones(idCurso);
        }

        // Obtiene estudiantes por seccion para el ComboBox de asistencia
        public DataTable ObtenerEstudiantesPorSeccion(int idSeccion)
        {
            return datos.ObtenerEstudiantesPorSeccion(idSeccion);
        }

        // Registra un nuevo estudiante con validacion
        public string RegistrarEstudiante(string matricula, string nombre, string apellido, int idSeccion)
        {
            Estudiante est = new Estudiante(matricula, nombre, apellido);
            est.IdSeccion  = idSeccion;

            string error = est.Validar();

            if (error != "")
                return error;

            datos.Insertar(matricula, nombre, apellido, idSeccion);
            return "";
        }

        // Edita un estudiante existente con validacion
        public string EditarEstudiante(int idEstudiante, string matricula, string nombre, string apellido, int idSeccion)
        {
            Estudiante est = new Estudiante(matricula, nombre, apellido);
            est.IdSeccion  = idSeccion;

            string error = est.Validar();

            if (error != "")
                return error;

            datos.Editar(idEstudiante, matricula, nombre, apellido, idSeccion);
            return "";
        }

        // Elimina un estudiante
        public void EliminarEstudiante(int idEstudiante)
        {
            datos.Eliminar(idEstudiante);
        }
    }
}

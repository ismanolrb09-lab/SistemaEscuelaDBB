using CapaDatos;
using System.Data;

namespace CapaNegocio
{
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

        // 2
        public DataTable ObtenerSecciones(int idCurso)
        {
            return datos.ObtenerSecciones(idCurso);
        }

        // 3
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


        // Edita un estudiante existente
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



        public void EliminarEstudiante(int idEstudiante)
        {
            datos.Eliminar(idEstudiante);
        }
    }
}

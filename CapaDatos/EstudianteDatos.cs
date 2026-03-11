using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class EstudianteDatos
    {
        ConexionBD con = new ConexionBD();

        // Obtiene todos los estudiantes con curso y seccion
        public DataTable ObtenerEstudiantes()
        {
            DataTable dt = new DataTable();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerEstudiantes", con.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                con.CerrarConexion();
            }
            catch
            {
                con.CerrarConexion();
            }

            return dt;
        }

        // Obtiene todos los cursos para el ComboBox
        public DataTable ObtenerCursos()
        {
            DataTable dt = new DataTable();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerCursos", con.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                con.CerrarConexion();
            }
            catch
            {
                con.CerrarConexion();
            }

            return dt;
        }

        // Obtiene secciones por curso para el ComboBox
        public DataTable ObtenerSecciones(int idCurso)
        {
            DataTable dt = new DataTable();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerSecciones", con.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCurso", idCurso);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                con.CerrarConexion();
            }
            catch
            {
                con.CerrarConexion();
            }

            return dt;
        }

        // Obtiene estudiantes por seccion para el ComboBox de asistencia
        public DataTable ObtenerEstudiantesPorSeccion(int idSeccion)
        {
            DataTable dt = new DataTable();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerEstudiantesPorSeccion", con.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdSeccion", idSeccion);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                con.CerrarConexion();
            }
            catch
            {
                con.CerrarConexion();
            }

            return dt;
        }

        // Inserta un nuevo estudiante
        public void Insertar(string matricula, string nombre, string apellido, int idSeccion)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarEstudiante", con.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Matricula",  matricula);
                cmd.Parameters.AddWithValue("@Nombre",     nombre);
                cmd.Parameters.AddWithValue("@Apellido",   apellido);
                cmd.Parameters.AddWithValue("@IdSeccion",  idSeccion);

                cmd.ExecuteNonQuery();
                con.CerrarConexion();
            }
            catch
            {
                con.CerrarConexion();
            }
        }

        // Edita un estudiante existente
        public void Editar(int idEstudiante, string matricula, string nombre, string apellido, int idSeccion)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_EditarEstudiante", con.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdEstudiante", idEstudiante);
                cmd.Parameters.AddWithValue("@Matricula",    matricula);
                cmd.Parameters.AddWithValue("@Nombre",       nombre);
                cmd.Parameters.AddWithValue("@Apellido",     apellido);
                cmd.Parameters.AddWithValue("@IdSeccion",    idSeccion);

                cmd.ExecuteNonQuery();
                con.CerrarConexion();
            }
            catch
            {
                con.CerrarConexion();
            }
        }

        // Elimina un estudiante
        public void Eliminar(int idEstudiante)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarEstudiante", con.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdEstudiante", idEstudiante);

                cmd.ExecuteNonQuery();
                con.CerrarConexion();
            }
            catch
            {
                con.CerrarConexion();
            }
        }
    }
}

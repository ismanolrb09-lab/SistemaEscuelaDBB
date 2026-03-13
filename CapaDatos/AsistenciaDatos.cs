using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class AsistenciaDatos
    {
        ConexionBD con = new ConexionBD();

        // Registra o actualiza
        public void RegistrarAsistencia(int idEstudiante, System.DateTime fecha, bool presente)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_RegistrarAsistencia", con.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdEstudiante", idEstudiante);
                cmd.Parameters.AddWithValue("@Fecha",        fecha.Date);
                cmd.Parameters.AddWithValue("@Presente",     presente);

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

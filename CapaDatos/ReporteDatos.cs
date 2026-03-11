using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ReporteDatos
    {
        ConexionBD con = new ConexionBD();

        // Obtiene el ranking de inasistencias
        public DataTable RankingInasistencia()
        {
            DataTable dt = new DataTable();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_RankingInasistencia", con.AbrirConexion());
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

        // Obtiene estudiantes con asistencia menor al 80%
        public DataTable AlertaAsistencia()
        {
            DataTable dt = new DataTable();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_AlertaAsistencia80", con.AbrirConexion());
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
    }
}

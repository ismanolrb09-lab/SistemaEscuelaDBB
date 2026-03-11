using System.Data.SqlClient;

namespace CapaDatos
{
    public class ConexionBD
    {
        private SqlConnection Conexion = new SqlConnection(
            "Server=.;DataBase=EscuelaDB;Integrated Security=true");

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == System.Data.ConnectionState.Closed)
                Conexion.Open();

            return Conexion;
        }

        public void CerrarConexion()
        {
            if (Conexion.State == System.Data.ConnectionState.Open)
                Conexion.Close();
        }
    }
}

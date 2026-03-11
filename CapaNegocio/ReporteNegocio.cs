using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    // Capa negocio para reportes
    public class ReporteNegocio
    {
        ReporteDatos datos = new ReporteDatos();

        // Obtiene el ranking de inasistencias
        public DataTable ObtenerRankingInasistencia()
        {
            return datos.RankingInasistencia();
        }

        // Obtiene estudiantes con asistencia menor al 80%
        public DataTable ObtenerAlertas()
        {
            return datos.AlertaAsistencia();
        }
    }
}

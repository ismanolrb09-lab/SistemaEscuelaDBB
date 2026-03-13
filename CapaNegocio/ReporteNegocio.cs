using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class ReporteNegocio
    {
        ReporteDatos datos = new ReporteDatos();

        public DataTable ObtenerRankingInasistencia()
        {
            return datos.RankingInasistencia();
        }

        //menor al 80%
        public DataTable ObtenerAlertas()
        {
            return datos.AlertaAsistencia();
        }
    }
}

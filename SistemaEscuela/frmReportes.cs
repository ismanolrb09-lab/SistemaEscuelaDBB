using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace SistemaEscuela
{
    public partial class frmReportes : Form
    {
        ReporteNegocio negocio = new ReporteNegocio();

        public frmReportes()
        {
            InitializeComponent();
            this.Text = "Reportes y Alertas";
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            DataTable dt = negocio.ObtenerRankingInasistencia();
            dgvReporte.DataSource = dt;
            lblInfo.Text = "Ranking de inasistencias - Total: " + dt.Rows.Count + " estudiantes";
        }

        private void btnAlertas_Click(object sender, EventArgs e)
        {
            DataTable dt = negocio.ObtenerAlertas();
            dgvReporte.DataSource = dt;
            lblInfo.Text = "Estudiantes con menos del 80%: " + dt.Rows.Count;

            foreach (DataGridViewRow fila in dgvReporte.Rows)
            {
                if (fila.IsNewRow == true) continue;

                decimal porcentaje = Convert.ToDecimal(fila.Cells["Porcentaje"].Value);

                if (porcentaje < 60)
                    fila.DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
                else
                    fila.DefaultCellStyle.BackColor = System.Drawing.Color.LightYellow;
            }
        }
    }
}

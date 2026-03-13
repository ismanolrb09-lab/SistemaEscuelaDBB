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
    public partial class frmAsistencia : Form
    {
        EstudianteNegocio negocioEst = new EstudianteNegocio();
        AsistenciaNegocio negocioAsis = new AsistenciaNegocio();

        public frmAsistencia()
        {
            InitializeComponent();
            this.Text = "Registrar Asistencia";
        }

        private void frmAsistencia_Load(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Today;
            CargarCursos();
        }

        private void CargarCursos()
        {
            DataTable dt = negocioEst.ObtenerCursos();
            cboCurso.DisplayMember = "NombreCurso";
            cboCurso.ValueMember = "IdCurso";
            cboCurso.DataSource = dt;
        }

        private void cboCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCurso.SelectedValue == null) return;

            int idCurso = Convert.ToInt32(cboCurso.SelectedValue);
            DataTable dt = negocioEst.ObtenerSecciones(idCurso);
            cboSeccion.DisplayMember = "NombreSeccion";
            cboSeccion.ValueMember = "IdSeccion";
            cboSeccion.DataSource = dt;
        }

        private void cboSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSeccion.SelectedValue == null) return;

            int idSeccion = Convert.ToInt32(cboSeccion.SelectedValue);
            DataTable dt = negocioEst.ObtenerEstudiantesPorSeccion(idSeccion);
            cboEstudiante.DisplayMember = "Nombre";
            cboEstudiante.ValueMember = "IdEstudiante";
            cboEstudiante.DataSource = dt;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cboEstudiante.SelectedValue == null)
            {
                MessageBox.Show("Selecciona un estudiante.");
                return;
            }

            int idEstudiante = Convert.ToInt32(cboEstudiante.SelectedValue);
            bool presente = chkPresente.Checked;

            string error = negocioAsis.GuardarAsistencia(idEstudiante, dtpFecha.Value, presente);

            if (error != "")
            {
                MessageBox.Show(error);
                return;
            }

            string estado = "";

            if (presente == true)
                estado = "Presente";
            else
                estado = "Ausente";

            MessageBox.Show("Asistencia registrada: " + estado);
        }
    }
}

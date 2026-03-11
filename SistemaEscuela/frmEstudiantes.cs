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
    public partial class frmEstudiantes : Form
    {
        EstudianteNegocio negocio = new EstudianteNegocio();
        int idSeleccionado = 0;

        public frmEstudiantes()
        {
            InitializeComponent();
            this.Text = "Gestion de Estudiantes";
        }

        private void frmEstudiantes_Load(object sender, EventArgs e)
        {
            CargarCursos();
            CargarLista();
        }

        private void CargarCursos()
        {
            DataTable dt = negocio.ObtenerCursos();
            cboCurso.DisplayMember = "NombreCurso";
            cboCurso.ValueMember = "IdCurso";
            cboCurso.DataSource = dt;
        }

        private void cboCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCurso.SelectedValue == null) return;

            int idCurso = Convert.ToInt32(cboCurso.SelectedValue);
            DataTable dt = negocio.ObtenerSecciones(idCurso);
            cboSeccion.DisplayMember = "NombreSeccion";
            cboSeccion.ValueMember = "IdSeccion";
            cboSeccion.DataSource = dt;
        }

        private void CargarLista()
        {
            dgvEstudiantes.DataSource = negocio.MostrarEstudiantes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cboSeccion.SelectedValue == null)
            {
                MessageBox.Show("Selecciona una seccion.");
                return;
            }

            int idSeccion = Convert.ToInt32(cboSeccion.SelectedValue);
            string error = "";

            if (idSeleccionado == 0)
                error = negocio.RegistrarEstudiante(txtMatricula.Text, txtNombre.Text, txtApellido.Text, idSeccion);
            else
                error = negocio.EditarEstudiante(idSeleccionado, txtMatricula.Text, txtNombre.Text, txtApellido.Text, idSeccion);

            if (error != "")
            {
                MessageBox.Show(error);
                return;
            }

            MessageBox.Show("Guardado correctamente.");
            Limpiar();
            CargarLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un estudiante de la lista.");
                return;
            }

            if (MessageBox.Show("Desea eliminar este estudiante?", "Confirmar",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                negocio.EliminarEstudiante(idSeleccionado);
                MessageBox.Show("Eliminado correctamente.");
                Limpiar();
                CargarLista();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgvEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvEstudiantes.Rows[e.RowIndex];

            if (fila.Cells["IdEstudiante"].Value == null || fila.Cells["IdEstudiante"].Value == DBNull.Value) return;

            idSeleccionado = Convert.ToInt32(fila.Cells["IdEstudiante"].Value);
            txtMatricula.Text = fila.Cells["Matricula"].Value.ToString();
            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            txtApellido.Text = fila.Cells["Apellido"].Value.ToString();
        }

        private void Limpiar()
        {
            idSeleccionado = 0;
            txtMatricula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtMatricula.Focus();
        }

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)8 && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)8 && e.KeyChar != ' ')
                e.Handled = true;
        }
    }
}

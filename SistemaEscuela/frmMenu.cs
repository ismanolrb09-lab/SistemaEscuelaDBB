using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscuela
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            this.Text = "Menu Principal";
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            new frmEstudiantes().ShowDialog();
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            new frmAsistencia().ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            new frmReportes().ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
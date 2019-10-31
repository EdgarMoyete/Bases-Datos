using Escuela.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escuela
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            cmbEscuela.SelectedIndex = 0;
        }

        private void cmbEscuela_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tbl = cmbEscuela.SelectedIndex;
            switch (tbl)
            {
                case 1:
                    frmCarreras carreras = new frmCarreras();
                    carreras.Visible = true;
                    break;
                case 2:
                    frmEspecialidades especialidades = new frmEspecialidades();
                    especialidades.Visible = true;
                    break;
                case 3:
                    frmMaterias materias = new frmMaterias();
                    materias.Visible = true;
                    break;
                case 4:
                    frmAlumnos alumnos = new frmAlumnos();
                    alumnos.Visible = true;
                    break;
                case 5:
                    frmCalificaciones calificaciones = new frmCalificaciones();
                    calificaciones.Visible = true;
                    break;
                //default:
                //    MessageBox.Show("Seleccione una opcion","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                //    break;
            }
        }
    }
}

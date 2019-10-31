using dll_Escuela;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escuela.Formularios
{
    public partial class frmCalificaciones : Form
    {
        public frmCalificaciones()
        {
            InitializeComponent();
        }

        private void frmCalificaciones_Load(object sender, EventArgs e)
        {
            Calificaciones x = new Calificaciones();
            dgvCalificaciones.DataSource = x.consultar();
        }
    }
}

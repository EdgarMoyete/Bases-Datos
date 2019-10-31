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
    public partial class frmEspecialidades : Form
    {
        public frmEspecialidades()
        {
            InitializeComponent();
        }

        private void frmEspecialidades_Load(object sender, EventArgs e)
        {
            Especialidades x = new Especialidades();
            dgvEspecialidades.DataSource = x.consultar();
        }
    }
}

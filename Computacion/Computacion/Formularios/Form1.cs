using Computacion.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            cmbTablas.SelectedIndex = 0;
        }

        private void cmbTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tbl = cmbTablas.SelectedIndex;
            switch (tbl)
            {
                case 1:
                    frmComputadoras computadoras = new frmComputadoras();
                    computadoras.Visible = true;
                    break;
                case 2:
                    frmProcesadores procesadores = new frmProcesadores();
                    procesadores.Visible = true;
                    break;
                case 3:
                    frmMemorias memorias = new frmMemorias();
                    memorias.Visible = true;
                    break;
                case 4:
                    frmTarjetasVideo tarjetasVideo = new frmTarjetasVideo();
                    tarjetasVideo.Visible = true;
                    break;
                case 5:
                    frmDiscosDuros discosDuros = new frmDiscosDuros();
                    discosDuros.Visible = true;
                    break;
            }
        }
    }
}

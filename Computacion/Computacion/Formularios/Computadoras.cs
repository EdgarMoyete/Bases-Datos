using dll_Computacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computacion.Formularios
{
    public partial class frmComputadoras : Form
    {
        public frmComputadoras()
        {
            InitializeComponent();
        }

        private void frmComputadoras_Load(object sender, EventArgs e)
        {
            Computadoras x = new Computadoras();
            dgvComputadoras.DataSource = x.consultar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Computadoras x = new Computadoras {
                NumSerie=txtNumSerie.Text,
                Marca=txtMarca.Text,
                Modelo=txtModelo.Text,
                Tipo=txtTipo.Text,
                Color=txtColor.Text,
                TipoPantalla=txtTipoPantalla.Text,
                PulgadasPantalla=byte.Parse(txtPulgadasPantalla.Text),
                AnchoPantalla=short.Parse(txtAnchoPantalla.Text),
                AltoPantalla=short.Parse(txtAltoPantalla.Text),
                Ranuras=txtRanuras.Text,
                Bateria=short.Parse(txtBateria.Text),
                UnidadOptica=chkUnidadOptica.Checked,
                TecladoIluminado=chkTecladoIluminado.Checked,
                DetectorHuella=chkDetectorHuella.Checked,
                Peso=float.Parse(txtPeso.Text),
                SistemaOperativo=txtSistemaOperativo.Text,
                VersionSO=txtVersionSO.Text,
                Id_procesador=txtProcesador.Text,
                Id_memoria=txtMemoria.Text,
                Id_tarjetaVideo=txtTarjetaVideo.Text,
                Id_discoDuro=txtDiscoDuro.Text
            };
            if (x.actualizar())
            {
                MessageBox.Show("La computadora ha sido actualizado", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvComputadoras.DataSource = x.consultar();
            }
            else
            {
                MessageBox.Show("Error al actualizar la computadora", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Computadoras x = new Computadoras();
                x.NumSerie=txtNumSerie.Text;
                x.Marca=txtMarca.Text;
                x.Modelo=txtModelo.Text;
                x.Tipo=txtTipo.Text;
                x.Color=txtColor.Text;
                x.TipoPantalla=txtTipoPantalla.Text;
                x.PulgadasPantalla=byte.Parse(txtPulgadasPantalla.Text);
                x.AnchoPantalla=short.Parse(txtAnchoPantalla.Text);
                x.AltoPantalla=short.Parse(txtAltoPantalla.Text);
                x.Ranuras=txtRanuras.Text;
                x.Bateria=short.Parse(txtBateria.Text);
                x.UnidadOptica=chkUnidadOptica.Checked;
                x.TecladoIluminado=chkTecladoIluminado.Checked;
                x.DetectorHuella=chkDetectorHuella.Checked;
                x.Peso=float.Parse(txtPeso.Text);
                x.SistemaOperativo=txtSistemaOperativo.Text;
                x.VersionSO=txtVersionSO.Text;
                x.Id_procesador=txtProcesador.Text;
                x.Id_memoria=txtMemoria.Text;
                x.Id_tarjetaVideo=txtTarjetaVideo.Text;
                x.Id_discoDuro = txtDiscoDuro.Text;
            if (x.agregar())
            {
                MessageBox.Show("La computadora ha sido agregada", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvComputadoras.DataSource = x.consultar();
            }
            else
            {
                MessageBox.Show("Error al agregar la computadora", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarxId_Click(object sender, EventArgs e)
        {
            Computadoras x = new Computadoras {
                NumSerie=txtNumSerie.Text
            };
            DataTable dt = x.buscarxId();
            if (dt.Rows.Count > 0)
            {
                dgvComputadoras.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Error al buscar, la computadora no existe en la Base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvComputadoras.DataSource = x.consultar();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Computadoras x = new Computadoras();
            dgvComputadoras.DataSource = x.consultar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Computadoras x = new Computadoras {
                NumSerie=txtNumSerie.Text
            };
            DialogResult resultado;
            resultado = MessageBox.Show("Estas seguro de eliminar la computadora", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                if (x.eliminar())
                {
                    MessageBox.Show("La computadora ha sido eliminado", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvComputadoras.DataSource = x.consultar();
                }
                else
                {
                    MessageBox.Show("Error al eliminar la computadora", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
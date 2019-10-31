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
    public partial class frmTarjetasVideo : Form
    {
        public frmTarjetasVideo()
        {
            InitializeComponent();
        }

        private void frmTarjetasVideo_Load(object sender, EventArgs e)
        {
            TarjetasVideo x = new TarjetasVideo();
            dgvTarjetasVideo.DataSource = x.consultar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            TarjetasVideo x = new TarjetasVideo {
                Id_gpu=txtId.Text,
                Marca=txtMarca.Text,
                Modelo=txtModelo.Text,
                Capacidad=short.Parse(txtCapacidad.Text),
                Frecuencia=short.Parse(txtFrecuencia.Text),
                FrecuenciaMaxima=short.Parse(txtFrecuenciaMaxima.Text)
            };
            if (x.actualizar())
            {
                MessageBox.Show("La tarjeta de video ha sido actualizado", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvTarjetasVideo.DataSource = x.consultar();
            }
            else
            {
                MessageBox.Show("Error al actualizar la tarjeta de video", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            TarjetasVideo x = new TarjetasVideo();
            x.Id_gpu = txtId.Text;
            x.Marca = txtMarca.Text;
            x.Modelo = txtModelo.Text;
            x.Capacidad=short.Parse(txtCapacidad.Text);
            x.Frecuencia = short.Parse(txtFrecuencia.Text);
            x.FrecuenciaMaxima = short.Parse(txtFrecuenciaMaxima.Text);
            if (x.agregar())
            {
                MessageBox.Show("La tarjeta de video ha sido agregada", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvTarjetasVideo.DataSource = x.consultar();
            }
            else
            {
                MessageBox.Show("Error al agregar la tarjeta de video", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarxId_Click(object sender, EventArgs e)
        {
            TarjetasVideo x = new TarjetasVideo {
                Id_gpu=txtId.Text
            };
            DataTable dt = x.buscarxId();
            if (dt.Rows.Count > 0)
            {
                dgvTarjetasVideo.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Error al buscar, el cliente no existe en la Base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvTarjetasVideo.DataSource = x.consultar();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            TarjetasVideo x = new TarjetasVideo();
            dgvTarjetasVideo.DataSource = x.consultar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            TarjetasVideo x = new TarjetasVideo {
                Id_gpu=txtId.Text
            };
            DialogResult resultado;
            resultado = MessageBox.Show("Estas seguro de eliminar la tarjeta de video", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                if (x.eliminar())
                {
                    MessageBox.Show("La tarjeta de video ha sido eliminada", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvTarjetasVideo.DataSource = x.consultar();
                }
                else
                {
                    MessageBox.Show("Error al eliminar la tarjeta de video", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
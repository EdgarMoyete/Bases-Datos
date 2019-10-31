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
    public partial class frmProcesadores : Form
    {
        public frmProcesadores()
        {
            InitializeComponent();
        }

        private void frmProcesadores_Load(object sender, EventArgs e)
        {
            Procesadores x = new Procesadores();
            dgvProcesadores.DataSource = x.consultar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Procesadores x = new Procesadores {
                Id_cpu=txtId.Text,
                Marca=txtMarca.Text,
                Modelo=txtModelo.Text,
                Frecuencia=float.Parse(txtFrecuencia.Text),
                TurboBoost=float.Parse(txtTurboBoost.Text),
                Nucleos=byte.Parse(txtNucleos.Text),
                Subnucleos=byte.Parse(txtSubnucleos.Text),
                Cache=byte.Parse(txtCache.Text)
            };
            if (x.actualizar())
            {
                MessageBox.Show("El procesador ha sido actualizado", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvProcesadores.DataSource = x.consultar();
            }
            else
            {
                MessageBox.Show("Error al actualizar el procesador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Procesadores x = new Procesadores();
            x.Id_cpu = txtId.Text;
            x.Marca = txtMarca.Text;
            x.Modelo = txtModelo.Text;
            x.Frecuencia = float.Parse(txtFrecuencia.Text);
            x.TurboBoost = float.Parse(txtTurboBoost.Text);
            x.Nucleos = byte.Parse(txtNucleos.Text);
            x.Subnucleos = byte.Parse(txtNucleos.Text);
            x.Cache = byte.Parse(txtCache.Text);
            if (x.agregar())
            {
                MessageBox.Show("El procesador ha sido agregado", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvProcesadores.DataSource = x.consultar();
            }
            else
            {
                MessageBox.Show("Error al agregar el procesador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarxId_Click(object sender, EventArgs e)
        {
            Procesadores x = new Procesadores {
                Id_cpu = txtId.Text
            };
            DataTable dt = x.buscarxId();
            if (dt.Rows.Count > 0)
            {
                dgvProcesadores.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Error al buscar, el procesador no existe en la Base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvProcesadores.DataSource = x.consultar();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Procesadores x = new Procesadores();
            dgvProcesadores.DataSource = x.consultar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Procesadores x = new Procesadores {
                Id_cpu=txtId.Text
            };
            DialogResult resultado;
            resultado = MessageBox.Show("Estas seguro de eliminar el procesador", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                if (x.eliminar())
                {
                    MessageBox.Show("El procesador ha sido eliminado", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvProcesadores.DataSource = x.consultar();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el procesador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

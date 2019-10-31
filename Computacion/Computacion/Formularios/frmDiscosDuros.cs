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
    public partial class frmDiscosDuros : Form
    {
        public frmDiscosDuros()
        {
            InitializeComponent();
        }

        private void frmDiscosDuros_Load(object sender, EventArgs e)
        {
            DiscosDuros x = new DiscosDuros();
            dgvDiscosDuros.DataSource = x.consultar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DiscosDuros x = new DiscosDuros {
                Id_discosDuros=txtId.Text,
                Marca=txtMarca.Text,
                Modelo=txtModelo.Text,
                Tipo=txtTipo.Text,
                Capacidad=short.Parse(txtCapacidad.Text),
                Velocidad=short.Parse(txtVelocidad.Text)
            };
            if (x.actualizar())
            {
                MessageBox.Show("El disco duro ha sido actualizado", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDiscosDuros.DataSource = x.consultar();
            }
            else
            {
                MessageBox.Show("Error al actualizar el disco duro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DiscosDuros x = new DiscosDuros();
            x.Id_discosDuros = txtId.Text;
            x.Marca = txtMarca.Text;
            x.Modelo = txtModelo.Text;
            x.Tipo = txtTipo.Text;
            x.Capacidad = short.Parse(txtCapacidad.Text);
            x.Velocidad = short.Parse(txtVelocidad.Text);
            if (x.agregar())
            {
                MessageBox.Show("El disco duro ha sido agregado", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDiscosDuros.DataSource = x.consultar();
            }
            else
            {
                MessageBox.Show("Error al agregar el disco duro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarxId_Click(object sender, EventArgs e)
        {
            DiscosDuros x = new DiscosDuros {
                Id_discosDuros=txtId.Text
            };
            DataTable dt = x.buscarxId();
            if (dt.Rows.Count > 0)
            {
                dgvDiscosDuros.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Error al buscar, el disco duro no existe en la Base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvDiscosDuros.DataSource = x.consultar();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DiscosDuros x = new DiscosDuros();
            dgvDiscosDuros.DataSource = x.consultar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DiscosDuros x = new DiscosDuros {
                Id_discosDuros=txtId.Text
            };
            DialogResult resultado;
            resultado = MessageBox.Show("Estas seguro de eliminar el cliente", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                if (x.eliminar())
                {
                    MessageBox.Show("El cliente ha sido eliminado", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDiscosDuros.DataSource = x.consultar();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
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
    public partial class frmMemorias : Form
    {
        public frmMemorias()
        {
            InitializeComponent();
        }

        private void frmMemorias_Load(object sender, EventArgs e)
        {
            Memorias x = new Memorias();
            dgvMemorias.DataSource = x.consultar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Memorias x = new Memorias {
                Id_ram=txtId.Text,
                Marca=txtMarca.Text,
                Tipo=txtTipo.Text,
                Capacidad=byte.Parse(txtCapacidad.Text),
                Velocidad=byte.Parse(txtVelocidad.Text)
            };
            if (x.actualizar())
            {
                MessageBox.Show("La memoria ha sido actualizado", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvMemorias.DataSource = x.consultar();
            }
            else
            {
                MessageBox.Show("Error al actualizar la memoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Memorias x = new Memorias();
            x.Id_ram = txtId.Text;
            x.Marca = txtMarca.Text;
            x.Tipo = txtTipo.Text;
            x.Capacidad = byte.Parse(txtCapacidad.Text);
            x.Velocidad = short.Parse(txtVelocidad.Text);
            if (x.agregar())
            {
                MessageBox.Show("La memoria ha sido agregada", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvMemorias.DataSource = x.consultar();
            }
            else
            {
                MessageBox.Show("Error al agregar la memoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarxId_Click(object sender, EventArgs e)
        {
            Memorias x = new Memorias {
                Id_ram=txtId.Text
            };
            DataTable dt = x.buscarxId();
            if (dt.Rows.Count > 0)
            {
                dgvMemorias.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Error al buscar, la memoria no existe en la Base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvMemorias.DataSource = x.consultar();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Memorias x = new Memorias();
            dgvMemorias.DataSource = x.consultar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Memorias x = new Memorias {
                Id_ram=txtId.Text
            };
            DialogResult resultado;
            resultado = MessageBox.Show("Estas seguro de eliminar la memoria", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                if (x.eliminar())
                {
                    MessageBox.Show("La memoria ha sido eliminada", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvMemorias.DataSource = x.consultar();
                }
                else
                {
                    MessageBox.Show("Error al eliminar la memoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
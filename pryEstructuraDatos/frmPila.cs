using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }
        clsPila FilaDePersonas = new clsPila();

        private void btnAgregarPila_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigoPila.Text);
            ObjNodo.Nombre = txtNombrePila.Text;
            ObjNodo.Tramite = txtTramitePila.Text;
            FilaDePersonas.Agregar(ObjNodo);
            FilaDePersonas.Recorrer(dgvPila);
            FilaDePersonas.Recorrer(lstPila);
            FilaDePersonas.Recorrer();
            txtCodigoPila.Text = "";
            txtNombrePila.Text = "";
            txtTramitePila.Text = "";
        }

        private void btnEliminarPila_Click(object sender, EventArgs e)
        {
            if (FilaDePersonas.Primero != null)
            {
                lblCodigoPila.Text = FilaDePersonas.Primero.Codigo.ToString();
                lblNombrePila.Text = FilaDePersonas.Primero.Nombre;
                lblTramitePila.Text = FilaDePersonas.Primero.Tramite;
                FilaDePersonas.Eliminar();
                FilaDePersonas.Recorrer(dgvPila);
                FilaDePersonas.Recorrer(lstPila);
                FilaDePersonas.Recorrer();
            }
            else
            {
                lblCodigoPila.Text = "";
                lblNombrePila.Text = "";
                lblTramitePila.Text = "";
            }
        }

        private void txtCodigoPila_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoPila.Text != "" && txtNombrePila.Text != "" && txtTramitePila.Text != "")
            {
                btnAgregarPila.Enabled = true;
            }
            else
            {
                btnAgregarPila.Enabled = false;
            }
        }

        private void txtNombrePila_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoPila.Text != "" && txtNombrePila.Text != "" && txtTramitePila.Text != "")
            {
                btnAgregarPila.Enabled = true;
            }
            else
            {
                btnAgregarPila.Enabled = false;
            }
        }

        private void txtTramitePila_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoPila.Text != "" && txtNombrePila.Text != "" && txtTramitePila.Text != "")
            {
                btnAgregarPila.Enabled = true;
            }
            else
            {
                btnAgregarPila.Enabled = false;
            }
        }
    }
}

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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }      
        clsListaDoble Lista = new clsListaDoble();

        private void btnAgregarListaDoble_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigoListaDoble.Text);
            ObjNodo.Nombre = txtNombreListaDoble.Text;
            ObjNodo.Tramite = txtTramiteListaDoble.Text;
            Lista.AgregarListaDoble(ObjNodo);
            Lista.RecorrerListaDoble(dgvListaDoble);
            Lista.RecorrerListaDoble(lstListaDoble);
            Lista.RecorrerListaDoble(cbCodigoListaDoble);
            Lista.RecorrerListaDoble();
            txtCodigoListaDoble.Text = "";
            txtNombreListaDoble.Text = "";
            txtTramiteListaDoble.Text = "";
        }

        private void btnEliminarListaDoble_Click(object sender, EventArgs e)
        {
            if (Lista.Primero != null)
            {
                Int32 x = Convert.ToInt32(cbCodigoListaDoble.Text);
                Lista.EliminarListaDoble(x);
                Lista.RecorrerListaDoble(dgvListaDoble);
                Lista.RecorrerListaDoble(lstListaDoble);
                Lista.RecorrerListaDoble(cbCodigoListaDoble);
                Lista.RecorrerListaDoble();
            }
            else
            {
                MessageBox.Show("La lista está vacía");
            }
            cbCodigoListaDoble.Text = "";
            btnEliminarListaDoble.Enabled = false;
        }

        private void optAscendente_CheckedChanged(object sender, EventArgs e)
        {
            Lista.RecorrerListaDoble(dgvListaDoble);
            Lista.RecorrerListaDoble(lstListaDoble);
            Lista.RecorrerListaDoble(cbCodigoListaDoble);
            Lista.RecorrerListaDoble();
        }

        private void optDescendente_CheckedChanged(object sender, EventArgs e)
        {
            Lista.RecorrerListaDobleDescendente(dgvListaDoble);
            Lista.RecorrerListaDobleDescendente(lstListaDoble);
            Lista.RecorrerListaDobleDescendente(cbCodigoListaDoble);
            Lista.RecorrerListaDobleDescendente();
        }

        private void txtCodigoListaDoble_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoListaDoble.Text != "" && txtNombreListaDoble.Text != "" && txtTramiteListaDoble.Text != "")
            {
                btnAgregarListaDoble.Enabled = true;
            }
            else
            {
                btnAgregarListaDoble.Enabled = false;
            }
        }

        private void txtNombreListaDoble_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoListaDoble.Text != "" && txtNombreListaDoble.Text != "" && txtTramiteListaDoble.Text != "")
            {
                btnAgregarListaDoble.Enabled = true;
            }
            else
            {
                btnAgregarListaDoble.Enabled = false;
            }
        }

        private void txtTramiteListaDoble_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoListaDoble.Text != "" && txtNombreListaDoble.Text != "" && txtTramiteListaDoble.Text != "")
            {
                btnAgregarListaDoble.Enabled = true;
            }
            else
            {
                btnAgregarListaDoble.Enabled = false;
            }
        }

        private void cbCodigoListaDoble_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCodigoListaDoble.SelectedIndex != -1)
            {
                btnEliminarListaDoble.Enabled = true;
            }
            else
            {
                btnEliminarListaDoble.Enabled = false;
            }
        }
    }
}

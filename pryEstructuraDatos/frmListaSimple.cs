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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }
        clsListaSimple Lista = new clsListaSimple();

        private void btnAgregarListaSimple_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigoListaSimple.Text);
            ObjNodo.Nombre = txtNombreListaSimple.Text;
            ObjNodo.Tramite = txtTramiteListaSimple.Text;
            Lista.Agregar(ObjNodo);
            Lista.Recorrer(dgvListaSimple);
            Lista.Recorrer(lstListaSimple);
            Lista.Recorrer(cbCodigoListaSimple);
            Lista.Recorrer();
            txtCodigoListaSimple.Text = "";
            txtNombreListaSimple.Text = "";
            txtTramiteListaSimple.Text = "";
        }

        private void btnEliminarListaSimple_Click(object sender, EventArgs e)
        {
            if (Lista.Primero != null)
            {
                Int32 x = Convert.ToInt32(cbCodigoListaSimple.Text);
                Lista.Eliminar(x);
                Lista.Recorrer(dgvListaSimple);
                Lista.Recorrer(lstListaSimple);
                Lista.Recorrer(cbCodigoListaSimple);
                Lista.Recorrer();
            }
            else
            {
                MessageBox.Show("La lista está vacía");
            }
            cbCodigoListaSimple.Text = "";
            btnEliminarListaSimple.Enabled = false;
        }

        private void txtCodigoListaSimple_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoListaSimple.Text != "" && txtNombreListaSimple.Text != "" && txtTramiteListaSimple.Text != "")
            {
                btnAgregarListaSimple.Enabled = true;
            }
            else
            {
                btnAgregarListaSimple.Enabled = false;
            }
        }

        private void txtNombreListaSimple_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoListaSimple.Text != "" && txtNombreListaSimple.Text != "" && txtTramiteListaSimple.Text != "")
            {
                btnAgregarListaSimple.Enabled = true;
            }
            else
            {
                btnAgregarListaSimple.Enabled = false;
            }
        }

        private void txtTramiteListaSimple_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoListaSimple.Text != "" && txtNombreListaSimple.Text != "" && txtTramiteListaSimple.Text != "")
            {
                btnAgregarListaSimple.Enabled = true;
            }
            else
            {
                btnAgregarListaSimple.Enabled = false;
            }
        }

        private void cbCodigoListaSimple_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCodigoListaSimple.SelectedIndex != -1 )
            {
                btnEliminarListaSimple.Enabled = true;
            }
            else
            {
                btnEliminarListaSimple.Enabled = false;
            }
        }
    }
}

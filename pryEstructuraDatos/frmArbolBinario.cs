using System;
using System.Collections;
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
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }
        clsArbolBinario Arbol = new clsArbolBinario();

        private void btnAgregarArbolBinario_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigoArbolBinario.Text);
            ObjNodo.Nombre = txtNombreArbolBinario.Text;
            ObjNodo.Tramite = txtTramiteArbolBinario.Text;
            Arbol.AgregarArbolBinario(ObjNodo);
            Arbol.RecorrerArbolBinario(dgvArbolBinario);
            Arbol.RecorrerArbolBinario(cbCodigoArbolBinario);
            Arbol.RecorrerArbolBinario(tvArbolBinario);
            //Arbol.RecorrerListaDoble();//Falta programar crear el csv
            txtCodigoArbolBinario.Text = "";
            txtNombreArbolBinario.Text = "";
            txtTramiteArbolBinario.Text = "";
        }

        private void txtCodigoArbolBinario_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoArbolBinario.Text != "" && txtNombreArbolBinario.Text != "" && txtTramiteArbolBinario.Text != "")
            {
                btnAgregarArbolBinario.Enabled = true;
            }
            else
            {
                btnAgregarArbolBinario.Enabled = false;
            }
        }

        private void txtNombreArbolBinario_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoArbolBinario.Text != "" && txtNombreArbolBinario.Text != "" && txtTramiteArbolBinario.Text != "")
            {
                btnAgregarArbolBinario.Enabled = true;
            }
            else
            {
                btnAgregarArbolBinario.Enabled = false;
            }
        }

        private void txtTramiteArbolBinario_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoArbolBinario.Text != "" && txtNombreArbolBinario.Text != "" && txtTramiteArbolBinario.Text != "")
            {
                btnAgregarArbolBinario.Enabled = true;
            }
            else
            {
                btnAgregarArbolBinario.Enabled = false;
            }
        }

        private void cbCodigoArbolBinario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCodigoArbolBinario.SelectedIndex != -1)
            {
                btnEliminarArbolBinario.Enabled = true;
            }
            else
            {
                btnEliminarArbolBinario.Enabled = false;
            }
        }

        private void optInOrdenDesc_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.RecorrerArbolDesc(dgvArbolBinario);
            Arbol.RecorrerArbolDesc(cbCodigoArbolBinario);
        }

        private void optInOrdenAsc_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.RecorrerArbolBinario(dgvArbolBinario);
            Arbol.RecorrerArbolBinario(cbCodigoArbolBinario);
        }

        private void optPreOrden_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnEliminarArbolBinario_Click(object sender, EventArgs e)
        {
            if (Arbol.Raiz != null)
            {
                Int32 x = Convert.ToInt32(cbCodigoArbolBinario.Text);
                Arbol.Eliminar(x);
                Arbol.RecorrerArbolBinario(dgvArbolBinario);
                Arbol.RecorrerArbolBinario(cbCodigoArbolBinario);
            }
            else
            {
                MessageBox.Show("La lista está vacía");
            }
            cbCodigoArbolBinario.Text = "";
            btnEliminarArbolBinario.Enabled = false;
        }

        private void btnEquilibrarArbolBinario_Click(object sender, EventArgs e)
        {
            Arbol.Equilibrar();
        }
    }
}

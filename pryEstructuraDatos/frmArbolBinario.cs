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
    }
}

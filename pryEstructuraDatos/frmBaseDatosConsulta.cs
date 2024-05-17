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
    public partial class frmBaseDatosConsulta : Form
    {
        public frmBaseDatosConsulta()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsBaseDatos objBaseDatos = new clsBaseDatos();
            if (txtConsultaSql.Text == "")
            {
                objBaseDatos.Listar(dgvBaseDatosConsulta);
            }
            else
            {
                objBaseDatos.Listar(dgvBaseDatosConsulta, txtConsultaSql.Text);
            }
        }
    }
}

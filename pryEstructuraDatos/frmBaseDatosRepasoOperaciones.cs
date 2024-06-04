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
    public partial class frmBaseDatosRepasoOperaciones : Form
    {
        public frmBaseDatosRepasoOperaciones()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsBaseDatos objBD = new clsBaseDatos();

            String VarSQL = "SELECT * FROM LIBRO";

            switch (cbOperacion.SelectedIndex)
            {
                case 0:
                    lblListar.Text = cbOperacion.Text + ": " + "Idiomas de libros";

                    VarSQL = "SELECT Nombre AS Idiomas " + "FROM Idioma " + "ORDER BY 1 DESC";

                    break;
                case 1:
                    lblListar.Text = cbOperacion.Text + ": " + "Paises que tienen libros.";

                    VarSQL = "SELECT * FROM Pais WHERE " + "IdPais IN (SELECT IdPais FROM Libro)";
                    break;
            }

            objBD.Listar(dgvBaseDatosRepasoOperaciones, VarSQL);
        }
    }
}

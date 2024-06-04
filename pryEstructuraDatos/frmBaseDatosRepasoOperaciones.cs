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

                    lblListar.Text = cbOperacion.Text + ": " + "Idiomas de libros.";

                    VarSQL = "SELECT Nombre AS Idiomas " + "FROM Idioma " + "ORDER BY 1 DESC";

                    break;

                case 1:

                    lblListar.Text = cbOperacion.Text + ": " + "Paises que tienen libros.";

                    VarSQL = "SELECT * FROM Pais WHERE " + "IdPais IN (SELECT IdPais FROM Libro)";

                    break;

                case 2:

                    lblListar.Text = cbOperacion.Text + ": " + "Tabla libro e idioma juntas.";

                    VarSQL = "SELECT * " + "FROM LIBRO, IDIOMA " + "WHERE LIBRO.IDIDIOMA = IDIOMA.IDIDIOMA";

                    break;

                case 3:

                    lblListar.Text = cbOperacion.Text + ": " + "Libros cuyo IdAutor sea 18.";

                    VarSQL = "SELECT * " + "FROM Libro " + "WHERE IdAutor = 18";

                    break;

                case 4:

                    lblListar.Text = cbOperacion.Text + ": " + "Libros cuyo precio sea mayor a 600.";

                    VarSQL = "SELECT * " + "FROM Libro " + "WHERE Precio " + "IN " +
                             "(SELECT DISTINCT Precio " + "FROM Libro " +
                             "WHERE Precio > 600)";

                    break;
                   
                case 5:

                    lblListar.Text = cbOperacion.Text + ": " + "Libros cuyo precio sea mayor a 700 y haya más de 4 en stock.";

                    VarSQL = "SELECT * " + "FROM " + "(SELECT * " + "FROM Libro " +
                             "AS T1 " + "WHERE T1.Precio > 700) " + "AS T2 " +
                             "WHERE T2.Cantidad > 4";

                    break;

                case 6:

                    lblListar.Text = cbOperacion.Text + ": " + "Libros cuyo IdIdioma sean 3, 5 o 7.";

                    VarSQL = "SELECT * " + "FROM Libro " + "WHERE IdIdioma = 3 " +
                             "UNION " + "SELECT * " + "FROM Libro " + "WHERE IdIdioma = 5 "
                             + "UNION " + "SELECT * " + "FROM Libro " + "WHERE IdIdioma = 7";

                    break;

                case 7:

                    lblListar.Text = cbOperacion.Text + ": " + "Autores que hayan escrito algún libro del stock.";

                    VarSQL = "SELECT * " + "FROM Autor " + "WHERE IdAutor " + "IN (SELECT IdAutor FROM libro)";

                    break;

                case 8:

                    lblListar.Text = cbOperacion.Text + ": " + "Título y precio del libro.";

                    VarSQL = "SELECT Titulo, Precio " + "FROM Libro " + "ORDER BY Titulo ASC";

                    break;

                case 9:

                    lblListar.Text = cbOperacion.Text + ": " + "";

                    break;

                case 10:

                    lblListar.Text = cbOperacion.Text + ": " + "";

                    break;

                case 11:

                    lblListar.Text = cbOperacion.Text + ": " + "";

                    break;

                case 12:

                    lblListar.Text = cbOperacion.Text + ": " + "";

                    break;

                case 13:

                    lblListar.Text = cbOperacion.Text + ": " + "";

                    break;

                case 14:

                    lblListar.Text = cbOperacion.Text + ": " + "";

                    break;

                case 15:

                    lblListar.Text = cbOperacion.Text + ": " + "";

                    break;

                case 16:

                    lblListar.Text = cbOperacion.Text + ": " + "";

                    break;

                case 17:

                    lblListar.Text = cbOperacion.Text + ": " + "";

                    break;

                case 18:

                    lblListar.Text = cbOperacion.Text + ": " + "";

                    break;

                case 19:

                    lblListar.Text = cbOperacion.Text + ": " + "";

                    break;
            }

            objBD.Listar(dgvBaseDatosRepasoOperaciones, VarSQL);
        }
    }
}

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
    public partial class frmBaseDatosOperaciones : Form
    {
        public frmBaseDatosOperaciones()
        {
            InitializeComponent();
        }

        clsBaseDatos objBaseDatos = new clsBaseDatos();

        private void btnProyeccionSimple_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO " + "FROM LIBRO " + "ORDER BY 1 DESC";

            objBaseDatos.Listar(dgvBaseDatosOperaciones, varSQL);
        }

        private void btnProyeccionMultiatributo_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO, AÑO " + "FROM LIBRO " + "ORDER BY TITULO ASC";

            objBaseDatos.Listar(dgvBaseDatosOperaciones, varSQL);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * " + "FROM LIBRO " + "WHERE IDAUTOR = 2 " + 
                            "UNION " + "SELECT * " + "FROM LIBRO " + "WHERE IDAUTOR = 5 "
                            + "UNION " + "SELECT * " + "FROM LIBRO " + "WHERE IDAUTOR = 3";

            objBaseDatos.Listar(dgvBaseDatosOperaciones, varSQL);
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * " + "FROM LIBRO, IDIOMA " +
                            "WHERE LIBRO.IDIDIOMA = IDIOMA.IDIDIOMA";

            objBaseDatos.Listar(dgvBaseDatosOperaciones, varSQL);
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * " + "FROM PAIS " + "WHERE IDPAIS " + "IN (SELECT IDPAIS FROM LIBRO)";

            objBaseDatos.Listar(dgvBaseDatosOperaciones, varSQL);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * " + "FROM PAIS " + "WHERE IDPAIS " + "NOT IN (SELECT IDPAIS FROM LIBRO)";

            objBaseDatos.Listar(dgvBaseDatosOperaciones, varSQL);
        }

        private void btnSeleccionSimple_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * " + "FROM LIBRO " + "WHERE IDAUTOR = 2";

            objBaseDatos.Listar(dgvBaseDatosOperaciones, varSQL);
        }

        private void btnSeleccionMultiatributo_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * " + "FROM LIBRO " + "WHERE IDIDIOMA " + "IN " + 
                            "(SELECT DISTINCT IDIDIOMA " + "FROM LIBRO " + 
                            "WHERE IDIDIOMA < 5)";

            objBaseDatos.Listar(dgvBaseDatosOperaciones, varSQL);
        }

        private void btnSeleccionPorConvolucion_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * " + "FROM " +  "(SELECT * " + "FROM LIBRO " + 
                            "AS T1 " + "WHERE T1.IDIDIOMA > 5) " + "AS T2 " + 
                            "WHERE T2.IDAUTOR > 10";

            objBaseDatos.Listar(dgvBaseDatosOperaciones, varSQL);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    internal class clsArbolBinario
    {
        //Creo el campo inicial del árbol. Lo llamamos raíz
        private clsNodo PrimerNodo;

        //Creo la única propiedad que necesito
        public clsNodo Raiz
        {
            get { return PrimerNodo; }
            set { PrimerNodo = value; }
        }

        public void AgregarArbolBinario(clsNodo Nuevo)
        {
            Nuevo.Izquierdo = null;
            Nuevo.Derecho = null;
            if (Raiz == null)
            {
                Raiz = Nuevo;
            }
            else
            {
                clsNodo NodoPadre = Raiz; //ant
                clsNodo Aux = Raiz;

                while (Aux != null)
                {
                    NodoPadre = Aux;

                    if (Nuevo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierdo;
                    }
                    else
                    {
                        Aux = Aux.Derecho;
                    }
                }

                //Fuera del Mientras
                if (Nuevo.Codigo < NodoPadre.Codigo)
                {
                    NodoPadre.Izquierdo = Nuevo;
                }
                else
                {
                    NodoPadre.Derecho = Nuevo;
                }
            }
        }
        public void RecorrerArbolBinario(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrderAsc(Grilla, Raiz);
        }
        public void InOrderAsc(DataGridView Dgv, clsNodo R)//R = Raiz
        {
            if (R.Izquierdo != null)
            {
                InOrderAsc(Dgv, R.Izquierdo);
            }

            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);

            if (R.Derecho != null)
            {
                InOrderAsc(Dgv, R.Derecho);
            }
        }
        public void RecorrerArbolBinario(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrderAsc(Lista, Raiz);
        }
        public void InOrderAsc(ListBox Lst, clsNodo R)//R = Raiz
        {
            if (R.Izquierdo != null)
            {
                InOrderAsc(Lst, R.Izquierdo);
            }

            Lst.Items.Add(R.Codigo);

            if (R.Derecho != null)
            {
                InOrderAsc(Lst, R.Derecho);
            }
        }
        public void RecorrerArbolBinario(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode NodoPadre = new TreeNode("Árbol");
            tree.Nodes.Add(NodoPadre);
            PreOrden(Raiz, NodoPadre);
            tree.ExpandAll();
        }

        //Que esto se pase a un treeview
        private void PreOrden(clsNodo R, TreeNode nodoTreeView)//R = Raiz 
        {
            TreeNode NodoPadre = new TreeNode(R.Codigo.ToString());
            nodoTreeView.Nodes.Add(NodoPadre);
            if(R.Izquierdo != null)
            {
                PreOrden(R.Izquierdo, NodoPadre);
            }
            if(R.Derecho != null)
            {
                PreOrden(R.Derecho, NodoPadre);
            }
        }

        public void RecorrerArbolBinario(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrderAsc(Combo, Raiz);
        }
        public void InOrderAsc(ComboBox cb, clsNodo R)//R = Raiz
        {
            if (R.Izquierdo != null)
            {
                InOrderAsc(cb, R.Izquierdo);
            }

            cb.Items.Add(R.Codigo);

            if (R.Derecho != null)
            {
                InOrderAsc(cb, R.Derecho);
            }
        }
    }
}

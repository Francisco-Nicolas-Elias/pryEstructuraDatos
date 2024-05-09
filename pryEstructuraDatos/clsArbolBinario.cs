using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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
            InOrdenAsc(Grilla, Raiz);
        }

        public void InOrdenAsc(DataGridView Dgv, clsNodo R)//R = Raiz
        {
            if (R == null)
            {
                return; //Si la raíz es null, no hay nada que procesar
            }

            //Pregunta si hay algo a la izquierda
            if (R.Izquierdo != null)
            {
                InOrdenAsc(Dgv, R.Izquierdo);
            }

            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);

            //Pregunta si hay algo a la derecha
            if (R.Derecho != null)
            {
                InOrdenAsc(Dgv, R.Derecho);
            }
        }

        public void RecorrerArbolDesc(DataGridView dgv)
        {
            dgv.Rows.Clear();
            InOrdenDesc(dgv, Raiz);
        }

        public void InOrdenDesc(DataGridView Dgv, clsNodo R)//R = Raíz 
        {
            if (R == null)
            {
                return; //Si la raíz es null, no hay nada que procesar
            }

            //Pregunta si hay algo a la derecha
            if (R.Derecho != null)
            {
                InOrdenDesc(Dgv, R.Derecho);
            }

            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);

            //Pregunta si hay algo a la izquierda
            if (R.Izquierdo != null)
            {
                InOrdenDesc(Dgv, R.Izquierdo);
            }
        }

        public void RecorrerArbolPreOrden(DataGridView dgv)
        {
            dgv.Rows.Clear();
            PreOrden(dgv, Raiz);
        }

        public void PreOrden(DataGridView dgv, clsNodo R) //R = Raiz
        {
            if (R == null)
            {
                return; //Si la raíz es null, no hay nada que procesar
            }

            //Agrega el nodo raíz primero
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite); 

            //Luego recorre el subárbol izquierdo si existe
            if (R.Izquierdo != null)
            {
                PreOrden(dgv, R.Izquierdo);
            }

            //Finalmente, recorre el subárbol derecho si existe
            if (R.Derecho != null)
            {
                PreOrden(dgv, R.Derecho);
            }
        }

        public void RecorrerArbolPostOrden(DataGridView dgv)
        {
            dgv.Rows.Clear();
            PostOrden(dgv, Raiz);
        }

        public void PostOrden(DataGridView dgv, clsNodo R)
        {
            if (R == null)
            {
                return; //Si la raíz es null, no hay nada que procesar
            }

            //Recorre el subárbol izquierdo si existe
            if (R.Izquierdo != null)
            {
                PostOrden(dgv, R.Izquierdo);
            }

            //Luego, recorre el subárbol derecho si existe
            if (R.Derecho != null)
            {
                PostOrden(dgv, R.Derecho);
            }

            //Finalmente, agrega el nodo raíz al final
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }

        public void RecorrerArbolBinario(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }

        public void InOrdenAsc(ListBox Lst, clsNodo R)//R = Raiz
        {
            if (R == null)
            {
                return; //Si la raíz es null, no hay nada que procesar
            }
            //Pregunta si hay algo a la izquierda
            if (R.Izquierdo != null)
            {
                InOrdenAsc(Lst, R.Izquierdo);
            }

            Lst.Items.Add(R.Codigo);

            //Pregunta si hay algo a la derecha
            if (R.Derecho != null)
            {
                InOrdenAsc(Lst, R.Derecho);
            }
        }

        public void RecorrerArbolDesc(ListBox Lst)
        {
            Lst.Items.Clear();
            InOrdenDesc(Lst, Raiz);
        }

        public void InOrdenDesc(ListBox Lst, clsNodo R)//R = Raiz
        {
            if (R == null)
            {
                return; //Si la raíz es null, no hay nada que procesar
            }

            //Pregunta si hay algo a la derecha
            if (R.Derecho != null)
            {
                InOrdenDesc(Lst, R.Derecho);
            }

            Lst.Items.Add(R.Codigo);

            //Pregunta si hay algo a la izquierda
            if (R.Izquierdo != null)
            {
                InOrdenDesc(Lst, R.Izquierdo);
            }
        }

        public void RecorrerArbolPreOrden(ListBox lst)
        {
            lst.Items.Clear();
            PreOrden(lst, Raiz);
        }

        public void PreOrden(ListBox lst, clsNodo R) //R = Raiz
        {
            if (R == null)
            {
                return; //Si la raíz es null, no hay nada que procesar
            }

            //Agrega el nodo raíz primero
            lst.Items.Add(R.Codigo);

            //Luego recorre el subárbol izquierdo si existe
            if (R.Izquierdo != null)
            {
                PreOrden(lst, R.Izquierdo);
            }

            //Finalmente, recorre el subárbol derecho si existe
            if (R.Derecho != null)
            {
                PreOrden(lst, R.Derecho);
            }
        }

        public void RecorrerArbolPostOrden(ListBox lst)
        {
            lst.Items.Clear();
            PostOrden(lst, Raiz);
        }

        public void PostOrden(ListBox lst, clsNodo R)
        {
            if (R == null)
            {
                return; //Si la raíz es null, no hay nada que procesar
            }

            //Recorre el subárbol izquierdo si existe
            if (R.Izquierdo != null)
            {
                PostOrden(lst, R.Izquierdo);
            }

            //Luego, recorre el subárbol derecho si existe
            if (R.Derecho != null)
            {
                PostOrden(lst, R.Derecho);
            }

            //Finalmente, agrega el nodo raíz al final
            lst.Items.Add(R.Codigo);
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
            if (R == null)
            {
                return; //Si la raíz es null, no hay nada que procesar
            }

            TreeNode NodoPadre = new TreeNode(R.Codigo.ToString());

            nodoTreeView.Nodes.Add(NodoPadre);

            //Pregunta si hay algo a la izquierda
            if (R.Izquierdo != null)
            {
                PreOrden(R.Izquierdo, NodoPadre);
            }

            //Pregunta si hay algo a la derecha
            if (R.Derecho != null)
            {
                PreOrden(R.Derecho, NodoPadre);
            }
        }

        public void RecorrerArbolBinario(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrdenAsc(Combo, Raiz);
        }

        public void InOrdenAsc(ComboBox cb, clsNodo R)//R = Raiz
        {
            if (R == null)
            {
                return; //Si la raíz es null, no hay nada que procesar
            }

            //Pregunta si hay algo a la izquierda
            if (R.Izquierdo != null)
            {
                InOrdenAsc(cb, R.Izquierdo);
            }

            cb.Items.Add(R.Codigo);

            //Pregunta si hay algo a la derecha
            if (R.Derecho != null)
            {
                InOrdenAsc(cb, R.Derecho);
            }
        }

        public void RecorrerArbolDesc(ComboBox cb)
        {
            cb.Items.Clear();
            InOrdenDesc(cb, Raiz);
        }

        public void InOrdenDesc(ComboBox cb, clsNodo R)//R = Raíz
        {
            if (R == null)
            {
                return; //Si la raíz es null, no hay nada que procesar
            }

            //Pregunta si hay algo a la derecha
            if (R.Derecho != null)
            {
                InOrdenDesc(cb, R.Derecho);
            }

            cb.Items.Add(R.Codigo);

            //Pregunta si hay algo a la izquierda
            if (R.Izquierdo != null)
            {
                InOrdenDesc(cb, R.Izquierdo);
            }
        }

        public void RecorrerArbolPreOrden(ComboBox cb)
        {
            cb.Items.Clear();
            PreOrden(cb, Raiz);
        }

        public void PreOrden(ComboBox cb, clsNodo R) //R = Raiz
        {
            cb.Items.Add(R.Codigo); //Agrega el nodo raíz primero

            //Luego recorre el subárbol izquierdo si existe
            if (R.Izquierdo != null)
            {
                PreOrden(cb, R.Izquierdo);
            }

            //Finalmente, recorre el subárbol derecho si existe
            if (R.Derecho != null)
            {
                PreOrden(cb, R.Derecho);
            }
        }

        public void RecorrerArbolPostOrden(ComboBox cb)
        {
            cb.Items.Clear();
            PostOrden(cb, Raiz);
        }

        public void PostOrden(ComboBox cb, clsNodo R)
        {
            //Recorre el subárbol izquierdo si existe
            if (R.Izquierdo != null)
            {
                PostOrden(cb, R.Izquierdo);
            }

            //Luego, recorre el subárbol derecho si existe
            if (R.Derecho != null)
            {
                PostOrden(cb, R.Derecho);
            }

            //Finalmente, agrega el nodo raíz al final
            cb.Items.Add(R.Codigo);
        }

        //Es para tener una busqueda pero no lo utilizamos para ninguno de los algoritmos que usamos ahora 
        public clsNodo BuscarCodigo(Int32 cod)
        {
            clsNodo Aux = Raiz;
            while (Aux != null)
            {
                if (cod == Aux.Codigo) break;
                if (cod < Aux.Codigo) Aux = Aux.Izquierdo;
                else Aux = Aux.Derecho;
            }
            return Aux;
        }

        private clsNodo[] Vector = new clsNodo[100];
        private Int32 i = 0;

        public void Equilibrar()
        {
            i = 0;
            GrabarVectorInOrden(Raiz);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }

        private void EquilibrarArbol(Int32 ini, Int32 fin)
        {
            Int32 m = (ini + fin) / 2;
            if (ini <= fin)
            {
                AgregarArbolBinario(Vector[m]);
                EquilibrarArbol(ini, m - 1);
                EquilibrarArbol(m + 1, fin);
            }
        }

        private void GrabarVectorInOrden(clsNodo NodoPadre, Int32 Codigo)
        {
            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo, Codigo);
            }
            if (NodoPadre.Codigo != Codigo)
            {
                Vector[i] = NodoPadre;
                i = i + 1;
            }
            if (NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho, Codigo);
            }
        }

        private void GrabarVectorInOrden(clsNodo NodoPadre)
        {
            if (NodoPadre == null)
            {
                return;//Si el NodoPadre es null, no hay nada que procesar
            }
            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo);
            }

            Vector[i] = NodoPadre;
            i = i + 1;

            if(NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho);
            }
        }

        public void Eliminar(Int32 codigo)
        {
            i = 0;
            GrabarVectorInOrden(Raiz, codigo);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }        
    }
}

﻿using System;
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
        public void RecorrerArbolBinario(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }
        public void InOrdenAsc(ListBox Lst, clsNodo R)//R = Raiz
        {
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

        private void GrabarVectorInOrden(clsNodo NodoPadre)
        {
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

        public void Eliminar(Int32 codigo)
        {
            i = 0;
            GrabarVectorInOrden(Raiz, codigo);
            EquilibrarArbol(0, i - 1);
        }
        private void GrabarVectorInOrden(clsNodo NodoPadre, Int32 Codigo)
        {
            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo, Codigo);
            }
            if(NodoPadre.Codigo != Codigo)
            {
                Vector[i] = NodoPadre;
                i = i + 1;
            }
            if(NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho, Codigo);
            }
        }
    }
}

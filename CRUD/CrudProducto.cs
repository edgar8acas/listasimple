using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    class CrudProducto
    {
        Producto inicio = null;
        public void Agregar(Producto nuevo)
        {
            if(inicio == null)
            {
                inicio = nuevo;
                inicio.Anterior = null;
            } else {
                Producto p = inicio;
                while(p.Siguiente != null)
                {
                    p = p.Siguiente;
                }
                p.Siguiente = nuevo;
                nuevo.Anterior = p;
            }
            inicio.Siguiente = null;
        }

        public void EliminarPrimero()
        {
            inicio = inicio.Siguiente;
        }

        public void EliminarUltimo()
        {
            if(inicio == null)
            {
                MessageBox.Show("Lista vacía");
            }
            else if(inicio.Siguiente == null)
            {
                inicio = null;
            }
            else
            {
                Producto p = inicio;
                while (p.Siguiente.Siguiente != null)
                {
                    p = p.Siguiente;
                }
                p.Siguiente = null;
            }
        }

        public void InvertirLista()
        {
            
        }

        public string ReporteInverso()
        {
            string lista = "";
            Producto p = inicio;
            while (p != null)
            {
                lista += p.ToString();
                p = p.Siguiente;
            }
            return lista;
        }

    }
}

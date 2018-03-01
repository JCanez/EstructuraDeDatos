using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Listas.Class
{
    public class Pila
    {
        private Nodo raiz;

        class Nodo
        {
            public int info;
            public Nodo sig;
        }

        public Pila()
        {
            raiz = null;
        }

        public void Insertar(int x)
        {
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.info = x;

            if (raiz == null)
            {
                nuevo.sig = null;
                raiz = nuevo;
            }
            else
            {
                nuevo.sig = raiz;
                raiz = nuevo;
            }
        }

        public int Extraer()
        {
            if (raiz != null)
            {
                int informacion = raiz.info;
                raiz = raiz.sig;
                return informacion;
            }
            else
            {
                return int.MaxValue;
            }
        }

        public string Imprimir()
        {
            Nodo reco = raiz;
            string cadena_datos = "";
            
            while (reco != null)
            {
                cadena_datos += "-" + reco.info;
                reco = reco.sig;
            }

            return cadena_datos;
        }
    }
}

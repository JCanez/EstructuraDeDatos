using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Listas.Class
{
    class Generica
    {
        private Nodo raiz;

        public Generica()
        {
            raiz = null;
        }

        class Nodo
        {
            public int info;
            public Nodo sig;
        }

        public void Insertar(int pos, int x)
        {
            if (pos <= Cantidad() + 1)
            {
                Nodo nuevo = new Nodo();
                nuevo.info = x;
                if (pos == 1)
                {
                    nuevo.sig = raiz;
                    raiz = nuevo;
                }
                else
                {
                    if (pos == Cantidad() + 1)
                    {
                        Nodo reco = raiz;
                        while (reco.sig != null)
                        {
                            reco = reco.sig;
                        }
                        reco.sig = nuevo;
                        nuevo.sig = null;
                    }
                    else
                    {
                        Nodo reco = raiz;
                        for (int f = 1; f <= pos - 2; f++)
                            reco = reco.sig;
                        Nodo siguiente = reco.sig;
                        reco.sig = nuevo;
                        nuevo.sig = siguiente;
                    }
                }

            }
        }

        public void Insertar_Primera_Posicion(int x)
        {
            Nodo nuevo = new Nodo();
            nuevo.info = x;

            if (Cantidad() > 0)
            {
                nuevo.sig = raiz;
                raiz = nuevo;
            }
            else
            {
                raiz = nuevo;
                nuevo.sig = null;
            }
        }

        public bool Insertar_Segunda_Posicion(int x)
        {
            Nodo nuevo = new Nodo();
            nuevo.info = x;

            if (Cantidad() > 0)
            {
                nuevo.sig = raiz.sig;
                raiz.sig = nuevo;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Insertar_Antepenultima_Posicion(int x)
        {
            Nodo nuevo = new Nodo();
            nuevo.info = x;

            int posActual = 1;
            int cantNodos = Cantidad();

            Nodo reco = raiz;

            while(posActual < cantNodos - 1)
            {
                posActual++;
                reco = reco.sig;
            }

            Nodo temp = reco.sig;

            reco.sig = nuevo;
            nuevo.sig = temp;

            Nodo a = raiz;
        }

        public void Insertar_Ultima_Posicion(int x)
        {
            Nodo nuevo = new Nodo();
            nuevo.info = x;

            Nodo reco = raiz;

            while (reco.sig != null)
            {
                reco = reco.sig;
            }

            reco.sig = nuevo;
            nuevo.sig = null;
        }

        public int Extraer(int pos)
        {
            if (pos <= Cantidad())
            {
                int informacion;
                if (pos == 1)
                {
                    informacion = raiz.info;
                    raiz = raiz.sig;
                }
                else
                {
                    Nodo reco;
                    reco = raiz;
                    for (int f = 1; f <= pos - 2; f++)
                        reco = reco.sig;
                    Nodo prox = reco.sig;
                    reco.sig = prox.sig;
                    informacion = prox.info;
                }
                return informacion;
            }
            else
            {
                return int.MaxValue;
            }
        }

        public void Borrar(int pos)
        {
            if (pos <= Cantidad())
            {
                if (pos == 1)
                {
                    raiz = raiz.sig;
                }
                else
                {
                    Nodo reco;
                    reco = raiz;
                    for (int f = 1; f <= pos - 2; f++)
                        reco = reco.sig;
                    Nodo prox = reco.sig;
                    reco.sig = prox.sig;
                }
            }
        }

        public void Borrar_Primera_Posicion()
        {
            Nodo refe = raiz.sig;
            raiz = null;
            raiz = refe;
        }

        public void Borrar_Segunda_Posicion()
        {
            if(Cantidad() >= 2)
            {
                Nodo refe = raiz.sig;

                raiz.sig = refe.sig;
                refe.sig = null;
            }
        }

        public void Borrar_Ultima_Posicion()
        {
            Nodo reco = raiz;
            Nodo anterior = null;

            while(reco.sig != null)
            {
                anterior = reco;
                reco = reco.sig;
            }

            anterior.sig = null;
        }

        public void Borrar_Nodo_Mayor()
        {
            Nodo mayor = null;
            Nodo anterior = null;
            Nodo anterior_mayor = null;

            Nodo reco = raiz;

            int valor_mayor = raiz.info;

            while (reco.sig != null)
            {
                if (reco.info > valor_mayor)
                {
                    anterior_mayor = anterior;
                    mayor = reco;
                }

                anterior = reco;
                reco = reco.sig;
            }

            anterior_mayor.sig = mayor.sig;
        }

        public void Intercambiar(int pos1, int pos2)
        {
            if (pos1 <= Cantidad() && pos2 <= Cantidad())
            {
                Nodo reco1 = raiz;
                for (int f = 1; f < pos1; f++)
                    reco1 = reco1.sig;

                Nodo reco2 = raiz;
                for (int f = 1; f < pos2; f++)
                    reco2 = reco2.sig;

                int aux = reco1.info;
                reco1.info = reco2.info;
                reco2.info = aux;
            }
        }

        public int Mayor()
        {
            if (!Vacia())
            {
                int may = raiz.info;
                Nodo reco = raiz.sig;
                while (reco != null)
                {
                    if (reco.info > may)
                        may = reco.info;
                    reco = reco.sig;
                }
                return may;
            }
            else
                return int.MaxValue;
        }

        public int PosMayor()
        {
            if (!Vacia())
            {
                int may = raiz.info;
                int x = 1;
                int pos = x;
                Nodo reco = raiz.sig;
                while (reco != null)
                {
                    if (reco.info > may)
                    {
                        may = reco.info;
                        pos = x;
                    }
                    reco = reco.sig;
                    x++;
                }
                return pos;
            }
            else
                return int.MaxValue;
        }

        public void Ordenar_Mayor_Menor()
        {
            Nodo temp = raiz;
            int valor = temp.info;

            while (temp.sig != null)
            {
                if (valor > temp.info)
                {

                }

                temp = temp.sig;
            }
        }

        public void Ordenar_Menor_Mayor()
        {
        }

        public bool Ordenada()
        {
            if (Cantidad() > 1)
            {
                Nodo reco1 = raiz;
                Nodo reco2 = raiz.sig;
                while (reco2 != null)
                {
                    if (reco2.info < reco1.info)
                        return false;
                    reco2 = reco2.sig;
                    reco1 = reco1.sig;
                }
            }
            return true;
        }

        public bool Existe(int x)
        {
            Nodo reco = raiz;
            while (reco != null)
            {
                if (reco.info == x)
                    return true;
                reco = reco.sig;
            }
            return false;
        }

        public  bool Vacia()
        {
            if (raiz == null)
                return true;
            else
                return false;
        }

        public string Imprimir()
        {
            Nodo reco = raiz;
            string cadena = "";
            while (reco != null)
            {
                cadena += "-" + reco.info;
                reco = reco.sig;
            }
            return cadena;
        }

        public int Cantidad()
        {
            int cant = 0;
            Nodo reco = raiz;
            while (reco != null)
            {
                reco = reco.sig;
                cant++;
            }
            return cant;
        }
    }
}
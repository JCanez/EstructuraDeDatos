using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Listas.Class
{
    public class Dobles
    {
        private Nodo raiz;

        public class Nodo
        {
            public Nodo ant;
            public int inf;
            public Nodo sig;
        }

        public Dobles()
        {
            raiz = null;
        }

        public void Insertar(int valor, int pos)
        {
            Nodo nuevo = new Nodo();
            nuevo.inf = valor;

            if (raiz == null)
            {
                raiz = nuevo;
                raiz.sig = null;
                raiz.ant = null;
            }
            else
            {
                Nodo reco = raiz;
                if (pos == 1)
                {
                    Nodo temp = raiz;

                    raiz = nuevo;
                    raiz.ant = null;
                    raiz.sig = temp;

                    temp.ant = raiz;
                }
                else if (pos > Cantidad())
                {
                    while (reco.sig != null)
                    {
                        reco = reco.sig;
                    }
                    reco.sig = nuevo;
                    nuevo.sig = null;
                    nuevo.ant = reco;
                }
                else
                {
                    int puntero = 1;

                    while (puntero < pos - 1)
                    {
                        reco = reco.sig;
                        puntero++;
                    }

                    Nodo temp = reco.sig;
                    reco.sig = nuevo;
                    nuevo.sig = temp;
                    nuevo.ant = reco;
                    temp.ant = nuevo;
                }
            }
        }

        public void Extraer(int pos)
        {

        }

        public void Borrar(int pos)
        {
            Nodo reco = raiz;

            if (pos == 1)
            {
                if (Cantidad() > 1)
                {
                    raiz = reco.sig;
                    raiz.ant = null;
                    reco = null;
                }
                else
                {
                    raiz = null;
                }
            }
            else if (pos > Cantidad() || pos == Cantidad())
            {
                Nodo ant = null;
                while (reco.sig != null)
                {
                    ant = reco;
                    reco = reco.sig;
                }

                reco = null;
                ant.sig = null;
            }
            else
            {
                int pos_act = 1;
                Nodo ant = null;
                Nodo sig = null;

                bool success = false;

                while (reco != null)
                {
                    if (pos == pos_act && success == false)
                    {
                        ant.sig = sig;
                        sig.ant = ant;

                        reco.ant = null;
                        reco.sig = null;

                        reco = null;
                        success = true;
                    }

                    if (success == false)
                    {
                        pos_act++;
                        ant = reco;
                        reco = reco.sig;
                        sig = reco.sig;
                    }
                }
            }
        }

        public void Intercambiar(int pos1, int pos2)
        {
            Nodo reco = raiz, ref1 = null, ref2 = null;

            int pos_act = 1;
            bool ambos = false;
            int tot_enc = 0, v1 = 0, v2 = 0;

            while (ambos == false)
            {
                if (pos_act == pos1)
                {
                    v1 = reco.inf;
                    tot_enc++;

                    ref1 = reco;
                    reco = raiz;

                    if (tot_enc == 2)
                    {
                        ambos = true;
                    }
                }

                if (pos_act == pos2)
                {
                    v2 = reco.inf;
                    tot_enc++;

                    ref2 = reco;
                    reco = raiz;

                    if (tot_enc == 2)
                    {
                        ambos = true;
                    }
                }
                reco = reco.sig;
                pos_act++;
            }

            ref1.inf = v2;
            ref2.inf = v1;
        }

        public int Mayor()
        {
            int mayor = 0;
            Nodo reco = raiz;

            while (reco != null)
            {
                if (mayor < reco.inf)
                    mayor = reco.inf;

                reco = reco.sig;
            }

            return mayor;
        }

        public int Posicion_Mayor()
        {
            int mayor = 0, pun = 0, pos = 0;
            Nodo reco = raiz;

            while (reco != null)
            {
                pun++;

                if (mayor < reco.inf)
                {
                    mayor = reco.inf;
                    pos = pun;
                }

                reco = reco.sig;
            }

            return pos;
        }

        public int Cantidad()
        {
            int total = 0;

            Nodo reco = raiz;
            while (reco != null)
            {
                total++;
                reco = reco.sig;
            }

            return total;
        }

        public bool Ordenada()
        {
            Nodo reco = raiz;

            int act = 0;
            bool ordenada = true;

            while (reco != null)
            {
                if (act > reco.inf)
                {
                    ordenada = false;
                }

                act = reco.inf;

                reco = reco.sig;
            }
            return ordenada;
        }

        public bool Existe(int valor)
        {
            Nodo reco = raiz;
            bool existe = false;

            while (reco != null)
            {
                if (reco.inf == valor)
                {
                    existe = true;
                }

                reco = reco.sig;
            }

            return existe;
        }

        public bool Vacia()
        {
            if (raiz == null)
                return true;
            else
                return false;
        }

        public string Imprimir()
        {
            string cadena = "";
            Nodo reco = raiz;

            while (reco != null)
            {
                cadena += "-" + reco.inf;
                reco = reco.sig;
            }

            //reco = raiz;

            //while (reco.sig != null)
            //    reco = reco.sig;

            //cadena += "----";

            //while (reco != null)
            //{
            //    cadena += "*" + reco.inf;
            //    reco = reco.ant;
            //}

            return cadena;
        }
    }
}

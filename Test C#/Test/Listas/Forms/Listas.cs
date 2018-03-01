using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.Listas.Class;

namespace Test.Listas.Forms
{
    public partial class Listas : Form
    {
        Pila pila = new Pila();
        Cola cola = new Cola();
        Generica generica = new Generica();

        bool intercambiar = false;

        public Listas()
        {
            InitializeComponent();
        }

        #region Lista Tipo Pila
        private void Pila_button_Click(object sender, EventArgs e)
        {
            Pila_groupBox.Enabled = true;
            Cola_groupBox.Enabled = false;
            Genericas_groupBox.Enabled = false;
        }

        private void Agregar_Valor_Lista_button_Click(object sender, EventArgs e)
        {
            pila.Insertar(Convert.ToInt32(Nuevo_Valor_Pila_textBox.Text));
            Nuevo_Valor_Pila_textBox.Text = "";
        }

        private void Extraer_button_Click(object sender, EventArgs e)
        {
            pila.Extraer();
        }

        private void Imprimir_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pila.Imprimir());
        }
        #endregion

        #region Lista Tipo Cola
        private void Cola_button_Click(object sender, EventArgs e)
        {
            Pila_groupBox.Enabled = false;
            Cola_groupBox.Enabled = true;
            Genericas_groupBox.Enabled = false;
        }

        private void Agregar_Valor_Cola_button_Click(object sender, EventArgs e)
        {
            cola.Insertar(Convert.ToInt32(Nuevo_Valor_Cola_textBox.Text));
            Nuevo_Valor_Cola_textBox.Text = "";
        }

        private void Extraer_Cola_button_Click(object sender, EventArgs e)
        {
            cola.Extraer();
        }

        private void Imprimir_Cola_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cola.Imprimir());
        }

        private void Vaciar_Cola_button_Click(object sender, EventArgs e)
        {
            if (cola.Vacia())
                MessageBox.Show("La cola se encuentra vacia.");
            else
                MessageBox.Show("La cola cuenta con elementos.");
        }
        #endregion

        #region Lista Tipo Genericas
        private void Genericas_button_Click(object sender, EventArgs e)
        {
            Pila_groupBox.Enabled = false;
            Cola_groupBox.Enabled = false;
            Genericas_groupBox.Enabled = true;
        }

        private void Agregar_Valor_Generico_button_Click(object sender, EventArgs e)
        {
            generica.Insertar(Convert.ToInt32(Posicion_Generico_textBox.Text), Convert.ToInt32(Valor_Generico_textBox.Text));
        }

        private void Extraer_Generico_button_Click(object sender, EventArgs e)
        {
            generica.Extraer(Convert.ToInt32(Posicion_Generico_textBox.Text));
        }

        private void Imprimir_Generico_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(generica.Imprimir());
        }

        private void Vacia_Generico_button_Click(object sender, EventArgs e)
        {
            if (generica.Vacia())
                MessageBox.Show("La lista se encuentra vacia.");
            else
                MessageBox.Show("La lista cuenta con elementos.");
        }

        private void Borrar_Generico_button_Click(object sender, EventArgs e)
        {
            generica.Borrar(Convert.ToInt32(Posicion_Generico_textBox.Text));
        }

        private void Mayor_Valor_Generico_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El valor mayor es: " + generica.Mayor());
        }

        private void Posicion_Mayor_Generico_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La posicion con el valor mayor es: " + generica.PosMayor());
        }

        private void Ordenada_Generico_button_Click(object sender, EventArgs e)
        {
            if (generica.Ordenada())
                MessageBox.Show("La lista se encuentra con los valores ordenados.");
            else
                MessageBox.Show("La lista se encuentra con los valores desordenados.");
        }

        private void Existe_Generico_button_Click(object sender, EventArgs e)
        {
            if (generica.Existe(Convert.ToInt32(Valor_Generico_textBox.Text)))
                MessageBox.Show("El valor se encuentra en la lista.");
            else
                MessageBox.Show("El valor no se encuentra en la lista.");
        }

        private void Intercambiar_Generica_button_Click(object sender, EventArgs e)
        {
            if (intercambiar == false)
            {
                Intercambiar_Generica_button.Text = "Intercambiar";
                Valor_Generica_label.Text = "Valor 1";
                Posicion_Generica_label.Text = "Valor 2";
                intercambiar = true;
            }
            else
            {
                generica.Intercambiar(Convert.ToInt32(Valor_Generico_textBox.Text), Convert.ToInt32(Posicion_Generico_textBox.Text));

                Intercambiar_Generica_button.Text = "¿Intercambiar?";
                Valor_Generica_label.Text = "Valor";
                Posicion_Generica_label.Text = "Posicion";

                intercambiar = false;
            }
        }
        #endregion
    }
}
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
    public partial class Listas_Dobles : Form
    {
        Dobles doble = new Dobles();
        bool cambios = false;

        public Listas_Dobles()
        {
            InitializeComponent();
        }

        private void Insertar_button_Click(object sender, EventArgs e)
        {
            int pos = Convert.ToInt32(Posicion_textBox.Text);

            doble.Insertar(Convert.ToInt32(Valor_textBox.Text), pos);

            if (pos > doble.Cantidad())
                MessageBox.Show("Se agrego al final de la lista, por ser mayor la posicion que la cantidad de elementos.");
        }

        private void Extraer_button_Click(object sender, EventArgs e)
        {
            doble.Extraer(Convert.ToInt32(Posicion_textBox.Text));
        }

        private void Borrar_button_Click(object sender, EventArgs e)
        {
            doble.Borrar(Convert.ToInt32(Posicion_textBox.Text));
        }

        private void Intercambiar_button_Click(object sender, EventArgs e)
        {
            if (cambios == false)
            {
                Valor_label.Text = "Posicion(1)";
                Posicion_label.Text = "Posicion(2)";
                Intercambiar_button.Text = "Intercambiar";
                cambios = true;
            }
            else
            {
                doble.Intercambiar(Convert.ToInt32(Valor_textBox.Text), Convert.ToInt32(Posicion_textBox.Text));
                Valor_label.Text = "Valor";
                Posicion_label.Text = "Posicion";
                Intercambiar_button.Text = "¿Intercambiar?";
                cambios = false;
            }
        }

        private void Mayor_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El valor mayor es: " + doble.Mayor());
        }

        private void Posicion_Mayor_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La posicion con el valor mayor es: " + doble.Posicion_Mayor());
        }

        private void Cantidad_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El total de elementos es: " + doble.Cantidad());
        }

        private void Ordenada_button_Click(object sender, EventArgs e)
        {
            if (doble.Ordenada())
                MessageBox.Show("La lista esta ordenada.");
            else
                MessageBox.Show("La lista no se encuentra ordenada.");
        }

        private void Existe_button_Click(object sender, EventArgs e)
        {
            if (doble.Existe(Convert.ToInt32(Valor_textBox.Text)))
                MessageBox.Show("El valor se encuentra en la lista");
            else
                MessageBox.Show("El valor no se encuentra en la lista");
        }

        private void Vacia_button_Click(object sender, EventArgs e)
        {
            if (doble.Vacia())
                MessageBox.Show("La lista se encuentra vacia");
            else
                MessageBox.Show("La lista no se encuentra vacia");
        }

        private void Imprimir_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(doble.Imprimir());
        }

        private void Salir_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

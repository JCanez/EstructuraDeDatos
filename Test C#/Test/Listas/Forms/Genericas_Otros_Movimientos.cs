using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.Listas.Forms
{
    public partial class Genericas_Otros_Movimientos : Form
    {
        public Genericas_Otros_Movimientos()
        {
            InitializeComponent();
        }

        #region Insertar
        private void Insertar_Primera_Posicion_button_Click(object sender, EventArgs e)
        {
            int a;

            if (!Valor_Vacio())
                a = 0;
            else
                Mensajes("Favor de agregar un valor.");
        }

        private void Insertar_Ultima_Posicion_button_Click(object sender, EventArgs e)
        {

        }

        private void Insertar_Segunda_Posicion_button_Click(object sender, EventArgs e)
        {

        }

        private void Insertar_Antepenultima_Posicion_button_Click(object sender, EventArgs e)
        {

        }

        private bool Valor_Vacio()
        {
            if (Valor_textBox.Text != "")
                return false;
            else
                return true;
        }
        #endregion

        #region Borrar
        private void Borrar_Primera_Posicion_button_Click(object sender, EventArgs e)
        {

        }

        private void Borrar_Segunda_Posicion_button_Click(object sender, EventArgs e)
        {

        }

        private void Borrar_Ultima_Posicion_button_Click(object sender, EventArgs e)
        {

        }

        private void Borrar_Nodo_Mayor_button_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void Mensajes(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
    }
}

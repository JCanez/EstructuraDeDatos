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
        public int movimiento = 0;
        public int valor = 0;

        public Genericas_Otros_Movimientos()
        {
            InitializeComponent();
        }

        #region Insertar
        private void Insertar_Primera_Posicion_button_Click(object sender, EventArgs e)
        {
            if (!Valor_Vacio())
            {
                movimiento = 1;
                this.Close();
            }
            else
            {
                Mensajes("Favor de agregar un valor.");
            }
        }

        private void Insertar_Segunda_Posicion_button_Click(object sender, EventArgs e)
        {
            if (!Valor_Vacio())
            {
                movimiento = 2;
                this.Close();
            }
            else
            {
                Mensajes("Favor de agregar un valor.");
            }
        }

        private void Insertar_Antepenultima_Posicion_button_Click(object sender, EventArgs e)
        {
            if (!Valor_Vacio())
            {
                movimiento = 3;
                this.Close();
            }
            else
            {
                Mensajes("Favor de agregar un valor.");
            }
        }

        private void Insertar_Ultima_Posicion_button_Click(object sender, EventArgs e)
        {
            if (!Valor_Vacio())
            {
                movimiento = 4;
                this.Close();
            }
            else
            {
                Mensajes("Favor de agregar un valor.");
            }
        }

        private bool Valor_Vacio()
        {
            if (Valor_textBox.Text != "")
            {
                valor = Convert.ToInt32(Valor_textBox.Text);
                return false;
            }
            else
                return true;
        }
        #endregion

        #region Borrar
        private void Borrar_Primera_Posicion_button_Click(object sender, EventArgs e)
        {
            movimiento = 5;
            this.Close();
        }

        private void Borrar_Segunda_Posicion_button_Click(object sender, EventArgs e)
        {
            movimiento = 6;
            this.Close();
        }

        private void Borrar_Ultima_Posicion_button_Click(object sender, EventArgs e)
        {
            movimiento = 7;
            this.Close();
        }

        private void Borrar_Nodo_Mayor_button_Click(object sender, EventArgs e)
        {
            movimiento = 8;
            this.Close();
        }
        #endregion

        #region Ordenar
        private void Ordenar_Mayor_Menor_button_Click(object sender, EventArgs e)
        {
            movimiento = 9;
            this.Close();
        }

        private void Ordenar_Menor_Mayor_button_Click(object sender, EventArgs e)
        {
            movimiento = 10;
            this.Close();
        }
        #endregion

        private void Mensajes(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void Cerrar_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Valor_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //NUMERO ENTEROS
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            //NUMERO DECIMALES
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.Listas.Forms;

namespace Test
{
    public partial class EstructurasDinamicas : Form
    {
        public EstructurasDinamicas()
        {
            InitializeComponent();
        }

        private void Listas_button_Click(object sender, EventArgs e)
        {
            Listas.Forms.Listas_Simples forma_lista = new Listas.Forms.Listas_Simples();
            forma_lista.ShowDialog();
        }

        private void Salir_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Listas_Dobles_button_Click(object sender, EventArgs e)
        {
            Listas_Dobles Frm_Dobles = new Listas_Dobles();
            Frm_Dobles.ShowDialog();
        }
    }
}

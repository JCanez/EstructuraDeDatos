using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Listas.Forms.Listas forma_lista = new Listas.Forms.Listas();
            forma_lista.ShowDialog();
        }
    }
}

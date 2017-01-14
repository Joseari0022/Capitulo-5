using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadena
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CadenaPalabra()
        {
            int Numero;
            Numero = int.Parse(NumerotextBox.Text);
            if (Numero == 1)
            {
                PalabratextBox.Text = "Jose Gonzalez";

            }
            else if (Numero == 2)
            {
                PalabratextBox.Text = "Cheo Paredes";
            }
            else if (Numero == 3)
            {
                PalabratextBox.Text = "Johalvin Paredes";
            }
            else if (Numero == 4)
            {
                PalabratextBox.Text = "Danilo Sanchez";
            }
            else if (Numero > 4)
            {
                PalabratextBox.Text = "ya no hay mas Palabra solo cuatro Palabra";
            }
        }

        private void ClickButton_Click(object sender, EventArgs e)
        {
            CadenaPalabra();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class frmTomas : Form
    {
        public frmTomas()
        {
            InitializeComponent();
        }

        private void bt_Click(object sender, EventArgs e)
        {
            lbl.Text = "";
            string frase = txt.Text;

            for (int i = 0; i < frase.Length; i++)
            {
                lbl.Text = lbl.Text + frase.Substring(i, 1) + "\r\n";
            }
        }

        private void btPalabra_Click(object sender, EventArgs e)
        {
            lbl.Text = "";
            string frase = txt.Text;
            string palabra = "";

            for (int i = 0; i < frase.Length; i++)
            {
                string letra = frase.Substring(i, 1);

                if (letra==" ")
                {
                    lbl.Text = lbl.Text + palabra + "\r\n";
                    palabra = "";
                }
                else
                {
                    palabra = palabra + letra;
                }
            }
            lbl.Text = lbl.Text + palabra;
        }
    }
}

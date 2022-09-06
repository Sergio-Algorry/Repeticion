using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class frmRepeticion : Form
    {
        public frmRepeticion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTomas NuevoFormulario = new frmTomas();

            NuevoFormulario.ShowDialog();
        }

        private void bt_Click(object sender, EventArgs e)
        {

            int repeticiones = Convert.ToInt32( txtHasta.Text);

            for (int i = 0; i < repeticiones; i++)
            {
                lblFigura.Left = lblFigura.Left + 50;
                Demora();
            }
        }

        private void Demora()
        {
            for (int j = 0; j < 10; j++)
            {
                txtcontador.Text = j.ToString();
                this.Refresh();
            }
        }

        private void btWhile_Click(object sender, EventArgs e)
        {
            
            while (lblFigura.Right < this.Width-20)
            {
                lblFigura.Left = lblFigura.Left + 5;
                Demora();
            }
        }

        private void btUntil_Click(object sender, EventArgs e)
        {
            do
            {
                lblFigura.Left = lblFigura.Left + 5;
                Demora();
            } while (lblFigura.Right < this.Width - 20);
        }
    }
}

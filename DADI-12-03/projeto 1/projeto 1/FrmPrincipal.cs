using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void lblTítulo_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            double v1 = double.Parse(txtbValor1.Text);
            double v2 = double.Parse(txtbValor2.Text);

            double total = v1 + v2;

            lblTotal.Text = total.ToString();
        }

        private void bntSubtrair_Click(object sender, EventArgs e)
        {
            double v1 = double.Parse(txtbValor1.Text);
            double v2 = double.Parse(txtbValor2.Text);

            double total = v1 - v2;

            lblTotal.Text = total.ToString();
        }

        private void bntMultiplicar_Click(object sender, EventArgs e)
        {
            double v1 = double.Parse(txtbValor1.Text);
            double v2 = double.Parse(txtbValor2.Text);

            double total = v1 * v2;

            lblTotal.Text = total.ToString();
        }

        private void bntDividir_Click(object sender, EventArgs e)
        {
            double v1 = double.Parse(txtbValor1.Text);
            double v2 = double.Parse(txtbValor2.Text);

            if(v2 != 0) 
            {
                double total = v1 / v2;

                lblTotal.Text = total.ToString();
            }
            else
            {
                lblTotal.Text = "ERRO - DIVISÃO POR ZERO";
            }
        }
    }
}

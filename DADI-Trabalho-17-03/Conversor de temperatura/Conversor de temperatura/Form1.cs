using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_de_temperatura
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblCeusius.Left = (PnlCelsius.ClientSize.Width - LblCeusius.Width) / 2;
            LblCeusius.Top = 0;

            TbCeusius.Left = (PnlCelsius.ClientSize.Width - TbCeusius.Width) / 2;
            TbCeusius.Top = (PnlCelsius.ClientSize.Height - TbCeusius.Height);

            PnlCelsius.Top = (TlpMain.ClientSize.Height - PnlCelsius.Height) / 5;


            LblFahrenheit.Left = (PnlFahrenheit.ClientSize.Width - LblFahrenheit.Width) / 2;
            LblFahrenheit.Top = 0;

            TbFahrenheit.Left = (PnlFahrenheit.ClientSize.Width - TbFahrenheit.Width) / 2;
            TbFahrenheit.Top = (PnlFahrenheit.ClientSize.Height - TbFahrenheit.Height);

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
          
        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void LblCeusius_Click(object sender, EventArgs e)
        {

        }

        private void LblFahrenheit_Click_1(object sender, EventArgs e)
        {

        }

        private void TbCeusius_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if(!double.TryParse(TbCeusius.Text, out double c)) 
            {
                return;
            }

            TbFahrenheit.Text = ((c * 1.8) + 32).ToString("f2");
            TbCeusius.Text = c.ToString("f2");
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

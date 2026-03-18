using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void Centralizar()
        {
            label1.Left = (panel1.ClientSize.Width - label1.Width) / 2;
            label1.Top = (panel1.ClientSize.Height - label1.Height) / 2;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

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
            Centralizar();
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            label1.Left = (panel1.Width - label1.Width) / 2;
            label1.Top = (panel1.Height - label1.Height) / 2;
            MessageBox.Show("rodou");
        }
    }
}

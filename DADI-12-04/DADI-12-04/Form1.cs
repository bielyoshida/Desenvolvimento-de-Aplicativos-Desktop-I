using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DADI_12_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAluno a = new FrmAluno();
            a.ShowDialog();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCurso c = new FrmCurso();
            c.ShowDialog();
        }

        private void sexoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProfessor s = new FrmProfessor();
            s.ShowDialog();
        }

    }
}

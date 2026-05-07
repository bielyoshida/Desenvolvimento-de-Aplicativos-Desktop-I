using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DADI__28_04
{
    public partial class FrmEstoque : Form
    {
        public FrmEstoque()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cnv = new SqlConnection(conn.StrCon))
                {
                    cnv.Open();
                    MessageBox.Show("Conectando ao BD");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao conectar ao BD\n\n" + ex.Message);
            }
        }
    }
}

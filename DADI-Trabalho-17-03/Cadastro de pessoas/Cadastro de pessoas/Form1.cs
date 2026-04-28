using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_pessoas
{
    public partial class FrmMain : Form
    {
        List<Pessoa> lista = new List<Pessoa>();

        public class Pessoa
        {
            public string Nome { get; set; }
            public int Idade { get; set; }
        }
        public FrmMain()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void LblIdade_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = TbNome.Text;
            int idade;

            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Digite o nome");
                return;
            }

            if (!int.TryParse(TbIdade.Text, out idade))
            {
                MessageBox.Show("Digite uma idade válida");
                return;
            }

            Pessoa p = new Pessoa();
            p.Nome = nome;
            p.Idade = idade;

            lista.Add(p);

            MessageBox.Show("Cadastrado com sucesso!");

            TbNome.Clear();
            TbIdade.Clear();

        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            LbLista.Items.Clear();

            foreach (Pessoa p in lista)
            {
                LbLista.Items.Add(p.Nome + " - " + p.Idade + " anos");
            }
        }
    }
}

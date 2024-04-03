using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormPrincipal : Form
    {
        //variavel inteiro
        int contador = 0;
        //variavel texto
        string mensagem = string.Empty;
        //variavel decimal
        decimal saldoAtual = decimal.Zero;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void contaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //cria uma variavel do formConta
            var formConta = new FormConta();
            //mostra a tela formConta
            formConta.Show();
            //incrementa o valor da variável contador
            contador++;
            contador = contador + 1;
        }

        private void contadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exibe uma caixa de mensagem
            mensagem = "Contador de clique: " + contador;
            MessageBox.Show(mensagem,
                "Contador",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //atribui o valor da variavel mensagem
            mensagem = "deseja sair do aplicativo?";
            var resultado = MessageBox.Show(mensagem, "Sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                //fecha o aplicativo
                Application.Exit();
            }
            else
            {
                //grava um log que ele desistiu de sair
                Console.Write("O usuario desistiu de fechar");
            }
        }

        private void ferramentasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calculoDeJurosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormCalculoJuros().ShowDialog();
        }
    }
}

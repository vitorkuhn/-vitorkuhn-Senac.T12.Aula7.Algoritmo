using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormCalculoJuros : Form
    {
        public FormCalculoJuros()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // criar variaveis aporte, e juros do tipo double
            //obter o texto do txtValor
            // obter o texto do txtJuros
            // converter o texto em um número double
            double aporte = double.Parse(txtValor.Text);
            double juros = double.Parse(txtJuros.Text);
            double meses = double.Parse(txtMeses.Text);


            //chamar o método calcular
            double total = CalculaJuros(aporte, juros, meses);
            MessageBox.Show($"Total de rendimento:{total:F2}");
        }
        //calcula os juros com base no aporte e %
        //private: só pode ser chamado nesta tela
        //void: retorno vazio
        // (double aporte, double juros): parametros do metodo
        private double CalculaJuros(double aporte, double juros, double meses)
        {
            double total = 0.0;
            // estrutura de repetição
            for(int mes = 1; mes <= meses ; mes++)
            {
                aporte *= 1 + (juros / 100);
            }
            total = aporte;
            //retorna o valor total calculado
            return total;
        }
    }
}

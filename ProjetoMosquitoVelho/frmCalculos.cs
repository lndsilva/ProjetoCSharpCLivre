using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMosquitoVelho
{
    public partial class frmCalculos : Form
    {
        public frmCalculos()
        {
            InitializeComponent();
        }

        //criando o método para somar valores e retornar o resultado
        public double somaValor(double num1, double num2)
        {
            return (num1 + num2);
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Clear();
            lblResposta.Text = "";
            txtNum1.Focus();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            //declarando as variáveis
            double num1, num2, resp;

            //Atribuir valores as variáveis
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            //Calculando
            //resp = num1 + num2;
            resp = somaValor(num1, num2);

            //Enviando valor para a resposta
            lblResposta.Text = resp.ToString();


        }
    }
}

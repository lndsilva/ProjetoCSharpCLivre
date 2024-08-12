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
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        //limparCampos
        public void limparCampos()
        {
            txtValor1.Clear();
            txtValor2.Clear();
            lblResposta.Text = "";
            rdbsomar.Checked = false;
            rdbSubtrair.Checked = false;
            rdbMultiplicar.Checked = false;
            rdbDividir.Checked = false;
            txtValor1.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, resp = 0;

            try
            {
                num1 = Convert.ToDouble(txtValor1.Text);
                num2 = Convert.ToDouble(txtValor2.Text);

                //instânciar o objeto/classe
                Operacoes op = new Operacoes();

                if (rdbsomar.Checked)
                {
                    resp = op.somar(num1, num2);
                }
                if (rdbSubtrair.Checked)
                {
                    resp = op.subtrair(num1, num2);
                }
                if (rdbMultiplicar.Checked)
                {
                    resp = op.multiplicar(num1, num2);
                }
                if (rdbDividir.Checked)
                {
                    if (num2 == 0)
                    {
                        MessageBox.Show("Impossível divisão por 0",
                            "SistemaABC",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1);
                        //executar o método limparCampos
                        limparCampos();

                    }
                    else
                    {
                        resp = op.dividir(num1, num2);

                    }

                    lblResposta.Text = resp.ToString();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Insira somente números");
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //executando o método limparCampos
            limparCampos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

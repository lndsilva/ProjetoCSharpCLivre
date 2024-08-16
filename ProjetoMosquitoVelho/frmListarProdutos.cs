using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProjetoMosquitoVelho
{
    public partial class frmListarProdutos : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmListarProdutos()
        {
            InitializeComponent();
            //executando o método para carregar a combobox
            carregaCombo();
        }
        //criando o método carregaCombo
        public void carregaCombo()
        {
            //inserindo valores no vetor
            produtos[0] = "Banana";
            produtos[1] = "Limão";
            produtos[2] = "Laranja";
            produtos[3] = "Pera";
            produtos[4] = "Uva";
            produtos[5] = "Maça";
            produtos[6] = "Melancia";
            produtos[7] = "Jaboticaba";
            produtos[8] = "Goiaba";
            produtos[9] = "Tangerina";

            for (int i = 0; i < produtos.Length; i++)
            {
                cbbProdutos.Items.Add(produtos[i]);
            }

        }
        private void frmListarProdutos_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        //criando um vetor
        string[] produtos = new string[10];

        private void btnCarregar_Click(object sender, EventArgs e)
        {


            //inserindo valores no vetor
            produtos[0] = "Banana";
            produtos[1] = "Limão";
            produtos[2] = "Laranja";
            produtos[3] = "Pera";
            produtos[4] = "Uva";
            produtos[5] = "Maça";
            produtos[6] = "Melancia";
            produtos[7] = "Jaboticaba";
            produtos[8] = "Goiaba";
            produtos[9] = "Tangerina";

            //imprimindo os vetores
            //MessageBox.Show("Produto "+ produtos[0]);
            //MessageBox.Show("Produto "+ produtos[5]) ;

            //limpando os itens da lista
            ltbListaProdutos.Items.Clear();

            //percorrendo o vetor criado
            for (int i = 0; i < produtos.Length; i++)
            {
                ltbListaProdutos.Items.Add(produtos[i]);
            }
        }

        private void cbbListarItens_MouseClick(object sender, MouseEventArgs e)
        {
            produtos[0] = "Banana";
            produtos[1] = "Limão";
            produtos[2] = "Laranja";
            produtos[3] = "Pera";
            produtos[4] = "Uva";
            produtos[5] = "Maça";
            produtos[6] = "Melancia";
            produtos[7] = "Jaboticaba";
            produtos[8] = "Goiaba";
            produtos[9] = "Tangerina";

            cbbListarItens.Items.Clear();

            for (int i = 0; i < produtos.Length; i++)
            {
                cbbListarItens.Items.Add(produtos[i]);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void btnTestarPessoa_Click(object sender, EventArgs e)
        {
            //instanciando o objeto pessoa
            Pessoa p = new Pessoa();
            p.Nome = "Senac";
            lblTestarPessoa.Text = p.Nome;




        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            Bilhete bilhete = new Bilhete();

            bilhete.Documento = txtDocumento.Text;
            bilhete.NumeroCartao = mtbNumeroCartao.Text;

            lblMostrarDocumeto.Text = bilhete.Documento;
            lblMostrarNumeroCartao.Text = bilhete.NumeroCartao;


        }
    }
}

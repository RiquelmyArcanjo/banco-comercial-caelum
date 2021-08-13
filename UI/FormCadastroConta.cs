using Banco_Comercial_IBM.Busca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Banco_Comercial_IBM
{
    public partial class FormCadastroConta : Form
    {
        private FormHome formPrincipal;

        //ICollection é uma das Interfaces que o List, HashSet e SortSet herdam
        //Criando a variável para pegar a coleção de devedores, sendo ela list, hashset ou sortset... (ICollection é genérico)
        private ICollection<string> devedores;//tipando para string

        //Construtor
        public FormCadastroConta(FormHome formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();

            //Instanciando GeradorDeDevedores e atribuindo os devedores para o ICollection
            GeradorDeDevedores objGeraDevedores = new GeradorDeDevedores();
            this.devedores = objGeraDevedores.GerarListaNomes();
        }
        //load do form colocar o numero da conta
        private void btnCadastraConta_Click(object sender, EventArgs e)
        {
            //bool retornoCadastraConta = true;

            string titular = txtNomeTitular.Text;

            bool isDevedor = this.devedores.Contains(titular);//verifica se o nome digitado é um devedor

            if (txtNomeTitular.Text == "" || cmbTipoConta.Text == "")
                MessageBox.Show("Preencha todos os campos!");                        
            else if (isDevedor)
                MessageBox.Show("Cliente devedor! Infelizmente não é possível criar uma conta...");                  
            else
            {
                Conta novaConta;

                if (cmbTipoConta.Text == "Conta Corrente")
                    novaConta = new ContaCorrente();
                else if (cmbTipoConta.Text == "Conta Poupança")
                    novaConta = new ContaPoupanca();
                else if (cmbTipoConta.Text == "Conta Estudante")
                    novaConta = new ContaEstudante();
                else
                    novaConta = new ContaInvestimento();

                novaConta.Titular = new Cliente(txtNomeTitular.Text);
                novaConta.Numero = Convert.ToInt32(txtNumeroConta.Text);
                this.formPrincipal.AdicionarConta(novaConta);

                MessageBox.Show("Cadastro realizado!");
                this.Close();
            }
        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {
            txtNumeroConta.Text = Conta.ProximoNumero().ToString();
            this.ActiveControl = txtNomeTitular;
        }
    }
}

using Banco_Comercial_IBM.Exceptions;
using Banco_Comercial_IBM.Interfaces;
using Banco_Comercial_IBM.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco_Comercial_IBM.MinhasExtensoes;

namespace Banco_Comercial_IBM
{
    public partial class FormHome : Form
    {
        private List<Conta> listContas;
        private List<string> listHistoricoMovimentacoes;
        private Dictionary<string, Conta> dicionario;
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            this.listContas = new List<Conta>();
            this.listHistoricoMovimentacoes = new List<string>();
            this.dicionario = new Dictionary<string, Conta>();

            Conta c1 = new ContaCorrente();
            c1.Titular = new Cliente("Jeff");
            this.AdicionarConta(c1);

            Conta c2 = new ContaPoupanca();
            c2.Titular = new Cliente("Elon");
            this.AdicionarConta(c2);

            Conta c3 = new ContaInvestimento();
            c3.Titular = new Cliente("Bernard");
            this.AdicionarConta(c3);

            Conta c4 = new ContaEstudante();
            c4.Titular = new Cliente("Bill");
            this.AdicionarConta(c4);

            this.Height = 440;
            this.Width = 440;

            this.ActiveControl = txtBuscaTitular;
        }

        public void AdicionarConta(Conta conta)
        {
            this.listContas.Add(conta);
            cmbContas.Items.Add(conta);
            this.dicionario.Add(conta.Titular.Nome, conta);
        }

        private void btnMovimentacao_Click(object sender, EventArgs e)
        {
            operar();
        }

        private void operar()
        {
            string msgOperacao;

            bool retornoCamposPreenchidos = camposPreenchidos();

            if (retornoCamposPreenchidos == true)
            {
                Conta selecionada = (Conta)cmbContas.SelectedItem;

                //SAQUE
                if (cmbTipoMovimento.Text == "Sacar")
                {
                    try
                    {
                        selecionada.Sacar(Convert.ToDouble(txtValor.Text));
                        if(selecionada is ContaCorrente)
                        {
                            listHistoricoMovimentacoes.Add("- Saque de R$ " + txtValor.Text + " + taxa de R$ 0,10 em " + DateTime.Now + " (Titular id: " + selecionada.Numero + ").");
                            msgOperacao = Convert.ToDouble(txtValor.Text) + " reais foram sacados! (Taxa de R$0,10 aplicada)";
                        }
                        else
                        {
                            listHistoricoMovimentacoes.Add("- Saque de R$ " + txtValor.Text + " em " + DateTime.Now + " (Titular id: " + selecionada.Numero + ").");
                            msgOperacao = Convert.ToDouble(txtValor.Text) + " reais foram sacados!";
                        }
                    }
                    catch (SaldoInsuficienteException e)
                    {
                        msgOperacao = e.Message;
                    }
                    catch (ArgumentException e)
                    {
                        msgOperacao = e.Message;
                    }
                    catch (FormatException)
                    {
                        msgOperacao = "Insira um valor válido para realizar o saque!";
                    }
                    catch (Exception e)
                    {
                        msgOperacao = "Erro inesperado: " + e.Message;
                    }
                }
                //DEPÓSITO
                else if (cmbTipoMovimento.Text == "Depositar")
                {
                    try
                    {
                        selecionada.Depositar(Convert.ToDouble(txtValor.Text));
                        if(selecionada is ContaEstudante)
                        {
                            listHistoricoMovimentacoes.Add("- Depósito de R$ " + txtValor.Text + " + bônus de 1% em " + DateTime.Now + " (Titular id: " + selecionada.Numero + ").");
                            msgOperacao = txtValor.Text + " reais foram depositados! (Bônus de 1% aplicado)";
                        }
                        else
                        {
                            listHistoricoMovimentacoes.Add("- Depósito de R$ " + txtValor.Text + " em " + DateTime.Now + " (Titular id: " + selecionada.Numero + ").");
                            msgOperacao = txtValor.Text + " reais foram depositados!";
                        }

                    }
                    catch (ArgumentException e)
                    {
                        msgOperacao = e.Message;
                    }
                    catch (FormatException)
                    {
                        msgOperacao = "Insira um valor válido para realizar o depósito!";
                    }
                    catch (LimiteDepositoException e)
                    {
                        msgOperacao = e.Message;
                    }
                    catch (Exception e)
                    {
                        msgOperacao = "Erro inesperado: " + e.Message;
                    }

                }
                //TRANSFERÊNCIA
                else
                {
                    double valorOp;
                    int NumContaDestino;
                    msgOperacao = "";
                    try
                    {
                        if (!double.TryParse(txtValor.Text, out valorOp))
                            throw new FormatException("Digite um valor válido.");
                        if (!int.TryParse(txtNumeroContaDestino.Text, out NumContaDestino))
                            throw new FormatException("Digite o número da conta destino corretamente...");
                        if (txtNumeroContaDestino.Text == txtNumeroConta.Text)
                            throw new ContaDestinoInvalidaException("Escolha uma conta que não seja a sua para realizar a transferência!");

                        foreach (Conta conta in listContas)
                        {
                            if (conta.Numero == NumContaDestino)
                            {
                                selecionada.Transferir(valorOp, conta);
                                listHistoricoMovimentacoes.Add("- Transferência de R$ " + txtValor.Text + " em " + DateTime.Now + " (Remente id.: " + selecionada.Numero + " | Destinatário id.: " + conta.Numero + ").");
                                msgOperacao = "Transferência de " + txtValor.Text + " reais realizada!";
                                break;
                            }
                            else
                                msgOperacao = "Conta inexistente, revise o número da conta destino!";
                        }
                    }
                    catch (FormatException e)
                    {
                        msgOperacao = e.Message;
                    }
                    catch (ContaDestinoInvalidaException e)
                    {
                        msgOperacao = e.Message;
                    }
                    catch (ArgumentException e)
                    {
                        msgOperacao = e.Message;
                    }
                    catch (Exception e)
                    {
                        msgOperacao = "Erro inesperado: " + e.Message;
                    }
                }

                MessageBox.Show(msgOperacao);
                txtSaldoFinal.Text = selecionada.Saldo.ToString();
                txtValor.Text = String.Empty;
                cmbTipoMovimento.SelectedIndex = -1;
                txtValor.Focus();
            }
        }

        private bool camposPreenchidos()
        {
            string msgErro = "";
            bool camposPreenchidos = true;

            if (cmbContas.Text == "")
            {
                msgErro += "Conta não selecionada.\n";
                camposPreenchidos = false;
            }
            if (string.IsNullOrEmpty(cmbTipoMovimento.Text))
            {
                msgErro += "Tipo de movimento não selecionado.\n";
                camposPreenchidos = false;
            }
            if (txtValor.Text == "")
            {
                msgErro += "Preencha o Valor da Operação.\n";
                camposPreenchidos = false;
            }
            if (txtNumeroContaDestino.Text == "")
            {
                msgErro += "Número da conta destino vazio.\n";
                camposPreenchidos = false;
            }

            if (camposPreenchidos == false)
                MessageBox.Show(msgErro, "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return camposPreenchidos;
        }

        private void cmbTipoMovimento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoMovimento.Text == "Transferir")
            {
                txtNumeroContaDestino.Enabled = true;
                txtNumeroContaDestino.Text = String.Empty;

                lblMsg.Text = String.Empty;
            }
            else
            {
                txtNumeroContaDestino.Text = txtNumeroConta.Text;
                txtNumeroContaDestino.Enabled = false;


                if (cmbTipoMovimento.Text == "Sacar")
                    lblMsg.Text = "Taxa de saque na conta corrente: R$ 0,10.";
                else if (cmbTipoMovimento.Text == "Depositar")
                    lblMsg.Text = "Depósito na conta estudante têm bônus de 1%.";
                else
                    lblMsg.Text = String.Empty;
            }
        }

        private void cmbContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cmbContas.SelectedIndex;
            Conta selecionada = listContas[indice];

            cmbTipoMovimento.SelectedIndex = -1;

            txtNumeroConta.Text = selecionada.Numero.ToString();
            txtNumeroContaDestino.Text = selecionada.Numero.ToString();

            txtSaldoFinal.Text = selecionada.Saldo.ToString();
        }

        private void btnNovaConta_Click(object sender, EventArgs e)
        {
            //this representa a instância de Form1 que está sendo utilizada pelo Window Form
            FormCadastroConta formularioDeCadastro = new FormCadastroConta(this);
            //Mostra o form
            formularioDeCadastro.ShowDialog();
        }
        private void btnBuscaTitular_Click(object sender, EventArgs e)
        {
            string nomeTitular = txtBuscaTitular.Text;
            try
            {
                Conta conta = dicionario[nomeTitular];

                cmbContas.SelectedItem = conta;
                txtNumeroConta.Text = Convert.ToString(conta.Numero);
                txtNumeroContaDestino.Text = Convert.ToString(conta.Numero);
                txtNumeroContaDestino.Enabled = false;
                txtSaldoFinal.Text = Convert.ToString(conta.Saldo);
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("Usuário não encontrado, revise o nome!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado: " + ex.Message);
            }
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            FormRelatorios formRelatorios = new FormRelatorios(this.listContas, this.listHistoricoMovimentacoes);
            formRelatorios.ShowDialog();
        }
    }
}
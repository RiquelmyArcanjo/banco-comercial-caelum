using Banco_Comercial_IBM.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco_Comercial_IBM.UI
{
    public partial class FormRelatorios : Form
    {
        private List<Conta> contas;
        private List<string> historicoMovimentacoes;
        public FormRelatorios(List<Conta> contas, List<string> historicoMovimentacoes)
        {
            InitializeComponent();
            this.contas = contas;
            this.historicoMovimentacoes = historicoMovimentacoes;
        }

        private void cmbRelatorios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtResultadoRelatorio.Text = String.Empty;
                //SALDO GERAL
                if (cmbRelatorios.Text == "Saldo Geral")
                {
                    double totalSaldoContas = 0;
                    foreach (Conta conta in contas)
                    {
                        totalSaldoContas += conta.Saldo;
                    }
                    txtResultadoRelatorio.Text = "Saldo Geral de todos os " + contas.Count + " clientes do banco: " + totalSaldoContas + " reais." + Environment.NewLine;
                }
                //SALDO MAIOR QUE 500
                else if (cmbRelatorios.Text == "Saldo > 500")
                {
                    var consulta = contas.Where(c => c.Saldo > 500).OrderBy(c => c.Titular.Nome).ThenBy(c => c.Numero);
                    txtResultadoRelatorio.Text = "CLIENTES COM O SALDO MAIOR QUE R$ 500,00:" + Environment.NewLine;
                    foreach (var c in consulta)
                    {
                        txtResultadoRelatorio.Text += c.Titular.Nome + " (Código: " + c.Numero + ")." + Environment.NewLine;
                    }
                }
                //MAIOR SALDO
                else if (cmbRelatorios.Text == "Maior Saldo")
                {
                    txtResultadoRelatorio.Text = "Maior Saldo: " + contas.Max(c => c.Saldo) + " reais." + Environment.NewLine;
                }
                //HISTÓRICO DE MOVIMENTAÇÕES
                else if (cmbRelatorios.Text == "Histórico de Movimentações")
                {
                    foreach (var movimento in historicoMovimentacoes)
                    {
                        txtResultadoRelatorio.Text += movimento + Environment.NewLine;
                    }
                }
                //TRIBUTOS DAS CONTAS CORRENTES
                else if (cmbRelatorios.Text == "Tributos das Contas Correntes")
                {
                    txtResultadoRelatorio.Text = "TRIBUTOS DE TODAS AS CONTAS CORRENTES:" + Environment.NewLine;
                    int qtdCC = 0;
                    foreach (Conta conta in contas)
                    {
                        if (conta is ContaCorrente)
                        {
                            qtdCC++;
                            ITributavel t = (ContaCorrente)conta;
                            txtResultadoRelatorio.Text += (string.Format("Cliente {0}: {1} reais.{2}", conta.Titular.Nome, t.CalcularTributos(), Environment.NewLine));
                        }
                    }
                    txtResultadoRelatorio.Text += (string.Format("Total de contas correntes encontradas: {0}.{1}", qtdCC, Environment.NewLine));
                }
                //CONTAS ANTIGAS C/ SALDO MAIOR QUE 1000
                else if (cmbRelatorios.Text == "Código Titular < 10 e Saldo > 1000")
                {
                    txtResultadoRelatorio.Text = "CLIENTES ANTIGOS COM SALDO MAIOR QUE R$ 1.000,00:" + Environment.NewLine;
                    var consulta = contas.Where(c => c.Numero < 10 && c.Saldo > 1000).OrderBy(c => c.Titular.Nome).ThenBy(c => c.Numero);
                    foreach (var c in consulta)
                    {
                        txtResultadoRelatorio.Text += (c.Titular.Nome + " (Código: " + c.Numero + ")." + Environment.NewLine);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado: " + ex.Message);
            }
            finally
            {
                txtResultadoRelatorio.Text += (string.Format("Relatório gerado em: {0}.", DateTime.Now));
            }
        }

        private void FormRelatorios_Load(object sender, EventArgs e)
        {
            this.Height = 440;
            this.Width = 605;
        }

        private void btnSalvarRelatorio_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    using (StreamWriter escritor = new StreamWriter(myStream))
                    {
                        escritor.Write(txtResultadoRelatorio.Text);
                    }
                    myStream.Close();
                }
            }
        }
    }
}

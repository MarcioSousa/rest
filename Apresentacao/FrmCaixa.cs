using Model;
using Negocios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmCaixa : Form
    {
        string escolha = "";

        public FrmCaixa()
        {
            InitializeComponent();
            DgvCaixa.AutoGenerateColumns = false;
        }
        private void CarregaGrid()
        {
            CaixaNegocio caixaNegocio = new CaixaNegocio();
            List<Caixa> caixas = new List<Caixa>();

            caixas = caixaNegocio.TodosRegistros();

            DgvCaixa.DataSource = null;
            DgvCaixa.DataSource = caixas;

            DgvCaixa.Update();
            DgvCaixa.Refresh();

            CarregaCampos();
        }
        private void CarregaCampos()
        {
            if (DgvCaixa.Rows.Count != 0)
            {
                double totalpagamento = 0;
                double totalpedido = 0;
                double totalquebra = 0;
                double dinheiro = 0;
                double cheque = 0;
                double debito = 0;
                double credito = 0;
                double outro = 0;

                PagamentoNegocio pagamentoNegocio = new PagamentoNegocio();
                PedidoNegocio pedidoNegocio = new PedidoNegocio();

                DtpCaixa.Text = Convert.ToString(DgvCaixa.Rows[DgvCaixa.CurrentRow.Index].Cells[0].Value);
                TxtValor.Text = Convert.ToDouble(DgvCaixa.Rows[DgvCaixa.CurrentRow.Index].Cells[1].Value).ToString("##0.00");
                BtnEditar.Visible = true;
                BtnExcluir.Visible = true;
                DtpPesquisa.Visible = true;
                CbxPesquisa.Visible = true;

                totalpagamento = Convert.ToDouble(pagamentoNegocio.TotalPagamento(Convert.ToDateTime(DgvCaixa.Rows[DgvCaixa.CurrentRow.Index].Cells[0].Value)));
                totalpedido = Convert.ToDouble(pedidoNegocio.TotalPedido(Convert.ToDateTime(DgvCaixa.Rows[DgvCaixa.CurrentRow.Index].Cells[0].Value)));
                dinheiro = Convert.ToDouble(pagamentoNegocio.TotalPagamentoTipo(Convert.ToDateTime(DgvCaixa.Rows[DgvCaixa.CurrentRow.Index].Cells[0].Value), "Dinheiro"));
                cheque = Convert.ToDouble(pagamentoNegocio.TotalPagamentoTipo(Convert.ToDateTime(DgvCaixa.Rows[DgvCaixa.CurrentRow.Index].Cells[0].Value), "Cheque"));
                debito = Convert.ToDouble(pagamentoNegocio.TotalPagamentoTipo(Convert.ToDateTime(DgvCaixa.Rows[DgvCaixa.CurrentRow.Index].Cells[0].Value), "Débito"));
                credito = Convert.ToDouble(pagamentoNegocio.TotalPagamentoTipo(Convert.ToDateTime(DgvCaixa.Rows[DgvCaixa.CurrentRow.Index].Cells[0].Value), "Crédito"));
                outro = Convert.ToDouble(pagamentoNegocio.TotalPagamentoTipo(Convert.ToDateTime(DgvCaixa.Rows[DgvCaixa.CurrentRow.Index].Cells[0].Value), "Outro"));

                totalquebra = totalpedido - totalpagamento;

                TxtTotalPagamento.Text = totalpagamento.ToString("C");
                TxtTotalPedido.Text = totalpedido.ToString("C");
                TxtQuebraCaixa.Text = totalquebra.ToString("C");
                TxtDinheiro.Text = dinheiro.ToString("C");
                TxtCheque.Text = cheque.ToString("C");
                TxtDebito.Text = debito.ToString("C");
                TxtCredito.Text = credito.ToString("C");
                TxtOutro.Text = outro.ToString("C");

            }
            else
            {
                CbxPesquisa.Visible = false;
                BtnEditar.Enabled = false;
                BtnExcluir.Enabled = false;
                DtpPesquisa.Visible = false;
                TxtValor.Text = "";
                TxtTotalPagamento.Text = "R$0,00";
                TxtTotalPedido.Text = "R$0,00";
                TxtQuebraCaixa.Text = "R$0,00";
                TxtDinheiro.Text = "R$0,00";
                TxtCheque.Text = "R$0,00"; ;
                TxtDebito.Text = "R$0,00";
                TxtCredito.Text = "R$0,00";
                TxtOutro.Text = "R$0,00";
            }
        }
        private void AbreTudo()
        {
            DgvCaixa.Enabled = false;
            BtnAdicionar.Enabled = false;
            BtnEditar.Enabled = false;
            BtnExcluir.Enabled = false;

            BtnConfirmar.Enabled = true;
            BtnCancelar.Enabled = true;

            DtpCaixa.Enabled = true;
            TxtValor.ReadOnly = false;
            DtpPesquisa.Enabled = false;

            if (escolha == "A")
            {
                DtpCaixa.Value = DateTime.Today.Date;
                TxtValor.Text = "";
            }

            DtpCaixa.Focus();
        }
        private void FechaTudo()
        {
            DgvCaixa.Enabled = true;
            BtnAdicionar.Enabled = true;
            BtnEditar.Enabled = true;
            BtnExcluir.Enabled = true;

            BtnConfirmar.Enabled = false;
            BtnCancelar.Enabled = false;

            DtpCaixa.Enabled = false;
            TxtValor.ReadOnly = true;

            DgvCaixa.ReadOnly = true;
            DtpPesquisa.Enabled = true;

            CarregaGrid();

            BtnAdicionar.Focus();
        }

        private void FrmCaixa_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void DgvCaixa_SelectionChanged(object sender, EventArgs e)
        {
            CarregaCampos();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            escolha = "A";
            AbreTudo();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            escolha = "E";
            AbreTudo();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja realmente excluir o Caixa Selecionado?", "Exclusão", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    CaixaNegocio caixaNegocio = new CaixaNegocio();

                    caixaNegocio.Excluir(Convert.ToDateTime(DgvCaixa.Rows[DgvCaixa.CurrentRow.Index].Cells[0].Value));

                    MessageBox.Show("Caixa Excluído com Sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CarregaGrid();
                }
                else
                {
                    MessageBox.Show("Exclusão não Finalizada!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível Excluir o Caixa Selecionado.");
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (TxtValor.Text != "")
                    {
                        CaixaNegocio caixaNegocio = new CaixaNegocio();
                        Caixa caixa = new Caixa(Convert.ToDouble(TxtValor.Text), Convert.ToDateTime(DtpCaixa.Value));

                        if (escolha == "A")
                        {
                            if (caixaNegocio.Inserir(caixa) != "0")
                            {
                                MessageBox.Show("Não foi possível inserir.\nVerifique se já foi registrado esse valor para essa data.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                TxtValor.Focus();
                                return;
                            }
                        }
                        else
                        {
                            if (caixaNegocio.Alterar(caixa, Convert.ToDateTime(DgvCaixa.Rows[DgvCaixa.CurrentRow.Index].Cells[0].Value.ToString())) != "0")
                            {
                                MessageBox.Show("Não foi possível alterar o caixa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                DtpCaixa.Focus();
                                return;
                            }

                        }
                        escolha = "";
                        FechaTudo();
                    }
                    else
                    {
                        MessageBox.Show("Preencha a data e o valor do caixa!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    CarregaGrid();
                    BtnAdicionar.Focus();
                }
                catch (Exception ex)
                {
                    TxtValor.Text = "";
                    MessageBox.Show("Não foi possível finalizar o cadastro. Aviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível finalizar o cadastro, verifique o campo Valor. Aviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtValor.Text = "";
                TxtValor.Focus();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            escolha = "";
            FechaTudo();
        }

        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',')
            {
                if (TxtValor.Text.Contains(","))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DtpPesquisa_ValueChanged(object sender, EventArgs e)
        {
            if (CbxPesquisa.Checked)
            {
                CarregaPesquisa();
            }
            else
            {
                CarregaGrid();
            }
        }

        private void CarregaPesquisa()
        {
            try
            {
                if (CbxPesquisa.Checked)
                {
                    CaixaNegocio caixaNegocio = new CaixaNegocio();
                    List<Caixa> caixas = new List<Caixa>();

                    caixas = caixaNegocio.ProcurarPorData(DtpPesquisa.Value);

                    DgvCaixa.DataSource = caixas;

                    DgvCaixa.Update();
                    DgvCaixa.Refresh();

                    if (DgvCaixa.Rows.Count != 0)
                    {
                        BtnEditar.Visible = true;
                        BtnExcluir.Visible = true;
                    }
                    else
                    {
                        BtnEditar.Visible = false;
                        BtnExcluir.Visible = false;
                    }
                }
                else
                {
                    CarregaGrid();
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível pesquisar o valor do caixa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CbxPesquisa_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxPesquisa.Checked)
            {
                CarregaPesquisa();
            }
            else
            {
                CarregaGrid();
            }
        }

    }
}

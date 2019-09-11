using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Negocios;

namespace Apresentacao
{
    public partial class FrmPagamento : Form
    {
        Pedido pedido;
        bool inserirpagamento;

        public FrmPagamento(Pedido pedido)
        {
            InitializeComponent();
            this.pedido = pedido;
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

        private void FrmPagamento_Load(object sender, EventArgs e)
        {
            CarregaInformacoes();
            CarregaGridPagamentos();
        }
        private void CarregaGridPagamentos()
        {
            try
            {
                PagamentoNegocio pagamentoNegocio = new PagamentoNegocio();
                double ValorTotalPago = 0, ValorTotalPedido = 0;


                DgvPagamento.Rows.Clear();
                DgvPagamento.DataSource = null;

                if (pedido.Pagamentos != null)
                {
                    pedido.Pagamentos.Clear();
                }

                pedido.Pagamentos =  pagamentoNegocio.PagamentosPedido(pedido);

                for (int t = 0; t < pedido.Pagamentos.Count; t++)
                {
                    DgvPagamento.Rows.Add(pedido.Pagamentos[t].Codigo, pedido.Codigo, pedido.Pagamentos[t].Datahorapagamento, pedido.Pagamentos[t].Tipo, pedido.Pagamentos[t].Valor);
                    ValorTotalPago += pedido.Pagamentos[t].Valor;
                }
        
                if(DgvPagamento.Rows.Count != 0)
                {
                    BtnAlterar.Enabled = true;
                    BtnExcluir.Enabled = true;
                }
                else
                {
                    BtnAlterar.Enabled = false;
                    BtnExcluir.Enabled = false;

                    RbtDinheiro.Checked = true;
                    TxtValor.Text = "";
                }

                BtnReceber.Enabled = false;
                BtnCancelar.Enabled = false;
                BtnInserir.Enabled = true;

                PnlPagamento.Enabled = false;

                for(int t = 0; t < pedido.Itempedidos.Count; t++)
                {
                    ValorTotalPedido += pedido.Itempedidos[t].Valorunid * pedido.Itempedidos[t].Qtde;
                }

                LblQtdePagamento.Text = "Qtde Pago: " + DgvPagamento.Rows.Count.ToString();
                LblValorPago.Text = "Total Pago: " + ValorTotalPago.ToString("C");
                LblValorFaltante.Text = "Valor Faltante: " + Convert.ToDouble(ValorTotalPedido - ValorTotalPago).ToString("C");

            }
            catch 
            {
                MessageBox.Show("Não foi possível carregar os pagamentos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void CarregaInformacoes()
        {
            double valortotal = 0;

            LblMesa.Text = "Mesa: " + pedido.Numeromesa.ToString();
            LblGarcon.Text = "Garçon: " + pedido.Garcon.Codigo.ToString() + " - " + pedido.Garcon.Nome;

            for(int t = 0; t < pedido.Itempedidos.Count; t++)
            {
                valortotal += pedido.Itempedidos[t].Valorunid * pedido.Itempedidos[t].Qtde;
            }

            LblTotalConta.Text = "Total Conta: " + valortotal.ToString("C");
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            PnlPagamento.Enabled = true;
            inserirpagamento = true;
            BtnInserir.Enabled = false;
            BtnAlterar.Enabled = false;
            BtnExcluir.Enabled = false;
            RbtDinheiro.Checked = true;
            TxtValor.Text = "";


            BtnReceber.Enabled = true;
            BtnCancelar.Enabled = true;
        }

        private void BtnReceber_Click(object sender, EventArgs e)
        {
            try
            {
                PagamentoNegocio pagamentoNegocio = new PagamentoNegocio();
                Pagamento pagamento = new Pagamento(0, DateTime.Now, "", Convert.ToDouble(TxtValor.Text), pedido);

                if (RbtCheque.Checked)
                {
                    pagamento.Tipo = "Cheque";
                }
                else if (RbtCredito.Checked)
                {
                    pagamento.Tipo = "Crédito";
                }
                else if (RbtDebito.Checked)
                {
                    pagamento.Tipo = "Débito";
                }
                else if (RbtDinheiro.Checked)
                {
                    pagamento.Tipo = "Dinheiro";
                }
                else
                {
                    pagamento.Tipo = "Outro";
                }

                if (inserirpagamento)
                {
                    pagamentoNegocio.Inserir(pagamento);
                    CarregaGridPagamentos();
                }
                else
                {
                    pagamento.Codigo = Convert.ToInt32(DgvPagamento.Rows[DgvPagamento.CurrentRow.Index].Cells[0].Value);
                    pagamentoNegocio.Alterar(pagamento);
                    CarregaGridPagamentos();
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível Gravar o Pagamento!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja Excluir o Pagamento selecionado?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    PagamentoNegocio pagamentoNegocio = new PagamentoNegocio();
                    pagamentoNegocio.Excluir(Convert.ToInt32(DgvPagamento.Rows[DgvPagamento.CurrentRow.Index].Cells[0].Value));
                    MessageBox.Show("Pagamento Excluído com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregaGridPagamentos();
                }
            }
            catch 
            {
                MessageBox.Show("Não foi possível Excluir o Pagamento!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            PnlPagamento.Enabled = false;
            BtnCancelar.Enabled = false;
            RbtDinheiro.Checked = true;
            TxtValor.Text = "";

            BtnInserir.Enabled = true;

            if (DgvPagamento.Rows.Count != 0)
            {
                BtnAlterar.Enabled = true;
                BtnExcluir.Enabled = true;
            }
            else
            {
                BtnAlterar.Enabled = false;
                BtnExcluir.Enabled = false;
            }

        }


        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            BtnInserir.Enabled = false;
            BtnExcluir.Enabled = false;
            PnlPagamento.Enabled = true;
            BtnCancelar.Enabled = true;
        }

        private void DgvPagamento_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvPagamento.Rows.Count != 0)
            {
                if (DgvPagamento.Rows[DgvPagamento.CurrentRow.Index].Cells[3].Value.ToString() == "Cheque")
                {
                    RbtCheque.Checked = true;
                }
                else if (DgvPagamento.Rows[DgvPagamento.CurrentRow.Index].Cells[3].Value.ToString() == "Crédito")
                {
                    RbtCredito.Checked = true;
                }
                else if (DgvPagamento.Rows[DgvPagamento.CurrentRow.Index].Cells[3].Value.ToString() == "Débito")
                {
                    RbtDebito.Checked = true;
                }
                else if (DgvPagamento.Rows[DgvPagamento.CurrentRow.Index].Cells[3].Value.ToString() == "Dinheiro")
                {
                    RbtDinheiro.Checked = true;
                }
                else
                {
                    RbtOutro.Checked = true;
                }

                TxtValor.Text = Convert.ToDouble(DgvPagamento.Rows[DgvPagamento.CurrentRow.Index].Cells[4].Value).ToString("##0.00");
            }
            else
            {
                RbtDinheiro.Checked = true;
                TxtValor.Text = "";
            }

        }

        private void RbtCheque_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnEncerrarMesa_Click(object sender, EventArgs e)
        {
            try
            {
                PedidoNegocio pedidoNegocio = new PedidoNegocio();

                if (MessageBox.Show("Fechamento de Mesa iniciado, deseja continuar?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    pedido.Disponivel = "sim";

                    pedidoNegocio.FecharMesa(pedido);
                    MessageBox.Show("Mesa foi aberta para novos clientes com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Houve um erro ao fazer o fechamento de mesa!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}

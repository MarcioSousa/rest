using Model;
using Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmEstoque : Form
    {
        List<Produto> produtos = new List<Produto>();

        string escolha = "";
        public FrmEstoque()
        {
            InitializeComponent();
            DgvProduto.AutoGenerateColumns = false;
            DgvEstoque.AutoGenerateColumns = false;
        }
        private void CarregaTodosProdutos()
        {
            try
            {
                ProdutoNegocio produtoNegocio = new ProdutoNegocio();

                produtos = produtoNegocio.TodosProduto();

                DgvProduto.DataSource = null;
                DgvProduto.DataSource = produtos;

                DgvProduto.Update();
                DgvProduto.Refresh();

                for (int t = 0; t < produtos.Count; t++)
                {
                    TxtProduto.AutoCompleteCustomSource.Add(produtos[t].Nome);
                }

            }
            catch
            {
                MessageBox.Show("Não foi possível carregar o Formulário de Produtos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void CarregaGridEstoque()
        {
            EstoqueNegocio estoqueNegocio = new EstoqueNegocio();
            List<Estoque> estoques = new List<Estoque>();

            estoques = estoqueNegocio.TodosEstoque();
            DgvEstoque.DataSource = null;
            DgvEstoque.Rows.Clear();

            for (int t = 0; t < estoques.Count; t++)
            {
                DgvEstoque.Rows.Add(estoques[t].Codigo, estoques[t].Produto.Codigo, estoques[t].Produto.Nome, estoques[t].Dataentrada, estoques[t].Datavencimento, estoques[t].Valortotal, estoques[t].Qtde);
            }

            DgvEstoque.Update();
            DgvEstoque.Refresh();

            AtualizaQtdeEstoqueProduto();
        }
        private void AtualizaQtdeEstoqueProduto()
        {
            for (int t = 0; t < DgvProduto.Rows.Count; t++)
            {
                ItemPedidoNegocio itemPedidoNegocio = new ItemPedidoNegocio();
                EstoqueNegocio estoqueNegocio = new EstoqueNegocio();

                int qtdesaida = itemPedidoNegocio.QtdeSaida(Convert.ToInt32(DgvProduto.Rows[t].Cells[0].Value));
                int qtdeentrada = estoqueNegocio.QtdeEntrada(Convert.ToInt32(DgvProduto.Rows[t].Cells[0].Value));

                if (qtdeentrada != 0)
                {
                    DgvProduto.Rows[t].Cells[3].Value = qtdeentrada - qtdesaida;
                }
                else
                {
                    DgvProduto.Rows[t].Cells[3].Value = "-";

                }
            }
        }
        private void CarregaGridEstoqueFiltro()
        {
            EstoqueNegocio estoqueNegocio = new EstoqueNegocio();
            List<Estoque> estoques = new List<Estoque>();

            estoques = estoqueNegocio.EstoquesProduto(Convert.ToInt32(DgvProduto.Rows[DgvProduto.CurrentRow.Index].Cells[0].Value));
            DgvEstoque.DataSource = null;
            DgvEstoque.Rows.Clear();

            if (estoques.Count() != 0)
            {
                for (int t = 0; t < estoques.Count; t++)
                {
                    DgvEstoque.Rows.Add(estoques[t].Codigo, estoques[t].Produto.Codigo, estoques[t].Produto.Nome, estoques[t].Dataentrada, estoques[t].Datavencimento, estoques[t].Valortotal, estoques[t].Qtde);
                }
            }
            else
            {
                LimpaCampos();
            }
        }
        private void CarregaCampos()
        {
            if (DgvEstoque.Rows.Count != 0)
            {
                TxtCodProd.Text = DgvEstoque.Rows[DgvEstoque.CurrentRow.Index].Cells[1].Value.ToString();
                TxtProduto.Text = DgvEstoque.Rows[DgvEstoque.CurrentRow.Index].Cells[2].Value.ToString();
                DtpEntrada.Value = Convert.ToDateTime(DgvEstoque.Rows[DgvEstoque.CurrentRow.Index].Cells[3].Value);
                DtpVencimento.Value = Convert.ToDateTime(DgvEstoque.Rows[DgvEstoque.CurrentRow.Index].Cells[4].Value);
                TxtValor.Text = Convert.ToDouble(DgvEstoque.Rows[DgvEstoque.CurrentRow.Index].Cells[5].Value).ToString("##0.00");
                TxtQtde.Text = DgvEstoque.Rows[DgvEstoque.CurrentRow.Index].Cells[6].Value.ToString();

                BtnEditar.Visible = true;
                BtnExcluir.Visible = true;
                TxtPesquisa.Visible = true;
            }
            else
            {
                BtnEditar.Enabled = false;
                BtnExcluir.Enabled = false;
                TxtPesquisa.Visible = false;

                LimpaCampos();
            }
        }
        private void AbreTudo()
        {
            DgvEstoque.Enabled = false;
            PnlProduto.Enabled = false;

            BtnAdicionar.Enabled = false;
            BtnEditar.Enabled = false;
            BtnExcluir.Enabled = false;

            BtnConfirmar.Enabled = true;
            BtnCancelar.Enabled = true;
            DtpEntrada.Enabled = true;
            DtpVencimento.Enabled = true;

            TxtCodProd.ReadOnly = false;
            TxtProduto.ReadOnly = false;
            TxtValor.ReadOnly = false;
            TxtQtde.ReadOnly = false;

            TxtPesquisa.Enabled = false;

            if (escolha == "A")
            {
                LimpaCampos();
            }

            TxtCodProd.Focus();
        }
        private void LimpaCampos()
        {
            TxtCodProd.Text = "";
            TxtProduto.Text = "";
            DtpEntrada.Value = DateTime.Today.Date;
            DtpVencimento.Value = DateTime.Today.Date;
            TxtValor.Text = "";
            TxtQtde.Text = "";
            TxtValorUnid.Text = "";
        }
        private void FechaTudo()
        {
            DgvEstoque.Enabled = true;
            PnlProduto.Enabled = true;

            BtnAdicionar.Enabled = true;
            BtnEditar.Enabled = true;
            BtnExcluir.Enabled = true;

            BtnConfirmar.Enabled = false;
            BtnCancelar.Enabled = false;
            DtpEntrada.Enabled = false;
            DtpVencimento.Enabled = false;

            TxtCodProd.ReadOnly = true;
            TxtProduto.ReadOnly = true;
            TxtValor.ReadOnly = true;
            TxtQtde.ReadOnly = true;

            DgvEstoque.ReadOnly = true;
            TxtPesquisa.Enabled = true;

            CarregaGridEstoque();

            BtnAdicionar.Focus();
        }
        private void CarregarNomeProduto()
        {
            bool passou = false;

            for (int t = 0; t < produtos.Count; t++)
            {
                if (produtos[t].Codigo.ToString() == TxtCodProd.Text)
                {
                    TxtProduto.Text = produtos[t].Nome;
                    passou = true;
                    break;
                }
            }

            if (passou == false)
            {
                TxtProduto.Text = "";
            }
        }
        private void CarregarCodigoProduto()
        {
            bool passou = false;

            for (int t = 0; t < produtos.Count; t++)
            {
                if (produtos[t].Nome == TxtProduto.Text)
                {
                    TxtCodProd.Text = produtos[t].Codigo.ToString();
                    passou = true;
                    break;
                }
            }

            if (passou == false)
            {
                TxtCodProd.Text = "";
            }
        }
        private double CalcularValorUnidade()
        {
            if (TxtValor.Text != "" && TxtQtde.Text != "")
            {
                return Convert.ToDouble(TxtValor.Text) / Convert.ToInt32(TxtQtde.Text);
            }
            return 0;
        }
        private void CarregaEntradaVencimento()
        {
            EstoqueNegocio estoqueNegocio = new EstoqueNegocio();
            List<Estoque> estoques = new List<Estoque>();

            DgvEstoque.DataSource = null;
            DgvEstoque.Rows.Clear();

            if (CbxEntrada.Checked)
            {
                estoques = estoqueNegocio.PesquisaEstoqueEntradaVencimento(true, false, Convert.ToInt32(NudMes.Value), Convert.ToInt32(NudAno.Value));
                if (estoques.Count != 0)
                {
                    for (int t = 0; t < estoques.Count; t++)
                    {
                        DgvEstoque.Rows.Add(estoques[t].Codigo, estoques[t].Produto.Codigo, estoques[t].Produto.Nome, estoques[t].Dataentrada, estoques[t].Datavencimento, estoques[t].Valortotal, estoques[t].Qtde);
                    }
                }
                else
                {
                    LimpaCampos();
                }

            }
            else if (CbxVencimento.Checked)
            {
                estoques = estoqueNegocio.PesquisaEstoqueEntradaVencimento(false, true, Convert.ToInt32(NudMes.Value), Convert.ToInt32(NudAno.Value));
                if (estoques.Count != 0)
                {
                    for (int t = 0; t < estoques.Count; t++)
                    {
                        DgvEstoque.Rows.Add(estoques[t].Codigo, estoques[t].Produto.Codigo, estoques[t].Produto.Nome, estoques[t].Dataentrada, estoques[t].Datavencimento, estoques[t].Valortotal, estoques[t].Qtde);
                    }
                }
                else
                {
                    LimpaCampos();
                }


            }
            else
            {
                CarregaGridEstoque();
            }
        }

        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            CarregaTodosProdutos();
            CbxProdutos.Checked = true;

            NudMes.Value = DateTime.Today.Date.Month;
            NudAno.Value = DateTime.Today.Date.Year;
        }
        private void DgvProduto_SelectionChanged(object sender, EventArgs e)
        {
            if (CbxProdutos.Checked)
            {
                CarregaGridEstoqueFiltro();
            }
            else
            {
                CarregaGridEstoque();
            }
        }
        private void CbxProdutos_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxProdutos.Checked)
            {
                CarregaGridEstoqueFiltro();
            }
            else
            {
                CarregaGridEstoque();
            }
        }
        private void BtnProduto_Click(object sender, EventArgs e)
        {
            FrmProduto frmProduto = new FrmProduto();
            frmProduto.ShowDialog();

            CarregaTodosProdutos();
        }
        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CbxEntrada.Checked = false;
                CbxVencimento.Checked = false;
                if (TxtPesquisa.Text != "")
                {
                    ProdutoNegocio produtoNegocio = new ProdutoNegocio();
                    if (decimal.TryParse(TxtPesquisa.Text, out decimal numero))
                    {
                        DgvProduto.DataSource = produtoNegocio.ProcurarPorCodigoOuNome(Convert.ToInt32(TxtPesquisa.Text), "");
                    }
                    else
                    {
                        DgvProduto.DataSource = produtoNegocio.ProcurarPorCodigoOuNome(0, TxtPesquisa.Text);
                    }

                    DgvProduto.Update();
                    DgvProduto.Refresh();

                    if(DgvProduto.Rows.Count == 0 || DgvEstoque.Rows.Count == 0)
                    {
                        DgvEstoque.DataSource = null;
                        DgvEstoque.Rows.Clear();

                        BtnEditar.Enabled = false;
                        BtnExcluir.Enabled = false;

                        LimpaCampos();
                    }
                    else
                    {
                        BtnEditar.Enabled = true;
                        BtnExcluir.Enabled = true;
                    }
                }
                else
                {
                    CarregaTodosProdutos();
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível pesquisar o produto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            AtualizaQtdeEstoqueProduto();
        }
        private void CbxEntrada_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxEntrada.Checked)
            {
                CbxVencimento.Checked = false;

                EstoqueNegocio estoqueNegocio = new EstoqueNegocio();
                List<Estoque> estoques = estoqueNegocio.PesquisaEstoqueEntradaVencimento(true, false, Convert.ToInt32(NudMes.Value), Convert.ToInt32(NudAno.Value));

                DgvEstoque.DataSource = null;
                DgvEstoque.Rows.Clear();

                for (int t = 0; t < estoques.Count; t++)
                {
                    DgvEstoque.Rows.Add(estoques[t].Codigo, estoques[t].Produto.Codigo, estoques[t].Produto.Nome, estoques[t].Dataentrada, estoques[t].Datavencimento, estoques[t].Valortotal, estoques[t].Qtde);
                }

                DgvEstoque.Update();
                DgvEstoque.Refresh();
            }
            else if (!CbxVencimento.Checked)
            {
                CarregaGridEstoque();
            }
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
                if (MessageBox.Show("Deseja realmente excluir o Estoque Selecionado?", "Exclusão", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    EstoqueNegocio estoqueNegocio = new EstoqueNegocio();

                    int valor = Convert.ToInt32(estoqueNegocio.Excluir(Convert.ToInt32(DgvEstoque.Rows[DgvEstoque.CurrentRow.Index].Cells[0].Value)));
                    MessageBox.Show("Estoque Excluído com Sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CarregaGridEstoque();
                }
                else
                {
                    MessageBox.Show("Exclusão não Finalizada!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível Excluir o Estoque Selecionado.");
            }
        }
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                double valor = Convert.ToDouble(TxtValor.Text);

                try
                {
                    if (TxtCodProd.Text != "" && TxtProduto.Text != "" && TxtValor.Text != "" && TxtQtde.Text != "")
                    {
                        EstoqueNegocio estoqueNegocio = new EstoqueNegocio();
                        ProdutoNegocio produtoNegocio = new ProdutoNegocio();

                        Estoque estoque = new Estoque(0, DtpEntrada.Value, DtpVencimento.Value, Convert.ToDouble(TxtValor.Text), Convert.ToInt32(TxtQtde.Text), produtoNegocio.ProdutoEstoque(Convert.ToInt32(TxtCodProd.Text)));

                        if (escolha == "A")
                        {
                            if (estoqueNegocio.Inserir(estoque) != "0")
                            {
                                MessageBox.Show("Não foi possível inserir.\nVerifique se já existe um código para esse produto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                TxtCodProd.Focus();
                                return;
                            }
                        }
                        else
                        {
                            estoque.Codigo = Convert.ToInt32(DgvEstoque.Rows[DgvEstoque.CurrentRow.Index].Cells[0].Value);

                            if (estoqueNegocio.Alterar(estoque) != "0")
                            {
                                MessageBox.Show("Não foi possível alterar o produto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                TxtCodProd.Focus();
                                return;
                            }

                        }
                        escolha = "";
                        FechaTudo();
                    }
                    else
                    {
                        MessageBox.Show("Digite o Código do Produto, o Nome do produto, o Valor do produto e a Qtde de produto estocado!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        if (TxtCodProd.Text == "")
                        {
                            TxtCodProd.Focus();
                        }
                        else if (TxtProduto.Text == "")
                        {
                            TxtProduto.Focus();
                        }
                        else if (TxtValor.Text == "")
                        {
                            TxtValor.Focus();
                        }
                        else if (TxtQtde.Text == "")
                        {
                            TxtQtde.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    TxtValor.Text = "";
                    MessageBox.Show("Não foi possível finalizar o cadastro. Aviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível finalizar o cadastro, verifique os campos 'Valor' e 'Qtde'. Aviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        private void TxtCodProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }
        private void TxtQtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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
        private void TxtCodProd_TextChanged(object sender, EventArgs e)
        {
            if (TxtCodProd.Focused)
            {
                CarregarNomeProduto();
            }
        }
        private void TxtProduto_TextChanged(object sender, EventArgs e)
        {
            if (TxtProduto.Focused)
            {
                CarregarCodigoProduto();
            }
        }
        private void DgvEstoque_SelectionChanged(object sender, EventArgs e)
        {
            CarregaCampos();
        }
        private void CbxVencimento_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxVencimento.Checked)
            {
                CbxEntrada.Checked = false;

                EstoqueNegocio estoqueNegocio = new EstoqueNegocio();
                List<Estoque> estoques = estoqueNegocio.PesquisaEstoqueEntradaVencimento(false, true, Convert.ToInt32(NudMes.Value), Convert.ToInt32(NudAno.Value));

                DgvEstoque.DataSource = null;
                DgvEstoque.Rows.Clear();

                for (int t = 0; t < estoques.Count; t++)
                {
                    DgvEstoque.Rows.Add(estoques[t].Codigo, estoques[t].Produto.Codigo, estoques[t].Produto.Nome, estoques[t].Dataentrada, estoques[t].Datavencimento, estoques[t].Valortotal, estoques[t].Qtde);
                }

                DgvEstoque.Update();
                DgvEstoque.Refresh();
            }else if (!CbxEntrada.Checked)
            {
                CarregaGridEstoque();
            }
        }
        private void TxtQtde_TextChanged(object sender, EventArgs e)
        {
            TxtValorUnid.Text = CalcularValorUnidade().ToString("##0.00");
        }
        private void TxtValor_TextChanged(object sender, EventArgs e)
        {
            CalcularValorUnidade();
        }
        private void NudMes_ValueChanged(object sender, EventArgs e)
        {
            CarregaEntradaVencimento();
        }
        private void NudAno_ValueChanged(object sender, EventArgs e)
        {
            CarregaEntradaVencimento();
        }
    }
}


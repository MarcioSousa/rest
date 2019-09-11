using Model;
using Negocios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmProduto : Form
    {
        string escolha = "";

        public FrmProduto()
        {
            InitializeComponent();
            DgvProduto.AutoGenerateColumns = false;
        }
        private void CarregaGrid()
        {
            ProdutoNegocio produtoNegocio = new ProdutoNegocio();
            List<Produto> produtos = new List<Produto>();

            produtos = produtoNegocio.TodosProduto();

            DgvProduto.DataSource = null;
            DgvProduto.DataSource = produtos;

            TxtPesquisa.Text = "";

            DgvProduto.Update();
            DgvProduto.Refresh();
        }
        private void CarregaCampos()
        {
            if (DgvProduto.Rows.Count != 0)
            {
                TxtCodigo.Text = DgvProduto.Rows[DgvProduto.CurrentRow.Index].Cells[0].Value.ToString();
                TxtNome.Text = DgvProduto.Rows[DgvProduto.CurrentRow.Index].Cells[1].Value.ToString();
                TxtValor.Text = Convert.ToDouble(DgvProduto.Rows[DgvProduto.CurrentRow.Index].Cells[2].Value).ToString("##0.00");
                BtnEditar.Visible = true;
                BtnExcluir.Visible = true;
                TxtPesquisa.Visible = true;
            }
            else
            {
                BtnEditar.Enabled = false;
                BtnExcluir.Enabled = false;
                TxtPesquisa.Visible = false;
                TxtCodigo.Text = "";
                TxtNome.Text = "";
                TxtValor.Text = "";
            }
        }
        private void AbreTudo()
        {
            DgvProduto.Enabled = false;
            BtnAdicionar.Enabled = false;
            BtnEditar.Enabled = false;
            BtnExcluir.Enabled = false;

            BtnConfirmar.Enabled = true;
            BtnCancelar.Enabled = true;

            TxtCodigo.ReadOnly = false;
            TxtNome.ReadOnly = false;
            TxtValor.ReadOnly = false;
            TxtPesquisa.Enabled = false;

            if (escolha == "A")
            {
                TxtCodigo.Text = "";
                TxtNome.Text = "";
                TxtValor.Text = "";
            }

            TxtCodigo.Focus();
        }
        private void FechaTudo()
        {
            DgvProduto.Enabled = true;
            BtnAdicionar.Enabled = true;
            BtnEditar.Enabled = true;
            BtnExcluir.Enabled = true;

            BtnConfirmar.Enabled = false;
            BtnCancelar.Enabled = false;

            TxtCodigo.ReadOnly = true;
            TxtNome.ReadOnly = true;
            TxtValor.ReadOnly = true;

            DgvProduto.ReadOnly = true;
            TxtPesquisa.Enabled = true;


            CarregaGrid();

            BtnAdicionar.Focus();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }
        private void DgvProduto_SelectionChanged(object sender, EventArgs e)
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
                if (MessageBox.Show("Deseja realmente excluir o Produto Selecionado?", "Exclusão", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    ProdutoNegocio produtoNegocio = new ProdutoNegocio();

                    int valor = Convert.ToInt32(produtoNegocio.Excluir(Convert.ToInt32(TxtCodigo.Text)));
                    MessageBox.Show("Produto Excluído com Sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CarregaGrid();
                }
                else
                {
                    MessageBox.Show("Exclusão não Finalizada!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível Excluir o Produto Selecionado.");
            }
        }
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                double valor = Convert.ToDouble(TxtValor.Text);

                try
                {
                    if (TxtCodigo.Text != "" && TxtNome.Text != "" && TxtValor.Text != "")
                    {
                        ProdutoNegocio produtoNegocio = new ProdutoNegocio();
                        Produto produto = new Produto(Convert.ToInt32(TxtCodigo.Text), TxtNome.Text.Trim(), Convert.ToDouble(TxtValor.Text));

                        if (escolha == "A")
                        {
                            if (produtoNegocio.Inserir(produto) != "0")
                            {
                                MessageBox.Show("Não foi possível inserir.\nVerifique se já existe um código para esse produto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                TxtCodigo.Focus();
                                return;
                            }
                        }
                        else
                        {
                            produto.Codigo = Convert.ToInt32(TxtCodigo.Text);

                            if (produtoNegocio.Alterar(produto, Convert.ToInt32(DgvProduto.Rows[DgvProduto.CurrentRow.Index].Cells[0].Value)) != "0")
                            {
                                MessageBox.Show("Não foi possível alterar o produto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                TxtCodigo.Focus();
                                return;
                            }

                        }
                        escolha = "";
                        FechaTudo();
                    }
                    else
                    {
                        MessageBox.Show("Digite o Nome do produto e o Valor do produto!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
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
        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TxtPesquisa.Text != "")
                {
                    if (decimal.TryParse(TxtPesquisa.Text, out decimal numero))
                    {
                        ProdutoNegocio produtoNegocio = new ProdutoNegocio();
                        DgvProduto.DataSource = produtoNegocio.ProcurarPorCodigoOuNome(Convert.ToInt32(TxtPesquisa.Text), "");
                    }
                    else
                    {
                        ProdutoNegocio produtoNegocio = new ProdutoNegocio();
                        DgvProduto.DataSource = produtoNegocio.ProcurarPorCodigoOuNome(0, TxtPesquisa.Text);
                    }

                    DgvProduto.Update();
                    DgvProduto.Refresh();

                    if (DgvProduto.Rows.Count != 0)
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
                MessageBox.Show("Não foi possível pesquisar o produto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }
    }
}


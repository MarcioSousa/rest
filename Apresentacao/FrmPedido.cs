using Model;
using Negocios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmPedido : Form
    {
        List<Produto> produtos = new List<Produto>();
        Pedido pedidoAvancado;
        bool imprimenovopedido = false;
        bool imprimeconta = false;

        public FrmPedido(Pedido pedido)
        {
            InitializeComponent();
            DgvPedido.AutoGenerateColumns = false;
            this.pedidoAvancado = pedido;
            LblCodigoPedido.Text = pedido.Codigo.ToString();
            LblDataHoraPedido.Text = pedido.Datahorapedido.ToShortDateString();
            LblCodigoGarcon.Text = pedido.Garcon.Codigo.ToString();
            BtnOcupaMesa.Enabled = false;
            BtnDeletarMesa.Enabled = false;
            BtnGarcon.Enabled = false;
            PnlProduto.Enabled = false;
            BtnGravarImprimir.Enabled = false;
            BtnImprimeConta.Enabled = true;
            BtnImprimePedido.Enabled = true;
            BtnPagamento.Enabled = true;
            CarregarGridAvancado();
        }
        public FrmPedido(int codmesa, string mesa)
        {
            InitializeComponent();
            DgvPedido.AutoGenerateColumns = false;
            txtCodMesa.Text = codmesa.ToString();
            TxtCodProduto.Focus();

            if (mesa == "ocupado")
            {
                CarregarnoInicio(codmesa);
                BtnOcupaMesa.Enabled = false;
                BtnGarcon.Enabled = false;
                BtnDeletarMesa.Enabled = true;
                BtnAdicionarPedido.Enabled = true;
            }
        }
        private void CarregarGridAvancado()
        {
            try
            {
                BtnRemoverPedido.Enabled = false;

                ItemPedidoNegocio itemPedidoNegocio = new ItemPedidoNegocio();
                GarconNegocio garconNegocio = new GarconNegocio();
                List<Itempedido> itempedidos = new List<Itempedido>();

                itempedidos = itemPedidoNegocio.itempedidos(pedidoAvancado);

                DgvPedido.Rows.Clear();

                for (int t = 0; t < itempedidos.Count; t++)
                {
                    DgvPedido.Rows.Add(itempedidos[t].Qtde, itempedidos[t].Codigo, itempedidos[t].Produto.Codigo, itempedidos[t].Produto.Nome, itempedidos[t].Valorunid, itempedidos[t].Qtde * itempedidos[t].Valorunid);
                }

                if(DgvPedido.Rows.Count != 0)
                {
                    BtnRemoverPedido.Enabled = true;
                }
                else
                {
                    BtnRemoverPedido.Enabled = false;
                }

                TxtCodProduto.Text = "";
                TxtNomeProduto.Text = "";
                TxtQtde.Text = "";
                CalcularTotalMesa();
            }
            catch
            {
                MessageBox.Show("Erro");
            }
        }
        private void CarregarnoInicio(int mesa)
        {
            PedidoNegocio pedidoNegocio = new PedidoNegocio();
            List<Pedido> pedidos = new List<Pedido>();

            pedidos = pedidoNegocio.PedidosMesa(mesa);

            if (pedidos.Count != 0)
            {
                LblCodigoPedido.Text = pedidos[0].Codigo.ToString();
                LblCodigoGarcon.Text = pedidos[0].Garcon.Codigo.ToString();
                LblDataHoraPedido.Text = pedidos[0].Datahorapedido.ToString("dd/MM/yyyy HH:mm:ss");

                AtualizarGrid();
            }
        }
        private void AtualizarGrid()
        {
            try
            {
                BtnRemoverPedido.Enabled = false;

                ItemPedidoNegocio itemPedidoNegocio = new ItemPedidoNegocio();
                GarconNegocio garconNegocio = new GarconNegocio();
                List<Itempedido> itempedidos = new List<Itempedido>();

                Pedido pedido = new Pedido(Convert.ToInt32(LblCodigoPedido.Text), Convert.ToDateTime(LblDataHoraPedido.Text), Convert.ToInt32(txtCodMesa.Text), "nao", garconNegocio.ProcurarPorCodigo(Convert.ToInt32(LblCodigoGarcon.Text)));

                itempedidos = itemPedidoNegocio.itempedidos(pedido);

                DgvPedido.Rows.Clear();

                for (int t = 0; t < itempedidos.Count; t++)
                {
                    DgvPedido.Rows.Add(itempedidos[t].Qtde, itempedidos[t].Codigo, itempedidos[t].Produto.Codigo, itempedidos[t].Produto.Nome, itempedidos[t].Valorunid, itempedidos[t].Qtde * itempedidos[t].Valorunid);
                }

                if (itempedidos.Count != 0)
                {
                    BtnRemoverPedido.Enabled = true;
                    BtnImprimeConta.Enabled = true;
                    BtnImprimePedido.Enabled = true;
                    BtnPagamento.Enabled = true;
                }
                else
                {
                    BtnRemoverPedido.Enabled = false;
                    BtnImprimeConta.Enabled = false;
                    BtnImprimePedido.Enabled = false;
                    BtnPagamento.Enabled = false;
                }

                TxtCodProduto.Enabled = true;
                TxtNomeProduto.Enabled = true;
                TxtQtde.Enabled = true;

                TxtCodProduto.Text = "";
                TxtNomeProduto.Text = "";
                TxtQtde.Text = "";
                CalcularTotalMesa();
                TxtCodProduto.Focus();
            }
            catch
            {
                MessageBox.Show("Erro");
            }
        }
        private void CarregaTodosProdutos()
        {
            try
            {
                ProdutoNegocio produtoNegocio = new ProdutoNegocio();

                produtos = produtoNegocio.TodosProduto();

                for (int t = 0; t < produtos.Count; t++)
                {
                    TxtNomeProduto.AutoCompleteCustomSource.Add(produtos[t].Nome);
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível carregar o Formulário de Produtos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void CarregarNomeProduto()
        {
            bool passou = false;

            for (int t = 0; t < produtos.Count; t++)
            {
                if (produtos[t].Codigo.ToString() == TxtCodProduto.Text)
                {
                    TxtNomeProduto.Text = produtos[t].Nome;
                    passou = true;
                    break;
                }
            }

            if (passou == false)
            {
                TxtNomeProduto.Text = "";
            }
        }
        private void CarregarCodigoProduto()
        {
            bool passou = false;

            for (int t = 0; t < produtos.Count; t++)
            {
                if (produtos[t].Nome == TxtNomeProduto.Text)
                {
                    TxtCodProduto.Text = produtos[t].Codigo.ToString();
                    passou = true;
                    break;
                }
            }

            if (passou == false)
            {
                TxtCodProduto.Text = "";
            }
        }


        private void BtnOcupaMesa_Click(object sender, EventArgs e)
        {
            try
            {
                if (LblCodigoGarcon.Text != "0")
                {
                    PedidoNegocio pedidoNegocio = new PedidoNegocio();
                    GarconNegocio garconNegocio = new GarconNegocio();

                    Pedido pedido = new Pedido(0, DateTime.Now, Convert.ToInt32(txtCodMesa.Text), "nao", garconNegocio.ProcurarPorCodigo(Convert.ToInt32(LblCodigoGarcon.Text)));

                    pedido.Codigo = Convert.ToInt32(pedidoNegocio.Inserir(pedido));

                    LblCodigoPedido.Text = pedido.Codigo.ToString();
                    LblDataHoraPedido.Text = pedido.Datahorapedido.ToString();

                    BtnOcupaMesa.Enabled = false;
                    BtnGarcon.Enabled = false;
                    TxtCodProduto.Enabled = true;
                    TxtNomeProduto.Enabled = true;
                    TxtQtde.Enabled = true;
                    BtnDeletarMesa.Enabled = true;
                    BtnAdicionarPedido.Enabled = true;

                    TxtCodProduto.Focus();
                }
                else
                {
                    MessageBox.Show("Cadastre Primeiro o Garçon que estará atendendo a mesa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível ocupar a mesa!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BtnGarcon_Click(object sender, EventArgs e)
        {
            FrmGarcon frmGarcon = new FrmGarcon();
            frmGarcon.codigogarcon = 0;
            frmGarcon.ShowDialog();
            LblCodigoGarcon.Text = Convert.ToString(frmGarcon.codigogarcon);
        }
        private void FrmPedido_Load(object sender, EventArgs e)
        {
            CarregaTodosProdutos();
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
        private void TxtCodProduto_KeyPress(object sender, KeyPressEventArgs e)
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
        private void TxtCodProduto_TextChanged(object sender, EventArgs e)
        {
            if (TxtCodProduto.Focused)
            {
                CarregarNomeProduto();
            }
        }
        private void TxtNomeProduto_TextChanged(object sender, EventArgs e)
        {
            if (TxtNomeProduto.Focused)
            {
                CarregarCodigoProduto();
            }
        }
        private void BtnAdicionarPedido_Click(object sender, EventArgs e)
        {
            if (TxtCodProduto.Text != "" && TxtNomeProduto.Text != "" && TxtQtde.Text != "")
            {
                for (int t = 0; t < produtos.Count; t++)
                {
                    if (produtos[t].Codigo == Convert.ToInt32(TxtCodProduto.Text))
                    {
                        DgvPedido.Rows.Add(TxtQtde.Text, "", TxtCodProduto.Text, TxtNomeProduto.Text, produtos[t].Valor, produtos[t].Valor * Convert.ToInt32(TxtQtde.Text));

                        TxtCodProduto.Text = "";
                        TxtNomeProduto.Text = "";
                        TxtQtde.Text = "";
                        TxtCodProduto.Focus();
                        BtnRemoverPedido.Enabled = true;
                        BtnImprimePedido.Enabled = true;
                        BtnImprimeConta.Enabled = true;
                        BtnGravarImprimir.Enabled = true;
                        CalcularTotalMesa();
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos Código, Nome do produto e a quantidade de produto pedido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCodProduto.Focus();
            }
        }
        private void BtnDeletarMesa_Click(object sender, EventArgs e)
        {
            if (DgvPedido.Rows.Count == 0)
            {
                if (MessageBox.Show("Deseja realmente Deletar o pedido da mesa?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    PedidoNegocio pedidoNegocio = new PedidoNegocio();

                    pedidoNegocio.Excluir(Convert.ToInt32(LblCodigoPedido.Text));
                    MessageBox.Show("Mesa deletado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Para dar continuidade, delete primeiro todos os pedidos feitos na mesa clicando no botão 'Remover Pedido'!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BtnRemoverPedido_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o pedido selecionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (DgvPedido.Rows[DgvPedido.CurrentRow.Index].Cells[1].Value.ToString() != "")
                {
                    ItemPedidoNegocio itemPedidoNegocio = new ItemPedidoNegocio();
                    itemPedidoNegocio.Excluir(Convert.ToInt32(DgvPedido.Rows[DgvPedido.CurrentRow.Index].Cells[1].Value));
                }

                DgvPedido.Rows.RemoveAt(DgvPedido.CurrentRow.Index);

                if (DgvPedido.Rows.Count == 0)
                {
                    BtnRemoverPedido.Enabled = false;
                    BtnImprimeConta.Enabled = false;
                    BtnImprimePedido.Enabled = false;
                    BtnGravarImprimir.Enabled = false;
                }

                MessageBox.Show("Excluido com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CalcularTotalMesa();
            }

        }

        private void BtnGravarImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                ItemPedidoNegocio itemPedidoNegocio = new ItemPedidoNegocio();
                ProdutoNegocio produtoNegocio = new ProdutoNegocio();
                PedidoNegocio pedidoNegocio = new PedidoNegocio();

                imprimenovopedido = true;

                for (int t = 0; t < DgvPedido.Rows.Count; t++)
                {
                    if (DgvPedido.Rows[t].Cells[1].Value.ToString() == "")
                    {
                        Itempedido itempedido = new Itempedido(0, Convert.ToInt32(DgvPedido.Rows[t].Cells[0].Value), Convert.ToDouble(DgvPedido.Rows[t].Cells[4].Value), produtoNegocio.ProdutoItemPedido(Convert.ToInt32(DgvPedido.Rows[t].Cells[2].Value)), pedidoNegocio.PedidoItemPedido(Convert.ToInt32(LblCodigoPedido.Text)));
                        itemPedidoNegocio.Inserir(itempedido);
                    }
                }

                ImprimirNovoPedido();
                AtualizarGrid();

                BtnGravarImprimir.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Não foi possível Salvar e imprimir o pedido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            imprimenovopedido = false;

        }

        private void PdImprimirDocumento_PrintPage(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Font titleFont = new System.Drawing.Font("Consolas", 10f, FontStyle.Bold);
            System.Drawing.Font pdvFont = new System.Drawing.Font("Consolas", 7f, FontStyle.Regular);
            System.Drawing.Font obsFont = new System.Drawing.Font("Consolas", 7f, FontStyle.Regular);

            SizeF size = new SizeF();
            float currentUsedHeight = 0f;

            e.Graphics.DrawString(" CodPed: " + LblCodigoPedido.Text, titleFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Usuario 2" + "Linha 2", titleFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString(" Pedido Mesa " + txtCodMesa.Text + "  | G. " + LblCodigoGarcon.Text, titleFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Usuario 2" + "Linha 2", titleFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("----------------------------------------", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("Qt|  Produto", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Topo", pdvFont);
            currentUsedHeight += size.Height;

            e.Graphics.DrawString("----------------------------------------", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            for (int t = 0; t < DgvPedido.Rows.Count; t++)
            {
                if (imprimeconta)
                {
                    string nomeproduto = DgvPedido.Rows[t].Cells[3].Value.ToString();

                    //COMPLETAR COM CARACTERES EM BRANCO; TOTAL: 30 CARACTERES PARA PODER IMPRIMIR
                    for (int l = nomeproduto.Length; l < 30; l++)
                    {
                        nomeproduto = nomeproduto + " ";
                    }

                    e.Graphics.DrawString(DgvPedido.Rows[t].Cells[0].Value.ToString() + " " + nomeproduto + Convert.ToDouble(DgvPedido.Rows[t].Cells[5].Value).ToString("##0.00"), pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
                    size = e.Graphics.MeasureString("Pedidos", pdvFont);
                    currentUsedHeight += size.Height;
                }
                else
                {
                    if (imprimenovopedido)
                    {
                        if (DgvPedido.Rows[t].Cells[1].Value.ToString() == "")
                        {
                            e.Graphics.DrawString(" " + DgvPedido.Rows[t].Cells[0].Value.ToString() + " " + DgvPedido.Rows[t].Cells[3].Value.ToString(), pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
                            size = e.Graphics.MeasureString("Pedidos", pdvFont);
                            currentUsedHeight += size.Height;
                        }
                    }
                    else
                    {
                        e.Graphics.DrawString(" " + DgvPedido.Rows[t].Cells[0].Value.ToString() + " " + DgvPedido.Rows[t].Cells[3].Value.ToString(), pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
                        size = e.Graphics.MeasureString("Pedidos", pdvFont);
                        currentUsedHeight += size.Height;
                    }
                }
            }

            e.Graphics.DrawString("----------------------------------------", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Pontos", pdvFont);
            currentUsedHeight += size.Height;

            if (imprimeconta)
            {
                e.Graphics.DrawString("                  TOTAL: " + TxtTotalMesa.Text, pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
                size = e.Graphics.MeasureString("Data", pdvFont);
                currentUsedHeight += size.Height;

                e.Graphics.DrawString("----------------------------------------", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
                size = e.Graphics.MeasureString("Pontos", pdvFont);
                currentUsedHeight += size.Height;
            }

            e.Graphics.DrawString("                    " + DateTime.Now, pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = e.Graphics.MeasureString("Data", pdvFont);
            currentUsedHeight += size.Height;
        }

        private void ImprimirNovoPedido()
        {
            try
            {
                PdImprimirDocumento.DocumentName = "Comanda";

                if (!PdImprimirDocumento.PrinterSettings.IsValid)
                    throw new Exception("Não foi possível localizar a impressora");

                PdImprimirDocumento.PrintPage += new PrintPageEventHandler(PdImprimirDocumento_PrintPage);

                PdImprimirDocumento.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível Imprimir no Balcão. Mensagem: " + ex.Message, "Falha Impressão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnImprimePedido_Click(object sender, EventArgs e)
        {
            ImprimirNovoPedido();
        }

        private void CalcularTotalMesa()
        {
            PagamentoNegocio pagamentoNegocio = new PagamentoNegocio();
            Garcon garcon = new Garcon(Convert.ToInt32(LblCodigoGarcon.Text), "");
            Pedido pedido = new Pedido(Convert.ToInt32(LblCodigoPedido.Text), DateTime.Now, 0, "", garcon);
            List<Pagamento> pagamentos = new List<Pagamento>();

            double TotalMes = 0;
            double TotalPago = 0;

            for (int t = 0; t < DgvPedido.Rows.Count; t++)
            {
                TotalMes += Convert.ToDouble(DgvPedido.Rows[t].Cells[5].Value);
            }

            pagamentos = pagamentoNegocio.PagamentosPedido(pedido);

            for(int t = 0; t < pagamentos.Count; t++)
            {
                TotalPago += pagamentos[t].Valor;
            }

            TxtTotalMesa.Text = TotalMes.ToString("C");
            TxtTotalPago.Text = TotalPago.ToString("C");
        }

        private void BtnImprimeConta_Click(object sender, EventArgs e)
        {
            imprimeconta = true;
            ImprimirNovoPedido();
            imprimeconta = false;
        }

        private void BtnPagamento_Click(object sender, EventArgs e)
        {
            GarconNegocio garconNegocio = new GarconNegocio();
            ItemPedidoNegocio itemPedidoNegocio = new ItemPedidoNegocio();
            Pedido pedido = new Pedido(Convert.ToInt32(LblCodigoPedido.Text), Convert.ToDateTime(LblDataHoraPedido.Text), Convert.ToInt32(txtCodMesa.Text), "nao", garconNegocio.ProcurarPorCodigo(Convert.ToInt32(LblCodigoGarcon.Text)));
            pedido.Itempedidos = itemPedidoNegocio.itempedidos(pedido);
            FrmPagamento frmPagamento = new FrmPagamento(pedido);
            frmPagamento.ShowDialog();
            if (pedido.Disponivel == "nao")
            {
                CalcularTotalMesa();
            }
            else
            {
                this.Close();
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //MessageBox.Show("Não foi possível ocupar a mesa!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

    }
}

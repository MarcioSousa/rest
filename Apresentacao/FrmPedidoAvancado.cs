using Model;
using Negocios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmPedidoAvancado : Form
    {
        public FrmPedidoAvancado()
        {
            InitializeComponent();
        }

        private void FrmPedidoAvancado_Load(object sender, EventArgs e)
        {
            CarregaGridPedido();
        }

        private void CarregaGridPedido()
        {
            try
            {
                PedidoNegocio pedidoNegocio = new PedidoNegocio();
                List<Pedido> pedidos = new List<Pedido>();

                DgvPedido.Rows.Clear();

                pedidos = pedidoNegocio.PedidosData(Convert.ToDateTime(DtpPedido.Value));

                for (int t = 0; t < pedidos.Count; t++)
                {
                    DgvPedido.Rows.Add(pedidos[t].Codigo, pedidos[t].Garcon.Codigo, pedidos[t].Numeromesa, pedidos[t].Datahorapedido, pedidos[t].Disponivel);
                }

                if(DgvPedido.Rows.Count != 0)
                {
                    BtnExcluir.Enabled = true;
                    BtnItem.Enabled = true;
                }
                else
                {
                    BtnExcluir.Enabled = false;
                    BtnItem.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível carregar os Pedidos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja excluir o pedido selecionado?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    PedidoNegocio pedidoNegocio = new PedidoNegocio();

                    if (Convert.ToInt32(pedidoNegocio.Excluir(Convert.ToInt32(DgvPedido.Rows[DgvPedido.CurrentRow.Index].Cells[0].Value))) == 0)
                    {
                        MessageBox.Show("Excluído com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregaGridPedido();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível excluir o Pedido!\nDelete todos os pagamentos e todos os item feitos por esse pedido selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível excluir o Pedido!\nDelete todos os pagamentos e todos os item feitos por esse pedido selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DtpPedido_ValueChanged(object sender, EventArgs e)
        {
            CarregaGridPedido();
        }

        private void BtnPagamento_Click(object sender, EventArgs e)
        {
            GarconNegocio garconNegocio = new GarconNegocio();
            ItemPedidoNegocio itemPedidoNegocio = new ItemPedidoNegocio();
            Pedido pedido = new Pedido(Convert.ToInt32(DgvPedido.Rows[DgvPedido.CurrentRow.Index].Cells[0].Value), Convert.ToDateTime(DgvPedido.Rows[DgvPedido.CurrentRow.Index].Cells[3].Value), Convert.ToInt32(DgvPedido.Rows[DgvPedido.CurrentRow.Index].Cells[2].Value), DgvPedido.Rows[DgvPedido.CurrentRow.Index].Cells[4].Value.ToString(), garconNegocio.ProcurarPorCodigo(Convert.ToInt32(DgvPedido.Rows[DgvPedido.CurrentRow.Index].Cells[1].Value)));
            pedido.Itempedidos = itemPedidoNegocio.itempedidos(pedido);
            FrmPagamento frmPagamento = new FrmPagamento(pedido);
            frmPagamento.ShowDialog();
            
        }

        private void BtnItem_Click(object sender, EventArgs e)
        {
            GarconNegocio garconNegocio = new GarconNegocio();
            Pedido pedido = new Pedido(Convert.ToInt32(DgvPedido.Rows[DgvPedido.CurrentRow.Index].Cells[0].Value), Convert.ToDateTime(DgvPedido.Rows[DgvPedido.CurrentRow.Index].Cells[3].Value), Convert.ToInt32(DgvPedido.Rows[DgvPedido.CurrentRow.Index].Cells[2].Value), DgvPedido.Rows[DgvPedido.CurrentRow.Index].Cells[4].Value.ToString(), garconNegocio.ProcurarPorCodigo(Convert.ToInt32(Convert.ToInt32(DgvPedido.Rows[DgvPedido.CurrentRow.Index].Cells[1].Value))));
            FrmPedido frmPedido = new FrmPedido(pedido);
            frmPedido.ShowDialog();
            CarregaGridPedido();
        }
    }
}

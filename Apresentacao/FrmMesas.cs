using Model;
using Negocios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmMesas : Form
    {
        public FrmMesas()
        {
            InitializeComponent();
        }

        public void MesaOcupada(int botao)
        {
            if (botao == 1)
            {
                BtnMesaUm.Image = PbxOcupado.Image;
            }
            else if (botao == 2)
            {
                BtnMesaDois.Image = PbxOcupado.Image;
            }
            else if (botao == 3)
            {
                BtnMesaTres.Image = PbxOcupado.Image;
            }
            else if (botao == 4)
            {
                BtnMesaQuatro.Image = PbxOcupado.Image;
            }
            else if (botao == 5)
            {
                BtnMesaCinco.Image = PbxOcupado.Image;
            }
            else if (botao == 6)
            {
                BtnMesaSeis.Image = PbxOcupado.Image;
            }
            else if (botao == 7)
            {
                BtnMesaSete.Image = PbxOcupado.Image;
            }
            else if (botao == 8)
            {
                BtnMesaOito.Image = PbxOcupado.Image;
            }
            else if (botao == 9)
            {
                BtnMesaNove.Image = PbxOcupado.Image;
            }
            else if (botao == 10)
            {
                BtnMesaDez.Image = PbxOcupado.Image;
            }
            else if (botao == 11)
            {
                BtnMesaOnze.Image = PbxOcupado.Image;
            }
            else if (botao == 12)
            {
                BtnMesaDoze.Image = PbxOcupado.Image;
            }
            else if (botao == 13)
            {
                BtnMesaTreze.Image = PbxOcupado.Image;
            }
            else if (botao == 14)
            {
                BtnMesaQuatorze.Image = PbxOcupado.Image;
            }
            else if (botao == 15)
            {
                BtnMesaQuinze.Image = PbxOcupado.Image;
            }
            else if (botao == 16)
            {
                BtnMesaDezesseis.Image = PbxOcupado.Image;
            }
            else if (botao == 17)
            {
                BtnMesaDezessete.Image = PbxOcupado.Image;
            }
            else if (botao == 18)
            {
                BtnMesaDezoito.Image = PbxOcupado.Image;
            }
            else if (botao == 19)
            {
                BtnMesaDezenove.Image = PbxOcupado.Image;
            }
            else if (botao == 20)
            {
                BtnMesaVinte.Image = PbxOcupado.Image;
            }
            else if (botao == 21)
            {
                BtnMesavUm.Image = PbxOcupado.Image;
            }
            else if (botao == 22)
            {
                BtnMesavDois.Image = PbxOcupado.Image;
            }
            else if (botao == 23)
            {
                BtnMesavTres.Image = PbxOcupado.Image;
            }
            else if (botao == 24)
            {
                BtnMesavQuatro.Image = PbxOcupado.Image;
            }
            else if (botao == 25)
            {
                BtnMesavCinco.Image = PbxOcupado.Image;
            }
            else if (botao == 26)
            {
                BtnMesavSeis.Image = PbxOcupado.Image;
            }
            else if (botao == 27)
            {
                BtnMesavSete.Image = PbxOcupado.Image;
            }
            else if (botao == 28)
            {
                BtnMesavOito.Image = PbxOcupado.Image;
            }
            else if (botao == 29)
            {
                BtnMesavNove.Image = PbxOcupado.Image;
            }
            else if (botao == 30)
            {
                BtnMesaTrinta.Image = PbxOcupado.Image;
            }
            else if (botao == 31)
            {
                BtnMesatUm.Image = PbxOcupado.Image;
            }
            else if (botao == 32)
            {
                BtnMesatDois.Image = PbxOcupado.Image;
            }
            else if (botao == 33)
            {
                BtnMesatTres.Image = PbxOcupado.Image;
            }
            else if (botao == 34)
            {
                BtnMesatQuatro.Image = PbxOcupado.Image;
            }
            else if (botao == 35)
            {
                BtnMesatCinco.Image = PbxOcupado.Image;
            }
            else if (botao == 36)
            {
                BtnMesatSeis.Image = PbxOcupado.Image;
            }
            else if (botao == 37)
            {
                BtnMesatSete.Image = PbxOcupado.Image;
            }
            else if (botao == 38)
            {
                BtnMesatOito.Image = PbxOcupado.Image;
            }
            else if (botao == 39)
            {
                BtnMesatNove.Image = PbxOcupado.Image;
            }
            else if (botao == 40)
            {
                BtnMesaQuarenta.Image = PbxOcupado.Image;
            }
        }
        public void MesaLivre(int botao)
        {
            if (botao == 1)
            {
                BtnMesaUm.Image = PbxLivre.Image;
            }
            else if (botao == 2)
            {
                BtnMesaDois.Image = PbxLivre.Image;
            }
            else if (botao == 3)
            {
                BtnMesaTres.Image = PbxLivre.Image;
            }
            else if (botao == 4)
            {
                BtnMesaQuatro.Image = PbxLivre.Image;
            }
            else if (botao == 5)
            {
                BtnMesaCinco.Image = PbxLivre.Image;
            }
            else if (botao == 6)
            {
                BtnMesaSeis.Image = PbxLivre.Image;
            }
            else if (botao == 7)
            {
                BtnMesaSete.Image = PbxLivre.Image;
            }
            else if (botao == 8)
            {
                BtnMesaOito.Image = PbxLivre.Image;
            }
            else if (botao == 9)
            {
                BtnMesaNove.Image = PbxLivre.Image;
            }
            else if (botao == 10)
            {
                BtnMesaDez.Image = PbxLivre.Image;
            }
            else if (botao == 11)
            {
                BtnMesaOnze.Image = PbxLivre.Image;
            }
            else if (botao == 12)
            {
                BtnMesaDoze.Image = PbxLivre.Image;
            }
            else if (botao == 13)
            {
                BtnMesaTreze.Image = PbxLivre.Image;
            }
            else if (botao == 14)
            {
                BtnMesaQuatorze.Image = PbxLivre.Image;
            }
            else if (botao == 15)
            {
                BtnMesaQuinze.Image = PbxLivre.Image;
            }
            else if (botao == 16)
            {
                BtnMesaDezesseis.Image = PbxLivre.Image;
            }
            else if (botao == 17)
            {
                BtnMesaDezessete.Image = PbxLivre.Image;
            }
            else if (botao == 18)
            {
                BtnMesaDezoito.Image = PbxLivre.Image;
            }
            else if (botao == 19)
            {
                BtnMesaDezenove.Image = PbxLivre.Image;
            }
            else if (botao == 20)
            {
                BtnMesaVinte.Image = PbxLivre.Image;
            }
            else if (botao == 21)
            {
                BtnMesavUm.Image = PbxLivre.Image;
            }
            else if (botao == 22)
            {
                BtnMesavDois.Image = PbxLivre.Image;
            }
            else if (botao == 23)
            {
                BtnMesavTres.Image = PbxLivre.Image;
            }
            else if (botao == 24)
            {
                BtnMesavQuatro.Image = PbxLivre.Image;
            }
            else if (botao == 25)
            {
                BtnMesavCinco.Image = PbxLivre.Image;
            }
            else if (botao == 26)
            {
                BtnMesavSeis.Image = PbxLivre.Image;
            }
            else if (botao == 27)
            {
                BtnMesavSete.Image = PbxLivre.Image;
            }
            else if (botao == 28)
            {
                BtnMesavOito.Image = PbxLivre.Image;
            }
            else if (botao == 29)
            {
                BtnMesavNove.Image = PbxLivre.Image;
            }
            else if (botao == 30)
            {
                BtnMesaTrinta.Image = PbxLivre.Image;
            }
            else if (botao == 31)
            {
                BtnMesatUm.Image = PbxLivre.Image;
            }
            else if (botao == 32)
            {
                BtnMesatDois.Image = PbxLivre.Image;
            }
            else if (botao == 33)
            {
                BtnMesatTres.Image = PbxLivre.Image;
            }
            else if (botao == 34)
            {
                BtnMesatQuatro.Image = PbxLivre.Image;
            }
            else if (botao == 35)
            {
                BtnMesatCinco.Image = PbxLivre.Image;
            }
            else if (botao == 36)
            {
                BtnMesatSeis.Image = PbxLivre.Image;
            }
            else if (botao == 37)
            {
                BtnMesatSete.Image = PbxLivre.Image;
            }
            else if (botao == 38)
            {
                BtnMesatOito.Image = PbxLivre.Image;
            }
            else if (botao == 39)
            {
                BtnMesatNove.Image = PbxLivre.Image;
            }
            else if (botao == 40)
            {
                BtnMesaQuarenta.Image = PbxLivre.Image;
            }
        }
        private void VerificarMesas()
        {
            PedidoNegocio pedidoNegocio = new PedidoNegocio();
            List<Pedido> pedidos = new List<Pedido>();

            for (int t = 1; t <= 40; t++)
            {
                MesaLivre(t);
            }

            pedidos = pedidoNegocio.MesasOcupadas();

            for (int t = 1; t <= 40; t++)
            {
                for (int p = 0; p < pedidos.Count; p++)
                {
                    if (pedidos[p].Numeromesa == t)
                    {
                        MesaOcupada(t);
                        break;
                    }
                }
            }
        }

        private void BtnMesaUm_Click(object sender, EventArgs e)
        {
            if (BtnMesaUm.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(1, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(1, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();

        }
        private void BtnMesaDois_Click(object sender, EventArgs e)
        {
            if (BtnMesaDois.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(2, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(2, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void BtnMesaTres_Click(object sender, EventArgs e)
        {
            if (BtnMesaTres.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(3, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(3, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void BtnMesaQuatro_Click(object sender, EventArgs e)
        {
            if (BtnMesaQuatro.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(4, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(4, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void BtnMesaCinco_Click(object sender, EventArgs e)
        {
            if (BtnMesaCinco.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(5, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(5, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void BtnMesaSeis_Click(object sender, EventArgs e)
        {
            if (BtnMesaSeis.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(6, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(6, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void BtnMesaSete_Click(object sender, EventArgs e)
        {
            if (BtnMesaSete.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(7, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(7, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void BtnMesaOito_Click(object sender, EventArgs e)
        {
            if (BtnMesaOito.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(8, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(8, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void BtnMesaNove_Click(object sender, EventArgs e)
        {
            if (BtnMesaNove.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(9, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(9, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void BtnMesaDez_Click(object sender, EventArgs e)
        {
            if (BtnMesaDez.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(10, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(10, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void BtnMesaOnze_Click(object sender, EventArgs e)
        {
            if (BtnMesaOnze.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(11, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(11, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void BtnMesaDoze_Click(object sender, EventArgs e)
        {
            if (BtnMesaDoze.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(12, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(12, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void BtnMesaTreze_Click(object sender, EventArgs e)
        {
            if (BtnMesaTreze.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(13, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(13, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void BtnMesaQuatorze_Click(object sender, EventArgs e)
        {
            if (BtnMesaQuatorze.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(14, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(14, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void BtnMesaQuinze_Click(object sender, EventArgs e)
        {
            if (BtnMesaQuinze.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(15, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(15, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void BtnMesaDezesseis_Click(object sender, EventArgs e)
        {
            if (BtnMesaDezesseis.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(16, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(16, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void BtnMesaDezessete_Click(object sender, EventArgs e)
        {
            if (BtnMesaDezessete.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(17, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(17, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void BtnMesaDezoito_Click(object sender, EventArgs e)
        {
            if (BtnMesaDezoito.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(18, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(18, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void BtnMesaDezenove_Click(object sender, EventArgs e)
        {
            if (BtnMesaDezenove.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(19, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(19, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void BtnMesaVinte_Click(object sender, EventArgs e)
        {
            if (BtnMesaVinte.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(20, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(20, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void BtnMesavUm_Click(object sender, EventArgs e)
        {
            if (BtnMesavUm.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(21, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(21, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void BtnMesavDois_Click(object sender, EventArgs e)
        {
            if (BtnMesavDois.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(22, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(22, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void BtnMesavTres_Click(object sender, EventArgs e)
        {
            if (BtnMesavTres.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(23, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(23, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void BtnMesavQuatro_Click(object sender, EventArgs e)
        {

            if (BtnMesavQuatro.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(24, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(24, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void BtnMesavCinco_Click(object sender, EventArgs e)
        {
            if (BtnMesavCinco.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(25, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(25, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void BtnMesavSeis_Click(object sender, EventArgs e)
        {
            if (BtnMesavSeis.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(26, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(26, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void BtnMesavSete_Click(object sender, EventArgs e)
        {
            if (BtnMesavSete.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(27, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(27, "ocupado");
                frmPedidos.ShowDialog();
            }

            VerificarMesas();

        }
        private void BtnMesavOito_Click(object sender, EventArgs e)
        {
            if (BtnMesavOito.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(28, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(28, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void BtnMesavNove_Click(object sender, EventArgs e)
        {
            if (BtnMesavNove.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(29, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(29, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void BtnMesaTrinta_Click(object sender, EventArgs e)
        {
            if (BtnMesaTrinta.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(30, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(30, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void BtnMesatUm_Click(object sender, EventArgs e)
        {
            if (BtnMesatUm.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(31, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(31, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();

        }
        private void BtnMesatDois_Click(object sender, EventArgs e)
        {
            if (BtnMesatDois.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(32, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(32, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void BtnMesatTres_Click(object sender, EventArgs e)
        {
            if (BtnMesatTres.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(33, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(33, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void BtnMesatQuatro_Click(object sender, EventArgs e)
        {
            if (BtnMesatQuatro.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(34, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(34, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void BtnMesatCinco_Click(object sender, EventArgs e)
        {
            if (BtnMesatCinco.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(35, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(35, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void BtnMesatSeis_Click(object sender, EventArgs e)
        {
            if (BtnMesatSeis.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(36, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(36, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void BtnMesatSete_Click(object sender, EventArgs e)
        {
            if (BtnMesatSete.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(37, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(37, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void BtnMesatOito_Click(object sender, EventArgs e)
        {
            if (BtnMesatOito.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(38, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(38, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void BtnMesatNove_Click(object sender, EventArgs e)
        {
            if (BtnMesatNove.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(39, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(39, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void BtnMesaQuarenta_Click(object sender, EventArgs e)
        {
            if (BtnMesaQuarenta.Image == PbxLivre.Image)
            {
                FrmPedido frmPedidos = new FrmPedido(40, "livre");
                frmPedidos.ShowDialog();
            }
            else
            {
                FrmPedido frmPedidos = new FrmPedido(40, "ocupado");
                frmPedidos.ShowDialog();
            }
            VerificarMesas();
        }
        private void FrmMesas_Load(object sender, EventArgs e)
        {
            VerificarMesas();
        }
        private void BtnTrocaMesa_Click(object sender, EventArgs e)
        {
            GbxTrocaMesa.Visible = true;
            NupMesaAtual.Focus();
        }
        private void BtnEncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnCancela_Click(object sender, EventArgs e)
        {
            GbxTrocaMesa.Visible = false;
            NupMesaAtual.Value = 1;
            NupNovaMesa.Value = 1;
        }
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigopedido = 0;
                int numeromesaocupada = 0;
                int numeromesalivre = Convert.ToInt32(NupNovaMesa.Value);

                if (NupMesaAtual.Value == NupNovaMesa.Value)
                {
                    MessageBox.Show("Digite numero de mesas diferentes nos campos", "Mesas Diferentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //VERIFICAR SE A MESA ATUAL ESTÁ REALMENTE OCUPADA!!!!
                PedidoNegocio pedidoNegocio = new PedidoNegocio();
                List<Pedido> pedidos = new List<Pedido>();

                pedidos = pedidoNegocio.MesasOcupadas();

                for(int t = 0; t < pedidos.Count; t++)
                {
                    if(pedidos[t].Numeromesa == NupMesaAtual.Value)
                    {
                        codigopedido = pedidos[t].Codigo;
                        numeromesaocupada = Convert.ToInt32(NupMesaAtual.Value);
                        break;
                    }
                }
                
                if(numeromesaocupada != 0)
                {
                    for (int t = 0; t < pedidos.Count; t++)
                    {
                        if (pedidos[t].Numeromesa == NupNovaMesa.Value)
                        {
                            MessageBox.Show("Escolha uma mesa que esteja livre nesse momento!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            numeromesalivre = 0;
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Coloque o número da mesa Atual que esteja ocupada no momento!\nPois ela está livre e não pode ser feito a troca!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (numeromesaocupada != 0 && numeromesalivre != 0)
                {
                    Pedido pedido = new Pedido(codigopedido, DateTime.Today.Date, numeromesalivre, "", null);
                    pedidoNegocio.AlterarMesa(pedido);
                    MessageBox.Show("Alterado com Sucesso!");
                    VerificarMesas();
                    NupMesaAtual.Value = 1;
                    NupNovaMesa.Value = 1;
                    GbxTrocaMesa.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve algum erro na alteração, contate o desenvolvedor! Aviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

}

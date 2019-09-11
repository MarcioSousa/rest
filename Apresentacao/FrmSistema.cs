using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmSistema : Form
    {
        public FrmSistema()
        {
            InitializeComponent();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGarcon_Click(object sender, EventArgs e)
        {
            FrmGarcon frmGarcon = new FrmGarcon();
            frmGarcon.ShowDialog();
        }

        private void BtnProduto_Click(object sender, EventArgs e)
        {
            FrmProduto frmProduto = new FrmProduto();
            frmProduto.ShowDialog();
        }

        private void BtnCaixa_Click(object sender, EventArgs e)
        {
            FrmCaixa frmCaixa = new FrmCaixa();
            frmCaixa.ShowDialog();
        }
    }
}

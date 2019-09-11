using System;
using System.Windows.Forms;
using Negocios;

namespace Apresentacao
{
    public partial class FrmPrincipal : Form
    {
        public bool admin = false;
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin(this);
            frmLogin.ShowDialog();
            if (admin)
            {
                BtnCaixa.Enabled = false;
                BtnProduto.Enabled = false;
                BtnGarcon.Enabled = false;
                BtnEstoque.Enabled = false;
                MsSistema.Enabled = false;
                BtnMesas.Enabled = false;
                BtnAvancado.Enabled = false;
                BtnDeletaUsuario.Visible = true;
            }
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
        private void BtnGarcon_Click(object sender, EventArgs e)
        {
            FrmGarcon frmGarcon = new FrmGarcon();
            frmGarcon.ShowDialog();
        }
        private void BtnEstoque_Click(object sender, EventArgs e)
        {
            FrmEstoque frmEstoque = new FrmEstoque();
            frmEstoque.ShowDialog();
        }
        private void BtnMesas_Click(object sender, EventArgs e)
        {
            FrmMesas frmMesas = new FrmMesas();
            frmMesas.ShowDialog();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAvancado_Click(object sender, EventArgs e)
        {
            FrmPedidoAvancado frmPedidoAvancado = new FrmPedidoAvancado();
            frmPedidoAvancado.ShowDialog();
        }

        private void DesenvolvedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSobre frmSobre = new FrmSobre();
            frmSobre.ShowDialog();
        }

        private void GarconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGarcon frmGarcon = new FrmGarcon();
            frmGarcon.ShowDialog();
        }

        private void ProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProduto frmProduto = new FrmProduto();
            frmProduto.ShowDialog();
        }

        private void CaixaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCaixa frmCaixa = new FrmCaixa();
            frmCaixa.ShowDialog();
        }

        private void UsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario();
            frmUsuario.ShowDialog();
        }

        private void SistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSistema frmSistema = new FrmSistema();
            frmSistema.ShowDialog();
        }

        private void BtnDeletaUsuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deletando usuários do sistema, dar continuidade?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
                if (Convert.ToInt32(usuarioNegocio.Excluir()) == 0)
                {
                    MessageBox.Show("Usuário deletado com sucesso!","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível deletar os usuários cadastrados no sistema!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Evento cancelado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}

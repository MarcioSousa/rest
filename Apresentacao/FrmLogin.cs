using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using Negocios;
using Model;
using System.Collections.Generic;

namespace Apresentacao
{
    public partial class FrmLogin : Form
    {
        Usuario usuario;
        FrmPrincipal frmPrincipal;
        public FrmLogin(FrmPrincipal frmPrincipal)
        {
            InitializeComponent();
            this.frmPrincipal = frmPrincipal;
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

                if (usuarioNegocio.VerificarBancoExiste("cfsrestaurante") == 0)
                {
                    usuarioNegocio.CriarBancoRestaurante("cfsrestaurante");
                    MessageBox.Show("Banco criado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (usuarioNegocio.QtdeUsuario() == 1)
                    {
                        List<Usuario> usuarios = new List<Usuario>();
                        usuarios = usuarioNegocio.TodosUsuario();
                        usuario = new Usuario(usuarios[0].Codigo, usuarios[0].Nome, usuarios[0].Senha);
                        TxtUsuario.Text = usuario.Nome;
                        TxtSenha.Focus();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Erro ao carregar o sistema!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtSenha.Text != "" && TxtUsuario.Text != "")
                {
                    if (TxtSenha.Text == "ADMIN" && TxtUsuario.Text == "ADMIN")
                    {
                        MessageBox.Show("Administrador ativado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmPrincipal.admin = true;
                        this.Close();
                    }
                    else
                    {
                        if (usuario is null)
                        {
                            if (MessageBox.Show("É seu primeiro login, deseja continuar?\nCaso afirmativo, anote num papel a parte seu nome e sua senha de acesso.\nNão se esqueça de sua senha de acesso para poder logar novamente da próxima vez!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                            {
                                UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
                                usuario = new Usuario(15, TxtUsuario.Text, TxtSenha.Text);
                                usuarioNegocio.Inserir(usuario);
                                this.Close();
                            }
                        }
                        else
                        {
                            if (TxtUsuario.Text == usuario.Nome && TxtSenha.Text == usuario.Senha)
                            {
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Usuario e senha incorretos!\nDigite novamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Preencha os campos Login e Senha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtUsuario.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível carregar o sistema!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LblEmpresa_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja zerar o acesso de usuário?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
                usuarioNegocio.Excluir(15);
                MessageBox.Show("Usuario zerado.\nÉ necessário fechar o sistema!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }
    }
}

//int qtde = usuarioNegocio.QtdeUsuario();

//if (qtde == 0)
//{
//    TxtAcesso.Visible = true;
//    LblAcesso.Visible = true;
//}
//else if (qtde == 1)
//{
//    TxtAcesso.Visible = false;
//    LblAcesso.Visible = false;

//    Usuario usuario = new Usuario(0, "", "");
//    usuario = usuarioNegocio.VerificarCodigo();

//    TxtUsuario.Text = usuario.Nome;
//    TxtSenha.Text = usuario.Senha;

//    BtnLogin.Focus();
//}
//else
//{
//    MessageBox.Show("Erro ao carregar o sistema!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
//}

//try
//{
//    UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

//    int qtde = usuarioNegocio.QtdeUsuario();

//    if (qtde == 0)
//    {
//        TxtAcesso.Visible = true;
//        LblAcesso.Visible = true;
//    }
//    else if (qtde == 1)
//    {
//        TxtAcesso.Visible = false;
//        LblAcesso.Visible = false;

//        Usuario usuario = new Usuario(0, "", "");
//        usuario = usuarioNegocio.VerificarCodigo();

//        TxtUsuario.Text = usuario.Nome;
//        TxtSenha.Text = usuario.Senha;

//        BtnLogin.Focus();
//    }
//    else
//    {
//        MessageBox.Show("Erro ao carregar o sistema!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
//    }
//}
//catch
//{
//    MessageBox.Show("Erro ao carregar o sistema!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
//}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using Model;

namespace Apresentacao
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
                List<Usuario> usuarios = new List<Usuario>();

                usuarios = usuarioNegocio.TodosUsuario();

                if (usuarios.Count == 1)
                {
                    TxtUsuario.Text = usuarios[0].Nome;
                }

            }
            catch
            {
                MessageBox.Show("Não foi possível carregar o Usuário e Senha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtSenha.Text = "";
            TxtNovoUsuario.Text = "";
            TxtNovaSenha.Text = "";
            TxtConfirmaNovaSenha.Text = "";

            PnlNovoUsuario.Enabled = false;

            TxtUsuario.Enabled = true;
            TxtSenha.Enabled = true;

            BtnEditar.Enabled = true;
            BtnEditar.Focus();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

                List<Usuario> usuarios = new List<Usuario>();

                usuarios = usuarioNegocio.TodosUsuario();

                if (usuarios.Count == 1)
                {
                    if (TxtUsuario.Text == usuarios[0].Nome && TxtSenha.Text == usuarios[0].Senha)
                    {
                        TxtUsuario.Enabled = false;
                        TxtSenha.Enabled = false;

                        PnlNovoUsuario.Enabled = true;
                        BtnEditar.Enabled = false;

                        TxtNovoUsuario.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Usuário e Senha incorretos, digite novamente o Usuário e Senha", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtUsuario.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Houve um erro no Sistema. Tente Novamente!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível Iniciar a Edição de Usuário", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtNovoUsuario.Text != "" && TxtNovaSenha.Text != "" && TxtNovaSenha.Text == TxtConfirmaNovaSenha.Text)
                {
                    UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
                    List<Usuario> usuarios = new List<Usuario>();

                    usuarios = usuarioNegocio.TodosUsuario();

                    if (usuarios.Count == 1)
                    {
                        Usuario usuario = new Usuario(usuarios[0].Codigo, TxtNovoUsuario.Text, TxtNovaSenha.Text);

                        if (usuarioNegocio.Alterar(usuario).ToString() == "0")
                        {
                            MessageBox.Show("Usuário e Senha alterados!\nFavor, anotar em um papel para não perder essas anotações ao conectar no seu sistema!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            PnlNovoUsuario.Enabled = false;
                            TxtSenha.Text = "";
                            BtnEditar.Enabled = true;
                            TxtUsuario.Enabled = true;
                            TxtSenha.Enabled = true;
                            TxtUsuario.Text = TxtNovoUsuario.Text;
                            TxtNovoUsuario.Text = "";
                            TxtNovaSenha.Text = "";
                            TxtConfirmaNovaSenha.Text = "";
                            BtnFechar.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível alterar o Usuário e a Senha", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Houve um erro no Sistema. Tente Novamente!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("As senhas não estão iguais ou os campos estão vazios. Digite duas vezes a mesma senha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtNovaSenha.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível Editar o Usuário cadastrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
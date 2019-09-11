using Model;
using Negocios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmGarcon : Form
    {
        string escolha = "";
        public int codigogarcon = -1;

        public FrmGarcon()
        {
            InitializeComponent();
            DgvGarcon.AutoGenerateColumns = false;
        }
        private void CarregaGrid()
        {
            GarconNegocio garconNegocio = new GarconNegocio();
            List<Garcon> garcons = new List<Garcon>();

            garcons = garconNegocio.TodosGarcon();

            DgvGarcon.DataSource = null;
            DgvGarcon.DataSource = garcons;

            TxtPesquisa.Text = "";

            DgvGarcon.Update();
            DgvGarcon.Refresh();

            CarregaCampos();
        }
        private void CarregaCampos()
        {
            if (DgvGarcon.Rows.Count != 0)
            {
                TxtCodigo.Text = DgvGarcon.Rows[DgvGarcon.CurrentRow.Index].Cells[0].Value.ToString();
                TxtNome.Text = DgvGarcon.Rows[DgvGarcon.CurrentRow.Index].Cells[1].Value.ToString();
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
            }
        }
        private void AbreTudo()
        {
            DgvGarcon.Enabled = false;
            BtnAdicionar.Enabled = false;
            BtnEditar.Enabled = false;
            BtnExcluir.Enabled = false;

            BtnConfirmar.Enabled = true;
            BtnCancelar.Enabled = true;

            TxtCodigo.ReadOnly = false;
            TxtNome.ReadOnly = false;
            TxtPesquisa.Enabled = false;

            if (escolha == "A")
            {
                TxtCodigo.Text = "";
                TxtNome.Text = "";
            }

            TxtCodigo.Focus();
        }
        private void FechaTudo()
        {
            DgvGarcon.Enabled = true;
            BtnAdicionar.Enabled = true;
            BtnEditar.Enabled = true;
            BtnExcluir.Enabled = true;

            BtnConfirmar.Enabled = false;
            BtnCancelar.Enabled = false;

            TxtCodigo.ReadOnly = true;
            TxtNome.ReadOnly = true;

            DgvGarcon.ReadOnly = true;
            TxtPesquisa.Enabled = true;


            CarregaGrid();

            BtnAdicionar.Focus();
        }

        private void FrmGarcon_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }
        private void DgvGarcon_SelectionChanged(object sender, EventArgs e)
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
                if (MessageBox.Show("Deseja realmente excluir o Garçon Selecionado?", "Exclusão", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    GarconNegocio garconNegocio = new GarconNegocio();

                    int valor = Convert.ToInt32(garconNegocio.Excluir(Convert.ToInt32(TxtCodigo.Text)));
                    MessageBox.Show("Garçon Excluído com Sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CarregaGrid();
                }
                else
                {
                    MessageBox.Show("Exclusão não Finalizada!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível Excluir o Garçon Selecionado.");
            }
        }
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtCodigo.Text != "" && TxtNome.Text != "")
                {
                    GarconNegocio garconNegocio = new GarconNegocio();
                    Garcon garcon = new Garcon(Convert.ToInt32(TxtCodigo.Text), TxtNome.Text);


                    if (escolha == "A")
                    {
                        if (garconNegocio.Inserir(garcon) != "0")
                        {
                            MessageBox.Show("Não foi possível inserir.\nVerifique se já existe um código para esse garçon.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TxtCodigo.Focus();
                            return;
                        }
                    }
                    else
                    {
                        garcon.Codigo = Convert.ToInt32(TxtCodigo.Text);

                        if (garconNegocio.Alterar(garcon, Convert.ToInt32(DgvGarcon.Rows[DgvGarcon.CurrentRow.Index].Cells[0].Value)) != "0")
                        {
                            MessageBox.Show("Não foi possível alterar o garçon.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TxtCodigo.Focus();
                            return;
                        }

                    }
                    escolha = "";
                    FechaTudo();
                }
                else
                {
                    MessageBox.Show("Digite o Código e o Nome do garçon!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                CarregaGrid();
                BtnAdicionar.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível finalizar o cadastro. Aviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            escolha = "";
            FechaTudo();
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
                        GarconNegocio garconNegocio = new GarconNegocio();
                        DgvGarcon.DataSource = garconNegocio.ProcurarPorCodigoOuNome(Convert.ToInt32(TxtPesquisa.Text), "");
                    }
                    else
                    {
                        GarconNegocio garconNegocio = new GarconNegocio();
                        DgvGarcon.DataSource = garconNegocio.ProcurarPorCodigoOuNome(0, TxtPesquisa.Text);
                    }

                    DgvGarcon.Update();
                    DgvGarcon.Refresh();

                    if (DgvGarcon.Rows.Count != 0)
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
        private void DgvGarcon_DoubleClick(object sender, EventArgs e)
        {
            if (DgvGarcon.Rows.Count != 0 && codigogarcon != -1)
            {
                codigogarcon = Convert.ToInt32(DgvGarcon.Rows[DgvGarcon.CurrentRow.Index].Cells[0].Value);

                if (codigogarcon > 0)
                {
                    this.Close();
                }
            }
      
        }



    }
}
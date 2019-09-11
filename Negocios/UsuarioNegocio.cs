using Control;
using Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace Negocios
{
  public  class UsuarioNegocio
    {
        readonly DQL consulta = new DQL();
        readonly DML manipulacao = new DML();
        readonly DDL criarbanco = new DDL();
        public string Inserir(Usuario usuario)
        {
            try
            {
                return manipulacao.ExecutarManipulacao(CommandType.Text, "INSERT INTO usuario(codigo, nome, senha) VALUES (" + usuario.Codigo + ",'" + usuario.Nome + "','" + usuario.Senha + "')").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Alterar(Usuario usuario)
        {
            try
            {
                return manipulacao.ExecutarManipulacao(CommandType.Text, "UPDATE usuario SET nome = '" + usuario.Nome + "', senha = '" + usuario.Senha + "' WHERE codigo = " + usuario.Codigo).ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Excluir()
        {
            try
            {
                manipulacao.ExecutarManipulacao(CommandType.Text, "DELETE FROM usuario");
                return "0";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Excluir(int codigousuario)
        {
            try
            {
                manipulacao.ExecutarManipulacao(CommandType.Text, "DELETE FROM usuario WHERE codigo = " + codigousuario);
                return "0";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Usuario> TodosUsuario()
        {
            try
            {
                List<Usuario> usuarios = new List<Usuario>();

                DataTable dataTableUsuario = consulta.ExecutarConsulta(CommandType.Text, "SELECT codigo, nome, senha FROM usuario ORDER BY codigo");

                foreach (DataRow linha in dataTableUsuario.Rows)
                {
                    Usuario usuario = new Usuario(Convert.ToInt32(linha["codigo"]), linha["nome"].ToString(), linha["senha"].ToString());
                    usuarios.Add(usuario);
                }

                return usuarios;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar os Usuarios.\nDetalhes: " + ex.Message);
            }
        }
        public int VerificarBancoExiste(string nomebanco)
        {
            try
            {
                return Convert.ToInt32(criarbanco.VerificandoBancoExiste(CommandType.Text, "SELECT COUNT(name) AS qtde FROM sys.databases WHERE name = '" + nomebanco + "'"));
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível fazer a verificação do Banco.\nDetalhes: " + ex.Message);
            }
        }
        public int CriarBancoRestaurante(string nomebanco)
        {
            try
            {
                criarbanco.CriarBancoDados(CommandType.Text, "CREATE DATABASE " + nomebanco);
                criarbanco.CriarTabelas(CommandType.Text, "CREATE TABLE usuario(codigo INT NOT NULL, nome VARCHAR(30), senha VARCHAR(30)); ALTER TABLE usuario ADD CONSTRAINT pk_codigousuario PRIMARY KEY(codigo); " +
                    "CREATE TABLE garcon(codigo INT NOT NULL, nome VARCHAR(30)); ALTER TABLE garcon ADD CONSTRAINT pk_codigogarcon PRIMARY KEY(codigo); " +
                    "CREATE TABLE produto(codigo INT NOT NULL, nome VARCHAR(30) NOT NULL, valor DECIMAL(10, 2)); ALTER TABLE produto ADD CONSTRAINT pk_codigoproduto PRIMARY KEY(codigo); " +
                    "CREATE TABLE caixa(datacaixa DATE NOT NULL, valor DECIMAL(10, 2)); ALTER TABLE caixa ADD CONSTRAINT pk_datacaixa PRIMARY KEY(datacaixa); " +
                    "CREATE TABLE estoque(codigo INT NOT NULL IDENTITY(1,1), codproduto INT NOT NULL, dataentrada DATE NOT NULL, datavencimento DATE, valortotal DECIMAL(10, 2), qtde INT); ALTER TABLE estoque ADD CONSTRAINT pk_codigoestoque PRIMARY KEY(codigo); ALTER TABLE estoque ADD CONSTRAINT fk_estoque_produto FOREIGN KEY(codproduto) REFERENCES produto(codigo); " +
                    "CREATE TABLE pedido(codigo INT NOT NULL IDENTITY(1,1), codgarcon INT NOT NULL, numeromesa INT NOT NULL, datahorapedido DATETIME, disponivel VARCHAR(10)); ALTER TABLE pedido ADD CONSTRAINT pk_codigopedido PRIMARY KEY(codigo); ALTER TABLE pedido ADD CONSTRAINT fk_pedido_garcon FOREIGN KEY(codgarcon) REFERENCES garcon(codigo); " +
                    "CREATE TABLE pagamento(codigo INT NOT NULL IDENTITY(1,1), codpedido INT NOT NULL, datahorapagamento DATETIME, tipo VARCHAR(15), valor DECIMAL(10, 2)); ALTER TABLE pagamento ADD CONSTRAINT pk_codigopagamento PRIMARY KEY(codigo); ALTER TABLE pagamento ADD CONSTRAINT fk_pagamento_pedido FOREIGN KEY(codpedido) REFERENCES pedido(codigo); " +
                    "CREATE TABLE itempedido(codigo INT NOT NULL IDENTITY(1,1), codproduto INT NOT NULL, codpedido INT NOT NULL, qtde INT, valorunid DECIMAL(10, 2)); ALTER TABLE itempedido ADD CONSTRAINT pk_codigoitempedido PRIMARY KEY(codigo); ALTER TABLE itempedido ADD CONSTRAINT fk_itempedido_produto FOREIGN KEY(codproduto) REFERENCES produto(codigo); ALTER TABLE itempedido ADD CONSTRAINT fk_itempedido_pedido FOREIGN KEY(codpedido) REFERENCES pedido(codigo)");
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível fazer a verificação do Banco.\nDetalhes: " + ex.Message);
            }
        }
        public int QtdeUsuario()
        {
            try
            {
                DataTable dataTableUsuario = consulta.ExecutarConsulta(CommandType.Text, "SELECT COUNT(codigo) AS qtde FROM usuario");

                return Convert.ToInt32(dataTableUsuario.Rows[0]["qtde"]);
            }
            catch (Exception ex) 
            {
                throw new Exception("Não foi possível verificar o Usuario Cadastrado.\nDetalhes: " + ex.Message);
            }
        }
        public Usuario VerificarCodigo()
        {
            try
            {
                DataTable dataTableUsuario = consulta.ExecutarConsulta(CommandType.Text, "SELECT codigo, nome, senha FROM usuario");
                Usuario usuario = new Usuario(Convert.ToInt32(dataTableUsuario.Rows[0]["codigo"]), dataTableUsuario.Rows[0]["nome"].ToString(), dataTableUsuario.Rows[0]["senha"].ToString());
                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível verificar o Usuario Cadastrado.\nDetalhes: " + ex.Message);
            }
        }

    }
}    

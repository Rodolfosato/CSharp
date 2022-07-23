using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlienExpress.Util;
using System.Data;

namespace AlienExpress.Model
{
    class Control
    {
        public int adm { get; set; }
        public bool tem { get; set; }
        public string mensagem = "";
        public int qnt { get; set; }
        public string produto { get; set; }
        public int carrinho { get; set; }
        public double total { get; set; }
        public double carteira { get; set; }
        public bool AcessarLogin(string login, string senha)
        {
            LoginDAOControl control = new LoginDAOControl();
            tem = control.Verificarlogin(login, senha);
            if(!control.mensagem.Equals(""))
            {
                this.mensagem = control.mensagem;
            }
            return tem;
        }
        public string CadastrarLogin(string email, string senha, string confsenha)
        {
            LoginDAOControl control = new LoginDAOControl();
            this.mensagem = control.Cadastrar(email, senha, confsenha);
            if (control.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
        public int ADM (string login, string senha)
        {
            LoginDAOControl control = new LoginDAOControl();
            adm = control.ADM(login, senha);
            this.adm = control.adm;
            return adm;
        }
        public string CadastrarProduto(string produto, string descricao, int quantidade, double preco)
        {
            AdmDAOControl control = new AdmDAOControl();
            this.mensagem = control.Cadastrar(produto, descricao, quantidade, preco);
            return mensagem;

        }

        public DataTable ListarProdutos(string sql)
        {
            AdmDAOControl control = new AdmDAOControl();
            DataTable dt = new DataTable();
            dt = control.Listar(sql);
            return dt;
        }
        public string AlterarProdutos(int id_produto, string produto, string descricao, int quantidade, double preco)
        {
            AdmDAOControl control = new AdmDAOControl();
            this.mensagem = control.Alterar(id_produto, produto, descricao, quantidade, preco);
            return mensagem;
        }
        public string DeletarProdutos(int id_produtos)
        {
            AdmDAOControl control = new AdmDAOControl();
            this.mensagem = control.Deletar(id_produtos);
            return mensagem;
        }
        public string AddCarrinho(int id_produto, int quantidade, string XD)
        {
            CLIENTDAOControl control = new CLIENTDAOControl();
            LoginDAOControl login = new LoginDAOControl();
            string cliente = login.login;
            double preco = control.preco(id_produto);
            this.mensagem = control.AdicionarCarrinho(id_produto, cliente, preco, quantidade);
            return mensagem;
        }
        public int Quantidade(int id_produto)
        {
            CLIENTDAOControl control = new CLIENTDAOControl();
            this.qnt = control.Quantidade(id_produto);
            return qnt;
        }
        public int Carrinho(string login)
        {
            CLIENTDAOControl cliente = new CLIENTDAOControl();
            this.carrinho = cliente.QTCarrinho(login);
            return carrinho;
        }
        public string ProdutoCarrinho(int id_produto)
        {
            LoginDAOControl login = new LoginDAOControl();
            string usuario = login.login;
            CLIENTDAOControl control = new CLIENTDAOControl();
            this.produto = control.ProdutoCarrinho(id_produto);
            return produto;
        }
        public double TotalCarrinho()
        {
            LoginDAOControl login = new LoginDAOControl();
            string usuario = login.login;
            CLIENTDAOControl cliente = new CLIENTDAOControl();
            this.total = cliente.ValorTotalCarrinho(usuario);
            return total;
        }
        public void LimparCarrinho()
        {
            LoginDAOControl login = new LoginDAOControl();
            string usuario = login.login;
            CLIENTDAOControl control = new CLIENTDAOControl();
            control.Limpar(usuario);
        }
        public double Carteira()
        {
            LoginDAOControl login = new LoginDAOControl();
            string usuario = login.login;
            CLIENTDAOControl control = new CLIENTDAOControl();
            control.Carteira(usuario);
            this.carteira = control.Carteira(usuario);
            return this.carteira;
        }
        public void ConfirmarCompra(string produto)
        {
            LoginDAOControl login = new LoginDAOControl();
            string usuario = login.login;
            CLIENTDAOControl control = new CLIENTDAOControl();
            control.PagarCarrinho(usuario, produto);
        }
        public int ID_Produto(string produto)
        {
            CLIENTDAOControl control = new CLIENTDAOControl();
            qnt = control.id_produto(produto);
            return qnt;
        }
    }
}

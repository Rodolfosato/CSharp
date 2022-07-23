using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlienExpress.Model;
using AlienExpress.Util;
using Npgsql;

namespace AlienExpress.CLIENT
{
    public partial class Carrinho : Form
    {
        public Carrinho()
        {           
            InitializeComponent();            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Model.Control control = new Model.Control();
            control.LimparCarrinho();
            this.Hide();
        }

        private void Carrinho_Load(object sender, EventArgs e)
        {
            Model.Control control = new Model.Control();
            DataTable dt = new DataTable();
            double Valorcarrinho;
            LoginDAOControl login = new LoginDAOControl();
            string usuario = login.login;
            Valorcarrinho = Convert.ToDouble(control.TotalCarrinho());
            string Valor = Convert.ToString(Valorcarrinho);
            string sql = "SELECT PRODUTO, CARRINHO.QUANTIDADE, CARRINHO.PRECO FROM PRODUTOS INNER JOIN CARRINHO ON PRODUTOS.ID_PRODUTO = CARRINHO.ID_PRODUTO WHERE CLIENTE ='" + usuario + "' ";
            dt = control.ListarProdutos(sql);
            dt.Columns[0].ColumnName = "PRODUTO";
            dt.Columns[1].ColumnName = "QUANTIDADE";
            dt.Columns[2].ColumnName = "PREÇO";
            dgvProdutos.DataSource = dt;
            lbValortotal.Text = Valor + " R$";
        }
    }
}

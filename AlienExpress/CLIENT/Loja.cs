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

namespace AlienExpress.CLIENT
{
    public partial class Loja : Form
    {
        public Loja()
        {
            Model.Control control = new Model.Control();
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM PRODUTOS";
            dt = control.ListarProdutos(sql);
            dt.Columns[0].ColumnName = "ID_PRODUTO";
            dt.Columns[1].ColumnName = "PRODUTO";
            dt.Columns[2].ColumnName = "DESCRIÇÃO";
            dt.Columns[3].ColumnName = "QUANTIDADE";
            dt.Columns[4].ColumnName = "PREÇO";
            InitializeComponent();
            dgvProdutos.DataSource = dt;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Model.Control control = new Model.Control();
           LoginDAOControl login = new LoginDAOControl();
            string XD;
            int qtcarrinho;
            XD = login.login;
            qtcarrinho = control.Carrinho(XD);
            control.Quantidade(Convert.ToInt32(txtId.Text));
            if (!txtId.Text.Equals(""))
            {
                if (!txtQuantidade.Text.Equals(""))
                {
                    if (qtcarrinho < 3)
                    {
                        if (control.qnt <= 0 || control.qnt < Convert.ToInt32(txtQuantidade.Text))
                        {
                            MessageBox.Show("Quantidade de Produtos Insuficiente!");
                        }
                        else
                        {
                            control.AddCarrinho(Convert.ToInt32(txtId.Text), Convert.ToInt32(txtQuantidade.Text), XD);
                            MessageBox.Show("Produto adicionado ao carrinho!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Carrinho cheio!");
                    }                   
                }
                else
                {
                    MessageBox.Show("Quantidade invalida!");
                }
            }
            else
            {
                MessageBox.Show("ID invalido!");
            }
        }
    }
}

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

namespace AlienExpress.ADM
{
    public partial class EditarProdutos : Form
    {
        public EditarProdutos()
        {

            InitializeComponent();           
        }

        private void txtBusca_KeyUp(object sender, KeyEventArgs e)
        {
            Model.Control control = new Model.Control();
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM PRODUTOS WHERE ID_PRODUTO =" + txtBusca.Text + " ";
            dt = control.ListarProdutos(sql);
            dt.Columns[0].ColumnName = "ID_PRODUTO";
            dt.Columns[1].ColumnName = "PRODUTO";
            dt.Columns[2].ColumnName = "DESCRIÇÃO";
            dt.Columns[3].ColumnName = "QUANTIDADE";
            dt.Columns[4].ColumnName = "PREÇO";
            dgvProdutos.DataSource = dt;            
        }

        private void txtBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 0)
            {
                e.Handled = true;
                MessageBox.Show("Fechar e abrir novamente a janela para consultar outro ID!");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Model.Control control = new Model.Control();
            if (control.mensagem.Equals(""))
            {
                if (!txtProduto.Text.Equals(""))
                {
                    if (!txtDescricao.Text.Equals(""))
                    {
                        if (!txtPreco.Text.Equals(""))
                        {
                            if (!txtQuantidade.Text.Equals(""))
                            {
                                control.AlterarProdutos(Convert.ToInt32(txtBusca.Text), txtProduto.Text, txtDescricao.Text, Convert.ToInt32(txtQuantidade.Text), Convert.ToDouble(txtPreco.Text));
                                MessageBox.Show("Produto alterado com Sucesso!");
                            }
                            else
                            {
                                MessageBox.Show("Produto faltando Quantidade!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Produto faltando Preço!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Produto faltando Descrição!");
                    }
                }
                else
                {
                    MessageBox.Show("Produto faltando Nome!");
                }
            }               
            else
            {
                MessageBox.Show(control.mensagem);
            }
        }
    }
}

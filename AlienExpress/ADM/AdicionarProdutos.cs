using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlienExpress.ADM
{
    public partial class AdicionarProdutos : Form
    {
        public AdicionarProdutos()
        {
            InitializeComponent();
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            if (!txtProduto.Text.Equals(""))
            {
                if (!txtDescricao.Text.Equals("")) 
                {
                    if (!txtPreco.Text.Equals(""))
                    {
                        if (!txtQuantidade.Text.Equals(""))
                        {
                            Model.Control control = new Model.Control();
                            control.CadastrarProduto(txtProduto.Text, txtDescricao.Text, Convert.ToInt32(txtQuantidade.Text), Convert.ToDouble(txtPreco.Text));
                            if (control.mensagem.Equals(""))
                            {

                            }
                            else
                            {
                                MessageBox.Show(control.mensagem);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Faltando Quantidade!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Faltando Preço!");
                    }
                }
                else
                {
                    MessageBox.Show("Faltando Descrição!");
                }
            }
            else
            {
                MessageBox.Show("Faltando Nome do Produto!");
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 188)
            {
                e.Handled = true;
            }
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 188)
            {
                e.Handled = true;
            }
        }
    }
}

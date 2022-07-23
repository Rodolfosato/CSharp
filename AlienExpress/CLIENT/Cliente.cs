using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlienExpress
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void cARTEIRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLIENT.Loja loja = new CLIENT.Loja();
            loja.ShowDialog();
        }

        private void cARRINHOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLIENT.Carrinho carrinho = new CLIENT.Carrinho();
            carrinho.ShowDialog();
        }
    }
}

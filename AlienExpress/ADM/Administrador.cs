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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void aDICIONARPRODUTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADM.AdicionarProdutos produtos = new ADM.AdicionarProdutos();
            produtos.ShowDialog();
        }

        private void lISTARPRODUTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADM.ListarProdutos listar = new ADM.ListarProdutos();
            listar.ShowDialog();
        }

        private void dELETARPRODUTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADM.EditarProdutos editar = new ADM.EditarProdutos();
            editar.ShowDialog();
        }

        private void eXCLUIRPRODUTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADM.ExcluirProduto excluir = new ADM.ExcluirProduto();
            excluir.ShowDialog();
        }
    }
}

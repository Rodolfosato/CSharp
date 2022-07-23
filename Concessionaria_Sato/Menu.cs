using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Concessionaria_Sato.Model;
using Concessionaria_Sato.Util;

namespace Concessionaria_Sato
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void fabricanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFabricante fabricante = new CadastroFabricante();
            fabricante.ShowDialog();
        }

        private void veiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarVeiculos veiculo = new CadastrarVeiculos();
            veiculo.ShowDialog();
        }

        private void veiculoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListarVeiculos listarveic = new ListarVeiculos();
            listarveic.ShowDialog();
        }

        private void fabricanteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FabricanteDAL.ListarFabricante listarfab = new FabricanteDAL.ListarFabricante();
            listarfab.ShowDialog();
        }

        private void fabricanteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FabricanteDAL.EditarFabricante editarfab = new FabricanteDAL.EditarFabricante();
            editarfab.ShowDialog();
        }

        private void veiculoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            VeiculoDAL.EditarVeiculos editarveic = new VeiculoDAL.EditarVeiculos();
            editarveic.ShowDialog();
        }

        private void fabricanteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FabricanteDAL.ExcluirFabricante excluirfab = new FabricanteDAL.ExcluirFabricante();
            excluirfab.ShowDialog();
        }

        private void veiculoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            VeiculoDAL.ExcluirVeiculos excluirveic = new VeiculoDAL.ExcluirVeiculos();
            excluirveic.ShowDialog();
        }
    }
}

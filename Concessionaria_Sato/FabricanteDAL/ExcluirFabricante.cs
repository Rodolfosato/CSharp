using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concessionaria_Sato.FabricanteDAL
{
    public partial class ExcluirFabricante : Form
    {
        public ExcluirFabricante()
        {
            InitializeComponent();
        }

        private void ExcluirFabricante_Load(object sender, EventArgs e)
        {
            Model.Fabricante fabricante = new Model.Fabricante();
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM FABRICANTE";
            dt = fabricante.Listar(sql);
            dt.Columns[0].ColumnName = "ID_FABRICANTE";
            dt.Columns[1].ColumnName = "FABRICANTE";
            dgvFabricante.DataSource = dt;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Model.Fabricante fabricante = new Model.Fabricante();
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM FABRICANTE WHERE ID_FABRICANTE = " + txtBuscar.Text + " ";
            dt = fabricante.Listar(sql);
            dt.Columns[0].ColumnName = "ID_FABRICANTE";
            dt.Columns[1].ColumnName = "FABRICANTE";
            dgvFabricante.DataSource = dt;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Model.Fabricante fabricante = new Model.Fabricante();
            if (txtBuscar.Text != null)
            {
                fabricante.ExcluirFabricante(Convert.ToInt32(txtBuscar.Text));
                MessageBox.Show("Fabricante excluido!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Favor digitar o Id a ser excluido!");
            }
        }
    }
}

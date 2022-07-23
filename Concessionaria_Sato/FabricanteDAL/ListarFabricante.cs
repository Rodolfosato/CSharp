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
    public partial class ListarFabricante : Form
    {
        public ListarFabricante()
        {
            InitializeComponent();
        }

        private void ListarFabricante_Load(object sender, EventArgs e)
        {
            Model.Fabricante fabricante = new Model.Fabricante();
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM FABRICANTE";
            dt = fabricante.Listar(sql);
            dt.Columns[0].ColumnName = "ID_FABRICANTE";
            dt.Columns[1].ColumnName = "FABRICANTE";
            dgvFabricante.DataSource = dt;
        }
    }
}

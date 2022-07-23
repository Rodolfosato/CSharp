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
    public partial class ListarProdutos : Form
    {
        public ListarProdutos()
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
    }
}

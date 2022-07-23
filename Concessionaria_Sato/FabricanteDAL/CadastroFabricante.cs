using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Concessionaria_Sato.Model;

namespace Concessionaria_Sato
{
    public partial class CadastroFabricante : Form
    {
        public CadastroFabricante()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Fabricante fabricante = new Fabricante();
                fabricante.fabricante = txtFabricante.Text;

                fabricante.Cadastrar();

                MessageBox.Show("Fabricante cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

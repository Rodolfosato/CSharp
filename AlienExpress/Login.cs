using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlienExpress.Util;

namespace AlienExpress
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroLogin cadastro = new CadastroLogin();
            this.Hide();
            cadastro.ShowDialog();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Model.Control control = new Model.Control();
            control.AcessarLogin(txtLogin.Text, txtSenha.Text);
            LoginDAOControl login = new LoginDAOControl();
            control.ADM(txtLogin.Text, txtSenha.Text);
            if (control.mensagem.Equals(""))
            {
                if (control.tem)
                {
                    if (control.adm == 2)
                    {
                        this.Hide();
                        Administrador administrador = new Administrador();
                        administrador.ShowDialog();
                    }
                    else if (control.adm == 1)
                    {
                        this.Hide();
                        Cliente cliente = new Cliente();
                        cliente.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Login ou senha incorreto ou não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(control.mensagem);
            }
        }
    }
}

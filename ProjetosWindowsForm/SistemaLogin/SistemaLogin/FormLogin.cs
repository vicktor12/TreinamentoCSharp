using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLogin
{
    public partial class FormLogin : Form
    {
        public static bool Cancel = false;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = boxUser.Text;
            string password = boxPassword.Text;

            if (user == "" || password == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                boxUser.Text = "";
                boxPassword.Text = "";
                boxUser.Focus();
                Close();
            } else
            {
                if (RegisterUser.Login(user, password))
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("Acesso Negado! Usuário ou Senha incorreto");
                    boxUser.Text = "";
                    boxPassword.Text = "";
                    boxUser.Focus();
                    Close();
                }
            }

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel = true;
            Close();
        }
    }
}

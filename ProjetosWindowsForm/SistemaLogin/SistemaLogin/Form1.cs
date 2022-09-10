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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void labelWelcome_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            
            while(RegisterUser.UserLogged == null)
            {
                Visible = false;
                login.ShowDialog();

                if(FormLogin.Cancel)
                {
                    Application.Exit();
                    return;
                }
            }
            labelWelcome.Text = "Seja bem vindo(a) \n " + RegisterUser.UserLogged.Name;
            Visible = true;
            
        }
    }
}

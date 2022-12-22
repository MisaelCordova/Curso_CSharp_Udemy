using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _84_ProjetoLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(btnLogin.Text == "Login")
            {
                if (txtUsuario.Text == "")
                    MessageBox.Show("Digite o nome do usuário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (txtUsuario.Text == "Misael")
                    {
                        if (mskSenha.Text == "")
                            MessageBox.Show("Digite a senha!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            if (mskSenha.Text == "1234")
                            {
                                MessageBox.Show("Usuário Logado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                lbllogin.Text = "Logado!";
                                lbllogin.ForeColor = Color.Green;
                                txtUsuario.Text = "";
                                mskSenha.Text = "";
                                btnLogin.Text = "Logout";
                            }
                            else
                            {
                                MessageBox.Show("Senha Incorreta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                        MessageBox.Show("Usuário incorreto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                lbllogin.Text = "Login!";
                lbllogin.ForeColor = Color.Black;
                txtUsuario.Text = "";
                mskSenha.Text = "";
                btnLogin.Text = "Login";
            }
          
        } 
    }
}

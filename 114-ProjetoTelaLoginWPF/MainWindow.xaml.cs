using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _114_ProjetoTelaLoginWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            psbSenha.Visibility = Visibility.Collapsed;
            txtSenha.Visibility = Visibility.Visible;
            txtSenha.Text = psbSenha.Password;
        }

        private void btnShow_MouseLeave(object sender, MouseEventArgs e)
        {
            txtSenha.Visibility = Visibility.Collapsed;
            psbSenha.Visibility = Visibility.Visible;
            txtSenha.Text = "";
        }

        private void btnEntrar_Click(object sender, RoutedEventArgs e)
        {
            if(btnEntrar.Content.ToString() == "Entrar")
            {
                if (txtusuario.Text == "Misael")
                {
                    if (psbSenha.Password == "123")
                    {
                        MessageBox.Show("Usuário logado com sucesso", "Erro", MessageBoxButton.OK, MessageBoxImage.Information);
                        btnEntrar.Content = "Sair";
                        btnEntrar.Background = new SolidColorBrush(Colors.Green);
                        psbSenha.Password = "";
                        MeuPrograma meuPrograma = new MeuPrograma();
                        meuPrograma.Show();
                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Usuário incorreto", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                }


            }
            else
            {
                btnEntrar.Content = "Entrar";
                btnEntrar.Background = new SolidColorBrush(Color.FromArgb(221, 221, 221, 221));
            }
           
        }
    }
}

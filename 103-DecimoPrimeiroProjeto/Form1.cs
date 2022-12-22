using CadastroBiblioteca;
using System.Windows.Forms;
namespace _103_DecimoPrimeiroProjeto
{
    public partial class Form1 : Form
    {
        BaseDeDados baseDeDados;

        public Form1()
        {
            InitializeComponent();
            baseDeDados = new BaseDeDados("BaseDeDados.xml");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroPessoa cadastroPessoa = new CadastroPessoa(txtNome.Text, txtNumeroDocumento.Text, Convert.ToDateTime(txtDataNascimento.Text), txtNomeRua.Text, Convert.ToUInt32(txtNumeroCasa.Text));
            baseDeDados.AdicionaPessoa(cadastroPessoa);
            MessageBox.Show("Usuário cadastrado com sucesso", "Cadastro Concluído");
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            List<CadastroPessoa> listaPessoas = baseDeDados.PesquisaPessoaPorDoc(txtBusca.Text);
            if(listaPessoas !=null & listaPessoas.Count > 0)
            {
                lblNome.Text = listaPessoas[0].Nome;
                lblDataNascimento.Text = listaPessoas[0].DataNasci.ToString();
                lblNomeRua.Text = listaPessoas[0].NomeDarua;
                lblNumeroCasa.Text = listaPessoas[0].NumeroDaCasa.ToString();

            }
            else
            {
                MessageBox.Show("Usuário não localizado", "Exceção");
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            List<CadastroPessoa> listaPessoas = baseDeDados.RemoverPessoaPorDoc(txtBusca.Text);
            if (listaPessoas != null & listaPessoas.Count > 0)
            {
                lblNome.Text = listaPessoas[0].Nome;
                lblDataNascimento.Text = listaPessoas[0].DataNasci.ToString();
                lblNomeRua.Text = listaPessoas[0].NomeDarua;
                lblNumeroCasa.Text = listaPessoas[0].NumeroDaCasa.ToString();
                MessageBox.Show("Usuário Removido com Sucesso", "Usuário removido");
            }
            else
            {
                MessageBox.Show("Usuário não localizado", "Exceção");
            }
        }
    }
}
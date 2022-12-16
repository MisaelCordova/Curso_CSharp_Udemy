using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57_NonoProjeto
{

    internal class InterfaceGrafica
    {
        public enum Resultado_e
        {
            Successo = 0,
            Sair = 1,
            Excecao = 2,
        }
        public void MostraMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        public Resultado_e PegaString(ref string minhaString, string mensagem)
        {
            Resultado_e retorno;
            Console.WriteLine(mensagem);
            string temp = Console.ReadLine();
            if (temp == "S" || temp == "s")
                retorno = Resultado_e.Sair;
            else
            {
                minhaString = temp;
                retorno = Resultado_e.Successo;

            }
            Console.Clear();
            return retorno;
        }
        public Resultado_e PegaData(ref DateTime data, string mensagem)
        {
            Resultado_e retorno;
            do
            {
                try
                {
                    Console.WriteLine(mensagem);
                    string temp = Console.ReadLine();
                    if (temp == "s" || temp == "S")
                    {
                        retorno = Resultado_e.Sair;
                    }
                    else
                    {
                        data = Convert.ToDateTime(temp);
                        retorno = Resultado_e.Successo;
                    }
                }
                catch (Exception e)
                {
                    MostraMensagem("EXECEÇAO" + e.Message);
                    retorno = Resultado_e.Excecao;
                }
            } while (retorno == Resultado_e.Excecao);
            Console.Clear();
            return retorno;
        }
        public Resultado_e PegaUInt(ref UInt32 numero, string mensagem)
        {
            Resultado_e retorno;
            do
            {
                try
                {
                    Console.WriteLine(mensagem);
                    string temp = Console.ReadLine();
                    if (temp == "s" || temp == "S")
                    {
                        retorno = Resultado_e.Sair;
                    }
                    else
                    {
                        numero = Convert.ToUInt32(temp);
                        retorno = Resultado_e.Successo;
                    }
                }
                catch (Exception e)
                {
                    MostraMensagem("EXECEÇAO" + e.Message);
                    retorno = Resultado_e.Excecao;
                }
            } while (retorno == Resultado_e.Excecao);
            Console.Clear();
            return retorno;
        }
        BaseDeDados baseDeDados;
        public InterfaceGrafica(BaseDeDados baseDeDados)
        {
            this.baseDeDados = baseDeDados;
        }
        //metodos novos
        public void ImprimeDadosNaTela(CadastroPessoa pessoa)
        {
            Console.WriteLine("Nome: " + pessoa.Nome);
            Console.WriteLine("Número do documento: " + pessoa.NumeroDoDocumento);
            Console.WriteLine("Data de Nascimento: " + pessoa.DataNasci);
            Console.WriteLine("Nome da Rua: " + pessoa.NomeDarua);
            Console.WriteLine("Número da Casa: " + pessoa.NumeroDaCasa);
            Console.WriteLine("");
        }
        public void ImprimeDadosNaTela(List<CadastroPessoa> listaDePessoas)
        {
            foreach(CadastroPessoa pessoa in listaDePessoas) 
            {
                ImprimeDadosNaTela(pessoa);
            }
        }
        public Resultado_e CadastraUsuario()
        {
            Console.Clear();
            string Nome = "";
            DateTime DataDeNasc = new DateTime();
            string NumeroDoDocumento = "";
            string NomeDaRua = "";
            UInt32 NumeroDaCasa = 0;

            if (PegaString(ref Nome, "Digite o nome completo ou digite S para sair") == Resultado_e.Sair)
                return Resultado_e.Sair;
            if (PegaData(ref DataDeNasc, "Digite a data de nascimento no formato DD/MM/AAAA ou S para sair") == Resultado_e.Sair)
                return Resultado_e.Sair;
            if (PegaString(ref NumeroDoDocumento, "Digite o número do documento ou digite S para sair") == Resultado_e.Sair)
                return Resultado_e.Sair;
            if (PegaString(ref NomeDaRua, "Digite o nome da rua ou digite S para sair") == Resultado_e.Sair)
                return Resultado_e.Sair;

            if (PegaUInt(ref NumeroDaCasa, "Digite o numero da casa ou digite S para sair") == Resultado_e.Sair)
                return Resultado_e.Sair;
            CadastroPessoa cadastroPessoa = new CadastroPessoa(Nome, NumeroDoDocumento, DataDeNasc, NomeDaRua, NumeroDaCasa);
            baseDeDados.AdicionaPessoa(cadastroPessoa);
            Console.Clear();
            Console.WriteLine("Adicionando usuário: ");
            ImprimeDadosNaTela(cadastroPessoa);
            MostraMensagem("");
            return Resultado_e.Successo;
        }

        public void BuscaUsuario()
        {
            Console.Clear();
            Console.WriteLine("Digite o número do documento para busca o usuário ou digite S para sair");
            string temp = Console.ReadLine();
            if(temp.ToLower() == "s")
                return;

            List<CadastroPessoa> listaDePessoaTemp = baseDeDados.PesquisaPessoaPorDoc(temp);
            Console.Clear();
            if (listaDePessoaTemp != null)
            {
                Console.WriteLine("Usuário(s) com documento " + temp + " encontrado(s)");
                ImprimeDadosNaTela(listaDePessoaTemp);
            }
            else
                Console.WriteLine("Nenhum usuário com o documento " + temp + "foi encontrado.");

            MostraMensagem("");
        }
        public void RemoveUsuario()
        {
            Console.Clear();
            Console.WriteLine("Digite o número do documento para remover o usuário ou digite S para sair");
            string temp = Console.ReadLine();
            if (temp.ToLower() == "s")
                return;

            List<CadastroPessoa> listaDePessoaTemp = baseDeDados.RemoverPessoaPorDoc(temp);
            Console.Clear();
            if (listaDePessoaTemp != null)
            {
                Console.WriteLine("Usuário(s) com documento " + temp + " removido(s)");
                ImprimeDadosNaTela(listaDePessoaTemp);
            }
            else
                Console.WriteLine("Nenhum usuário com o documento " + temp + " foi encontrado.");

            MostraMensagem("");
        }
        public void Sair()
        {
            Console.Clear();
            MostraMensagem("Encerrando o programa");
        }
        public void OpcaoDesconhecida()
        {
            Console.Clear();
            MostraMensagem("Opção desconhecida");
        }
        public void IniciaInterface()
        {
            string temp;
            do
            {
                Console.WriteLine("Digite C para cadastrar um novo usuário.");
                Console.WriteLine("Digite B para busca um usuário pelo número do documento");
                Console.WriteLine("Digite H para mostrar a data e a hora");
                Console.WriteLine("Digite R pra remover um usuário pelo número do documento");
                Console.WriteLine("Digite S para Sair");
                temp = Console.ReadKey(true).KeyChar.ToString().ToLower();
                switch (temp)
                {
                    case "c":
                        if (baseDeDados.BaseDisponivel() ==false)
                        {
                            MostraMensagem("Base Indisponivel tente novamente em alguns instantes");
                            break;
                        }
                        CadastraUsuario();
                        break;
                    case "b":
                        BuscaUsuario();
                        break;
                    case "r":
                        RemoveUsuario();
                        break;
                    case "h":
                      //  RemoveUsuario();
                      MostraMensagem(DateTime.Now.ToString());
                        break;
                    case "s":
                        Sair();
                        break;
                    default:
                        OpcaoDesconhecida();
                        break;
                }
            } while (temp != "s");
        }
    }

}

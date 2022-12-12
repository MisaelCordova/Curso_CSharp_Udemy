using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace _39_SextoProjeto
{
    internal class Program
    {
        static string delimitadorInicio;
        static string delimitadorFim;
        static string tagNome;
        static string tagDataNasc;
        static string tagNomeFim;
        static string tagNomeDaRua;
        static string tagNumeroDaCasa;

        public struct DadosCadastraisStruct
        {
            public string Nome;
            public DateTime DataDeNasc;
            public string NomeDaRua;
            public UInt32 NumeroDaCasa;

        }
        public enum Resultado_e
        {
            Successo = 0,
            Sair = 1,
            Excecao = 2,
        }
        public static  Resultado_e PegaString(ref string minhaString, string mensagem)
        
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
        public static Resultado_e PegaData(ref DateTime data, string mensagem)
        {
            Resultado_e retorno;
            do
            {
                try
                {
                    Console.WriteLine(mensagem);
                    string temp = Console.ReadLine();
                    if(temp == "s" || temp == "S")
                    {
                        retorno = Resultado_e.Sair;
                    }
                    else
                    {
                        data = Convert.ToDateTime(temp);
                        retorno = Resultado_e.Successo;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("EXECEÇAO" + e.Message);
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    retorno = Resultado_e.Excecao;
                }
            }while( retorno == Resultado_e.Excecao);
            Console.Clear();
            return retorno;

        }
        public static Resultado_e PegaUInt(ref UInt32 numero, string mensagem)
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
                    Console.WriteLine("EXECEÇAO" + e.Message);
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    retorno = Resultado_e.Excecao;
                }
            } while (retorno == Resultado_e.Excecao);
            Console.Clear();
            return retorno;

        }
      
        public static void MostraMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        public static Resultado_e CadastraUsuario(ref List<DadosCadastraisStruct> ListaDeUsuario)
        {
            DadosCadastraisStruct cadastroUsuario;
            cadastroUsuario.Nome = "";
            cadastroUsuario.DataDeNasc = new DateTime();
            cadastroUsuario.NomeDaRua = "";
            cadastroUsuario.NumeroDaCasa = 0;
            if (PegaString(ref cadastroUsuario.Nome, "Digite o nome completo ou digite S para sair") == Resultado_e.Sair)
                return Resultado_e.Sair;
            if(PegaData(ref cadastroUsuario.DataDeNasc,"Digite a data de nascimento no formato DD/MM/AAAA ou S para sair")==Resultado_e.Sair) 
                return Resultado_e.Sair;
            if (PegaString(ref cadastroUsuario.NomeDaRua, "Digite o nome da rua ou digite S para sair")== Resultado_e.Sair) 
                return Resultado_e.Sair;
            if(PegaUInt(ref cadastroUsuario.NumeroDaCasa, "Digite o numero da casa ou digite S para sair") == Resultado_e.Sair)
                return Resultado_e.Sair;
            ListaDeUsuario.Add(cadastroUsuario);
            return Resultado_e.Successo;
        }
        public static void GravaDados(string caminho, List<DadosCadastraisStruct> ListaDeUsuarios)
        {
            try
            {
                string conteudoArquivo = "";
                foreach(DadosCadastraisStruct cadastro in ListaDeUsuarios)
                {
                    conteudoArquivo += delimitadorInicio + "\r\n";
                    conteudoArquivo += tagNome + cadastro.Nome + "\r\n";
                    conteudoArquivo += tagDataNasc + cadastro.DataDeNasc.ToString("dd/MM/yyyy") + "\r\n";
                    conteudoArquivo += tagNomeDaRua + cadastro.NomeDaRua + "\r\n";
                    conteudoArquivo += tagNumeroDaCasa + cadastro.NumeroDaCasa + "\r\n";
                    conteudoArquivo += delimitadorFim + "\r\n";
                }
                File.WriteAllText(caminho, conteudoArquivo);
            }
         
            catch(Exception e)
            {
                Console.WriteLine("EXCEÇÃO: " + e.Message) ;
            }   
        }
        public static void CarregaDados(string caminho, ref List<DadosCadastraisStruct> ListDeUsuarios)
        {
            try
            {
                if(File.Exists(caminho)) 
                {
                    string[] conteudoArquivo = File.ReadAllLines(caminho);
                    DadosCadastraisStruct dadosCadastrais;
                    dadosCadastrais.Nome = "";
                    dadosCadastrais.DataDeNasc = new DateTime(0);
                    dadosCadastrais.Nome = "";
                    dadosCadastrais.NomeDaRua = "";
                    dadosCadastrais.NumeroDaCasa = 0;

                    foreach(string linha in conteudoArquivo)
                    {
                        if (linha.Contains(delimitadorInicio)) 
                            continue;
                        if (linha.Contains(delimitadorFim))
                            ListDeUsuarios.Add(dadosCadastrais);
                        if (linha.Contains(tagNome))
                            dadosCadastrais.Nome = linha.Replace(tagNome, "");
                        if (linha.Contains(tagDataNasc))
                            dadosCadastrais.DataDeNasc = Convert.ToDateTime(linha.Replace(tagDataNasc, ""));
                        if (linha.Contains(tagNomeDaRua))
                            dadosCadastrais.NomeDaRua = linha.Replace(tagNomeDaRua, "");
                        if (linha.Contains(tagNumeroDaCasa))
                            dadosCadastrais.NumeroDaCasa = Convert.ToUInt32(linha.Replace(tagNumeroDaCasa, ""));



                    }

                }
            }
            catch(Exception e) 
            {
                Console.WriteLine("EXCECAO: "+e.Message);
            }
        }
        static void Main(string[] args)
        {
            List<DadosCadastraisStruct> ListaDeUsuarios = new List<DadosCadastraisStruct>();
            string opcao = "";
            delimitadorInicio = "### INICIO ###";
            delimitadorInicio = "### FIM ###";
            tagNome = "NOME: ";
            tagDataNasc = "DATA_DE_NASCIMENTO: ";
            tagNomeDaRua = "NOME_DA_RUA: ";
            tagNumeroDaCasa = "NUMERO_DA_CASA";
            string caminhoArquivo = @"baseDeDados.txt";

            CarregaDados(caminhoArquivo, ref ListaDeUsuarios);


            do
            {
                Console.WriteLine("Digite C para cadastrar um novo usuário ou S para sair");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();
                
                if (opcao == "c")
                {
                    
                    if (CadastraUsuario(ref ListaDeUsuarios) == Resultado_e.Successo)
                         GravaDados(caminhoArquivo, ListaDeUsuarios);
                 
                         

                }
                else if (opcao == "s")
                {
                    MostraMensagem("Encerrando o programa");
                }
                else
                {
                    MostraMensagem("Opção não reconhecida");
                }
            } while (opcao != "s");
        
        }
    }
}

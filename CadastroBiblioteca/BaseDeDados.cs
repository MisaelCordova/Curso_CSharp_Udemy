using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Threading;
using CadastroBiblioteca;

namespace CadastroBiblioteca
{
    [DataContract]
    public class BaseDeDados
    {
        [DataMember]
        private List<CadastroPessoa> ListaDePessoas;
        private string caminhoBaseDeDados;
        private Mutex mutexArquivo;
        private Mutex mutexLista;
        private bool baseDisponivel;


        public void AdicionaPessoa(CadastroPessoa pessoa)
        {
            mutexLista.WaitOne();
            ListaDePessoas.Add(pessoa);
            mutexLista.ReleaseMutex();
            new Thread(() =>
            {
                baseDisponivel = false;
                mutexArquivo.WaitOne();
                Serializador.Serializa(caminhoBaseDeDados, this);
                mutexArquivo.ReleaseMutex();
                baseDisponivel = true;
            }).Start();

        }
        public List<CadastroPessoa> PesquisaPessoaPorDoc(string numeroDeDocumento)
        {
            mutexLista.WaitOne();
            List<CadastroPessoa> ListaDePessoasTemp = ListaDePessoas.Where(x => x.NumeroDoDocumento == numeroDeDocumento).ToList();
            mutexLista.ReleaseMutex();

            if (ListaDePessoasTemp.Count > 0)
                return ListaDePessoasTemp;
            else
            {
                return null;
            }
        }
        public List<CadastroPessoa> RemoverPessoaPorDoc(string numeroDeDocumento)
        {
            mutexLista.WaitOne();
            List<CadastroPessoa> ListaDePessoasTemp = ListaDePessoas.Where(x => x.NumeroDoDocumento == numeroDeDocumento).ToList();
            mutexLista.ReleaseMutex();
            if (ListaDePessoasTemp.Count > 0)
            {
                foreach (CadastroPessoa pessoa in ListaDePessoasTemp)
                {
                    baseDisponivel = false;
                    mutexLista.WaitOne();
                    ListaDePessoas.Remove(pessoa);
                    mutexLista.ReleaseMutex();
                    baseDisponivel = true;
                }
                new Thread(() =>
                {
                    mutexArquivo.WaitOne();
                    Serializador.Serializa(caminhoBaseDeDados, this);
                    mutexArquivo.ReleaseMutex();
                }).Start();
                return ListaDePessoasTemp;
            }
            else
            {

                return null;
            }
        }
        public bool BaseDisponivel()
        {
            return baseDisponivel;
        }
        public BaseDeDados(string caminhoBaseDeDados)
        {
            this.caminhoBaseDeDados = caminhoBaseDeDados;
            mutexLista = new Mutex();
            mutexArquivo = new Mutex();
            baseDisponivel = true;
            new Thread(() =>
            {
                baseDisponivel = false;
                mutexArquivo.WaitOne();
                BaseDeDados baseDeDadostemp = Serializador.Desserializa(caminhoBaseDeDados);
                mutexArquivo.ReleaseMutex();
                mutexLista.WaitOne();
                if (baseDeDadostemp != null)
                    ListaDePessoas = baseDeDadostemp.ListaDePessoas;
                else
                    ListaDePessoas = new List<CadastroPessoa>();
                mutexLista.ReleaseMutex();
                baseDisponivel = true;
            }).Start();



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using _50_OitavoProjeto;

namespace _57_NonoProjeto
{
    [DataContract]
    internal class BaseDeDados
    {
        [DataMember]
        private List<CadastroPessoa> ListaDePessoas;
        private string caminhoBaseDeDados;

        public void AdicionaPessoa(CadastroPessoa pessoa)
        {
            ListaDePessoas.Add(pessoa);
            Serializador.Serializa(caminhoBaseDeDados, this);
        }
        public List<CadastroPessoa> PesquisaPessoaPorDoc(string numeroDeDocumento)
        {
            List<CadastroPessoa> ListaDePessoasTemp = ListaDePessoas.Where(x=>x.NumeroDoDocumento== numeroDeDocumento).ToList();

            if(ListaDePessoasTemp.Count>0)
                return ListaDePessoasTemp;
            else
            {
                return null;
            }
        }
        public  List<CadastroPessoa> RemoverPessoaPorDoc(string numeroDeDocumento) 
        {
            List<CadastroPessoa> ListaDePessoasTemp = ListaDePessoas.Where(x=>x.NumeroDoDocumento == numeroDeDocumento).ToList();
            if (ListaDePessoasTemp.Count > 0) 
            {
                foreach (CadastroPessoa pessoa in ListaDePessoasTemp)
                {
                    ListaDePessoas.Remove(pessoa);
                }
                return ListaDePessoasTemp;
            }
                
            else
            {
            
                return null;
            }
        }
        public BaseDeDados(string caminhoBaseDeDados)
        {
            this.caminhoBaseDeDados = caminhoBaseDeDados;
            BaseDeDados baseDeDadostemp = Serializador.Desserializa(caminhoBaseDeDados);
            if(baseDeDadostemp != null)
            {
                ListaDePessoas = baseDeDadostemp.ListaDePessoas;
            }
            else
            {
                ListaDePessoas = new List<CadastroPessoa>();
            }
           
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50_OitavoProjeto
{
    internal class BaseDeDados
    {
        private List<CadastroPessoa> ListaDePessoas;

        public void AdicionaPessoa(CadastroPessoa pessoa)
        {
            ListaDePessoas.Add(pessoa);
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
        public BaseDeDados()
        {
            ListaDePessoas = new List<CadastroPessoa>();
        }
    }
}

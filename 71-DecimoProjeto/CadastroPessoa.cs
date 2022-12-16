using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace _57_NonoProjeto
{
    [DataContract]
    internal class CadastroPessoa
    {

        [DataMember]
        private string nome;
        [DataMember]
        private string numeroDoDocumento;
        [DataMember]
        private DateTime dataNasci;
        [DataMember]
        private string nomeDarua;
        [DataMember]
        private UInt32 numeroDaCasa;

        public CadastroPessoa(string nome, string numeroDoDocumento, DateTime dataNasci, string nomeDarua, uint numeroDaCasa)
        {
            this.nome = nome;
            this.numeroDoDocumento = numeroDoDocumento;
            this.dataNasci = dataNasci;
            this.nomeDarua = nomeDarua;
            this.numeroDaCasa = numeroDaCasa;
        }

        public string Nome { get => nome; set => nome = value; }
        public string NumeroDoDocumento { get => numeroDoDocumento; set => numeroDoDocumento = value; }
        public DateTime DataNasci { get => dataNasci; set => dataNasci = value; }
        public string NomeDarua { get => nomeDarua; set => nomeDarua = value; }
        public uint NumeroDaCasa { get => numeroDaCasa; set => numeroDaCasa = value; }
    }
}

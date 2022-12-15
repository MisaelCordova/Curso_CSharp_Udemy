using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml;
using System.IO;
using _57_NonoProjeto;

namespace _50_OitavoProjeto
{
    internal static class Serializador
    {
        static private DataContractSerializer serializador = new DataContractSerializer(typeof(BaseDeDados));
        public static void Serializa(string caminhoArquivoXml, BaseDeDados baseDeDados)
        {
            XmlWriterSettings xmlConfig = new XmlWriterSettings { Indent = true };
            StringBuilder construtorDeString = new StringBuilder();
            XmlWriter  escritorDeXml = XmlWriter.Create(construtorDeString, xmlConfig);
            serializador.WriteObject(escritorDeXml, baseDeDados);
            escritorDeXml.Flush();
            string objetoSerializadoString = construtorDeString.ToString();

            FileStream meuArquivoXml = File.Create(caminhoArquivoXml);
            meuArquivoXml.Close();
            File.WriteAllText(caminhoArquivoXml, objetoSerializadoString);
            escritorDeXml.Close();
        }
        public static BaseDeDados Desserializa(string caminhoArquivoXml)
        {
            try
            {
                if (File.Exists(caminhoArquivoXml))
                {
                    string conteudoDoObjetoSerializado = File.ReadAllText(caminhoArquivoXml);
                    StringReader leitorDeString = new StringReader(conteudoDoObjetoSerializado);
                    XmlReader leitorDeXml = XmlReader.Create(leitorDeString);
                    BaseDeDados baseDeDadosTemp = (BaseDeDados)serializador.ReadObject(leitorDeXml);
                    return baseDeDadosTemp;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }
    }
   
}

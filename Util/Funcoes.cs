using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public static class Funcoes
    {
        /// <summary>
        /// Apresenta o primeiro e último nome de um nome inserido
        /// </summary>
        /// <param name="nomeCompleto">Nome completo da pessoa</param>
        /// <returns>O primeiro e o último nome</returns>
        public static string NomeCurto(string nomeCompleto)
        {
            string primParteNome = nomeCompleto.Substring(0, nomeCompleto.IndexOf(" "));
            string ultParteNome = nomeCompleto.Substring(nomeCompleto.LastIndexOf(" ") + 1);

            return String.Concat(primParteNome, " ", ultParteNome);
        }

        public static string Email(string nomeCompleto)
        {
            return nomeCompleto.Substring(0, nomeCompleto.IndexOf(" ")).ToLower() + "." + nomeCompleto.Substring(nomeCompleto.LastIndexOf(" ") + 1).ToLower() + "@xpto.pt";
        }

        public static string EmailAlternativo(string nomeCompleto)
        {
            return nomeCompleto.Substring(0, 1).ToLower() + nomeCompleto.Substring(nomeCompleto.LastIndexOf(" ") + 1).ToLower() + "@xpto.pt";
        }

        /// <summary>
        /// Remove os espaços a mais dentro de uma string
        /// </summary>
        /// <param name="frase">string a ser analisada</param>
        /// <returns>Uma string já sem os espaços a mais</returns>
        public static string RetiraEspacos(string frase)
        {
            string strAux = frase.Trim(); //instanciamos uma string auxiliar à nossa frase e removemos os espaços no início e no fim
            string[] arr = new string[frase.Length]; //instanciamos um array para copiarmos o que queremos
            string novaFrase = "";            

            for (int i = 0; i < strAux.Length; i++)
            { //percorremos o o array com a nossa frase
                if (Char.IsWhiteSpace(strAux[i])) // se o caracter for um espaço
                {
                    if (!Char.IsWhiteSpace(strAux[i - 1])) // se o caracter anterior não for um espaço
                    {
                        arr[i] = strAux[i].ToString(); // copiamos para o nosso array
                    }
                }
                else
                { // se não for um espaço
                    arr[i] = strAux[i].ToString(); //copiamos para o nosso array
                }
            }

            foreach (string c in arr) // percorremos o nosso array e criamos a nova frase a sermos devolvida
            {
                novaFrase = novaFrase + c;
            }

            return novaFrase;
        }

        /// <summary>
        /// Substitui caracteres especiais por outros dados previamente
        /// </summary>
        /// <param name="frase">String a analisar</param>
        /// <returns>String com os caracteres alterados</returns>
        public static string Substitui(string frase)
        {
            Dictionary<string, string> dicionario = new Dictionary<string, string>(); // inicializa um dicionário
            string auxStr = frase; // instancia uma string com a frase a analisar

            dicionario.Add("ã", "a"); // adiciona um par de chave-valor no dicionário
            dicionario.Add("à", "a");
            dicionario.Add("á", "a");
            dicionario.Add("â", "a");
            dicionario.Add("é", "e");
            dicionario.Add("ê", "e");
            dicionario.Add("ó", "o");
            dicionario.Add("ô", "o");
            dicionario.Add("õ", "o");
            dicionario.Add("ç", "c");

            foreach (KeyValuePair<String, String> entry in dicionario) // percorre o dicionário
            {
                if (auxStr.Contains(entry.Key)) // se a string contém a "chave"
                {
                    auxStr = auxStr.Replace(entry.Key, entry.Value); // substitui pelo respetivo valor
                }
            }

            return auxStr;
        }
    }
}

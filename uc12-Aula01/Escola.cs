using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uc12_Aula01
{
    public class Escola
    {
        private String cnpj;
        public String nome;
        public String endereco;


        public Escola() { }
        public Escola(String nome, String cnpj, String endereco)
        {
            this.nome = nome;

            if (ValidaCNPJ(cnpj))
            {
                this.cnpj = this.limpaCnpj(cnpj);
            }
            this.endereco = endereco;
        }
        public String getCnpj()
        {

            return Convert.ToUInt64(this.cnpj).
                ToString(@"00\.000\.000/0000\-00");
        }               // 03 .709 .814/0001 -98
        public Boolean setCnpj(String cnpj)
        {
            this.cnpj = this.limpaCnpj(cnpj);
            return true;
        }
        private String limpaCnpj(String cnpj)
        {
            return String.Join("", System.Text.RegularExpressions.Regex.Split(cnpj, @"[^\d]"));
        }
        public bool ValidaCNPJ(string vrCNPJ)
        {
            string CNPJ = vrCNPJ.Replace(".", "");
            CNPJ = CNPJ.Replace("/", "");
            CNPJ = CNPJ.Replace("-", "");
            int[] digitos, soma, resultado;
            int nrDig;
            string ftmt;
            bool[] CNPJOk;
            ftmt = "6543298765432";
            digitos = new int[14];
            soma = new int[2];
            soma[0] = 0;
            soma[1] = 0;
            resultado = new int[2];
            resultado[0] = 0;
            resultado[1] = 0;
            CNPJOk = new bool[2];
            CNPJOk[0] = false;
            CNPJOk[1] = false;
            try
            {
                for (nrDig = 0; nrDig < 14; nrDig++)
                {
                    digitos[nrDig] = int.Parse(
                    CNPJ.Substring(nrDig, 1));
                    if (nrDig <= 11)
                        soma[0] += (digitos[nrDig] *
                        int.Parse(ftmt.Substring(
                        nrDig + 1, 1)));
                    if (nrDig <= 12)
                        soma[1] += (digitos[nrDig] *
                        int.Parse(ftmt.Substring(
                        nrDig, 1)));
                }
                for (nrDig = 0; nrDig < 2; nrDig++)
                {
                    resultado[nrDig] = (soma[nrDig] % 11);
                    if ((resultado[nrDig] == 0) || (
                    resultado[nrDig] == 1))
                        CNPJOk[nrDig] = (
                        digitos[12 + nrDig] == 0);
                    else
                        CNPJOk[nrDig] = (
                        digitos[12 + nrDig] == (
                        11 - resultado[nrDig]));
                }
                return (CNPJOk[0] && CNPJOk[1]);
            }
            catch
            {
                return false;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uc12_Aula01
{
    public class Pessoa
    {
        public string Nome;
        public DateTime nascimento { get; set; }
        public string Cpf { get; set; }
public string rg { get; set; }
public string NomeSocial { get; set; }
        public String religiao { get; set; }
        public String partidoPolitico { get; set; }
        public Boolean oncologico { get; set; }
        public Boolean soroPositivo { get; set; }
        public Pessoa() { }
        public Pessoa(string nome, DateTime nascimento, string cpf, string rg, string religiao, string partidoPolitico, bool oncologico, bool soroPositivo)
        {
            this.Nome = nome;
            this.nascimento = nascimento;
            this.Cpf = cpf;
            this.rg = rg;
            this.religiao = religiao;
            this.partidoPolitico = partidoPolitico;
            this.oncologico = oncologico;
            this.soroPositivo = soroPositivo;
        }
        public string getNome()
        {
            return this.Nome;
        }
        public bool setNome(String nome)
        {
            this.Nome = nome;
            return true;
        }
        public String getCPF()
        {
            return this.Cpf;
        }
        public Boolean setCPF(string cpf)
        {
            this.Cpf = cpf;
            return true;
        }
        public DateTime getNascimento()
        {
            return this.nascimento;
        }
        public bool setNascimento(DateTime nascimento)
        {
            this.nascimento = nascimento;
            return true;
        }
        public string getRG()
        {
            return this.rg;
        }
        public bool setRG(string rg)
        {
            this.rg = rg;
            return true;
        }
        public string getReligiao()
        {
            return this.religiao;
        }
        public bool setReligiao(String religiao)
        {
            this.religiao = religiao;
            return true;
        }
        public string getPartido()
        {
            return this.partidoPolitico;
        }
        public bool setPartido(String partidoPolitico)
        {
            this.partidoPolitico = partidoPolitico;
            return true;
        }
        public bool getOncologico()
        {
            return this.oncologico;
        }
        public bool setOncologico(bool oncologico)
        {
            this.oncologico = oncologico;
            return true;
        }
        public bool getSoroPositivo()
        {
            return this.soroPositivo;
        }
        public bool setSoroPositivo(bool soroPositivo)
        {
            this.soroPositivo = soroPositivo;
            return true;
        }

    }
}

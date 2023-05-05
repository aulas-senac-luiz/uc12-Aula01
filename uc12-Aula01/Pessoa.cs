using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uc12_Aula01
{
    class Pessoa
    {
        private string nome;
        private DateTime nascimento;
        private string cpf;
        private string rg;
        private String religiao;
        private String partidoPolitico;
        private Boolean oncologico;
        private Boolean soroPositivo;
        public Pessoa() { }
        public Pessoa(string nome, DateTime nascimento, string cpf, string rg, string religiao, string partidoPolitico, bool oncologico, bool soroPositivo)
        {
            this.nome = nome;
            this.nascimento = nascimento;
            this.cpf = cpf;
            this.rg = rg;
            this.religiao = religiao;
            this.partidoPolitico = partidoPolitico;
            this.oncologico = oncologico;
            this.soroPositivo = soroPositivo;
        }

    }
}

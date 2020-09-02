using System;
using digBank.contratos;

namespace digBank.classes
{
    public class Pessoa
    {
        public Pessoa()
        {
            this.Id = Guid.NewGuid();
        }
        public string nome { get; private set; }
        public string cpf { get;  private set; }
        public string senha { get; private set; }
        public Guid Id { get; set; }
        //public iConta conta { get; set; }

        public void setNome(string nome)
        {
            this.nome = nome; 
        }

        public void setCpf(string cpf)
        {
            this.cpf = cpf;

        }
        public void setSenha(string senha)
        {
            this.senha = senha;
        }
        public void setId()
        {
            this.Id = Guid.NewGuid();
        }


    }
}

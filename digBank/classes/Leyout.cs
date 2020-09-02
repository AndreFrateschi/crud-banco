using System;
using System.Collections.Generic;

namespace digBank.classes
{
    public class Layout
    {
        private static Pessoa pessoa = new Pessoa();
  
        public Pessoa Inserir()
        {
            Console.Clear();
            Console.WriteLine("            BANK OF AMERICA             ");
            Console.WriteLine("                                        ");
            Console.WriteLine("     DIGITE O SEU NOME:                 ");
            string nome = Console.ReadLine();
            Console.WriteLine("    |||||||||||||||||||||||||           ");
            Console.WriteLine("     DIGITE O SEU CPF:                  ");
            string cpf = Console.ReadLine();
            Console.WriteLine("    |||||||||||||||||||||||||           ");
            Console.WriteLine("     DIGITE A SUA SENHA:                ");
            string senha = Console.ReadLine();
            Console.WriteLine("    |||||||||||||||||||||||||           ");

            //criar conta do usuario

            contaCorrente contaCorrente = new contaCorrente();

            pessoa.setNome(nome);
            pessoa.setCpf(cpf);
            pessoa.setSenha(senha);
            //pessoa.setId();
            //pessoa.conta = contaCorrente;

            return pessoa;

        }


        public string ConsultaPorNomePessoa()
        {
            Console.Clear();
            Console.WriteLine("            BANK OF AMERICA             ");
            Console.WriteLine("                                        ");
            Console.WriteLine(" DIGITE O NOME DA PESSOA PARA A PESQUISA");
            string nome = Console.ReadLine();

            return nome;

        }


        public Pessoa TelaInicial()
        {
            Console.Clear();
            Console.WriteLine("            BANK OF AMERICA             ");
            Console.WriteLine("                                        ");
            Console.WriteLine("     DIGITE A OPCAO DESEJADA            ");
            Console.WriteLine("    |||||||||||||||||||||||||           ");
            Console.WriteLine("      1 = CRIAR CONTA                   ");
            Console.WriteLine("    |||||||||||||||||||||||||           ");
            Console.WriteLine("      2 = ALTERAR DADOS DE PESSOA       ");
            Console.WriteLine("    |||||||||||||||||||||||||           ");
            Console.WriteLine("      3 = CONSULTA DADOS DA PESSOA      ");
            Console.WriteLine("    |||||||||||||||||||||||||           ");
            Console.WriteLine("      4 = EXCLUIR PESSOA                ");
            Console.WriteLine("    |||||||||||||||||||||||||           ");

            return pessoa;
        }


        public Pessoa Atualizar()
        {
            Console.Clear();
            Console.WriteLine("            BANK OF AMERICA             ");
            Console.WriteLine(" PESSOA ENCONTADA, ALTERAR DADOS ABAIXO ");
            Console.WriteLine("                ALTERAR                 ");
            Console.WriteLine("                                        ");
            Console.WriteLine("     DIGITE NOVO NOME                   ");
            string nome = Console.ReadLine();
            Console.WriteLine("    |||||||||||||||||||||||||           ");
            Console.WriteLine("     DIGITE NOVO CPF:                   ");
            string cpf = Console.ReadLine();
            Console.WriteLine("    |||||||||||||||||||||||||           ");
            Console.WriteLine("     DIGITE A SUA NOVA SENHA:            ");
            string senha = Console.ReadLine();
            Console.WriteLine("    |||||||||||||||||||||||||           ");
          
            pessoa.setNome(nome);
            pessoa.setCpf(cpf);
            pessoa.setSenha(senha);
 
            return pessoa;

        }

        public string Listar1()
        {
            Console.Clear();
            Console.WriteLine("            BANK OF AMERICA             ");
            Console.WriteLine("          CONSULTA DE PESSOA            ");
            Console.WriteLine("                                        ");
            Console.WriteLine("       DIGITE CPF PARA PESQUISA         ");
            string cpf = Console.ReadLine();
            Console.WriteLine("    |||||||||||||||||||||||||           ");

            return cpf;
        }

        public Pessoa Listar2(Pessoa pessoa)
        {

            Console.WriteLine("    |||||||||||||||||||||||||           ");
            Console.WriteLine("     NOME :" + pessoa.nome);

            Console.WriteLine("    |||||||||||||||||||||||||           ");
            Console.WriteLine("     SENHA :" + pessoa.senha);
            Console.WriteLine("    |||||||||||||||||||||||||           ");

            return pessoa;
        }


        public string Excluir1()
        {
            Console.Clear();
            Console.WriteLine("            BANK OF AMERICA             ");
            Console.WriteLine("            EXCLUIR PESSOA              ");
            Console.WriteLine("                                        ");
            Console.WriteLine("       DIGITE CPF PARA PESQUISA         ");
            string cpf = Console.ReadLine();
            Console.WriteLine("    |||||||||||||||||||||||||           ");

            return cpf;
        }


        public string Excluir2(Pessoa pessoa)
        {

            Console.WriteLine("    DESEJA REALMENTE EXCLUIR A PESSOA:  ");
            Console.WriteLine("    |||||||||||||||||||||||||           ");
            Console.WriteLine("     NOME :" + pessoa.nome);

            Console.WriteLine("    |||||||||||||||||||||||||           ");
            Console.WriteLine("     SENHA :" + pessoa.senha);
            Console.WriteLine("    |||||||||||||||||||||||||           ");
            Console.WriteLine("     S = Sim       | N = Nao            ");
            string pergunta = Console.ReadLine();

            return pergunta;
        }



        private static void telaDeLogin()
        {
            Console.Clear();
            Console.WriteLine("            BANK OF AMERICA             ");
            Console.WriteLine("                                        ");
            Console.WriteLine("     DIGITE O CPF:                      ");
            string cpf = Console.ReadLine();
            Console.WriteLine("    |||||||||||||||||||||||||           ");
            Console.WriteLine("     DIGITE A SUA SENHA:                ");
            string senha = Console.ReadLine();
            Console.WriteLine("    |||||||||||||||||||||||||           ");


            //logar no sistema
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;

namespace digBank.classes
{
    public class Mongo
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;

        public void CRUDwithMongoDb()
        {
            _client = new MongoClient();
            _database = _client.GetDatabase("admin");
            Layout layout = new Layout();


            var _collection = _database.GetCollection<Pessoa>("pessoaMongo");

            layout.TelaInicial();

            string userSelection = Console.ReadLine();
            switch (userSelection)
            {
                case "1":
                    //Insert
                    _collection.InsertOne(layout.Inserir());
                    Console.Clear();
                    Console.WriteLine("Inclusao realizada com sucesso...");
                    Console.WriteLine("\n--------------------------------------------------------------\nAperte S para continuar...\n");
                    break;
                case "2":
                    //Select 
                    var nomeDePesquisa = layout.ConsultaPorNomePessoa();
                    var pessoaEncontrada = _collection.Find(x => x.nome == nomeDePesquisa);
                    var qtdPessoEncontrada = pessoaEncontrada.CountDocuments();

                    if (qtdPessoEncontrada == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Pessoa nao encontrada");
                        Console.WriteLine("\n--------------------------------------------------------------\nAperte S para continuar...\n");
                    }
                    if (qtdPessoEncontrada == 1)
                    {
                        var novaPessoa = layout.Atualizar();
                        _collection.FindOneAndUpdate<Pessoa>
                        (Builders<Pessoa>.Filter.Eq("nome", nomeDePesquisa), Builders<Pessoa>.Update.Set("nome", novaPessoa.nome).Set("cpf", novaPessoa.cpf).Set("senha", novaPessoa.senha));
                        Console.Clear();
                        Console.WriteLine("Alteracao efetuada com sucesso");
                        Console.WriteLine("\n--------------------------------------------------------------\nAperte S para continuar...\n");

                    }
                    if (qtdPessoEncontrada > 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Mais de uma pessoa encontrada");
                        Console.WriteLine("\n--------------------------------------------------------------\nAperte S para continuar...\n");
                    }
                    break;

                case "3":
                    //Select
                    var cpfDePesquisa = layout.Listar1();
                    var cpfEncontrado = _collection.Find(x => x.cpf == cpfDePesquisa).ToList();
                    var qtdcpfEncontrada = cpfEncontrado.Count;

                     if (qtdcpfEncontrada == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("CPF nao encontrado");
                        Console.WriteLine("\n--------------------------------------------------------------\nAperte S para continuar...\n");
                    }
                    if (qtdcpfEncontrada == 1)
                    {
                        layout.Listar2(cpfEncontrado.FirstOrDefault());
                        Console.WriteLine("\n--------------------------------------------------------------\nAperte S para continuar...\n");
                    }
                    if (qtdcpfEncontrada > 1)
                    {
                        Console.WriteLine("Mais de uma pessoa encontrada prepar lista de retorno");
                        Console.WriteLine("\n--------------------------------------------------------------\nAperte S para continuar...\n");

                    }
                    break;

                case "4":
                    //procurar e deletar pessoa 
                    var cpfDePesquisaExclusao = layout.Excluir1();
                    var cpfEncontradoExclusao = _collection.Find(x => x.cpf == cpfDePesquisaExclusao).ToList();
                    var qtdcpfEncontradoExclusao = cpfEncontradoExclusao.Count;

                    if (qtdcpfEncontradoExclusao == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("CPF nao encontrado");
                        Console.WriteLine("\n--------------------------------------------------------------\nAperte S para continuar...\n");
                    }
                    if (qtdcpfEncontradoExclusao == 1)
                    {
                        Console.Clear();
                        var Excluir2 = layout.Excluir2(cpfEncontradoExclusao.FirstOrDefault());
                        if (Excluir2 == "S")
                        {
                            _collection.DeleteOne(s => s.cpf == cpfDePesquisaExclusao);
                            Console.WriteLine("Pessoa foi excluida com sucesso");
                            Console.WriteLine("\n--------------------------------------------------------------\nAperte S para continuar...\n");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Pessoa nao foi excluida");
                            Console.WriteLine("\n--------------------------------------------------------------\nAperte S para continuar...\n");
                        }
                    }
                    if (qtdcpfEncontradoExclusao > 1)
                    {
                        Console.WriteLine("Mais de uma pessoa encontrada preparar exclusao para esta regra ");
                        Console.WriteLine("\n--------------------------------------------------------------\nAperte S para continuar...\n");
                    }
                    break;

                default:
                    Console.WriteLine("Opcao invalida");
                    break;
            }

            string userChoice = Console.ReadLine();
            if (userChoice == "S" || userChoice == "s")
            {
                this.CRUDwithMongoDb();
            }
        }


    }
}

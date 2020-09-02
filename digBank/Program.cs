using System;
using digBank.classes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace digBank
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // layout.telaPrincipal();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            Mongo mongo = new Mongo();
            mongo.CRUDwithMongoDb();
           
            //Hold the screen by logic  
            Console.WriteLine("precionar para terminar o programa");
            Console.ReadKey();

        }


      
    }
}

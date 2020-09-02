using System;
namespace digBank.classes
{
    public abstract class banco
    {
        public banco()
        {
            this.nomeDoBanco = "AMERICA OF BANK";
            this.codigoDoBanco = "00000"; 
        }

        public string nomeDoBanco { get; private set; }

        public string codigoDoBanco { get; private set; }

    }
}

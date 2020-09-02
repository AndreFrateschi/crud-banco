using System;
namespace digBank.classes
{
    public class contaCorrente : conta
    {
        public contaCorrente()
        {
            this.numeroDaConta = "00" + conta.numeroDaContaSequincial;
        }

    }
}

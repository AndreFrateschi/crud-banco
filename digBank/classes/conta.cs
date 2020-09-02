using System;
using digBank.contratos;

namespace digBank.classes
{
    public abstract class conta : banco, iConta
    {
        public conta()
        {
            this.numeroDaConta = "001";
            conta.numeroDaContaSequincial++;

        }

        public double saldo { get; protected set; }
        public string numeroAgencia { get; private set; }
        public string numeroDaConta { get; protected set; }
        public static int numeroDaContaSequincial { get; private set; }

        public double consultaSaldo()
        {
            return this.saldo;
        }

        public void deposit(double valor)
        {
            this.saldo += valor;
        }

        public bool saca(double valor)
        {
            if (valor > this.consultaSaldo())
                return false;

            this.saldo -= valor;
            return true;


        }
        public string getCodigoBanco()
        {
            return this.codigoDoBanco;
        }

        public string getNumeroDaConta()
        {
            return this.numeroDaConta;
        }

        public string getNumetoAgencia()
        {
            return this.numeroAgencia; 
        }

        void iConta.saca(double valor)
        {
            throw new NotImplementedException();
        }
    }
}

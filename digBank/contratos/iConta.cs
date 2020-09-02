using System;
namespace digBank.contratos
{
    public interface iConta
    {

        void deposit(double valor);
        void saca(double valor);
        double consultaSaldo();
        string getCodigoBanco();
        string getNumetoAgencia();
        string getNumeroDaConta();
    }


}

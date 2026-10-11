using System;

namespace Aula07Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
               Cartao card = new Cartao();

            Mastercard master = new Mastercard();
            master.titular = "Ana";
            master.parcelas = 2;
            master.ComprarComDescontoMastercard(45f);
        }
    }
}

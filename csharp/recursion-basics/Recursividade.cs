using System;

namespace Aula25Recursividade
{
    public class Recursividade
    {
        

        public void GerarSequenciaFibonacci(int numero1, int numero2, int vezes){

        int soma = numero1 + numero2;

        
        if( vezes > 0)
            {
                Console.WriteLine(soma);
                GerarSequenciaFibonacci( numero2, numero2 + numero2, vezes - 1);

            }
            
        }

        public int GerarFibonacci(int numero){
            if(numero == 1){
                return 1;
            }
            else{
                return numero = GerarFibonacci(numero - 1);
            }
        }
    }
}
using System;

namespace RelatoriosPOO
{
    public class Mensal : Relatorio
    {
        public override void MostrarRelatorio(){

             base.MostrarRelatorio();
    
            System.Console.WriteLine("Mostrar relatorio mensal");
        }

        internal void relatorio()
        {
            throw new NotImplementedException();
        }
    }
}
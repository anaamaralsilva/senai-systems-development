namespace Aula22MetodosEstáticos
{
    public static class Conversor
    {
        public static float CotacaoDolar = 5.29f;

          public static float ConverterDolarParaReal( float valorUS){
            return CotacaoDolar * valorUS;
        } 
        
        public static float ConverterRealParaDolar( float valorRS ){
            return valorRS / CotacaoDolar;
        }
      
    }
}
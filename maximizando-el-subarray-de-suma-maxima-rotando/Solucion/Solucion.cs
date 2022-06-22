namespace Weboo.Examen
{
    public static class Solucion
    {
        public static int[] MejorRotacion(int[] numeros)
        {
             return RotandoArray(numeros);


        }


        public static int[] RotandoArray(int[] numeros){
        //rota el array 
        int count = 0;
        int[] BiggestSubArray = new int[numeros.Length];
         Array.Copy(numeros,BiggestSubArray,numeros.Length);
        while (count < numeros.Length) //poner igual si quiero incluir al inicial al final
        {
            
       int[] RotedArray = new int[numeros.Length];
       for (int i = 1; i < numeros.Length; i++)
       {
        RotedArray[i-1] = numeros[i];
       }
       RotedArray[numeros.Length-1] = numeros[0];
       //array ha sido rotado
        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = RotedArray[i];
        }
        //ahora numeros = RotedArray
        int SumMaxOfRoted1 = MaxSubArray(RotedArray);
        int SumMaxOfRoted2 = MaxSubArray(BiggestSubArray);
        BiggestSubArray = Comparer(SumMaxOfRoted1, SumMaxOfRoted2, RotedArray, BiggestSubArray);
        count ++;
        }
        return BiggestSubArray;
        }


        public static int MaxSubArray(int[] array){
            int inicio = 0;
        int final = 0;
        int maxSuma = array[0];
        for (int i = 0; i < array.Length; i++)
        { int sumaActual = 0;
         for (int j = i; j < array.Length; j++)
        {   sumaActual += array[j];
            if(sumaActual>=maxSuma)
            {
               maxSuma = sumaActual;
               inicio = i;
               final = j;
            }
        }
         } 
          int MaxSuma = maxSuma;
          return MaxSuma;
        }   


        public static int[] Comparer(int a, int b, int[] Roted1, int[] Roted2){ 
            if (a>b)
            {
                return Roted1;
            }
            return Roted2;
         }
    }
}


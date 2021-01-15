public static int  StrangeSum(int[] inputArray)
{
   int sum = 0;  // O(1)
   for (int i = 0; i < inputArray.Length; i++) //O(N) * O(N) * O(N) * O(N)
   {
       for (int j = 0; j < inputArray.Length; j++)  //O(N) * O(N)* O(N)
       {
           for (int k = 0; k < inputArray.Length; k++) // O(N) * O(N)

           {
               int y = 0; // O(1)
               if (j != 0) // O(N)
               {
                   y = k / j; // O(1)
               }

               sum += inputArray[i] + i + k + j + y; // O(1)
           }
       }
   }
   return sum; // O(1)
}
// Получаем O(5 + N^4)
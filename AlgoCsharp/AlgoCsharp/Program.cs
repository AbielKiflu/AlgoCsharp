using System;

namespace AlgoCsharp
{
    class Program
    {
      
        static void Main()
        {
             char[] characters = { 'A', 'B', 'C', 'D' };

           int perm= Combinations.Permutations(characters.Length,2);
            Console.WriteLine(perm);



        }
    }
}
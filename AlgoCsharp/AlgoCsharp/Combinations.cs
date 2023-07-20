using System;



namespace AlgoCsharp
{
	public class Combinations
	{

		public Combinations()
		{

		}


        // Function to calculate factorial (n!)
       public static int Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }

        // Function to calculate the number of permutations (P(n, r))
        public static int Permutations(int n, int r)
        {
            int numerator = Factorial(n);
            int denominator = Factorial(n - r);
            return numerator / denominator;
        }

    }
}

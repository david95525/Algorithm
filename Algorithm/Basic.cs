using static System.Console;
namespace Algorithm
{
    public  class Basic
    {
        public static void Fibonacci_Algorithm()
        {
            WriteLine("Hello, World!");
            Write("請輸入一個整數:");
            string? str = ReadLine();
            int num = Int32.Parse(str);
            if (num < 0)
            {
                WriteLine("數字必須大於0");
            }
            else
            {
                int[] output = new int[num + 1];
                int result = Fibonacci(num);
                int result2 = Fibonacci_DP(num, output);
                WriteLine($"Fibonacci({num})={result},{result2}\n");
            }
        }
        private static  int Fibonacci(int n)
        {
            if(n == 0) return 0;
            else if(n == 1) return 1;
            else
                return Fibonacci(n - 1)+Fibonacci(n-2);
        }
        /// <summary>
        /// Fibonacci by Dynamic Programming
        /// </summary>
        /// <returns></returns>
        private static  int Fibonacci_DP(int n, int[]output)
        {          
            int result = output[n];
            if (result == 0)
            {
                if (n == 0)
                    return 0;
                else if (n == 1)
                    return 1;
                else
                    return Fibonacci_DP(n - 1, output) + Fibonacci_DP(n - 2, output);
            }
            output[n]=result;
            return result;
        }
    }
}

namespace AlgorithmKata
{
    /* 2023.08.24
    짝수와 홀수
    

     */



    internal class Program
    {
        // 짝수와 홀수
        public static string solution(int num)
        {
            if (num % 2 == 0)
                return "Even";
            else
                return "Odd";
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
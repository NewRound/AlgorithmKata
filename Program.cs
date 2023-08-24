namespace AlgorithmKata
{
    /* 2023.08.24
    짝수와 홀수
    평균 구하기
    자릿수 더하기

     */



    internal class Program
    {
        // 짝수와 홀수
        /*
        public static string solution(int num)
        {
            if (num % 2 == 0)
                return "Even";
            else
                return "Odd";
        }
        */

        // 평균 구하기
        /*
        public static double solution(int[] arr)
        {
            double answer = 0;
            for(int i = 0; i < arr.Length;i++)
            {
                answer += arr[i];
            }
            answer /= arr.Length;
            return answer;
        }
        */

        // 자릿수 더하기
        public int solution(int n)
        {
            int answer = 0;
            string number = n.ToString();
            foreach(char c in number)
            {
                answer += c - '0';
            }
            return answer;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
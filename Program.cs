using System.Collections.Generic;

namespace AlgorithmKata
{
    /* 2023.08.24
    짝수와 홀수
    평균 구하기
    자릿수 더하기 ----- 블로그 리뷰 완료
    약수의 합
    나머지가 1이 되는 수 찾기
    x만큼 간격이 있는 n개의 숫자
    자연수 뒤집어 배열로 만들기
     */

    /* 2023.08.25
    문자열을 정수로 바꾸기
    정수 제곱근 판별
    정수 내림차순으로 배치하기
    하샤드 수
    두 정수 사이의 합


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
        /*
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
        */

        // 약수의 합
        /*
        public int solution(int n)
        {
            int answer = 0;
            for(int i = 1; i <= n/2; i++)
            {
                if(n%i == 0)
                {
                    answer += i;
                }
            }

            return answer + n;
        }
        */

        // 나머지가 1이 되는 수 찾기
        /*
        public int solution(int n)
        {
            for(int i = 2; i < n / 2; i++)
            {
                if(n%i == 1)
                    return i;
            }
            return n - 1;
        }
        */

        // x만큼 간격이 있는 n개의 숫자
        /*
        public long[] solution(int x, int n)
        {
            long[] answer = new long[n];
            for(int i = 0; i < n; i++)
            {
                if (i == 0)
                    answer[i] = x;
                else
                    answer[i] = answer[i - 1] + x;
            }
            return answer;
        }
        */

        // 자연수 뒤집어 배열로 만들기
        /*
        public int[] solution(long n)
        {
            string number = n.ToString();
            int[] answer = new int[number.Length];
            for(int i = 0; i < number.Length; i++)
            {
                answer[i] = number[number.Length - 1 - i] - '0';
            }

            return answer;
        }
        */

        // 문자열을 정수로 바꾸기
        /*
        public static int solution(string s)
        {
            int answer = 0;
            answer = int.Parse(s);
            return answer;
        }
        */

        // 정수 제곱근 판별
        /*
        public static long solution(long n)
        {
            int root = (int)Math.Sqrt(n);

            if (n == Math.Pow(root, 2))
                return (long)Math.Pow(root + 1, 2);

            return -1;
        }
        */

        // 정수 내림차순으로 배치하기
        /*
        public static long solution(long n)
        {
            // 실패
            //long answer = 0;
            //string num = n.ToString();
            //List<int> numList = new List<int>();
            
            //foreach(char c in num)
            //{
            //    numList.Add((c - '0'));
            //}
            //numList.Reverse();
            //for(int i = 0; i < numList.Count; i++)
            //{
            //    Console.WriteLine(numList[i]);
            //}

            //for(int i = 0;i<numList.Count;i++)
            //{
            //    Console.WriteLine((numList[i] * (long)Math.Pow(10, numList.Count - 1 - i)));
            //    answer += (numList[i] * (long)Math.Pow(10, numList.Count - i));
                
            //}
            //return answer;
            

            long answer = 0;
            string num = n.ToString();
            int number = 0;
            List<int> list = new List<int>();
            foreach (char c in num)
            {
                number = c - '0';
                list.Add(number);
            }
            list.Sort();
            list.Reverse();

            for (int i = 0; i < list.Count; i++)
            {
                answer += (list[i] * (long)Math.Pow(10, list.Count - i));
            }
            answer /= 10;

            return answer;
        }
        */

        // 하샤드 수
        /*
        public static bool solution(int x)
        {
            bool answer = false;
            string num = x.ToString();
            int number = 0;
            foreach (int i in num)
            {
                number += i - '0';
            }
            if(x %number == 0)
            {
                answer = true;
            }

            return answer;
        }
        */

        // 두 정수 사이의 합
        public static long solution(int a, int b)
        {
            if (a == b)
                return a;
            if (a > b)
            {
                int temp = b;
                b = a;
                a = temp;
            }
            long answer = 0;
            for (int i = 0; i < b - a + 1; i++)
            {
                answer += (long)(a + i);
            }
            return answer;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(solution(3,5));
        }
    }
}
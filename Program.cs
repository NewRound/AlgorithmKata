using System.Collections;
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
    콜라츠 추측
    서울에서 김서방 찾기
    나누어 떨어지는 숫자 배열
    음양 더하기
    핸드폰 번호 가리기
    없는 숫자 더하기
    제일 작은 수 제거하기
    가운데 글자 가져오기
    수박수박수박수박수박수?
    내적
    약수의 개수와 덧셈
    문자열 내림차순으로 배치하기
    부족한 금액 계산하기
    문자열 다루기 기본
    행렬의 덧셈
    직사각형 별찍기
    최대공약수와 최소공배수
    3진법 뒤집기
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
        /*
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
        */

        // 콜라츠 추측
        /*
        public static int solution(int num)
        {
            int answer = 0;
            long number = num;

            for (int i = 0; i < 500; i++)
            {
                if (number == 1)
                    break;

                if(number % 2 == 0)
                {
                    number /= 2;
                    answer++;
                }
                else
                {
                    number *= 3;
                    number++;
                    answer++;
                }
            }

            if(answer == 500)
                answer = -1;

            return answer;
        }
        */

        // 서울에서 김서방 찾기
        /*
        public string solution(string[] seoul)
        {
            string answer = "";

            for(int i = 0; i < seoul.Length; i++)
            {
                if (seoul[i] == "Kim")
                {
                    answer += $"김서방은 {i}에 있다";
                }
            }

            return answer;
        }
        */

        // 나누어 떨어지는 숫자 배열
        /*
        public static int[] solution(int[] arr, int divisor)
        {
            List<int> result = new List<int>();
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % divisor == 0)
                    result.Add(arr[i]);
            }

            if(result.Count == 0)
                return new int[1] { -1};

            result.Sort();

            int[] answer = new int[result.Count];

            for(int i = 0; i < result.Count; i++)
            {
                answer[i] = result[i];
            }

            return answer;
        }
        */

        // 음양 더하기
        /*
        public int solution(int[] absolutes, bool[] signs)
        {
            int answer = 0;

            for (int i = 0; i < absolutes.Length; i++)
            {
                if (signs[i])
                    answer += absolutes[i];
                else
                    answer -= absolutes[i];
            }

            return answer;
        }
        */

        // 핸드폰 번호 가리기
        /*
        public string solution(string phone_number)
        {
            string answer = "";
            if (phone_number.Length == 4)
                return phone_number;
            for(int i = 0; i < phone_number.Length; i++)
            {
                if(i < phone_number.Length - 4)
                    answer += '*';
                else
                    answer += phone_number[i];
            }
            return answer;
        }
        */

        // 없는 숫자 더하기
        /*
        public static int solution(int[] numbers)
        {
            int answer = 0;
            bool find = false;

            for(int i = 0; i < 10; i++)
            {
                find = false;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i == numbers[j])
                    {
                        find = true;
                        break;
                    }
                }
                if (!find)
                    answer += i;
            }
            return answer;
        }
        */

        // 제일 작은 수 제거하기
        /*
        public static int[] solution(int[] arr)
        {
            if (arr.Length == 1)
                return new int[1] { -1 };

            int[] answer = new int[arr.Length - 1];
            int minNum = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if(minNum > arr[i])
                    minNum = arr[i];
            }
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == minNum)
                {
                    continue;
                }
                answer[j] = arr[i];
                j++;
            }
            return answer;
        }
        */

        // 가운데 글자 가져오기
        /*
        public string solution(string s)
        {
            string answer = "";
            int count = s.Length/2;
            if(s.Length % 2 == 0)
            {
                answer += s[count - 1];
                answer += s[count];
            }
            else
            {
                answer += s[count];
            }
            return answer;
        }
        */

        // 수박수박수박수박수박수?
        /*
        public string solution(int n)
        {
            string answer = "";
            for(int i = 0; i < n;i++)
            {
                if(i%2==0)
                {
                    answer += "수";
                }
                else
                {
                    answer += "박";
                }
            }
            return answer;
        }
        */

        // 내적
        /*
        public int solution(int[] a, int[] b)
        {
            int answer = 0;

            for (int i = 0; i < a.Length; i++)
            {
                answer += a[i] * b[i];
            }

            return answer;
        }
        */

        // 약수의 개수와 덧셈
        /*
        public int solution(int left, int right)
        {
            int answer = 0;
            int cnt = 0;
            for (int i = left; i <= right; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        cnt++;
                    }
                }
                if (cnt % 2 == 0)
                {
                    answer += i;
                }
                else
                {
                    answer -= i;
                }
                cnt = 0;
            }
            return answer;
        }
        */

        // 문자열 내림차순으로 배치하기
        /*
        public string solution(string s)
        {
            string answer = "";
            List<int> list = new List<int>();
            for(int i = 0; i < s.Length;i++)
            {
                list.Add((int)s[i]);
            }

            list.Sort();
            list.Reverse();

            for(int i = 0; i < list.Count; i++)
            {
                answer += (char)list[i];
            }

            return answer;
        }
        */

        // 부족한 금액 계산하기
        /*
        public long solution(int price, int money, int count)
        {
            // int값의 범위를 넘어서서 오류가 떴었음 (원래 pay가 int였음.)
            long pay = 0;
            for(int i = 1; i <= count; i++)
            {
                pay += i;
            }

            pay *= (long)price;

            if (pay > money)
                return (pay - (long)money);
            else
                return 0;
        }
        */

        // 문자열 다루기 기본
        /*
        public bool solution(string s)
        {
            if(s.Length != 4 && s.Length != 6)
                return false;
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] > '9')
                    return false;
            }
            return true;
        }
        */

        // 행렬의 덧셈
        /*
        public int[,] solution(int[,] arr1, int[,] arr2)
        {
            int[,] answer = new int[arr1.GetLength(0), arr1.GetLength(1)];

            for(int i = 0; i < arr1.GetLength(1); i++)
            {
                for(int j = 0; j < arr2.GetLength(0); j++)
                {
                    answer[i, j] = arr1[i, j] + arr2[i, j];
                }
            }

            return answer;
        }
        */

        // 직사각형 별찍기
        /*
        public static void Main()
        {
            String[] s;

            Console.Clear();
            s = Console.ReadLine().Split(' ');

            int a = Int32.Parse(s[0]);
            int b = Int32.Parse(s[1]);
            for (int i = 0; i < b ; i++)
            {
                for (int j = 0; j < a ; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
        */

        // 최대공약수와 최소공배수
        /*
        public int[] solution(int n, int m)
        {
            // 현재 9,13,15,16 안됨  =>  공배수는 long으로 바꿔보자
            // 아직 9, 15안됨
            //int[] answer = new int[2];
            //int min = 0;
            //int max = 0;

            //if(n > m)
            //{
            //    int temp = n;
            //    n = m;
            //    m = temp;
            //}

            //List<int> mList = new List<int>();

            //if (m % n == 0)
            //{
            //    min = n;
            //    max = m;
            //}
            //else
            //{
            //    for(int i = 1; i * i <= m; i++)
            //    {
            //        if (m % i == 0)
            //        {
            //            mList.Add(i);
            //        }
            //    }
            //    mList.Add(m);
            //    for(int i = mList.Count - 1; i >= 0; i--)
            //    {
            //        if (n % mList[i] == 0)
            //        {
            //            min = mList[i];
            //            break;
            //        }
            //    }
            //    max = (m * n) / min;
            //}

            //answer[0] = min;
            //answer[1] = max;
            //return answer;
            // -------------------------------------------------------

            int[] answer = new int[2];
            int min;
            int max;

            //최대공약수 -> 유클리드 호제법 gcd(n, m) = gcd(m, n%m)
            // https://www.youtube.com/watch?v=TxdljAFjTNw
            min = gcd(n, m);
            //최소공배수 -> 두수의 곱 / 최대 공약수
            max = (n * m) / min;

            answer[0] = min;
            answer[1] = max;
            return answer;
        }
        public int gcd(int n, int m)
        {
            //두 수 n, m 이 있을 때 어느 한 수가 0이 될 때 까지
            //gcd(m, n%m) 의 재귀함수 반복
            if (m == 0) 
                return n;
            else 
                return gcd(m, n % m);
        }
        */

        // 3진법 뒤집기
        // 실패
        /*
        public int solution(int n)
        {
            string num3 = Convert.ToString(n,3);
            List<int> list = new List<int>();
            for (int i = 0; i < num3.Length; i++)
                list.Add(num3[i]);

            list.Reverse();

            string answerWord = "";
            for (int i = 0;i < list.Count;i++)
                answerWord += list[i].ToString();

            int answer = Convert.ToInt32(answerWord,3);

            
            return answer;
        }

        public void BaseN(string str, int n, int N)
        {
            int num = n / N;
            str = (n % N).ToString() + str;

            if (num >= N)
                BaseN(str, num, N);
            else
                str = num.ToString() + str;
        }
        */
        public int solution(int n)
        {
            int answer = 0;
            int count = 0;

            string str = string.Empty;

            while (true)
            {
                double temp = Math.Pow(3, count);
                if (temp > n)
                {
                    count--;
                    break;
                }

                count++;
            }
            for (int i = count; i >= 0; i--)
            {
                int pow = (int)Math.Pow(3, i);
                for (int j = 2; j >= 0; j--)
                {
                    if (n >= pow * j)
                    {
                        str += j;
                        n -= pow * j;
                        break;
                    }

                    if (j == 0)
                    {
                        str += "0";
                    }
                }
            }
            for (int i = 0; i < str.Length; i++)
            {
                int pow = (int)Math.Pow(3, i);

                int num = (int)Char.GetNumericValue(str[i]);

                answer += num * pow;
            }
            return answer;
        }


        static void Main(string[] args)
        {
            int[] answer = solution(999999, 1000000);
            Console.WriteLine($"min : {answer[0]} , max : {answer[1]}");
        }
    }
}
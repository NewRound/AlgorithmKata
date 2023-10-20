using System.Collections;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

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


    /* 2023.08.28
    이상한 문자 만들기
    */

    /* 2023.08.29
    삼총사
    크기가 작은 부분문자열
    */

    /* 2023.08.30
    최소직사각형
    시저 암호
    */

    /* 2023.08.31
    숫자 문자열과 영단어
    */

    /* 2023.09.04
    문자열 내 마음대로 정렬하기
    */

    /* 2023.09.06
    K번째수
    두 개 뽑아서 더하기
    */

    /* 2023.09.07
    가장 가까운 같은 글자
    푸드 파이트 대회
    */

    /* 2023.09.08
    콜라 문제
    명예의 전당 (1)

    */

    /*2023.09.11
    2016년

    */

    /* 2023.09.12
    카드 뭉치
     */

    /* 2023.09.13
    과일 장수
     */

    /* 2023.09.14
    모의고사
     */

    /* 2023.09.15
    소수 만들기
     */

    /* 2023.09.19
    덧칠하기
     */

    /* 2023.10.02
    기사단원의 무기
     */

    /* 2023.10.04
    로또의 최고 순위와 최저 순위
     */

    /* 2023.10.05
    옹알이 (2)
     */

    internal class Program
    {
        // 이전 풀이
        #region
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
        // 성공
        /*
    public static int solution(int n)
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
    */

        // 이상한 문자 만들기
        /*
    public static string solution(string s)
        {
            string answer = "";
            // 공백일 때 카운트를 제로로 만들고 카운트의 값에 따라 대소문자로 변경
            int count = 0;

            for(int i = 0; i < s.Length;i++)
            {
                if (s[i] == ' ')
                {
                    count = 0;
                    answer += ' ';
                    continue;
                }
                // 홀짝에 따라 문자 구분
                if(count % 2 == 0)
                {
                    if (s[i] > 'Z')
                    {
                        answer += (char)(s[i] - 32);
                        Console.WriteLine(s[i]);
                        Console.WriteLine((char)(s[i] - 32));
                        Console.WriteLine(answer);
                    }
                    else
                        answer += (char)s[i];
                }
                else
                {
                    if (s[i] < 'a')
                        answer += (char)(s[i] + 32);
                    else
                        answer += (char)s[i];
                }
                count++;
            }
            return answer;
        }
        */

        // 삼총사
        /*
        public int solution(int[] number)
        {
            int answer = 0;
            // 3중 for문
            for(int x = 0; x < number.Length;x++)
            {
                for (int y = x + 1; y < number.Length; y++)
                {
                    for (int z = y + 1; z < number.Length; z++)
                    {
                        if(number[x] + number[y] + number[z] == 0 )
                        {
                            answer++;
                        }
                    }
                }
            }

            return answer;
        }
        */

        // 크기가 작은 부분문자열
        // 런타임 에러
        /*
        public static int solution(string t, string p)
        {
            int answer = 0;
            int numP = int.Parse(p);
            int numT;
            for (int i = 0; i < t.Length - p.Length + 1;i++)
            {
                string numberT = t.Substring(i,p.Length);
                numT = int.Parse(numberT);
                if(numP >= numT)
                    answer++;
            }
            return answer;
        }
        */
        /*
        public static int solution(string t, string p)
        {
            int answer = 0;
            bool same = true;
            for (int i = 0; i < t.Length - p.Length + 1; i++)
            {
                same = true;
                // 조건 앞자리가 작으면 무조건 작다.
                for (int j = 0; j < p.Length; j++)
                {
                    if (t[i+j] < p[j])
                    {
                        break;
                    }
                    else if(t[i + j] > p[j])
                    {
                        same = false;
                        break;
                    }
                }
                if(same)
                    answer++;
            }
            return answer;
        }
        */

        // 최소직사각형
        /*
        public static int solution(int[,] sizes)
        {
            int answer = 0;
            int[] rets = new int[2] { 0,0 };
            // out of range => 이유 : 2차원 배열의 길이는 GetLength쓰자.
            for(int i = 0; i < sizes.GetLength(0);i++)
            {
                if (sizes[i,0] > sizes[i,1])
                {
                    // 숫자 바꾸기 익숙하다고 넘어갔다 오류남.
                    int temp = sizes[i,0];
                    sizes[i,0] = sizes[i,1];
                    sizes[i,1] = temp;
                }
                if (rets[0] < sizes[i,0])
                {
                    rets[0] = sizes[i,0];
                }
                if (rets[1] < sizes[i,1])
                {
                    rets[1] = sizes[i,1];
                }
                Console.WriteLine($"{rets[0]}, {rets[1]}");
            }
            answer = rets[0] * rets[1];
            return answer;
        }
        */

        // 시저 암호
        /*
        public static string solution(string s, int n)
        {
            string answer = "";
            // 각각의 문자에 대해.
            int charNum = 0;
            for(int i = 0; i < s.Length;i++)
            {
                // 공백 제외
                if (s[i] == ' ')
                {
                    answer += " ";
                    continue;
                }

                // n을 더한 문자 계산
                // else if 에 원래 charNum < 'a'를 활용 이는 대문자가 소문자 범위에 들어가는 결과를 일으킴.
                charNum = (int)s[i] + n;
                if (charNum > (int)'z')
                {
                    charNum -= 26;
                }
                else if((int)s[i] <= 'Z' && charNum > 'Z')
                {
                    charNum -= 26;
                }

                answer += (char)charNum;

            }
            return answer;
        }
        */

        //숫자 문자열과 영단어
        /*
        public static int solution(string s)
        {
            long answer = 0;
            // 숫자인 경우 (1자리 숫자)
            // 묶음 (o = 1 / t = 2, 3  /  f = 4, 5  /  s = 6, 7  / e = 8  / n = 9 / z = 0)
            // 건너뛰는 길이 4 3 3 5 4 4 3 5 5 4
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        answer += long.Parse(s[i].ToString());
                        answer *= (long)Math.Pow(10, 1);
                        count++;
                        break;

                    case 'o': // 1
                        answer += 1;
                        answer *= (long)Math.Pow(10, 1);
                        i += 2;
                        count++;
                        break;
                    case 't': // 2,3
                        if (s[i + 1] == 'w')
                        {
                            answer += 2;
                            answer *= (long)Math.Pow(10, 1);
                            i += 2;
                        }
                        else
                        {
                            answer += 3;
                            answer *= (long)Math.Pow(10, 1);
                            i += 4;
                        }
                        count++;
                        break;
                    case 'f': // 4,5
                        if (s[i + 1] == 'o')
                        {
                            answer += 4;
                            answer *= (long)Math.Pow(10, 1);
                            i += 3;
                        }
                        else
                        {
                            answer += 5;
                            answer *= (long)Math.Pow(10, 1);
                            i += 3;
                        }
                        count++;
                        break;
                    case 's': // 6,7
                        if (s[i + 1] == 'i')
                        {
                            answer += 6;
                            answer *= (long)Math.Pow(10, 1);
                            i += 2;
                        }
                        else
                        {
                            answer += 7;
                            answer *= (long)Math.Pow(10, 1);
                            i += 4;
                        }
                        count++;
                        break;
                    case 'e': // 8
                        answer += 8;
                        answer *= (long)Math.Pow(10, 1);
                        i += 4;
                        count++;
                        break;
                    case 'n': // 9
                        answer += 9;
                        answer *= (long)Math.Pow(10, 1);
                        i += 3;
                        count++;
                        break;
                    case 'z': // 0
                        answer += 0;
                        answer *= (long)Math.Pow(10, 1);
                        i += 3;
                        count++;
                        break;
                }
                Console.WriteLine("{0} :  {1}", answer, count);
            }

            return (int)(answer / 10);
        }
        */

        // K번째수
        /*
        public static int[] solution(int[] array, int[,] commands)
        {
            int[] answer = new int[commands.GetLength(0)];


            // commands의 수만큼 반복
            for (int i = 0; i < commands.GetLength(0); i++)
            {
                // 자르기
                int[] arr = new int[commands[i, 1] - commands[i, 0] + 1];
                for (int j = commands[i, 0] - 1; j < commands[i, 1]; j++)
                {
                    arr[j - (commands[i, 0] - 1)] = array[j];
                }
                // 정렬
                Array.Sort(arr);

                // 값 대입
                answer[i] = arr[commands[i, 2] - 1];
            }

            return answer;
        }
        */

        // 두 개 뽑아서 더하기
        /*
        public static int[] solution(int[] numbers)
        {

            List<int> answers = new List<int>();
            //answers.Add(0);

            // 모든 경우의 수
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (!answers.Contains(numbers[i] + numbers[j]))
                    {
                        Console.WriteLine($"{numbers[i]} + {numbers[j]} = {numbers[i] + numbers[j]}");
                        answers.Add(numbers[i] + numbers[j]);
                    }
                    else
                        continue;
                }
            }

            //answers.Remove(0);
            answers.Sort();
            int[] answer = new int[answers.Count];
            int count = 0;
            foreach (int i in answers)
            {
                answer[count] = i;
                count++;
            }

            return answer;

        }
        */

        // 가장 가까운 같은 글자
        /*
        public static int[] solution(string s)
        {
            int[] answer = new int[s.Length];
            Dictionary<char, int> numIndex = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                if (numIndex.ContainsKey(c))
                {
                    answer[i] = i - numIndex[c];
                    numIndex[c] = i;
                }
                else
                {
                    answer[i] = -1;
                    numIndex[c] = i;
                }
            }
            return answer;
        }
        */

        // 푸드 파이트 대회
        /*
        public static string solution(int[] food)
        {
            string answer = "0";
            for (int i = food.Length - 1; i > 0; i--)
            {
                if (food[i] > 1)
                {
                    int num = food[i] / 2;
                    string c = i.ToString();
                    for (int j = 0; j < num; j++)
                    {
                        answer = c + answer + c;
                    }
                }
            }
            return answer;
        }
        */

        // 콜라 문제
        /*
        public static int solution(int a, int b, int n)
        {
            int answer = 0;
            int empty = n;

            while (empty >= a)
            {
                Console.WriteLine(empty);
                int getCola = (empty / a) * b;
                answer += getCola;
                empty = getCola + (empty % a);
            }
            return answer;
        }
        */

        // 명예의 전당 (1)
        /*
        public static int[] solution(int k, int[] score)
        {
            int[] answer = new int[score.Length];

            // 명예의 전당
            List<int> honor = new List<int>();

            // 가수들의 점수를 전부 계산.
            for (int i = 0; i < score.Length; i++)
            {
                // 명예의 전당이 다 안채워졌을 때
                if (i < k)
                {
                    Console.WriteLine($"{score[i]}");
                    honor.Add(score[i]);
                }
                else
                {
                    if (score[i] > honor[0])
                    {
                        honor.Remove(honor[0]);
                        Console.WriteLine($"{score[i]}");
                        honor.Add(score[i]);
                    }
                }
                honor.Sort();
                Console.WriteLine($"{honor[0]}");
                answer[i] = honor[0];
            }

            return answer;
        }
        */

        // 2016년
        /*
        public static string solution(int a, int b)
        {
            int[] month = new int[11] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30 };
            // 0 = 금요일
            int day = b - 1;

            if (a != 1)
            {
                for (int i = 0; i < a - 1; i++)
                {
                    day += month[i];
                }
            }
            // SUN,MON,TUE,WED,THU,FRI,SAT
            day = day % 7;
            switch (day)
            {
                case 0:
                    return "FRI";
                case 1:
                    return "SAT";
                case 2:
                    return "SUN";
                case 3:
                    return "MON";
                case 4:
                    return "TUE";
                case 5:
                    return "WED";
                case 6:
                    return "THU";
            }
            return "asd";
        }
        */

        // 카드 뭉치
        /*
        public string solution(string[] cards1, string[] cards2, string[] goal)
        {
            // 중복되는 글자가 있을 수도 있다.
            int c1 = 0;
            int c2 = 0;

            for (int i = 0; i < goal.Length; i++)
            {
                if (c1 < cards1.Length)
                {
                    if (goal[i] == cards1[c1])
                    {
                        c1++;
                        continue;
                    }
                }
                if (c2 < cards2.Length)
                {
                    if (goal[i] == cards2[c2])
                    {
                        c2++;
                        continue;
                    }
                }
                return "No";
            }

            return "Yes";
        }
        */

        // 과일 장수
        /*
        public int solution(int k, int m, int[] score)
        {
            int answer = 0;
            List<int> scores = new List<int>();
            for (int i = 0; i < score.Length; i++)
            {
                scores.Add(score[i]);
            }
            scores.Sort();
            scores.Reverse();

            for (int i = 0; i < scores.Count; i++)
            {
                if (i % m == m - 1)
                {
                    answer += m * scores[i];
                }
            }

            return answer;
        }
        */

        // 모의고사
        /*
        public int[] solution(int[] answers)
        {
            int[] people1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] people2 = new int[8] { 2, 1, 2, 3, 2, 4, 2, 5 };
            int[] people3 = new int[10] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

            int p1 = 0;
            int p2 = 0;
            int p3 = 0;

            for (int i = 0; i < answers.Length; i++)
            {
                if (people1[i % 5] == answers[i])
                    p1++;
                if (people2[i % 8] == answers[i])
                    p2++;
                if (people3[i % 10] == answers[i])
                    p3++;
            }

            int maxInt = p1;
            if (p2 > maxInt)
            {
                maxInt = p2;
            }
            if (p3 > maxInt)
            {
                maxInt = p3;
            }

            int length = 0;
            if (p1 == maxInt)
                length++;
            if (p2 == maxInt)
                length++;
            if (p3 == maxInt)
                length++;

            int[] answer = new int[length];

            int index = 0;
            if (p1 == maxInt)
                answer[index++] = 1;
            if (p2 == maxInt)
                answer[index++] = 2;
            if (p3 == maxInt)
                answer[index++] = 3;


            return answer;
        }
        */

        // 소수 만들기
        /*
        public int solution(int[] nums)
        {
            int answer = 0;

            // 배열에서 3개를 더한 수.
            // 약수를 구함.
            // if 소수라면?
            // dic에 수를 키로하고 bool값으로 true

            Dictionary<int, bool> numDict = new Dictionary<int, bool>();
            int num = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        num = nums[i] + nums[j] + nums[k];

                        if (numDict.ContainsKey(num))
                        {
                            if (numDict[num])
                            {
                                answer++;
                            }
                        }
                        else
                        {
                            // 소수판단.
                            // 소수라면 dict = true
                            // 소수가 아니라면 dict = false
                            bool sosu = true;
                            for (int x = 2; x * x <= num; x++)
                            {
                                if (num % x == 0)
                                {
                                    // 소수가 아님.
                                    sosu = false;
                                    break;
                                }
                            }
                            if (sosu)
                            {
                                numDict[num] = true;
                                answer++;
                            }
                            else
                            {
                                numDict[num] = false;
                            }
                        }
                    }
                }
            }
            return answer;
        }
        */

        // 덧칠하기
        /*
        public static int solution(int n, int m, int[] section)
        {
            int answer = 0;

            int j = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i);

                if (section[j] - 1 == i)
                {
                    answer++;
                    i += m - 1;

                    for (int k = j + 1; k < section.Length; k++)
                    {
                        // 여기서 범위 설정 잘못해서 30분 날림... (-1이 빠졌었음.)
                        if (section[k] - 1 >= i)
                        {
                            j = k;
                            break;
                        }
                    }
                }
            }
            return answer;
        }
        */

        // 기사단원의 무기
        /*
        public static int solution(int number, int limit, int power)
        {
            int answer = 0;

            if(number == 1)
            {
                return 1;
            }

            int count = 0;
            for (int i = 2; i <= number; i++)
            {
                count = 0;
                for(int j = 1; j * j <= i; j++)
                {
                    if (i % j == 0)
                        count++;
                }

                if (i % (Math.Sqrt(i)) == 0)
                    count = (count * 2) - 1;
                else
                    count = count * 2;

                

                if (count > limit)
                    answer += power;
                else
                    answer += count;
            }
            answer++;

            return answer;
        }
        */

        // 로또의 최고 순위와 최저 순위
        /*
        public int[] solution(int[] lottos, int[] win_nums)
        {
            int[] answer = new int[2];
            int count = 0;
            int zero = 0;

            // 맞는번호 찾기
            for (int i = 0; i < lottos.Length; i++)
            {
                if (lottos[i] != 0)
                {
                    for (int j = 0; j < win_nums.Length; j++)
                    {
                        if (win_nums[j] == lottos[i])
                        {
                            count++;
                            break;
                        }
                    }
                }
                else
                    zero++;
            }

            answer[0] = 7 - count - zero;

            if (answer[0] == 7)
                answer[0] = 6;

            if (count < 2)
            {
                answer[1] = 6;
            }
            else
            {
                answer[1] = 7 - count;
            }

            return answer;
        }
        */

        // 옹알이 (2)
        /*
        public static int solution(string[] babbling)
        {
            string[] keyword = new string[4] { "aya", "ye", "woo", "ma" };
            int answer = 0;
            string lastWord = "   ";
            bool check = true;
            int stringCount = 0;

            for (int i = 0; i < babbling.Length; i++)
            {
                lastWord = "   ";
                check = true;
                string word = babbling[i];

                while (true)
                {
                    if (word.Length < 2)
                    {
                        check = false;
                        break;
                    }

                    string splitword = word.Substring(0, 2);
                    stringCount = 0;

                    if (splitword == lastWord.Substring(0, 2))
                    {
                        check = false;
                        break;
                    }

                    switch (splitword)
                    {
                        case "ay":
                            if (word.Length < 3)
                            {
                                check = false;
                                break;
                            }

                            if (word[2] == 'a')
                            {
                                stringCount = 3;
                                lastWord = "aya";
                            }
                            else
                                check = false;
                            break;
                        case "ye":
                            stringCount = 2;
                            lastWord = "ye";
                            break;
                        case "wo":
                            if (word.Length < 3)
                            {
                                check = false;
                                break;
                            }

                            if (word[2] == 'o')
                            {
                                stringCount = 3;
                                lastWord = "woo";
                            }
                            else
                                check = false;
                            break;
                        case "ma":
                            stringCount = 2;
                            lastWord = "ma";
                            break;
                        default:
                            check = false;
                            break;
                    }

                    Console.WriteLine($"i : {i},   word : {word},   check : {check}");

                    if (!check)
                        break;

                    if (word.Length == stringCount)
                    {
                        break;
                    }
                    else
                    {
                        word = word.Substring(stringCount, word.Length - stringCount);
                        Console.WriteLine($"word : {word},   check : {check}");
                    }
                }

                if (check)
                    answer++;

            }

            return answer;
        }
        */






        #endregion

        // 문자열 내 마음대로 정렬하기
        // 아직 안됨
        /*
        public static string[] solution(string[] strings, int n)
        {
            string[] answer = new string[strings.Length];
            Dictionary<char, List<string>> stringDict = new Dictionary<char, List<string>>();

            for(int i = 0; i < 26; i++)
            {
                stringDict[(char)(97 + i)] =null;
            }


            for(int i = 0; i < strings.Length; i++)
            {
                char key = strings[i][n];
                if (stringDict.TryGetValue(key, out List<string> value) && value != null)
                {
                    Console.WriteLine($"strings[i] : {strings[i]},  key : {key}");
                    value.Add(strings[i]);
                    value.Sort();
                    stringDict[key] = value;
                }
                else
                {
                    Console.WriteLine($"strings[i] : {strings[i]},  key : {key}");
                    value = new List<string>();
                    value.Add(strings[i]);
                    value.Sort();
                    stringDict[key] = value;
                }
            }

            for(int i = 0; i < 26; i++)
            {
                if (stringDict[(char)(97 + i)] != null)
                    Console.WriteLine($"{stringDict[(char)(97 + i)].Count} , {(char)(97 + i)}");
            }

            int count = 0;
            for(int i = 0; i < 26; i++)
            {
                if (stringDict.TryGetValue((char)(97 + i), out List<string> values) && values != null)
                {
                    for(int j = 0; j < values.Count; j++)
                    {
                        Console.WriteLine($"{(char)(97 + i)} : {values.Count},  {i},  {j}");
                        answer[count] = values[j];
                        count++;
                    }
                }
            }
            return answer;
        }
        */

        // 숫자 짝꿍
        // 1번 시도 타임 오버
        /*
        public static string solution(string X, string Y)
        {
            string answer = "";

            Dictionary<int, int> xNum = new Dictionary<int, int>();
            Dictionary<int, int> yNum = new Dictionary<int, int>();

            List<char> num = new List<char>();

            for(int i = 0; i < X.Length; i++)
            {
                if (xNum.ContainsKey((int)X[i]))
                {
                    xNum[(int)X[i]] += 1;
                }
                else
                {
                    xNum[(int)X[i]] = 1;
                }
            }
            for (int i = 0; i < Y.Length; i++)
            {
                if (yNum.ContainsKey((int)Y[i]))
                {
                    yNum[(int)Y[i]] += 1;
                }
                else
                {
                    yNum[(int)Y[i]] = 1;
                }
            }

            foreach(KeyValuePair<int,int> nums in xNum)
            {
                if (!yNum.ContainsKey(nums.Key))
                    continue;

                for(int i = 0; i < Math.Min(nums.Value, yNum[nums.Key]); i++)
                {
                    num.Add((char)nums.Key);
                }
            }

            if (num.Count == 0)
                return "-1";

            num.Sort();
            num.Reverse();

            for(int i = 0; i < num.Count; i++)
            {
                if (num[i] == '0' && answer == "")
                    break;

                answer += num[i];
            }

            if (answer == "")
                answer = "0";

            return answer;
        }
        */
        // 2번 시도 시간 초과
        /*
        public static string solution(string X, string Y)
        {
            string answer = "";

            List<char> xNum = X.ToList();
            List<char> yNum = Y.ToList();

            List<char> num = new List<char>();

            xNum.Sort();
            yNum.Sort();

            int yIndex = 0;
            for(int i = 0; i < xNum.Count; i++)
            {
                if (yIndex >= yNum.Count)
                    break;

                if ((int)yNum[yIndex] > (int)xNum[i])
                    continue;
                else if ((int)yNum[yIndex] < (int)xNum[i])
                {
                    i--;
                    yIndex++;
                    continue;
                }

                yIndex++;
                num.Add(xNum[i]);
            }

            if (num.Count == 0)
                return "-1";


            num.Reverse();

            for (int i = 0; i < num.Count; i++)
            {
                if (num[i] == '0' && answer == "")
                    break;

                answer += num[i];
            }

            if (answer == "")
                answer = "0";

            return answer;
        }
        */
        // 3번 시도 시간 초과
        /*
        public static string solution(string X, string Y)
        {
            string answer = "";

            List<char> xNum = X.ToList();
            List<char> yNum = Y.ToList();

            xNum.Sort();
            xNum.Reverse();
            yNum.Sort();
            yNum.Reverse();

            int yIndex = 0;
            bool zero = false;

            for(int i = 0; i < xNum.Count; i++)
            {
                if (yIndex >= yNum.Count)
                    break;

                if ((int)xNum[i] > (int)yNum[yIndex])
                {
                    continue;
                }
                else if ((int)xNum[i] < (int)yNum[yIndex])
                {
                    i--;
                    yIndex++;
                    continue;
                }

                yIndex++;

                if (xNum[i] != '0')
                    answer += xNum[i];
                else if (answer != "")
                {
                    zero = true;
                    answer += xNum[i];
                }
                else
                    zero = true;
            }

            if (zero && answer == "")
                answer = "0";
            else if(answer == "")
                answer = "-1";
                

            return answer;
        }
        */


        // 체육복
        // 1번 시도 런타임 에러
        /*
        public static int solution(int n, int[] lost, int[] reserve)
        {
            int answer = 0;

            Dictionary<int, bool[]> dic = new Dictionary<int, bool[]>();

            for(int i = 0; i < n; i++)
            {
                dic.Add(i + 1, new bool[2] { false, false });
            }

            for(int i = 0; i < lost.Length; i++)
            {
                bool[] condition = dic[lost[i]];
                condition[0] = true;
            }

            for (int i = 0; i < reserve.Length; i++)
            {
                bool[] condition = dic[reserve[i]];
                if (condition[0] == false)
                    condition[1] = true;
                else
                {
                    condition[0] = false;
                }
            }

            for(int i = 1; i <= n; i++)
            {
                bool[] condition = dic[i];

                if (condition[0] == false)
                    answer++;
                else
                {
                    if (i == 1)
                    {
                        bool[] backCondition = dic[i + 1];
                        if (backCondition[1] == true)
                        {
                            backCondition[1] = false;
                            answer++;
                        }
                    }
                    else
                    {
                        bool[] forntCondition = dic[i - 1];
                        bool[] backCondition = dic[i + 1];
                        if (forntCondition[1] == true)
                        {
                            forntCondition[1] = false;
                            answer++;
                        }
                        else if (backCondition[1] == true)
                        {
                            backCondition[1] = false;
                            answer++;
                        }

                    }
                }
            }

            return answer;
        }
        */


        // 문자열 나누기
        public static int solution(string s)
        {
            int answer = 0;

            string splitS = s;

            int xCount = 0;
            int nCount = 0;

            char c = ' ';

            while (true)
            {
                if(splitS == "")
                {
                    break;
                }
                else if(splitS.Length == 1)
                {
                    answer++;
                    break;
                }

                xCount = 0;
                nCount = 0;

                c = splitS[0];

                for (int i = 0; i < splitS.Length; i++)
                {
                    if(c == splitS[i])
                    {
                        xCount++;
                    }
                    else
                    {
                        nCount++;
                    }

                    if(xCount == nCount)
                    {
                        if (i == splitS.Length - 1)
                            splitS = "";
                        else
                        {
                            splitS = splitS.Substring(xCount + nCount, splitS.Length - xCount -nCount);
                        }
                        Console.WriteLine(splitS);
                        answer++;
                        break;
                    }
                    else if (i == splitS.Length - 1)
                    {
                        answer++;
                        splitS = "";
                    }
                }
            }

            return answer;
        }







        static void Main(string[] args)
        {
            int answer = solution("abracadabra");
            Console.WriteLine($"{answer}");

            //for(int i = 0; i < answer.Length; i++)
            //{
            //    Console.WriteLine($"{answer[i]}");
            //}

        }
    }
}
using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace _250514_001
{
    internal class Program
    {
        enum Size { Short, Tail, Grande, Venti };
        static void Main(string[] args)
        {
            //Console.Write("Hello, World!ㅋㅋ");
            //Console.Write("Hello, World!ㅋㅋ");
            //Console.WriteLine("Hello, World!ㅋㅋ"); // Line은 줄바꿈
            //Console.WriteLine("Hello, World!ㅋㅋ");

            ////주석 : 기위바위보 게임 실행
            //Console.WriteLine("가위 바위 보 중 아무거나 입력하세요.");
            //string var = Console.ReadLine(); //문자열 변수 선언
            //Console.Write(var);
            //Console.WriteLine("를 내셨네요.");

            //string str = "test";
            //Console.WriteLine(str[0]);
            //Console.WriteLine(str[1]);
            //Console.WriteLine(str[2]);
            //Console.WriteLine(str[3]);
            //Console.WriteLine(str[4]);

            //Console.WriteLine("학생표");
            //Console.Write("학생표\n");
            //Console.WriteLine("내용");

            //Console.WriteLine("이름\t학년");
            //Console.WriteLine("\"강형석\"\t1");
            //string A = "강형석";
            //string B = "서호진";
            //string C = "강형석";
            //string D = "강";
            //string E = "형석";
            //Console.WriteLine(A == B);
            //Console.WriteLine(A == C);
            //Console.WriteLine(D + E);

            //Console.Write("이름은?");
            //string name = Console.ReadLine();
            //Console.Write("학년은?");
            //string grade = Console.ReadLine();
            //Console.WriteLine("안녕하세요 {0}학년 {1}님 어서오세요", grade, name);

            //int a = 10;
            //float b = 20;
            //Console.WriteLine(a, b); // 에러 발생
            //Console.WriteLine("강", "형석"); // 에러 발생
            //Console.WriteLine("강" + "형석");
            //Console.WriteLine(a + b); // 10 20 출력 희망
            //Console.WriteLine(a.ToString() + " " + b.ToString());
            //Console.WriteLine("a : " + a.ToString() + ", b : " + b.ToString());
            //Console.WriteLine("a : {0}, b : {1}", a, b);
            //Console.WriteLine($"a : {a}, b : {b}");

            //Console.WriteLine("(C) Currency: {0:C}", -12345678);

            //string s = string.Format("{0:C}", -12345678);
            //Console.WriteLine(s);

            //float fNum = 1F / 3;
            //double doNum = 1D / 3; // = 1.0 / 3;
            //decimal dNum = 1M / 3;
            //Console.WriteLine(fNum);
            //Console.WriteLine(doNum);
            //Console.WriteLine(dNum);

            //double x = 1234.5;
            //int a;
            //a = (int)x; // type casting (명시적)형변환
            //Console.WriteLine(a);

            //int b = 1234;
            //long big = b; // type casting (암시적)형변환
            //Console.WriteLine(b);
            //string d = "1234.5678";
            //double c = Double.Parse(d); // 문자열에서 숫자를 실수로 가져옴
            //Console.WriteLine(c);
            //string e = "1234";
            //int f = int.Parse(e); // 문자열에서 숫자를 정수로 가져옴
            //Console.WriteLine(f);
            //string sstring = f.ToString();

            // 연산자 종류
            // 산술연산 + - * / (%=나머지)
            //int a = 1;
            //Console.WriteLine($"a: {a}, a%3: {a % 3}"); a = a + 1;
            //Console.WriteLine($"a: {a}, a%3: {a % 3}"); a = a + 1;
            //Console.WriteLine($"a: {a}, a%3: {a % 3}"); a = a + 1;
            //Console.WriteLine($"a: {a}, a%3: {a % 3}"); a = a + 1;
            //Console.WriteLine($"a: {a}, a%3: {a % 3}"); a = a + 1;
            //Console.WriteLine($"a: {a}, a%3: {a % 3}"); a = a + 1;
            //Console.WriteLine($"a: {a}, a%3: {a % 3}"); a = a + 1;
            //Console.WriteLine($"a: {a}, a%3: {a % 3}"); a = a + 1;
            //Console.WriteLine($"a: {a}, a%3: {a % 3}"); a = a + 1;

            // 논리 연산 (그리고AND, 또는OR, 배타적XOR, 반전NOT)
            //Console.WriteLine(true);
            //Console.WriteLine(false);
            // 그리고 AND
            //int hours_today = 0;
            //bool understand = false;
            //Console.WriteLine(hours_today >= 8 && understand);
            //hours_today = 8;
            //Console.WriteLine(hours_today >= 8 && understand);
            //understand = true;
            //Console.WriteLine(hours_today >= 8 && understand);

            // 또는 OR
            //hours_today = 0;
            //understand = false;
            //Console.WriteLine(hours_today >= 8 || understand);
            //hours_today = 8;
            //Console.WriteLine(hours_today >= 8 || understand);
            //understand = true;
            //Console.WriteLine(hours_today >= 8 || understand);

            // 배타적 XOR
            //hours_today = 0;
            //understand = false;
            //Console.WriteLine(hours_today >= 8 ^ understand);
            //hours_today = 8;
            //Console.WriteLine(hours_today >= 8 ^ understand);
            //understand = true;
            //Console.WriteLine(hours_today >= 8 ^ understand);

            // NOT
            //Console.WriteLine(!true);
            //Console.WriteLine(!false);

            // 비트연산
            //  00011001
            // &00000001
            //  00000001

            // 조건연산자 ? :
            //int point = 90;
            //Console.WriteLine("{0}점은 {1}입니다.", point, (point>=60) ? "pass":"fail");
            //point = 50;
            //Console.WriteLine("{0}점은 {1}입니다.", point, (point >= 60) ? "pass" : "fail");

            //int a = 0;
            //a = a + 1; Console.WriteLine(a);
            //a = a + 1; Console.WriteLine(a);
            //a += 1; Console.WriteLine(a);
            //a += 1; Console.WriteLine(a);
            //a *= 10; Console.WriteLine(a); // a = a * 10
            //a++; Console.WriteLine(a);
            //++a; Console.WriteLine(a);
            //a--; Console.WriteLine(a);
            //--a; Console.WriteLine(a);
            //Console.WriteLine(a++); // a를 먼저 출력하고 증가시킴
            //Console.WriteLine(++a); // 증가를 먼저 시키고 출력함
            //Console.WriteLine(a);

            // string class
            //string s = "Hello World!";
            //string money1 = "123000";
            //string money2 = "81230";
            //Console.WriteLine(s.Length); // 문자열 길이 출력
            //Console.WriteLine(s[8]); // 8번째 인덳 문자 출력
            //Console.WriteLine(s.Insert(6, "C# ")); // 문자열의 6번째 인덱스에 삽입
            //Console.WriteLine(money1);
            //Console.WriteLine(money2);
            //Console.WriteLine(money1.PadLeft(20, ' ')); //특정문자를 삽입하여 정렬
            //Console.WriteLine(money2.PadLeft(20, ' '));
            //Console.WriteLine(s.Remove(4)); // 4번째 이후 문자 제거
            //Console.WriteLine(s.Remove(6, 3)); // 6~3번째 사이 문자 제거
            //Console.WriteLine(s.Replace('l', 'm')); // 'l'문자들을 'm'으로 변환
            //s = "\nHello World!\n";
            //Console.WriteLine(s.Trim()); //앞뒤 공백 또는 특정 문자 제거
            //Console.WriteLine(s.TrimStart()); // 앞쪽 공백 또는 특정 문자 제거
            //Console.WriteLine(s.TrimEnd()); // 뒤쪽 공백 또는 특정 문자 제거
            //s = "010-1234-5678";
            //string[] phoneNums = s.Split('-'); //'-' 를 기준으로 문자배열을 리턴
            //Console.WriteLine(phoneNums[0]);
            //Console.WriteLine(phoneNums[1]);
            //Console.WriteLine(phoneNums[2]);
            //string s2 = String.Join("-", phoneNums); // 생성된 배열을 하나의 문자열로 결합
            //Console.WriteLine(s2);

            //string s = "Hello World!";
            //char[] destination = new char[10];
            //s.CopyTo(8, destination, 0, 4); // s의 8번째 인덱스부터 destination[] 배열의 0번 인덱스로 4개를 복사
            //Console.WriteLine(destination);

            //string s = "010-1234-5678";
            //string s_sub = s.Substring(8);
            //Console.WriteLine(s_sub); // s의 8번째 인덱스부터 맨 뒤까지 문자열을 리턴
            //s_sub = s.Substring(8, 2);
            //Console.WriteLine(s_sub); // s의 8번째 인덱스부터 2개의 문자열을 리턴
            //int i_start = s.IndexOf("0");
            //Console.WriteLine(i_start); // s에서 처음 나오는 "0"의 위치를 리턴
            //int i_last = s.LastIndexOf("0");
            //Console.WriteLine(i_last); // s에서 맨 마지막으로 나오는 "0"의 위치를 리턴
            //string first_num = s.Substring(i_start, i_last - i_start + 1);
            //Console.WriteLine(first_num); // 010 출력
            //Console.WriteLine(s.Contains("7")); // s에 "7"이라는 문자열이 있으면 true를 리턴
            //string fruit1 = "apple";
            //string fruit2 = "banana";
            //Console.WriteLine(fruit1.CompareTo(fruit2));
            //Console.WriteLine(fruit2.CompareTo(fruit1));
            //Console.WriteLine(fruit1.CompareTo(fruit1));

            //string fruit1 = "apple";
            //string fruit2 = "banana";
            //string fruits = fruit1 + fruit2;
            //Console.WriteLine(fruits);
            //Console.WriteLine(String.Concat(fruit1, fruit2)); 
            //Console.WriteLine(String.Compare(fruit1, fruit2));
            //string t = String.Copy(fruits);
            //Console.WriteLine(t);

            //Console.Write("더하고 싶은 숫자들을 입력해요:");
            //string num_in = Console.ReadLine();
            //Console.WriteLine(num_in);
            //string[] s_nums = num_in.Split();
            //Console.WriteLine(s_nums[0]);
            //Console.WriteLine(s_nums[1]);
            //Console.WriteLine(s_nums[2]);
            //int sum = 0;
            //sum = int.Parse(s_nums[0]) + int.Parse(s_nums[1]) + int.Parse(s_nums[2]);
            //Console.WriteLine(sum);

            //string max = String.Format("{0:X} {0:E} {0:N}", Int64.MaxValue);
            //Console.WriteLine(max); // 16진수형, 지수형, 구분자(,)가 있는 숫자형

            //Decimal exchangeRate = 1129.20m;
            //Console.WriteLine("현재 원달러 환율은 {0}이다.", exchangeRate);
            //Console.WriteLine("현재 원달러 환율은 {0:C2}이다.", exchangeRate);

            //Console.WriteLine("오늘 날짜는 {0:d}, 시각은 {0:t}입니다.", DateTime.Now);

            //TimeSpan duration = new TimeSpan(1, 12, 23, 62); // 1d 12h 23m 62s
            //Console.WriteLine("시간 {0:c}", duration);

            //string name = "강형석";
            ////name[0] = "김"; // 불변(immutable)
            //string name2 = "서형석";

            //StringBuilder sb = new StringBuilder("This is a stringbuilder test");
            //Console.WriteLine("{0}는 {1}개 글자입니다.", sb.ToString(), sb.Length);
            //sb.Clear();
            //Console.WriteLine("{0}는 {1}개 글자입니다.", sb.ToString(), sb.Length);
            //sb.Append("ㅋ");
            //Console.WriteLine(sb.ToString());
            //sb.Append("ㅋ");
            //Console.WriteLine(sb.ToString());
            //sb.Insert(1, "ㅎ", 2); // 1번째 위치에 "ㅗ"를 2번 추가
            //Console.WriteLine(sb.ToString()); // ㅋㅎㅎㅋ
            //sb.Remove(1, 2); // 1번째 위치에 2번 제거
            //Console.WriteLine(sb.ToString()); // ㅋㅋ
            //sb.Append("ㄷㄷ");
            //Console.WriteLine(sb.ToString()); // ㅋㅋㄷㄷ
            //sb.Replace("ㅋㄷ", "ㅎㅎ"); // "ㅋㄷ"을 "ㅎㅎ"로 대체
            //Console.WriteLine(sb.ToString()); // ㅋㅎㅎㄷ

            //Stopwatch time = new Stopwatch();
            //time.Start();
            //for (long i = 0; i < 10000; i++) { }
            //time.Stop();
            //Console.WriteLine(time.ElapsedMilliseconds);
            //time.Reset();

            //string test = string.Empty;
            //time.Start();
            //for (long i = 0; i < 10000; i++)
            //{
            //    test += i;
            //}
            //time.Stop();
            //Console.WriteLine(time.ElapsedMilliseconds);
            ////Console.WriteLine(test);
            //time.Reset();
            //StringBuilder testsb = new StringBuilder();
            //time.Start();
            //for (long i = 0; i < 10000; i++)
            //{
            //    testsb.Append(i);
            //}
            //time.Stop();
            //Console.WriteLine(time.ElapsedMilliseconds);
            //time.Reset();

            // Apple : 0, Banana : 1, Orange : 2
            // if (item == 1) printf("바나나는 달다")

            //enum Size { Short, Tail, Grande, Venti };
            for (int i = 0; i < 4; i++)
            {
                if (i == 0) { Console.WriteLine("숏 사이즈"); }
                else if (i == 1) { Console.WriteLine("테일 사이즈"); }
                else if (i == 2) { Console.WriteLine("그랑데 사이즈"); }
                else if (i == 3) { Console.WriteLine("벤티 사이즈"); }
            }
            for (int i = 0; i < 4; i++)
            {
                //if (i == "Short") { Console.WriteLine("숏 사이즈"); }
                if (i == (int)Size.Short) { Console.WriteLine("숏 사이즈"); }
                else if (i == (int)Size.Tail) { Console.WriteLine("테일 사이즈"); }
                else if (i == (int)Size.Grande) { Console.WriteLine("그랑데 사이즈"); }
                else if (i == (int)Size.Venti) { Console.WriteLine("벤티 사이즈"); }
            }

        }
    }
}

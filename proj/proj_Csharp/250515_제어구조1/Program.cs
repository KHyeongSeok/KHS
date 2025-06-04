namespace _250515_제어구조1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 제어 구조
            // 1. 조건문(분기 : 여러 경우로 생각을 확장하기)
            // BMI p.135
            // BMI < 20 : 저체중, 20 <= BMI <25 : 정상체중,
            // 25 <= BMI < 30 : 경도비만, 30 <= BMI < 40 : 비만,
            // 40 <= BMI : 고도비만
            //int BMI = 19;
            //if (BMI < 20) { Console.WriteLine("저체중"); }
            //else if (20 <= BMI && BMI < 25) { Console.WriteLine("정상체중"); }
            //else if (25 <= BMI && BMI < 30) { Console.WriteLine("경도비만"); }
            //else if (30 <= BMI && BMI < 40) { Console.WriteLine("비만"); }
            //else { Console.WriteLine("고도비만"); }

            // 2. 반복문(정해진 로직을 반복 수행)
            // while, do while, for, foreach
            // while 풀이법
        //    int BMI = 0;
        //    while (BMI >= 0) // ex) while(true) - 무한루프
        //    {
        //        Console.Write("BMI값? (종류하려면 음수입력) : ");
        //    string sBMI = Console.ReadLine();
        //        BMI = int.Parse(sBMI);
        //        if (0 <= BMI && BMI < 20) { Console.WriteLine("저체중"); }
        //    else if (20 <= BMI && BMI < 25) { Console.WriteLine("정상체중"); }
        //    else if (25 <= BMI && BMI < 30) { Console.WriteLine("경도비만"); }
        //    else if (30 <= BMI && BMI < 40) { Console.WriteLine("비만"); }
        //    else if (40 <= BMI) { Console.WriteLine("고도비만"); }
        //    else { Console.WriteLine("bye!"); }
        //}

        // for 풀이법 (초기세팅; 반복문수행조건; 다음반복을 위한작업)
        //int BMI = 0;
        //    for (int i = 0; i < 3; i++) // i : 0 -> 1 -> 2 -> 3
        //    {
        //        Console.Write("BMI값? (3번만 판별합니다.) : ");
        //        string sBMI = Console.ReadLine();
        //        BMI = int.Parse(sBMI);
        //        if (0 <= BMI && BMI < 20) { Console.WriteLine("저체중"); }
        //        else if (20 <= BMI && BMI < 25) { Console.WriteLine("정상체중"); }
        //        else if (25 <= BMI && BMI < 30) { Console.WriteLine("경도비만"); }
        //        else if (30 <= BMI && BMI < 40) { Console.WriteLine("비만"); }
        //        else if (40 <= BMI) { Console.WriteLine("고도비만"); }
        //    }
        //    Console.WriteLine("bye!");
            // 예제
            int a = 1; int sum = 0;
            while (a <= 3)
            {
                sum += a;
                a++;
            }
            Console.WriteLine($"1 to 3 누적합은 {sum}이다.");
            sum = 0;
            for (int num = 1; num <= 3; num++)
            {
                sum += num;
            }
            Console.WriteLine($"1 to 3 누적합은 {sum}이다.");
            int b = 0; sum = 0;
            do
            {
                sum += b;
                b++;
            } while (b <= 3);
            Console.WriteLine($"1 to 3 누적합은 {sum}이다.");
            int[] array = { 10, 20, 30, 40 }; sum = 0;
            for (int i2 = 0; i2 <= 3; i2++)
            {
                sum += array[i2];
            }
            //foreach (int num in array)
            //{
            //    sum += num;
            //}
            Console.WriteLine($"10 to 40 누적합은 {sum}이다.");

            //3. 합 : 일반적인 대응이 가능하다.
            // 0:월, 1:화, 2:수, 3:목, 4:금
            //for (int 요일 = 0; 요일 <= 6; 요일++)
            //{
            //    if (요일 == 0) { Console.WriteLine("월요병 앓는 중"); }
            //    else if (요일 == 1) { Console.WriteLine("화요일 화가 난다"); }
            //    else if (요일 == 2) { Console.WriteLine("수요일 수심이 가득"); }
            //    else if (요일 == 3) { Console.WriteLine("목요일 지친다"); }
            //    else if (요일 == 4) { Console.WriteLine("금요일 이제 곧 주말이다"); }
            //    else if (요일 == 5 || 요일 == 6) { Console.WriteLine("토일 주말이다"); }
            //}
            //Console.WriteLine("-----switch문-----");
            //for (int 요일 = 0; 요일 <= 6; 요일++)
            //{
            //    switch (요일)
            //    {
            //        case 0:
            //            Console.WriteLine("월요병 앓는 중");
            //            break;
            //        case 1:
            //            Console.WriteLine("화요일 화가 난다");
            //            break;
            //        case 2:
            //            Console.WriteLine("수요일 수심이 가득");
            //            break;
            //        case 3:
            //            Console.WriteLine("목요일 지친다");
            //            break;
            //        case 4:
            //            Console.WriteLine("금요일 이제 주말이다");
            //            break;
            //        case 5:
            //        case 6:
            //            Console.WriteLine("토일 주말이다");
            //            break;
            //    }
            //}

            // 2단 : 2(단) * 1(곱) = 2
            // 3단 : 3     * 1
            //       3     * 2
            // 단 : 2단 ~ 9단
            // 곱 : 1 ~ 9
            //for (int 단 = 2; 단 <=9; 단++)
            //{
            //    Console.WriteLine($"----{단}단 시작----");
            //    for (int 곱 = 1; 곱 <= 9; 곱++)
            //    {
            //        Console.WriteLine($"{단} * {곱} = {단 * 곱}");
            //    }
            //}
            //int 단 = 2;
            //while (단 <= 9)
            //{
            //    Console.WriteLine($"----{단}단 시작----");
            //    int 곱 = 1;
            //    while (곱 <= 9)
            //    {
            //        Console.WriteLine($"{단} * {곱} = {단 * 곱}");
            //        곱++;
            //    }
            //    단++;
            //}
            //int c = 0;
            //while (true)
            //{
            //    if (c == 10) break; // break에 의해 while문이 끝남
            //    c++;
            //    if (c % 2 == 0) continue; // 짝수 일때 건너 뜀
            //    Console.Write(c);
            //}
            //c = 0;
            //while (c < 10)
            //{
            //    if (c % 2 != 0) // break와 contiune를 사용 하지 않고 사용하는 법
            //    {
            //        Console.Write(c);
            //    }
            //    c++;
            //}

            //double min = double.MaxValue;
            //double max = double.MinValue;

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write("너의 점수는?"); string sPoint = Console.ReadLine();
            //    double point = double.Parse(sPoint);
            //    if (point > max)
            //    {
            //        max = point;
            //    }
            //    if (point < min)
            //    {
            //        min = point;
            //    }
            //}
            //Console.WriteLine($"max : {max}, min : {min}");

            //int x = 2;
            //int y = 3;
            //int pow = 1;
            //for (int y_i = 0; y_i < y; y_i++)
            //{
            //    pow *= x;
            //}
            //Console.WriteLine($"{x}의 {y}제곱은 {pow}");

            //p.148 반복문(!)
            // p.241 재귀함수(재귀메소드)
            //팩토리얼(!)
            //int fact = 1;
            //for (int i = 2; i <= 5; i++) // i : 2, 3, 4, 5
            //{
            //    fact *= i;
            //}
            //Console.WriteLine($"5! = {fact}");
            //Console.WriteLine($"5! = {Fact(5)}");

            // 1번 피라미드
            //    Console.WriteLine("(1)");
            //    for (int 행 = 1; 행 <= 5; 행++)
            //    {
            //        for (int 열 = 1; 열 <= 행; 열++)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.Write("\n");
            //    }
            //    Console.WriteLine("(2)");
            //    for (int 행 = 1; 행 <= 5; 행++)
            //    {
            //        for (int 열 = 1; 열 <= 2 * 행 - 1; 열++)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.Write("\n");
            //    }
            //    Console.WriteLine("(3)");
            //    for (int 행 = 1; 행 <= 5; 행++)
            //    {
            //        for (int 열 = 5; 열 >= 행; 열--)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.Write("\n");
            //    }
            //    Console.WriteLine("(4)");
            //    for (int 행 = 1; 행 <= 5; 행++)
            //    {
            //        for (int 열 = 5 - 행; 열 > 0; 열--) Console.Write(" ");
            //        for (int 열 = 0; 열 < 행; 열++) Console.Write("*");
            //        Console.Write("\n");
            //    }
        }
    // 5! = 5 * 4!
    //          4! = 4 * 3!
    //                   3! = 3 * 2!
    //                            2! = 2 * 1
    //private static double Fact( double x)
    //{
    //    if (x == 1)
    //        return 1;
    //    else
    //        return x * Fact(x - 1);
    //}
}
}
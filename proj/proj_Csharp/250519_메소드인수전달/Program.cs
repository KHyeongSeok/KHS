namespace _250519_메소드인수전달
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            sqr(a);
            Console.WriteLine($"값에 의한 호출 : {a}");
            int b = 3;
            sqr(ref b);
            Console.WriteLine($"ref에 의한 호출 : {b}");
            int res = sqr_return(a);
            Console.WriteLine($"값에 의한 호출 : {res}");
            int num1 = 7;
            int num2 = 2;
            int sum;
            int sub;
            int mul;
            int div;
            Sachink(num1, num2, out sum, out sub, out mul, out div);
            Console.WriteLine($"out에 의한 호출 : 합{sum} 차{sub} 곱{mul} 몫{div}");
        }
        static void Sachink(int a, int b, out int sum, out int sub, out int mul, out int div)
        {
            sum = a + b;
            sub = a - b;
            mul = a * b;
            div = a / b;
        }
        static void sqr (int x)
        {
            x = x * x;
        }
        static void sqr(ref int x)
        {
            x = x * x;
        }
        static int sqr_return(int x)
        {
            x = x * x;
            return x;
        }
    }
}

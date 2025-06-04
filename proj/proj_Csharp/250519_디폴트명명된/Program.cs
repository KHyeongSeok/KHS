namespace _250519_디폴트명명된
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int res = inc(num, 2); // int res = inc(num, 1);
            Console.WriteLine($"{num}로부터 증가한 양은 {res}이다.");
            int res2 = sub(frontNum:2, backNum:1);
            Console.WriteLine($"2 - 1 = {res2}");
        }
        static int inc(int x, int incAmount = 1)
        {
            x += incAmount;
            return x;
        }
        static int sub(int backNum, int frontNum)
        {
            return frontNum - backNum;
        }
    }
}

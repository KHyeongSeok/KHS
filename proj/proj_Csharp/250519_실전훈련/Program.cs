namespace _250519_실전훈련
{
    internal class Program
    {
        class Num
        {
            private int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            public int this[int index]
            {
                get { return num[index]; }
                set { num[index] = value; }
            }
            public int Length => num.Length;
            //public int Length { get { return days.Length; } }
        }
        static void Main(string[] args)
        {
            Num n = new Num();
            for (int i = 0; i < n.Length; i++)
            {
                for (int j = 0; i < n.Length; j++)
                {
                    Console.Write($"{n[i] * n[j]} ");
                }
                Console.WriteLine();
            }
            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        Console.Write($"{i * j} ");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}

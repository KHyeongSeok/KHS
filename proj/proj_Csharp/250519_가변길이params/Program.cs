namespace _250519_가변길이params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num_in = { 1, 2, 3, 4, 5, 6, 7 };
            double num_res = Average(num_in);
            Console.WriteLine($"평균 : {num_res}");
        }
        // public static double Average(params int[] x, int totalCount) - params 뒤에 붙이면 오류 남

        //public static double Average(int totalCount, params int[] x)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < totalCount; i++)
        //    {
        //        sum += x[i];
        //    }
        //    return sum / totalCount;
        //}                                         // 이건 됌
        public static double Average(params int[] x)
        {
            int sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum += x[i];
            }
            return sum/x.Length;
        }
    }
}

namespace _250516_배열
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] a = { 1, 2, 3 };
            //int[] b = new int[] { 1, 2, 3 };
            //int[] c = new int[3] { 1, 2, 3 };
            //int[] d = new int[3];
            //d[0] = 1;
            //d[1] = 2;
            //d[2] = 3;
            //Console.WriteLine($"a[] {a[0]} {a[1]} {a[2]}");
            //Console.WriteLine($"b[] {b[0]} {b[1]} {b[2]}");
            //Console.WriteLine($"c[] {c[0]} {c[1]} {c[2]}");
            //Console.WriteLine($"d[] {d[0]} {d[1]} {d[2]}");

            //int[] a = { 5, 25, 75, 35, 15 };
            //PrintArray(a);
            //int[] b = a;
            //PrintArray(b);
            //a[0] = 50;
            //PrintArray(a);
            //PrintArray(b); // 메모리상 배열은 a[]이기 때문에 복사가 되지 않아 0번째자리 50이 출력 됨

            //int[] c = (int[])a.Clone(); // a.Clone()는 Object(모든 객체의 원형) 타입 반환
            //PrintArray(c);
            //a[0] = 500;
            //PrintArray(c); // Clone을 사용하여 배열이 복사 되었기 때문에 a[]배열을 바꿔도 c[]는 그대로

            //int[] d = new int[10];
            //Array.Copy(a, 0, d, 1, 3); // a[]배열의 0번째 부터 3번째까지 d[]배열의 1번째 위치에 복사
            //PrintArray(a);
            //PrintArray(d);

            //a.CopyTo(d, 3); // a[]배열을 d[]배열의 3번쨰 위치에 복사
            //PrintArray(d);
            //Array.Sort(a); // 오름차순으로 정렬
            //PrintArray(a);

            //Array.Reverse(a); // 내림차순으로 정렬
            //PrintArray(a);

            //Array.Clear(a, 1, a.Length / 2); // 지정 범위 초기화
            //PrintArray(a);

            //Array.Clear(a); // 배열 초기화
            //PrintArray(a);

            // 2차원 배열 : 직사각형
            // 1 2 3
            // 4 5 6
            //int[,] a = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            //for (int i_x = 0; i_x < 2; i_x++) // i_x : 0, 1
            //{
            //    for (int i_y = 0; i_y < 3; i_y++) // i_y : 0 ,1 ,2
            //    {
            //        Console.Write($"{a[i_x, i_y]} ");
            //    }
            //}
            //Console.Write("\n");
            // 2차원 가변배열
            // 1 2
            // 3 4 5
            //int[][] b = new int[2][]; // 비워두는 이유 : 정할 수 없어서
            //b[0] = new int[] { 1, 2 };// 2개 짜리
            //b[1] = new int[] { 3, 4, 5 };// 3개 짜리
            //for (int i_x = 0; i_x < 2; i_x++)
            //{
            //    for (int i_y = 0; i_y < b[i_x].Length; i_y++)
            //    {
            //        Console.Write($"{b[i_x][i_y]} ");
            //    }
            //}

            //Random r = new Random();
            //Console.WriteLine(r.Next());
            //Console.WriteLine(r.Next());
            //Console.WriteLine(r.Next());
            //Console.WriteLine(r.NextDouble());
            //Console.WriteLine(r.NextDouble());
            //Console.WriteLine(r.NextDouble());

            Random r = new Random();
            int[] myWin = new int[] { 0, 0, 0 };
            for (int i = 0; i < myWin.Length; i++)
            {
                int ranNum = r.Next(); int computer = ranNum % 3;

                Console.WriteLine("가위 0, 바위 1, 보 2? 숫자로 대답하세요");
                string slnput = Console.ReadLine();
                int nlnupt = int.Parse(slnput);

                // 내가 이기는 경우
                // 나:가위0 - 컴:보2, 나:바위1 - 컴:가위0, 나:보2 - 컴:바위1
                if ((nlnupt == 0 && computer == 2) ||
                    (nlnupt == 1 && computer == 0) ||
                    (nlnupt == 2 && computer == 1)) myWin[i] = 1;
            }
            Console.WriteLine($"{myWin[0]}{myWin[1]}{myWin[2]}");
        }
        private static void PrintArray(int[] arr)
        {
            foreach(int num in arr)
            {
                Console.Write(num); Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}

namespace _250519_인덱서
{
    internal class Program
    {
        class Weekdays
        {
            private string[] days = { "월", "화", "수", "목", "금", "토", "일" };
            public string this[int index]
            {
                get { return days[index]; }
                set { days[index] = value; }
            }
            public int Length => days.Length;
            //public int Length { get { return days.Length; } }
        }
        static void Main(string[] args)
        {
            Weekdays week = new Weekdays();
            Console.WriteLine(week[0]);
            week[0] = "Mon";
            for (int i = 0; i < week.Length; i++)
            {
                Console.WriteLine($"{i}번째 인덱서 내용은 {week[i]}");
            }
        }
    }
}

namespace _250519_클래스와구조체
{
    struct DateStruct
    {
        public int year;
        public int month;
        public int day;
    }
    class DateClass
    {
        public int year;
        public int month;
        public int day;
    }
    class DtaeClass2
    {
        public int year;
        public int month;
        public int day;
        public DtaeClass2()
        {
            year = 3024;
            month = 5;
            day = 19;
        }
        public void print()
        {
            Console.WriteLine($"{year}-{month}-{day}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DtaeClass2 cday2 = new DtaeClass2();
            cday2.print();
            DateStruct sDay;
            sDay.year = 2024;
            sDay.month = 5;
            sDay.day = 19;
            Console.WriteLine($"{sDay.year}-{sDay.month}-{sDay.day}");

            DateClass cDay = new DateClass();
            cDay.year = 2024;
            cDay.month = 5;
            cDay.day = 19;
            Console.WriteLine($"{cDay.year}-{cDay.month}-{cDay.day}");

            DateStruct sDay2;
            sDay2 = sDay;
            Console.WriteLine($"{sDay2.year}-{sDay2.month}-{sDay2.day}");
            sDay2.year = 2025;
            Console.WriteLine($"{sDay.year}-{sDay.month}-{sDay.day}");
            Console.WriteLine($"{sDay2.year}-{sDay2.month}-{sDay2.day}");
        }
    }
}

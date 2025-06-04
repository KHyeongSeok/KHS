namespace _250515_constreadonly
{
    class ConstEx
    {
        // public : class외부에서 보임, const : 상수
        public const int number = 3;
    }
    class ReadonlyEx
    {
        public readonly int number = 10;
        // 생성자 : 함수처럼 생겼고, 클래스와 이름이 같다. return type이 없다.
        // 생성초기에 할 일을 정의
        public ReadonlyEx() { number = 20; }
        // 생성자는 여러 종류가 있다.
        public ReadonlyEx(int n) { number = n; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConstEx.number); // const 사용
            ReadonlyEx inst1 = new ReadonlyEx(); // readonly 사용
            Console.WriteLine(inst1.number);
            ReadonlyEx inst2 = new ReadonlyEx(100); // readonly 사용
            Console.WriteLine(inst2.number);
        }
    }
}

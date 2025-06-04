namespace _250519_스태틱
{
    class Car
    {
        int speed;
        public Car()
        {
            speed = 0;
        }
        public void SpeedUp()
        {
            speed += 10;
        }
        public static void BBangBBAng()
        {
            Console.WriteLine("빵빵!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car.BBangBBAng(); // static method : new가 불필요
            // (x new 필요) Car.SpeedUp();
            Car mysonata = new Car();
            mysonata.SpeedUp();
            Car yoursonata = new Car();
            yoursonata.SpeedUp();
        }
    }
}

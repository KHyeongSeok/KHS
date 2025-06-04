namespace _250519_getset
{
    class Rectangel
    {
        private double width;
        private double height;
        public double GetWidth()
        {
            return this.width;
        }
        public void SetWidth(double width)
        {
            if (width > 0)
            {
                this.width = width;
            }
        }
    }
    class RectangePropertyVer
    {
        public double Width
        {
            get;
            set;
        }
    }
    class RectangePropertyFullVer
    {
        private double width;
        public double Width
        {
            get { return width; }
            set { if (value > 0) width = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangel r = new Rectangel();
            //double num = 10.1;
            //if (num > 0)
            //{
            //    //r.width = 10;
            //}
            r.SetWidth(10.1);
            double result = r.GetWidth();
            RectangePropertyVer rProp = new RectangePropertyVer();
            rProp.Width = 10.3;
        }
    }
}

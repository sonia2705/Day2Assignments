namespace AbstractClassInterfaceDemo
{
    abstract class Shape
    {
        protected int area;
        public abstract void GetDimensions();
        public abstract void CalculateArea();
        public void DisplayArea()
        {
            Console.WriteLine("Area is " + area);
        }
    }
    class Square : Shape
    {
        int side;

        public override void CalculateArea()
        {
            area = side * side;
        }

        public override void GetDimensions()
        {
            Console.WriteLine("Enter side");
            side = Byte.Parse(Console.ReadLine());
        }
    }
    class Rectangle : Shape
    {
        int length, breadth;

        public override void GetDimensions()
        {
            Console.WriteLine("Enter length");
            length = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter breadth");
            breadth = Byte.Parse(Console.ReadLine());
        }
        public override void CalculateArea()
        {
            area = length * breadth;
        }


    }


    internal class Program
    {
        static void Main(string[] args)
        {

            Shape shape = null;
            Console.WriteLine("Enter the choice");
            int ch = byte.Parse(Console.ReadLine());
            if (ch == 1)
            {
                shape = new Square();
            }
            else if (ch == 2)
            {
                shape = new Rectangle();
            }
            shape.GetDimensions();
            shape.CalculateArea();
            shape.DisplayArea();

        }
    }
}
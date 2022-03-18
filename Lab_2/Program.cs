namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab N2 - Inheritance ");
            Console.WriteLine("Bagdeev Vladimir");


            Rectangle a = new Rectangle(){ Height = 13.7, Name = "Rectangle A", Width = 15.2 };
            Rectangle b = new Rectangle() { Width = 5.1, Name = "Rectangle B", Height = 2.8 };
           
            Console.WriteLine();
            Console.WriteLine("Figure nama: {0}", a.Name);
            Console.WriteLine("Figure area: {0}", a.GetArea());
            Console.WriteLine();
            Console.WriteLine("Figure nama: {0}", b.Name);
            Console.WriteLine("Figure area: {0}", b.GetArea());
            Console.WriteLine();

            Circle circle = new Circle() { Name = "Circle", r = 4 };
            Console.WriteLine("Figure nama: {0}", circle.Name);
            Console.WriteLine("Figure area: {0}", circle.GetArea());
            Console.WriteLine();

            Square square = new Square() { Name = "Square", a = 2 };
            Console.WriteLine("Figure nama: {0}", square.Name);
            Console.WriteLine("Figure area: {0}", square.GetArea());
            Console.WriteLine();

            Triangle triangle = new Triangle() { Name = "Triangle", a = 13, b = 14, c = 15 };
            Console.WriteLine("Figure nama: {0}", triangle.Name);
            Console.WriteLine("Figure area: {0}", triangle.GetArea());
            Console.WriteLine();

            Trapeze trapeze = new Trapeze() { Name = "Trapeze", base1 = 3, base2 = 5, Height = 2 };
            Console.WriteLine("Figure nama: {0}", trapeze.Name);
            Console.WriteLine("Figure area: {0}", trapeze.GetArea());
            Console.WriteLine();

            Rhomb rhomb = new Rhomb() { a = 4, b = 5, Name = "Rhomb" };
            Console.WriteLine("Figure nama: {0}", rhomb.Name);
            Console.WriteLine("Figure area: {0}", rhomb.GetArea());
            Console.WriteLine();

            Parallelogram parallelogram = new Parallelogram() { Name = "Parallelogram", b = 6, h = 3 };
            Console.WriteLine("Figure nama: {0}", parallelogram.Name);
            Console.WriteLine("Figure area: {0}", parallelogram.GetArea());
            Console.WriteLine();

            Pentagon pentagon = new Pentagon() { h = 3, b = 5, Name = "Pentagon" };
            Console.WriteLine("Figure nama: {0}", pentagon.Name);
            Console.WriteLine("Figure area: {0}", pentagon.GetArea());
            Console.WriteLine();

            Decagon decagon = new Decagon() { Name = "Decagon", a = 4 };
            Console.WriteLine("Figure nama: {0}", decagon.Name);
            Console.WriteLine("Figure area: {0}", decagon.GetArea());

        }
    }
}
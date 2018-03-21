using System;

namespace interfaces_abstract
{
    abstract class Polygon
    {
        public abstract int Area(int l);
        protected virtual void Sides() { }
    }

    interface IShape
    {
        int Perimeter(int l, int b);
    }

    class Square : Polygon, IShape
    {
        public override int Area(int l)
        {
            return l * l;
        }

        protected override void Sides()
        {
            Console.WriteLine("Sides: 4");
        }

        public int Perimeter(int l, int b)
        {
            return 2 * l + 2 * b;
        }
    }

    class Circle : IShape
    {
        public int Perimeter(int l, int b = 0)
        {
            return 2 * 3 * l;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Polygon poly = new Square();
            Square sq = new Square();
            IShape sh = new Square();
            int peri = sh.Perimeter(2, 5);
            Circle cir = new Circle();
            cir.Perimeter(8);
        }
    }
}

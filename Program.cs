using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure triangle1 = new Triangle(1, 5, 5, 5);
            triangle1.GetInfo();
            Figure triangle2 = new Triangle(2, 3, 4, 5);
            triangle2.GetInfo();
        }
    }
    abstract class Figure
    {
        public int Id { get; private set; }
        public Figure(int id)
        {
            this.Id = id;
        }
        public abstract Figure Clone();
        public abstract void GetInfo();
    }

    class Triangle : Figure
    {
        private double _sideAB;
        private double _sideBC;
        private double _sideAC;
        public Triangle(int id, double sideAB, double sideBC, double sideAC)
        : base(id)
        {
            _sideAB = sideAB;
            _sideBC = sideBC;
            _sideAC = sideAC;
        }
        public override Figure Clone()
        {
            return new Triangle(Id, _sideAB, _sideBC, _sideAC);
        }
        public override void GetInfo()
        {
            Console.WriteLine("Triangle with AB = {0}, BC = {1}, AC = {2}", _sideAB, _sideBC, _sideAC);
        }
    }

}

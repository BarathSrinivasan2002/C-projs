using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

namespace Shape
{
    public abstract class Shape
    {
        public String Name {  get; private set; }
        public abstract double Area
        {
            get;
        }
         public Shape(String name) {
            Name = name;
        }
        public override string ToString() {
            String x = "The area of the " + Name + " is " + Area + " cm.";
            return x;
        }
    }
    public class Square : Shape {
        public Double Length { get; set; }
      

        public Square(String name, double length) : base( name)
        {
            Length = length;
        }

        public override double Area
        {
            get
            {
                // Given the side, return the area of a square:
                return Length * Length ;
            }
        }

    }
    public class Circle : Square
    {
        public Double Area { get { return Math.PI * Length*Length; } }
        public Circle(string name, double length): base(name,length) { 
        
        }

    }

    public class Rectangle : Shape { 
    public double Width { get; protected set; }
    public double Height { get; protected set; }
    public override double Area { get { return Width * Height; } }
       public Rectangle(string name, double height, double width) : base(name) {
            Height = height;
            Width = width;
        }
    }

    public class Ellipse : Rectangle {
        public double Area { get { return Math.PI* Width * Height; } }

        public Ellipse(string name, double height, double width) : base(name , width, height) {     
        
        }
    }

    public class Triangle : Rectangle
    {
        public double Area { get { return  Width * Height* 0.5; } }

        public Triangle(string name, double height, double width) : base(name, width, height) { 
        
        }
    }

    public class Diamond : Rectangle
    {
        public double Area { get { return Width * Height * 0.5; } }

        public Diamond(string name, double height, double width) : base(name, width, height)
        {

        }
    }

    public class Program
    {
       
        static void Main(string[] args)
        {
            //  Example1();


            Example2();
        }
        private static void Example2()
        {
            List<Shape> shapes = new List<Shape>();

            shapes.Add(new Square("s1", 2));
            shapes.Add(new Rectangle("r1", 2, 3));
            shapes.Add(new Circle("c1", 2));
            shapes.Add(new Triangle("t1", 4, 6));
            shapes.Add(new Ellipse("e1", 2, 3));
            shapes.Add(new Diamond("d1", 2, 3));

            shapes.Add(new Square("s2", 5));
            shapes.Add(new Rectangle("r2", 5, 4));
            shapes.Add(new Circle("c2", 1));
            shapes.Add(new Triangle("t2", 7, 8));

            foreach (var s in shapes)
            {
                Console.WriteLine(s);
            }

        }
    }

}

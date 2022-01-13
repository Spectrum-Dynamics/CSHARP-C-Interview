//Given an instance Circle of the following class:
using System;

    public sealed class Circle
    {
        public Circle(double r)
        {
            radius = r;
        }

        private double radius;

        public double Calculate(Func<double, double> op)
        {
            return op(radius);
        }
    }

//a)	write code to calculate the circumference of the circle, without modifying the Circle class itself.
//b)	Write code implements method GetArea(), without modifying the Circle class itself:
//	Circle c=new Circle(5);
//	Double area = c.GetArea()

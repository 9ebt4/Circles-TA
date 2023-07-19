using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Object
{
    public class Circle
    {
        //Properties
        private double Radius { get; set; }

        //Constructor
        public Circle(double _radius) 
        {
            Radius= _radius;
        }

        public double CalculateDiameter()
        {
            return Radius * 2;
        }
        public double CalculateCircumference()
        {
            return Radius * 2 * Math.PI;
        }
        public double CalculateArea()
        {
            return Radius * Radius * Math.PI;
        }
        public void Grow()
        {
            Radius = Radius* 2;
        }
        public double GetRadius()
        { 
            return Radius;
        }
         
    }
}

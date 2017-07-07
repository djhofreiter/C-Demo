using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication.Shapes;
using Shapes;

namespace demo.Shapes
{
    public class Rectangle : Shape
    {

        private int length;
        private int width;
        public Rectangle(int length, int width) : base(length, width)
        {
            this.length = length;
            this.width = width;
        }

        public override double Area()
        {
            return length * width;
        }


    }

}

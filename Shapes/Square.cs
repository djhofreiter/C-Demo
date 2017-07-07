using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication.Shapes;

namespace demo.Shapes
{
    public class Square : Rectangle
    {
        private int length;

        public Square(int length) : base(length, length)
        {
            this.length = length;   
        }

        public override double Area()
        {
            return length^2; 
        }
    }
}

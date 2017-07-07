using System;
using System.Collections.Generic;
using System.Text;
using Shapes;

namespace ConsoleApplication.Shapes
{
    /// <summary>
    /// Shapes Class
    /// </summary>
    public class Shape:IShape
    {
        //Default Constructor
        public Shape()
        {
            length = 0;
            width = 0;
        }


        /// <summary>
        /// Overloaded constructor
        /// </summary>
        /// <param name="length">integer representing the shape length</param>
        /// <param name="width">integer representing the shape width</param>
        public Shape(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        //fields or variables
        private int length;
        private int width;

        //Method to calculate the area of the shape
        public virtual double Area()
        {
            if (length * width ==0)
            {
                throw new ShapeZeroAreaException($"area is 0, length is {length} and width is {width}");
            }
            return width * length;
        }

        public String GetShapeInfo()
        {
            string result = "";

        result = "height is " + length + " and the width is " + width;
            result = $"length is {length} + and width is { width}";
        
                  return result;
            }
        public override string ToString()
        {
            return $"The shape: {GetShapeInfo()}";
        }
    }
    
}

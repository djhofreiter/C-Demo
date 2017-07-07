using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication.Shapes;
using demo.Shapes;
using Shapes;

namespace demo.ConsoleApp
{
    class Program
    {
        //private variables
        private static int num = 10;

        public static int GetNum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            Shapes.Rectangle r1 = new Shapes.Rectangle(1, 4);

            IShape r5 = new Rectangle(2, 2);

            //if (r1 is Rectangle)
            //{
            //    Console.WriteLine("r1 is a Retangle");
            //    Rectangle r2 = (Rectangle)r1;
            //    Rectangle r3 = r1 as Rectangle;
            //}

            List<Shape> shapes = new List<Shape>();
            shapes.Add(r1);
            shapes.Add(new Rectangle(2, 4));

            Console.WriteLine(shapes.Count);

            for (int i = 0; i < shapes.Count; i++)
            {
                
            }

            foreach (var item in shapes)
            {
                Console.WriteLine(item.GetType());
                Console.WriteLine(item.Area());
                Console.WriteLine(item.ToString);
            }

            Dictionary<string, Shape> dict = new Dictionary<string, Shape>();

            Console.ReadLine();










            //            Rectangle Rect1 = new Rectangle(1, 0);

            //            try
            //            {
            //                Rect1.Area();
            //            }
            //            catch (Exception e)
            //            {
            //                Console.WriteLine(e.Message);
            //            }

        }
    }
}
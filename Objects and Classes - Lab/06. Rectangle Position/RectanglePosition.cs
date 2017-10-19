using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rectangle_Position
{
    class RectanglePosition
    {
        static void Main(string[] args)
        {
            var firstInput = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToList();
            var secondInput = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToList();
            rectangle firsRectangle=new rectangle();
            rectangle secondRectangle=new rectangle();
            AddProps(firsRectangle,firstInput);
            AddProps(secondRectangle,secondInput);
            if (IsInside(firsRectangle,secondRectangle))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }

        static bool IsInside(rectangle firsRectangle, rectangle secondRectangle)
        {
            if (firsRectangle.left>=secondRectangle.left&&firsRectangle.right<=secondRectangle.right&&firsRectangle.top>=secondRectangle.top&&firsRectangle.bottom<=secondRectangle.bottom)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        static void AddProps(rectangle rectangle,List<int> input)
        {
            rectangle.left = input[0];
            rectangle.top = input[1];
            rectangle.width = input[2];
            rectangle.height = input[3];
        }
        class rectangle
        {
            public int left { get; set; }
            public int top { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int right {
                get { return left + width; }
            }
            public int bottom {
                get { return top + height; }
            }
        }
    }
}

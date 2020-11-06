using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication49
{
    class Rectangle
    {
        double length;
        double width;
        double area;
        public Rectangle()
        {

        }
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
            //this.area = area;

        }
        public static Rectangle operator +(Rectangle r1,Rectangle r2)
      {
        Rectangle ans=new Rectangle();
        ans.length = r1.length + r2.length;
        ans.width = r1.width + r2.width;
        ans.area = ans.length * ans.width;
        return ans;
        

      }
        public void Display()
        {
            Console.WriteLine(this.length);
            Console.WriteLine(this.width);
            Console.WriteLine(this.area);
        }

    }
}

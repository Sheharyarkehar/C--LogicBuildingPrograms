using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abduL_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Marksheet m = new Marksheet();
            Console.Write("Enter number of Courses:");
            m.no_of_courses = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Total Marks");
            m.total_marks = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= m.no_of_courses;i++)
            {
                Console.Write("Enter name of Courses:");
                m.name_of_course = Console.ReadLine();
               
                Console.Write("Enter marks of Sub{0}:",i);
                m.marks = Convert.ToInt32(Console.ReadLine());
                m.obtained_marks += m.marks;

            }
            m.percentage = (m.obtained_marks * 100) / m.total_marks;
            Console.WriteLine("Percentage is "+m.percentage);
            
           
        }
    }
    public class Marksheet
    {
       public Marksheet()
        {

        }

       public string name_of_course;
        public int no_of_courses;
       public double obtained_marks;
       public double marks;
       public int total_marks;
        public double percentage;

       
    }
}

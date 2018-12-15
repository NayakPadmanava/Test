using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClass
{
    class GradeBook
    {
        int[] gradeObj;
        //public GradeBook()
        //{
        //    //Constructor
        //    gradeObj = new int[5];
        //    Console.WriteLine("Constructor is getting call");
        //}

        public GradeBook(int num)
        {
            gradeObj = new int[5];
            Console.WriteLine(num);
        }
        public GradeBook( GradeBook obj)
        {

            Console.WriteLine("Copy constructor");
        }
        public int AddGrade(int grade)
        {
            gradeObj[0] = grade;
            return grade;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    class BookGrade
    {
        private int score;
        private int percentage;
        private char grade;
        

        public string Name { get; set; }
        public char Grade
        {
            get
            {
                if (score == 50)
                {

                    return grade = 'A';
                }
                else
                {
                    return grade = 'B';
                }
            }
            // set { grade = value; }
        }

        public int Marks
        {
            set { score=value; }
            get {
                if(score > 50)
                { return score; }
                else
                {
                    return score=0;
                }
                 }
        }

        public int Percentage
        {
            get { return percentage; }
            set {  percentage = value; }
        }


    }
}

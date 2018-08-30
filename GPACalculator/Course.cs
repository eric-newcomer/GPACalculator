using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculator
{
    public class Course
    {
        public string Name { get; set; }
        public string Grade { get; set; }
        public int Credits { get; set; }

        public Course(string Name, string Grade, int Credits)
        {
            this.Name = Name;
            this.Grade = Grade;
            this.Credits = Credits;
        }
    }
}

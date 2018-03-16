using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EricGrehan_10375977
{
    class Student
    {
        public string FirstName {get;set;}
        public string SurName { get; set; }
        public string StudentNumber { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public string Course { get; set; }

        public Student() { }
        public Student(string firstName, string surName, string studentNumber, string county, string country, string course)
        {
            FirstName = firstName;
            SurName = surName;
            StudentNumber = studentNumber;
            County = country;
            Country = country;
            Course = course;
            //some comment
        }
    }
}

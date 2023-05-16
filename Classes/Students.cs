using Students_Grades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Grades
{
    public class Students : IStudents
    {
        public string Name { get; set; }
        public int Grade { get; set; }
    }
}

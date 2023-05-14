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
        /// <summary>
        /// Gets or sets the name of the student.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the grade of the student.
        /// </summary>
        public int Grade { get; set; }
    }
}

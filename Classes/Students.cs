using Students_Grades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Grades
{
    /// <summary>
    /// Represents a student with a name and grade.
    /// </summary>
    public class Students : IStudents
    {
        /// <summary>
        /// Implements the Name property from the IStudents interface.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Implements the Grade property from the IStudents interface.
        /// </summary>
        public int Grade { get; set; }
    }
}

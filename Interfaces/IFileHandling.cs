using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Grades.Interfaces
{
    internal interface IFileHandling
    {
        /// <summary>
        /// Reads a list of students from a file.
        /// </summary>
        /// <returns>A list of students.</returns>
        List<Students> Read();

        /// <summary>
        /// Writes a list of students to a file.
        /// </summary>
        /// <returns>A list of students.</returns>
        List<Students> Write();
    }
}

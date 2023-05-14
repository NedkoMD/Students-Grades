using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Grades.Interfaces
{
    /// <summary>
    /// Represents an interface for file handling related operations.
    /// </summary>
    internal interface IFileHandling
    {
        /// <summary>
        /// Reads student data from a file and returns a list of students.
        /// </summary>
        /// <returns>A list of students read from the file.</returns>
        List<Students> Read();

        /// <summary>
        /// Writes student data to a file and returns a list of students.
        /// </summary>
        /// <returns>A list of students that were written to the file.</returns>
        List<Students> Write();
    }
}

using System.Collections.Generic;

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

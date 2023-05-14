using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Grades.Interfaces
{
    /// <summary>
    /// Provides operations related to student grades.
    /// </summary>
    internal interface IGradeOperations
    {
        /// <summary>
        /// Displays information about all students.
        /// </summary>
        void ShowAllStudents();

        /// <summary>
        /// Calculates and displays the average grade of the students.
        /// </summary>
        void AverageGrade();

        /// <summary>
        /// Displays the student with the highest grade.
        /// </summary>
        void HighestGrade();

        /// <summary>
        /// Displays the student with the lowest grade.
        /// </summary>
        void LowestGrade();
    }
}

using Students_Grades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Students_Grades.Classes
{
    /// <summary>
    /// Provides different operations for student grades.
    /// </summary>
    internal class GradeOperations : IGradeOperations
    {
        private readonly List<Students> _studentList;

        /// <summary>
        /// Initializes a new instance of the <see cref="GradeOperations"/> class.
        /// </summary>
        /// <param name="studentList"></param>
        public GradeOperations(List<Students> studentList)
        {
            _studentList = studentList;
        }

        /// <summary>
        /// Displays the name and grade of all students.
        /// </summary>
        public void ShowAllStudents()
        {
            Console.WriteLine("Student-Grade ");
            Console.WriteLine("________________");
            foreach (Students student in _studentList)
            {
                Console.WriteLine($"{student.Name}-{student.Grade}");
            }
            Console.WriteLine("________________");
        }

        /// <summary>
        /// Calculates and displays the average grade of all students.
        /// </summary>
        public void AverageGrade()
        {
            double averageGrade = _studentList.Average(student => student.Grade);
            Console.WriteLine("Average grade of the students is {0}.", averageGrade);
        }

        /// <summary>
        /// Finds and displays the student with the highest grade.
        /// </summary>
        public void HighestGrade()
        {
            var highestGradeStudent = _studentList.OrderByDescending(student => student.Grade).First();
            Console.WriteLine("The student with the highest grade {0} is {1}.", highestGradeStudent.Grade, highestGradeStudent.Name);
        }

        /// <summary>
        /// Finds and displays the student with the lowest grade.
        /// </summary>
        public void LowestGrade()
        {
            var lowestGradeStudent = _studentList.OrderBy(student => student.Grade).First();
            Console.WriteLine("The student with the lowest grade {0} is {1}.", lowestGradeStudent.Grade, lowestGradeStudent.Name);
        }
    }
}

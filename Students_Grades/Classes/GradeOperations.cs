using NLog;
using Students_Grades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Students_Grades.Classes
{
    /// <summary>
    /// Provides operations for student grades.
    /// </summary>
    internal class GradeOperations : IGradeOperations
    {
        private readonly List<Students> _studentList;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Initializes a new instance of the GradeOperations class.
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
            if (_studentList.Any())
            {
                Console.WriteLine("Student-Grade");
                Console.WriteLine("________________");
                foreach (Students student in _studentList)
                {
                    Console.WriteLine($"{student.Name}-{student.Grade}");
                }
                Console.WriteLine("________________");
            }
            else
            {
                Console.WriteLine(Consts.showAllStudsError);
            }
        }

        /// <summary>
        /// Calculates and displays the average grade of all students.
        /// </summary>
        public void AverageGrade()
        {
            if (_studentList.Any())
            {
                double averageGrade = _studentList.Average(student => student.Grade);
                Console.WriteLine("Average grade of the students is {0}.", averageGrade);
            }
            else
            {
                Console.WriteLine(Consts.avgGradeError);
            }
        }

        /// <summary>
        /// Finds and displays the student with the highest grade.
        /// </summary>
        public void HighestGrade()
        {
            if (_studentList.Any())
            {
                var highestGradeStudent = _studentList.OrderByDescending(student => student.Grade).First();
                Console.WriteLine("The student with the highest grade {0} is {1}.", highestGradeStudent.Grade, highestGradeStudent.Name);
            }
            else
            {
                Console.WriteLine(Consts.highestGradeError);
            }
        }

        /// <summary>
        /// Finds and displays the student with the lowest grade.
        /// </summary>
        public void LowestGrade()
        {
            if (_studentList.Any())
            {
                var lowestGradeStudent = _studentList.OrderBy(student => student.Grade).First();
                Console.WriteLine("The student with the lowest grade {0} is {1}.", lowestGradeStudent.Grade, lowestGradeStudent.Name);
            }
            else
            {
                Console.WriteLine(Consts.lowestGradeError);
            }
        }
    }
}

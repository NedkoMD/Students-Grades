using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Students_Grades.Interfaces;
using Students_Grades.Classes;

namespace Students_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of FileHandling class implementing IFileHandling interface
            IFileHandling fileHandling = new FileHandling();

            // Read student data from file and store it in a list
            List<Students> studentList = fileHandling.Read();

            // Create an instance of GradeOperations class implementing IGradeOperations interface,
            // passing the studentList as a parameter to the constructor
            IGradeOperations operations = new GradeOperations(studentList);

            // Display all students
            operations.ShowAllStudents();

            // Display average grade
            operations.AverageGrade();

            // Display highest grade and student name
            operations.HighestGrade();

            // Display lowest grade and student name
            operations.LowestGrade();

            // Write students to a file
            fileHandling.Write();
        }
    }
}

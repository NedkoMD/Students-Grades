using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Grades.Classes
{
    public static class Consts
    {
        public const string projectFolder = "StudentsGrades";
        public const string textFilesFolder = "TextFiles";
        public const string gradesTxt = "grades.txt";
        public const string reportTxt = "report.txt";
        public const string fileWriteError = "Exception occurred while writing student grades.";
        public const string fileReadError = "Exception occurred while reading from the file.";
        public const string showAllStudsError = "No students found. Unable to show all students.";
        public const string avgGradeError = "No students found. Unable to calculate the average grade.";
        public const string highestGradeError = "No students found. Unable to calculate the highest grade.";
        public const string lowestGradeError = "No students found. Unable to calculate the lowest grade.";
    }
}

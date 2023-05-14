using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Grades.Interfaces
{
    internal interface IGradeOperations
    {
        void ShowAllStudents();
        void AverageGrade();
        void HighestGrade();
        void LowestGrade();
    }
}

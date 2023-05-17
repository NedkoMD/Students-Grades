using Students_Grades.Interfaces;

namespace Students_Grades
{
    public class Students : IStudents
    {
        public string Name { get; set; }
        public int Grade { get; set; }
    }
}

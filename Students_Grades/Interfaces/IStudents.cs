namespace Students_Grades.Interfaces
{
    /// <summary>
    /// Represents a student with a name and grade.
    /// </summary>
    internal interface IStudents
    {
        /// <summary>
        /// Gets or sets the name of the student.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the grade of the student.
        /// </summary>
        int Grade { get; set; }
    }
}

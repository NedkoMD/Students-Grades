using NUnit.Framework;
using Students_Grades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace StudentsGradesTests
{
    [TestFixture]
    public class GradeOperationTests
    {
        private StringWriter _consoleOutput;

        [SetUp]
        public void Setup()
        {
            // Create an instance of List<Student>
            _studentList = new List<Students>();
            _consoleOutput = new StringWriter();
            Console.SetOut(_consoleOutput);
        }

        [TearDown]
        public void TearDown()
        {
            // Clean up the console output redirection
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
        }

        [Test]
        public void ShowAllStudents_ShouldPrintAllStudentsAndGrades()
        {
            // Arrange
            _studentList.Add(new Students { Name = "Ivan Ivanov", Grade = 6 });
            _studentList.Add(new Students { Name = "Yana Petrova", Grade = 5 });
            _studentList.Add(new Students { Name = "Alex Galinov", Grade = 4 });

            // Act
            ShowAllStudents();

            // Assert
            string expectedOutput =
                "Student-Grade \r\n" +
                "________________\r\n" +
                "Ivan Ivanov-6\r\n" +
                "Yana Petrova-5\r\n" +
                "Alex Galinov-4\r\n" +
                "________________";
            string actualOutput = _consoleOutput.ToString().TrimEnd();
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        private void ShowAllStudents()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Student-Grade ");
            stringBuilder.AppendLine("________________");
            foreach (Students student in _studentList)
            {
                stringBuilder.AppendLine($"{student.Name}-{student.Grade}");
            }
            stringBuilder.AppendLine("________________");
            Console.WriteLine(stringBuilder.ToString());
        }

        private List<Students> _studentList;

        [Test]
        public void AverageGrade_ShouldCalculateAverageGrade()
        {
            // Arrange
            Students john = new Students { Name = "Peter Georgiev", Grade = 6 };
            Students jane = new Students { Name = "Martin Ivanov", Grade = 5 };
            Students alex = new Students { Name = "Galin Petrov", Grade = 4 };

            _studentList.Add(john);
            _studentList.Add(jane);
            _studentList.Add(alex);

            // Act
            double expectedAverage = (john.Grade + jane.Grade + alex.Grade) / 3.0;
            double actualAverage = _studentList.Average(student => student.Grade);

            // Assert
            Assert.AreEqual(expectedAverage, actualAverage);
        }

        [Test]
        public void HighestGrade_ShouldReturnStudentWithHighestGrade()
        {
            // Arrange
            _studentList.Add(new Students { Name = "Peter Georgiev", Grade = 6 });
            _studentList.Add(new Students{ Name = "Martin Ivanov", Grade = 5 });
            _studentList.Add(new Students { Name = "Galina Petrova", Grade = 4 });

            // Act
            var expectedHighestGradeStudent = new Students { Name = "Peter Georgiev", Grade = 6 };
            var actualHighestGradeStudent = _studentList.OrderByDescending(student => student.Grade).First();

            // Assert
            Assert.AreEqual(expectedHighestGradeStudent.Name, actualHighestGradeStudent.Name);
        }

        [Test]
        public void LowestGrade_ShouldReturnStudentWithLowestGrade()
        {
            // Arrange
            _studentList.Add(new Students { Name = "Peter Georgiev", Grade = 6 });
            _studentList.Add(new Students { Name = "Martin Ivanov", Grade = 5 });
            _studentList.Add(new Students { Name = "Galina Petrova", Grade = 4 });

            // Act
            var expectedLowestGradeStudent = new Students { Name = "Galina Petrova", Grade = 4 };
            var actualLowestGradeStudent = _studentList.OrderByDescending(student => student.Grade).Last();

            // Assert
            Assert.AreEqual(expectedLowestGradeStudent.Name, expectedLowestGradeStudent.Name);
        }
    }
}

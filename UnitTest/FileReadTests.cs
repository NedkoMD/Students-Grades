using NUnit.Framework;
using Students_Grades;
using Students_Grades.Classes;
using System.Collections.Generic;
using System.IO;

namespace Students_Grades.Tests
{
    [TestFixture]
    public class FileReadTests
    {
        private string _testFilePath;
        private List<Students> _studentList;

        [SetUp]
        public void SetUp()
        {
            // Set up a test file path outside the tests project
            _testFilePath = @"E:\.NET Rockstar\StudentsGrades\bin\Debug\TextFiles\grades.txt";

            // Create a sample student list
            _studentList = new List<Students>
            {
                new Students { Name = "Galin Petrov", Grade = 5 },
                new Students { Name = "Martin Ivanov", Grade = 6 },
                new Students { Name = "Martina Petrova", Grade = 4 }
            };
        }

        [Test]
        public void Read_ShouldReturnListOfStudents_WhenFileExists()
        {
            // Arrange
            FileRead fileRead = new FileRead(_studentList);

            // Act
            List<Students> result = fileRead.Read();

            // Assert
            Assert.AreEqual(_studentList.Count, result.Count);
            Assert.AreEqual(_studentList[0].Name, result[0].Name);
            Assert.AreEqual(_studentList[0].Grade, result[0].Grade);
        }
    }
}

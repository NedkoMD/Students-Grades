using NUnit.Framework;
using Students_Grades;
using Students_Grades.Classes;
using System;
using System.Collections.Generic;
using System.IO;

namespace Students_GradesTests
{
    [TestFixture]
    public class FileWriteTests
    {
        [Test]
        public void Write_ShouldWriteStudentsToFile()
        {
            // Arrange
            List<Students> studentList = new List<Students>()
            {
                new Students { Name = "Ivan Ivanov", Grade = 6 },
                new Students { Name = "Yana Ivanova", Grade = 5 }
            };

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, Consts.reportTxt);

            FileWrite fileWrite = new FileWrite(studentList);

            // Act
            List<Students> result = fileWrite.Write();

            // Assert
            // Check if the file was created
            Assert.IsTrue(File.Exists(filePath));

            // Check if the file contains the expected data
            string[] fileContent = File.ReadAllLines(filePath);
            Assert.AreEqual(2, fileContent.Length);
            Assert.AreEqual("Ivan Ivanov-6", fileContent[0]);
            Assert.AreEqual("Yana Ivanova-5", fileContent[1]);

            // Clean up - delete the file
            File.Delete(filePath);
        }
    }
}

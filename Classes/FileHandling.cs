using Students_Grades.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Students_Grades
{
    /// <summary>
    /// Provides file handling functionality for reading and writing student grades.
    /// </summary>
    internal class FileHandling : IFileHandling
    {
        private readonly List<Students> _studentList;

        /// <summary>
        /// Initializes a new instance of the FileHandling class.
        /// </summary>
        public FileHandling()
        {
            _studentList = new List<Students>();
        }

        /// <summary>
        /// Reads student grades from a file and returns a list of Students objects.
        /// </summary>
        /// <returns>A list of Students objects representing student grades.</returns>
        public List<Students> Read()
        {
            try
            {
                string filePath = Path.Combine(Environment.CurrentDirectory, "TextFiles", "grades.txt");

                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('-');
                        Students student = new Students();
                        student.Name = data[0];
                        student.Grade = int.Parse(data[1]);
                        _studentList.Add(student);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            return _studentList;
        }

        /// <summary>
        /// Writes student grades to a file.
        /// </summary>
        /// <returns>A list of Students objects that were written to the file.</returns>
        public List<Students> Write()
        {
            try
            {
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "report.txt");

                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (Students student in _studentList)
                    {
                        sw.WriteLine($"{student.Name}-{student.Grade}");
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            return _studentList;
        }
    }
}

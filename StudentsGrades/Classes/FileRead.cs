using NLog;
using Students_Grades.Classes;
using Students_Grades.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace Students_Grades
{
    /// <summary>
    /// Provides file handling functionality for reading and writing student grades.
    /// </summary>
    public class FileRead : IFileRead
    {
        private readonly List<Students> _studentList;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Initializes a constructor of the FileHandling class.
        /// </summary>
        public FileRead(List<Students> studentList)
        {
            _studentList = studentList;
        }

        /// <summary>
        /// Reads student grades from a file and returns a list of Students objects.
        /// </summary>
        /// <returns>A list of Students objects representing student grades.</returns>
        public List<Students> Read()
        {
            try
            {
                string filePath = Path.Combine(Environment.CurrentDirectory, Consts.textFilesFolder, Consts.gradesTxt);

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
                logger.Error(ex);
                Console.WriteLine(Consts.fileReadError);
            }

            return _studentList;
        }
    }
}

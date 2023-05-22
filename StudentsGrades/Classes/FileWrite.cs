using NLog;
using Students_Grades.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace Students_Grades.Classes
{
    public class FileWrite : IFileWrite
    {

        private readonly List<Students> _studentList;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Initializes a constructor of the FileHandling class.
        /// </summary>
        public FileWrite(List<Students> studentList)
        {
            _studentList = studentList;
        }

        /// <summary>
        /// Writes student grades to a file.
        /// </summary>
        /// <returns>A list of Students objects that were written to the file.</returns>
        public List<Students> Write()
        {
            try
            {
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), Consts.reportTxt);

                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (Students student in _studentList)
                    {
                        sw.WriteLine($"{student.Name}-{student.Grade}");
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                Console.WriteLine(Consts.fileWriteError);
            }

            return _studentList;
        }
    }
}

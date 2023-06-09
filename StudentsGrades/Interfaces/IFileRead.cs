﻿using System.Collections.Generic;

namespace Students_Grades.Interfaces
{
    public interface IFileRead
    {
        /// <summary>
        /// Reads a list of students from a file.
        /// </summary>
        /// <returns>A list of students.</returns>
        List<Students> Read();
    }
}

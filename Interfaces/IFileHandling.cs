using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Grades.Interfaces
{
    internal interface IFileHandling
    {
        List<Students> Read();
        List<Students> Write();
    }
}

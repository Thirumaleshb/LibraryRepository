using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRepository
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            string path = "D:\\C#\\FileLogger5.txt";

            File.AppendAllText(path, message + Environment.NewLine);

        }
    }
}

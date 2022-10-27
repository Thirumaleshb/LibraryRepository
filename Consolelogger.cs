using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRepository
{
    public  class Consolelogger:ILogger
    {
        //public StringBuilder logs=new StringBuilder();
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}

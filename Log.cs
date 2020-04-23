using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Log
    {
        public static void PrintLog(string directoryname, string filename, string contents)
        {
            DirectoryInfo di = new DirectoryInfo(directoryname);
            if (!di.Exists)
            {
                di.Create();
            }
            using (StreamWriter writer = new StreamWriter(directoryname + "\\" + filename, true))
            {
                writer.WriteLine("[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss" + "]" + contents));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ropositorio
{
    public class Log
    {
        public static void salvarLog(string tempo, string acao)
        {
            string path = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\logs.txt";
            if (!File.Exists(path))
                File.Create(path).Close();

            File.AppendAllText(path, "A ação de " + acao + " foi realizada em " + tempo + " segundos, em (" + DateTime.Now.ToShortDateString() + ")\r\n");
        }
    }
}

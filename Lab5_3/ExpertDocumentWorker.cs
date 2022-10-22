using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_3
{
    internal class ExpertDocumentWorker : ProDocumentWorker 
    {
        public ExpertDocumentWorker()
        {
            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            filePath = path + "/test.txtnew";
            File.Create(filePath).Dispose();
        }

        public override void SaveDocument()
        {
            File.WriteAllText(filePath, text);
            Console.WriteLine("Документ збережений в новому форматі");
            text = "";
        }
    }
}

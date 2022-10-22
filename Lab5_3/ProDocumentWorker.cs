using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_3
{
    internal class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Переписати документ:");
            text = Console.ReadLine();
            Console.WriteLine("Документ відредаговано");
        }

        public override void SaveDocument()
        {
            File.WriteAllText(filePath, text);
            Console.WriteLine("Документ збережено у старому форматі, збереження в інших форматах доступне у версії Експерт");
            text = "";
        }
    }
}

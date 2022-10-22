using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_3
{
    internal class DocumentWorker
    {
        protected string filePath;
        protected string text = "";

        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ відкритий");
            Console.WriteLine(File.ReadAllText(filePath));
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Правка документа доступна у версії Про");
        }


        public virtual void SaveDocument()
        {
            Console.WriteLine("Збереження документа доступне у версії Про");
        }



        public string ExpertKey { get; set; }
        public string ProKey { get; set; }
        public LicenseLevel Level { get; set; }

        public enum LicenseLevel
        {
            Expert,
            Pro
        }

        public DocumentWorker()
        {
            ExpertKey = "Exp442163";
            ProKey = "Pr554162";

            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            filePath = path + "/test.txtold";
            File.Create(filePath).Dispose();
        }
    }
}

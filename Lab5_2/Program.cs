using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode; 

            ClassRoom classRoom = new ClassRoom(new ExcelentPupil(), new BadPupil(), new GoodPupil());
            classRoom.ShowPupils(); 
        }
    }
}

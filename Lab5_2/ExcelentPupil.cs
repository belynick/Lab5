using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    internal class ExcelentPupil : Pupil
    {

        public override void Study()
        {
            Console.WriteLine("Чудовий учень: Я вмію Чудово вчитися");
        }

        public override void Read()
        {
            Console.WriteLine("Чудовий учень: Я вмію Чудово читати");
        }

        public override void Write()
        {
            Console.WriteLine("Чудовий учень: Я вмію Чудово писати");
        }

        public override void Relax()
        {
            Console.WriteLine("Чудовий учень: Я вмію Чудово відпочивати");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    internal class BadPupil : Pupil 
    {

        public override void Study()
        {
            Console.WriteLine("Поганий учень: Я вмію Погано вчитися");
        }

        public override void Read()
        {
            Console.WriteLine("Поганий учень: Я вмію Погано читати");
        }

        public override void Write()
        {
            Console.WriteLine("Поганий учень: Я вмію Погано писати");
        }

        public override void Relax()
        {
            Console.WriteLine("Поганий учень: Я вмію Погано відпочивати");
        }
    }
}

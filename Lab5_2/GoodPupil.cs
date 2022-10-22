using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    internal class GoodPupil : Pupil
    {

        public override void Study()
        {
            Console.WriteLine("Добрий учень: Я вмію Добре вчитися");
        }

        public override void Read()
        {
            Console.WriteLine("Добрий учень: Я вмію Добре читати");
        }

        public override void Write()
        {
            Console.WriteLine("Добрий учень: Я вмію Добре писати");
        }

        public override void Relax()
        {
            Console.WriteLine("Добрий учень: Я вмію Добре відпочивати");
        }
    }
}

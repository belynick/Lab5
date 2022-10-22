using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    internal class ClassRoom
    {
        Pupil[] arrPupil;
        public ClassRoom(params Pupil[] arrP)
        {
            arrPupil = arrP;
        }

        public void ShowPupils()
        {
            foreach (Pupil pupil in arrPupil)
            {
                pupil.Print();
            }
        }
    }
}

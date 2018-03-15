using System;
using System.Collections.Generic;
using System.Text;
using OO_exercises;

namespace OO_exercises
{
    class PAVETeacher : Teacher
    {
        public override string GetOccupation()
        {
            return "PAVE Teacher";
        }
        public PAVETeacher(int pStaffID, string pFname, string pLname, string pGender) :base (pStaffID, pFname, pLname, pGender)
        {
            TeachBehaviour = new TeachPAVE();
                       
        }
    }
}

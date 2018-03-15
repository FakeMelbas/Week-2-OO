using System;
using System.Collections.Generic;
using System.Text;

namespace OO_exercises
{
    class SecondaryTeacher : Teacher
    {
        public override string GetOccupation()
        {
            return "PAVE Teacher";
        }
        public SecondaryTeacher(int pStaffID, string pFname, string pLname, string pGender) :base (pStaffID, pFname, pLname, pGender)
        {
            TeachBehaviour = new TeachHighSchool();
        }
    }
}

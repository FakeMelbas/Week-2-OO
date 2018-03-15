using System;
using System.Collections.Generic;
using System.Text;

namespace OO_exercises
{
    class SpecialNeedsTeacher : Teacher
    {
        public SpecialNeedsTeacher(int pStaffID, string pFname, string pLname, string pGender) :base (pStaffID, pFname, pLname, pGender)
        {
            TeachBehaviour = new TeachSpecialNeeds();
        }
    }
}

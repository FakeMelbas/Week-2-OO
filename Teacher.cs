using System;
using System.Collections.Generic;
using System.Text;
using OO_exercises;

namespace OO_exercises
{
    public abstract class Teacher : Person
    {
        private int staffID;
        protected ITeach TeachBehaviour;

        public override string GetOccupation()
        {
            return "Teacher";
        }


        public int StaffID
        {
            get { return StaffID; }
            set { StaffID = value; }
        }
        public Teacher(int pStaffID, string pFname, string pLname, string pGender) :base (pFname, pLname, pGender)
        {
            staffID = pStaffID;
        }
        public override string Work()
        {
            return "Teach, teach, teach and stuff";
        }
    }
}

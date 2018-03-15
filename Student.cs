using OO_exercises;
using System;
using System.Collections.Generic;
using System.Text;

namespace OO_exercises
{
    public class Student : Person
    {
        private int studentID;

        public Student(int pStudentID, string pFName, string pLName, string pGender) :base (pFName, pLName, pGender)
        {
            studentID = pStudentID;
        }


        public int StudentID
        {
            get { return StudentID; }
            set {StudentID = value; }
        }
        public override string Work()
        {
            return "Study, Drink Coffee, Party, Sleep, Repeat";
        }

    }
}

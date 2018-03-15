using System;

namespace OO_exercises
{
    public abstract class Person
    {
        private string fName;
        private string gender;
        private string lName;

        public string GetGender()
        {
            return gender;
        }
        public virtual string GetOccupation()
        {
            return "Unemployed";
        }
        public Person(string pFname, string pGender, string pLname)
        {
            fName = pFname;
            gender = pGender;
            lName = pLname;

            switch(pGender)
            {
                case "M":
                    pGender = gender;
                    gender = "M";
                    break;
                case "F":
                    pGender = gender;
                    gender = "F";
                    break;

                default:
                    throw new InvalidOperationException("Invalid Gender Passed To Person Constructor");

            }
        }
        public Person(string pGender)
        {
            switch(pGender)
            {
                case "M":
                    Fname = "John";
                    gender = pGender;
                    lName = "Doe";
                    break;
                case "F":
                    Fname = "jane";
                    gender = pGender;
                    lName = "Doe";
                    break;
            }
        }
        public abstract string Work();

        private string Fname;

        public string FName
        {
            get { return FName; }
            set { FName = value; }
        }

        public string LName
        {
            get { return lName; }
            set { LName = value; }
        }

    }
   
}

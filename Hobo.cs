using OO_exercises;
using System;
using System.Collections.Generic;
using System.Text;

namespace OO_exercises
{
    class Hobo : Person
    {
    public Hobo(string pFName, string pLName, string pGender) :base (pFName, pLName, pGender)
    {

    }
    public Hobo(string pGender) :base (pGender)
    {

    }
    public override string Work()
    {
        return "Find A Place To Sleep";
    }
}
}

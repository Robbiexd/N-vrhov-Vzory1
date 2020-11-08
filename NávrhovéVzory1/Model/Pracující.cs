using System;
using System.Collections.Generic;
using System.Text;

namespace NávrhovéVzory1.Model
{
    public class Pracující : Osoba
    {
        public Pracující(int věk, string pohlaví, string jméno) : base(věk, pohlaví, jméno)
        {
        }

        public override string ToString()
        {
            return base.ToString() + " " + Věk.ToString() + " " + " " + Pohlaví + " " + " " + Jméno;
        }
    }
}

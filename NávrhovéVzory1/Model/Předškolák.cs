using System;
using System.Collections.Generic;
using System.Text;

namespace NávrhovéVzory1.Model
{
    public class Předškolák : Osoba
    {
        public Předškolák(int věk, string pohlaví, string jméno) : base(věk, pohlaví, jméno)
        {
        }

        public override string ToString()
        {
            return $"Typ: {nameof(Předškolák)}, Věk: {Věk.ToString()}, pohlaví: {Pohlaví}, Jméno: {Jméno}";
        }
    }
}

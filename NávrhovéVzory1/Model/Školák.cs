using System;
using System.Collections.Generic;
using System.Text;

namespace NávrhovéVzory1.Model
{
    public class Školák : Osoba
    {
        public Školák(int věk, string pohlaví, string jméno) : base(věk, pohlaví, jméno)
        {
        }

        public override string ToString()
        {
            return $"Typ: {nameof(Školák)}, Věk: {Věk.ToString()}, pohlaví: {Pohlaví}, Jméno: {Jméno}";
        }
    }
}

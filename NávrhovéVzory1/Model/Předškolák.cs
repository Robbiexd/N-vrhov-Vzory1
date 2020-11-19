using System;
using System.Collections.Generic;
using System.Text;

namespace NávrhovéVzory1.Model
{
    public class Předškolák : Osoba
    {
        public static byte počet = 0; // stačil by boolean, bybe je tu pro pripad, ze by bylo povoleno vice instanci
        public static Předškolák jižVytvořenáInstance;

        private Předškolák(int věk, string pohlaví, string jméno) : base(věk, pohlaví, jméno)
        {
        }

        public static Předškolák VraťTřídu(int věk, string pohlaví, string jméno)
        {
            if (Předškolák.počet < 1)
            {
                jižVytvořenáInstance = new Předškolák(věk, pohlaví, jméno);
                počet++;
            }
            return jižVytvořenáInstance;
        }

        public override string ToString()
        {
            return $"Typ: {nameof(Předškolák)}, Věk: {Věk.ToString()}, pohlaví: {Pohlaví}, Jméno: {Jméno}";
        }
    }
}

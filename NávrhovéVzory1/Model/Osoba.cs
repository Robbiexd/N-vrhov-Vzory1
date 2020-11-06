using System;
using System.Collections.Generic;
using System.Text;

namespace NávrhovéVzory1.Model
{
    public class Osoba
    {
        public int Věk { get; private set; } // vlastnosti: přístup k atributům pouze směrem ven
        public bool Pohlaví { get; private set; } // 1 = muž, 0 = žena
        public string Jméno { get; } // (chráněné, pouze pro čtení)


        // skrytý parametrický konstruktor se vstupními parametry věk, pohlaví, jméno
        protected Osoba(int věk, bool pohlaví, string jméno)
        {
            Věk = věk;
            Pohlaví = pohlaví;
            Jméno = jméno;
        }

        // veřejná statická metoda vracející instanci od třídy Osoba se vstupními parametry věk, pohlaví, jméno
        public static object VraťInstanci(int věk, bool pohlaví, string jméno)
        {
            if(věk < 0)
            {
                return null;
            }
            else if(věk >= 0 && věk <= 7)
            {
                Předškolák předškolák = new Předškolák()
            }

            else if(věk >= 8 && věk <= 19)
            {

            }
            else if (věk >= 20 && věk <= 19)
            {

            }
        }
    }
}

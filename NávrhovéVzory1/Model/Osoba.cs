using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace NávrhovéVzory1.Model
{
    public class Osoba
    {
        public int Věk { get; private set; } // vlastnosti: přístup k atributům pouze směrem ven
        public string Pohlaví { get; private set; } 
        public string Jméno { get; } // (chráněné, pouze pro čtení)


        // skrytý parametrický konstruktor se vstupními parametry věk, pohlaví, jméno
        protected Osoba(int věk, string pohlaví, string jméno)
        {
            Věk = věk;
            Pohlaví = pohlaví;
            Jméno = jméno;
        }

        // veřejná statická metoda vracející instanci od třídy Osoba se vstupními parametry věk, pohlaví, jméno
        public static object VraťInstanci(int věk, string pohlaví, string jméno)
        {
            // proč používat switch, když kaskáda if je to samé
            if(věk < 0)
            {
                return null;
            }
            else if(věk <= 7)
            {
                return Předškolák.VraťTřídu(věk, pohlaví, jméno);
            }

            else if(věk <= 19)
            {
                return Školák.VraťTřídu(věk, pohlaví, jméno);
            }
            else if (věk <= 65)
            {
                return Pracující.VraťTřídu(věk, pohlaví, jméno);
            }
            else 
            {
                return Důchodce.VraťTřídu(věk, pohlaví, jméno);
            }
        }


        // jak ověřit stárnutí? nechápu
        public object Stárnutí(int počet_let)
        {
            // ne, nemůžeme mládnout ;)
            return VraťInstanci(Věk + Math.Abs(počet_let), Pohlaví, Jméno);
        }
    }
}

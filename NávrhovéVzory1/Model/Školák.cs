using System;
using System.Collections.Generic;
using System.Text;

namespace NávrhovéVzory1.Model
{
    public class Školák : Osoba
    {
        public const byte omezenýPočetInstancí = 5; // fixní hodnota
        public static List<Školák> Školáci;
        public static byte počet = 0;
        private Školák(int věk, string pohlaví, string jméno) : base(věk, pohlaví, jméno)
        {
        }

        public static Školák VraťTřídu(int věk, string pohlaví, string jméno)
        {
            if (Školák.počet <= omezenýPočetInstancí)
            {
                počet++;
                Školák školák = new Školák(věk, pohlaví, jméno);
                Školáci.Add(školák);
                return školák;
                
            }
            else return null; // kdyz se uzivatel pokusi vytvorit vic instanci nez je povoleno, tak vracime null, neni v zadani specifikovano, co delat
        }


        // Pokud danou instanci už nebudete používat, tak ji vraťte, aby ji bylo možné poskytnout někomu jinému.
        // toto jsem pochopil tak, že proste instanci odebereme abz se uvolnilo místo a nekdo jiný si mohl vztvorit vlastni novou
        public static bool NavrátitNepoužívanouTřídu(string jméno)
        {
            foreach(Školák š in Školáci)
            {
                if (š.Jméno == jméno)
                {
                    Školáci.Remove(š);
                    počet--;
                    return true;

                }
                    
            }
            return false;

        }

        public override string ToString()
        {
            return $"Typ: {nameof(Školák)}, Věk: {Věk.ToString()}, pohlaví: {Pohlaví}, Jméno: {Jméno}";
        }
    }
}

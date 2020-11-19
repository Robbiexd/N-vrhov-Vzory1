using System;
using System.Collections.Generic;
using System.Text;

namespace NávrhovéVzory1.Model
{
    public class Pracující : Osoba
    {
        public static List<Pracující> Pracovníci;
        private Pracující(int věk, string pohlaví, string jméno) : base(věk, pohlaví, jméno)
        {
        }

        public static Pracující VraťTřídu(int věk, string pohlaví, string jméno)
        {
           for(int i = 0; i < Pracovníci.Count-1; i++)
            {
                if(Pracovníci[i].Jméno == jméno && Pracovníci[i].Pohlaví == pohlaví && Pracovníci[i].Věk == věk)
                {
                    return Pracovníci[i];
                }
            }
            return new Pracující(věk, pohlaví, jméno);
        }

        public override string ToString()
        {
            return $"Typ: {nameof(Pracující)}, Věk: {Věk.ToString()}, pohlaví: {Pohlaví}, Jméno: {Jméno}";
        }
    }
}

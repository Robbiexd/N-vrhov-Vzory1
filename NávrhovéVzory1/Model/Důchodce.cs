﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NávrhovéVzory1.Model
{
    public class Důchodce : Osoba
    {
        private Důchodce(int věk, string pohlaví, string jméno) : base(věk, pohlaví, jméno)
        {
        }

        public static Důchodce VraťTřídu(int věk, string pohlaví, string jméno)
        {
            return new Důchodce(věk, pohlaví, jméno);
        }
        public override string ToString()
        {
            return $"Typ: {nameof(Důchodce)}, Věk: {Věk.ToString()}, pohlaví: {Pohlaví}, Jméno: {Jméno}";
        }
    }
}

using NávrhovéVzory1.Model;
using System;

namespace NávrhovéVzory1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int věk; string jméno, pohlaví;
                Console.WriteLine("Zadejte věk:");
                věk = Math.Abs(Convert.ToInt32(Console.ReadLine())); // budeme doufat, že uživatel zadá číslo ;)
                Console.WriteLine("Zadejte pohlaví - muž, nebo žena:");
                pohlaví = Console.ReadLine(); // pozn. cmd neukládá některou diakritiku
                Console.WriteLine("Zadejte Jméno:");
                jméno = Console.ReadLine();

                var osoba = Osoba.VraťInstanci(věk, pohlaví, jméno);
                Console.WriteLine(osoba.ToString());

                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("");

            }
        }
    }
}

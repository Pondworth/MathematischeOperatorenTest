using System;

namespace MathematischeOperatoren
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ein Ausdruck ist eine Rechnung die ein Ergebnis liefert. 
            int zahl = 5 + 5;
            int zahl2 = 5 - 10;
            int zahl3 = 5 * 5;
            int zahl4 = 10 / 5;
            int zahl5 = 20;
            int zahl6 = 5;
            int ergebnis = zahl5 - zahl6;

            Console.WriteLine(zahl);
            Console.WriteLine(zahl2);
            Console.WriteLine(zahl3);
            Console.WriteLine(zahl4);
            Console.WriteLine(zahl5 + zahl6);
            Console.WriteLine(ergebnis);

            //Modulo Operator % ist der Restwert-Operator
            //10/3=3,33
            //10%3=1 > 10/3=3Rest1 
            int zahl7 = 10 / 3;
            int zahl8 = 10 % 3;
            Console.WriteLine(zahl7);
            Console.WriteLine(zahl8);

            Console.ReadKey();
        }
    }
}

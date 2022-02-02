using System;

namespace arayuzler_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INTERFACE");
            Focus focus = new();
            Console.WriteLine(focus.HangiMarkaninAraci().ToString());
            Console.WriteLine(focus.KacTekerlektenOlusur());
            Console.WriteLine(focus.StandartRengiNe().ToString());

            Civic civic = new();
            Console.WriteLine(civic.HangiMarkaninAraci().ToString());
            Console.WriteLine(civic.KacTekerlektenOlusur());
            Console.WriteLine(civic.StandartRengiNe().ToString());

            Corolla corolla = new();
            Console.WriteLine(corolla.HangiMarkaninAraci().ToString());
            Console.WriteLine(corolla.KacTekerlektenOlusur());
            Console.WriteLine(corolla.StandartRengiNe().ToString());

            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("ABSTRACT");

            NewFocus focus1 = new();
            Console.WriteLine(focus1.HangiMarkaninAraci().ToString());
            Console.WriteLine(focus1.KacTekerlektenOlusur());
            Console.WriteLine(focus1.StandartRengiNe().ToString());

            NewCivic civic1 = new();
            Console.WriteLine(civic1.HangiMarkaninAraci().ToString());
            Console.WriteLine(civic1.KacTekerlektenOlusur());
            Console.WriteLine(civic1.StandartRengiNe().ToString());
            
            NewCorolla corolla1 = new();
            Console.WriteLine(corolla1.HangiMarkaninAraci().ToString());
            Console.WriteLine(corolla1.KacTekerlektenOlusur());
            Console.WriteLine(corolla1.StandartRengiNe().ToString());
        }
    }
}
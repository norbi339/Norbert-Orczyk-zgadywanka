using System;

namespace ModelGry
{
    public class Gra
    {
        // inner types
        public enum Odpowiedz { ZaMalo = -1, ZaDuzo = 0, Trafiono = 1 }
        public enum StanGry { Trwa, Odgadnieta, Poddana }

        // fields
        public StanGry Stan { get; private set; }

        public readonly int ZakresOd, ZakresDo;

        //--------------
        private readonly int wylosowana;
        public int? Wylosowana
        {
            get
            {
                if (Stan == StanGry.Poddana || Stan == StanGry.Odgadnieta)
                    return wylosowana;
                else
                    return null;
            }
            //set { }
        }
        //--------------

        // hiatoria gry ToDo
        public int LicznikRuchow { get; private set; } = 0;

        // constructors
        public Gra(int a, int b)
        {
            ZakresOd = Math.Min(a,b);
            ZakresDo = Math.Max(a,b);
            wylosowana = Losuj(ZakresOd, ZakresDo);
            Stan = StanGry.Trwa;
        }

        public Odpowiedz Ocena(int propozycja )
        {
            LicznikRuchow++;
            if (propozycja < wylosowana)
                return Odpowiedz.ZaMalo;
            else if (propozycja > wylosowana)
                return Odpowiedz.ZaDuzo;
            else
            {
                Stan = StanGry.Odgadnieta;
                return Odpowiedz.Trafiono;
            }
        }

        public void Poddaj()
        {
            Stan = StanGry.Poddana;
        }

        /// <summary>
        /// Generuje liczbę pseudolosową z podanego zakresu, włącznie z krańcami
        /// </summary>
        /// <param name="min">dowolna liczba całkowita</param>
        /// <param name="max">dowolna liczba całkowita</param>
        /// <returns>liczba całkowita z podanego zakresu</returns>
        public static int Losuj(int min = 1, int max = 100)
        {
            if (min > max)
            { //swap
                int temp = min;
                min = max;
                max = temp;
            }
            Random generator = new Random();
            return generator.Next(min, max + 1);
        }
    }
}

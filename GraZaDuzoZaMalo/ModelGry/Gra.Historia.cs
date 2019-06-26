using System;
using System.Collections.Generic;
using System.Text;

namespace ModelGry
{
    public partial class  Gra
    {

        private readonly List<Ruch> historia;
        public IReadOnlyList<Ruch> Historia => historia;
       
        //inner class
        public class Ruch
        {
            public int propozycja { get; }
            public Odpowiedz odpowiedz { get; }
            public DateTime kiedy { get; }

            public Ruch(int prop, Odpowiedz odp)
            {
                propozycja = prop;
                odpowiedz = odp;
                kiedy = DateTime.Now;
            }
            public override string ToString() => $"({propozycja}, {odpowiedz}, {kiedy})";
          
        }
    }
}

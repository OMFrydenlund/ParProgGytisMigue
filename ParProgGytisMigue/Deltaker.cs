using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgGytisMigue
{
    internal class Deltaker
    {
        public string Navn { get; set; }
        public int Age { get; set; }
        public string Hobby { get; set; }

        public void PresenterDeltaker()
        {
            Console.WriteLine($"Hei mitt navn er {Navn}. Jeg er {Age} år gammel, og jeg er en {Hobby} på fritiden.");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice.Metier
{
    internal class Expression
    {
        public string A { get; set; }   
        public string B { get; set; }
        public string Op { get; set; }
        public Expression() { } 
        public string Evaluer()
        {

            try
            {
                double valA = Double.Parse(A);
                double valB = Double.Parse(B);
                double c;

                switch (Op)
                {
                    case "+": c = valA + valB; break;
                    case "-": c = valA - valB; break;
                    case "X": c = valA * valB; break;
                    case "/": c = valA / valB; break;
                    default: c = 0; break;
                }
                A = c.ToString();

                return c.ToString();
            }
            catch (Exception)
            {
                return "Error";
            }

        }

    }
}

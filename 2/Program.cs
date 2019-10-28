using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int auswahl;
            Console.WriteLine("Arbeiten mit strings");
            Console.WriteLine("1: Zeichen ersetzen.");
            Console.WriteLine("2: Vokale entfernen.");
            Console.WriteLine("3: Quersumme berechnen.");
            Console.WriteLine("4: Passwortstärke prüfen.");
            Console.WriteLine("Auswahl:");
            auswahl = Convert.ToInt32(Console.ReadLine());
            if (auswahl == 1)
            {
                string text, A = "";
                char Z, E;
                Console.WriteLine("Text eingeben:");
                text = Console.ReadLine();
                Console.WriteLine("Welche Zeichen soll ersetzt werden?");
                Z = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Ersetzen mit?");
                E = Convert.ToChar(Console.ReadLine());
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == Z)
                    {
                        A += E;
                    }
                    else
                    {
                        A += text[i];
                    }
                    //text.replace(Z,E);
                }
                Console.WriteLine(A);
            }
            else if (auswahl == 2)
            {
                string text, A = "";
                Console.WriteLine("Text eingeben:");
                text = Console.ReadLine();
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == 'e' || text[i] == 'a' || text[i] == 'u' || text[i] == 'o')
                    {
                        A += "";
                    }
                    else
                    {
                        A += text[i];
                    }
                }
                Console.WriteLine(A);
            }
            else if (auswahl == 3)
            {
                string eingabe;
                int Z = 0;
                Console.WriteLine("Zahl eingeben:");
                eingabe = Console.ReadLine();
                for (int i = 0; i < eingabe.Length; i++)
                {
                    Z += Convert.ToInt32(Convert.ToString(eingabe[i]));
                }
                Console.WriteLine("Die Quersumme von {0} beträgt {1}", eingabe, Z);
            }
            
  
        }
    }
}

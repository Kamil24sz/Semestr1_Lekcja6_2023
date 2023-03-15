using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestr1_Lekcja6_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instrukcja warunkowa IF

            Console.WriteLine("Podaj swój wynik z testu");
            int wynik = int.Parse(Console.ReadLine());

            // 100 - 6
            // 80-100 - 5
            // 70-80 - 4
            // 60-70 - 3
            // 50-60 - 2    wynik >= 50 && wynik < 60
            // 0-50 - 1    wynik < 50

            if(wynik < 50)
            {
                Console.WriteLine("Dostałeś ocenę 1");
            }
            else if(wynik >= 50 && wynik < 60)
            {
                Console.WriteLine("Dostałeś ocenę 2");
            }
            else if(wynik >= 60 && wynik < 70)
            {
                Console.WriteLine("Dostałeś ocenę 3");
            }
            else if(wynik >= 70 && wynik < 80)
            {
                Console.WriteLine("Dostałeś ocenę 4");
            }
            else if(wynik >= 80 && wynik < 100)
            {
                Console.WriteLine("Dostałeś ocenę 5");
            }
            else if(wynik == 100)
            {
                Console.WriteLine("Dostałeś ocenę 6");
            }

            //Zadanie z trójkątem
            double a, b, c;

            Console.WriteLine("Podaj długość boku a:");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj długość boku b:");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj długość boku c:");
            c = double.Parse(Console.ReadLine());

            if(a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Z tych boków można utworzyć trójkąt");
            }
            else
            {
                Console.WriteLine("Z tych boków nie można utworzyc trójkąta");
            }

            //Program z pierwiastkami
            Console.WriteLine("Podaj symbol lub liczbę atomową pierwaistka");
            string wejście = Console.ReadLine();

            //zamiana na duże litery
            wejście = wejście.ToUpper();

            if(wejście == "H" || wejście == "1")
            {
                Console.WriteLine("Pierwiastek to Wodór");
            }
            else if(wejście == "CO" || wejście == "27")
            {
                Console.WriteLine("Pierwiastek to Potas");
            }
            else if (wejście == "AG" || wejście == "19")
            {
                Console.WriteLine("Pierwiastek to Srebro");
            }
            else if (wejście == "AU" || wejście == "79")
            {
                Console.WriteLine("Pierwiastek to Złoto");
            }
            else if (wejście == "MG" || wejście == "12")
            {
                Console.WriteLine("Pierwiastek to Magnez");
            }

            Console.ReadLine();
        }
    }
}

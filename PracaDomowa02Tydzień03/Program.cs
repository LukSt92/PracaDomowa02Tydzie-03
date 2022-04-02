using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDomowa02Tydzień03
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int lnmb = random.Next(100);

            int licznik = 1;

            Console.WriteLine("System wylosował jedną liczbę z zakresu 1 - 100, proszę spróbuj którą.\nPodaj liczbę:");
            try
            {
                do
                {
                    int nmb = int.Parse(Console.ReadLine());
                    if (nmb > lnmb)
                    {
                        licznik++;
                        Console.WriteLine("Niestety, podana przez Ciebie liczba jest za duża.\nSpróbuj jeszcze raz:");
                    }

                    else if (nmb < lnmb)
                    {
                        licznik++;
                        Console.WriteLine("Niestety, podana przez Ciebie liczba jest za mała.\n Spróbuj jeszcze raz:");
                    }
                    else
                    {
                        Console.WriteLine($"Gratulacje! Udało Ci się odgadnąć wylosowaną liczbę w {licznik} próbach.");
                        break;
                    }
                }
                while (true);
            }
            catch (Exception)
            {
                Console.WriteLine("Podałeś niepoprawne dane.");
            }


            
        }
    }
}

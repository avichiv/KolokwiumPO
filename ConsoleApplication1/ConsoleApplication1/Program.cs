using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    enum Kolor
    {
        Biel,
        Czerwony,
        Zielony,
        Czarny
    }
    class Program
    {
        static void Main(string[] args)
        {
            string wybor;
            Console.WriteLine("Co chcesz zrobić?\nA - buduj biurowiec\nB - buduj dom jednorodzinny\nX - wyjście z aplikacji");
            do
            {
                wybor = Console.ReadLine();
                if(wybor == "A" )
                {
                    Console.WriteLine("Budujesz biurowiec.\nJaki rodzaj okien Cię interesuje: ");
                    string okno = Console.ReadLine();
                    Console.WriteLine("Jaki rodzaj drzwi Cię interesuje: ");
                    string drzwi = Console.ReadLine();
                    Console.WriteLine("Jaki kolor elewacji Cię interesuje:\nDostępne kolory: Biel, Czerwień, Zieleń, Czerń ");
                    string kolorElewacji = Console.ReadLine();
                    //ToString(okno, drzwi, kolorElewacji);


                }
                else if( wybor == "B")
                {
                    Console.WriteLine("Budujesz dom jednorodzinny.\nJaki rodzaj okien Cię interesuje: ");
                    string okno = Console.ReadLine();
                    Console.WriteLine("Jaki rodzaj drzwi Cię interesuje: ");
                    string drzwi = Console.ReadLine();
                    Console.WriteLine("Jaki kolor elewacji Cię interesuje:\nDostępne kolory: Biel, Czerwień, Zieleń, Czerń ");
                    string kolorElewacji = Console.ReadLine();
                }
                else if(wybor == "X")
                {
                    Console.WriteLine("Zapraszamy ponownie!");
                }
                else
                {
                    Console.WriteLine("Podałeś złą komendę, spróbuj jeszcze raz.");
                }

            }while(wybor != "X" );
            Console.ReadKey();

        }
    }
}

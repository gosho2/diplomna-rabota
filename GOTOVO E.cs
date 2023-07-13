using System;
using System.Collections.Generic;

namespace prenosimo_JP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dobre doshli vuv Bolnica Sveta Mariq!");
            Console.ReadKey();
            Console.WriteLine("Vuvedi biudjeta s koito razpolagash: ");
            decimal budget = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Imash izbor ot slednite operacii:");
            IDictionary<string, int> organs = new Dictionary<string, int>();
            organs.Add("mozuchna operaciq", 11000000);
            organs.Add("transplantaciq na bql drob", 164989);
            organs.Add("transplantaciq na cheren drob", 110000);
            organs.Add("transplantaciq na bubrek", 442500);
            organs.Add("lazerna operaciq na ochi", 6000);
            organs.Add("surdechna operaciq", 1800000);
            organs.Add("slagane na implant v ruka", 300);
            organs.Add("slagane na implant v krak", 17000);
            organs.Add("gipsirane", 100);
            organs.Add("operaciq na dalak", 500);
            organs.Add("operaciq na pankreas", 78000);
            foreach (string item in organs.Keys)
            {
                Console.WriteLine($"-{item}");
            }
            Console.WriteLine("Vuvedi jelana operaciq : ");
            string neshto = Console.ReadLine();
            Console.WriteLine($"Predstoi vi : {neshto}");
            Console.WriteLine($"Cenata na suotvetnata operaciq shte bude: {organs[neshto]}$");
            if (organs[neshto] > budget) 
            { 
                Console.WriteLine("Nqmate neobhodimite sredstva za operaciqta i nqma da oceleete!");
                Environment.Exit(0);
            }
            IDictionary<string, int> hirurzi = new Dictionary<string, int>();
            hirurzi.Add("Georgiev", 35);
            hirurzi.Add("Ivanov", 15);
            hirurzi.Add("Penchev", 60);
            hirurzi.Add("Temelkov", 23);
            hirurzi.Add("Slavov", 40);
            hirurzi.Add("Hadzhivasilev",100);
            Console.WriteLine("Izberete si hirurg za operaciqta kato imate slednite izbori:");
            foreach (string item in hirurzi.Keys)
            {
                Console.WriteLine($"-{item}");
            }
            string hirurg = Console.ReadLine();
            Console.WriteLine($"Ti izbra {hirurg} imash {hirurzi[hirurg]}% za ocelqvane");
            Console.WriteLine("Shte bude nujno kruvoprelivane za operaciqta.Molq vuvedi tvoqta kruvna grupa");
            string grupa = Console.ReadLine();
            if (grupa == "A")
            {
                Console.WriteLine($"Moje da se napravi kruvoprelivane ot vashi rodnini sus nuleva ili sus A grupa.Imate li takiva rodnini?");
                string answer = Console.ReadLine();
                if (answer == "da")
                {
                    Random r = new Random();
                    int a = r.Next(0, 100);
                    if (a > hirurzi[hirurg])
                    {
                        Console.WriteLine("Ako ne namerite donor nqma kak da budesh operiran");
                        Console.WriteLine("Ne ocelq!");
                    }
                    else
                    {
                        Console.WriteLine("Prekrasno shte budesh operiran na 16.07.2023 vuv 22:00");
                        Console.WriteLine("Ocelq!");
                    }
                }
                if (answer == "ne")
                {
                    Console.WriteLine("Ako ne namerite donor nqma kak da budesh operiran");
                    Console.WriteLine("Ne ocelq!");
                }
            }
            if (grupa == "B")
            {
                Console.WriteLine($"Moje da se napravi kruvoprelivane ot vashi rodnini sus nuleva ili sus B grupa.Imate li takiva rodnini?");
                string answer = Console.ReadLine();
                if (answer == "da")
                {
                    Random r = new Random();
                    int a = r.Next(0, 100);
                    if (a > hirurzi[hirurg])
                    {
                        Console.WriteLine("Ako ne namerite donor nqma kak da budesh operiran");
                        Console.WriteLine("Ne ocelq!");
                    }
                    else
                    {
                        Console.WriteLine("Prekrasno shte budesh operiran na 16.07.2023 vuv 22:00");
                        Console.WriteLine("Ocelq!");
                    }
                }
                if (answer == "ne")
                {
                    Console.WriteLine("Ako ne namerite donor nqma kak da budesh operiran");
                    Console.WriteLine("Ne ocelq!");
                }
            }
            if (grupa == "AB")
            {
                Console.WriteLine($"Moje da se napravi kruvoprelivane ot vashi rodnini sus nuleva, sus A, sus B ili sus AB grupa.Imate li takiva rodnini?");
                string answer = Console.ReadLine();
                if (answer == "da")
                {
                    Random r = new Random();
                    int a = r.Next(0, 100);
                    if (a > hirurzi[hirurg])
                    {
                        Console.WriteLine("Ako ne namerite donor nqma kak da budesh operiran");
                        Console.WriteLine("Ne ocelq!");
                    }
                    else
                    {
                        Console.WriteLine("Prekrasno shte budesh operiran na 16.07.2023 vuv 22:00");
                        Console.WriteLine("Ocelq!");
                    }
                }
                if (answer == "ne")
                {
                    Console.WriteLine("Ako ne namerite donor nqma kak da budesh operiran");
                    Console.WriteLine("Ne ocelq!");
                }
            }
            if (grupa == "0")
            {
                Console.WriteLine($"Moje da se napravi kruvoprelivane ot vashi rodnini sus nuleva grupa.Imate li takiva rodnini?");
                string answer = Console.ReadLine();
                if (answer == "da")
                {
                    Random r = new Random();
                    int a = r.Next(0, 100);
                    if (a > hirurzi[hirurg])
                    {
                        Console.WriteLine("Ako ne namerite donor nqma kak da budesh operiran");
                        Console.WriteLine("Ne ocelq!");
                    }
                    else
                    {
                        Console.WriteLine("Prekrasno shte budesh operiran na 16.07.2023 vuv 22:00");
                        Console.WriteLine("Ocelq!");
                    }
                }
                if (answer == "ne")
                {
                    Console.WriteLine("Ako ne namerite donor nqma kak da budesh operiran");
                    Console.WriteLine("Ne ocelq!");
                }
            }
        }
    }
}

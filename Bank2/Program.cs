using Bank;
using System;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account Konto = new Account("123456", "Doe", 400);
            Console.WriteLine("Wähle 1 für Kontostand,2 für Abheben, 3 für einzahlen oder 4 für Abbruch");
            int command = int.Parse(Console.ReadLine());

            while (command != 4)
            {
                if (command == 1)
                {   
                    Console.WriteLine($"Dein Kontostand beträgt {Konto.kontostand()}");
                    Console.WriteLine("Wähle 1 für Kontostand,2 für Abheben, 3 für einzahlen oder 4 für Abbruch");
                    command = int.Parse(Console.ReadLine());


                }
                else if (command == 2)
                {


                    if (Konto.Balance <= 0)
                    {
                        Console.WriteLine("Du hast kein Parra, Kenek!");
                        
                        command = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Wie viel willst du abheben?");
                        float abhebeSumme =float.Parse(Console.ReadLine());
                        Konto.abheben(abhebeSumme);
                        Console.WriteLine("Wähle 1 für Kontostand,2 für Abheben, 3 für einzahlen oder 4 für Abbruch");
                        command = int.Parse(Console.ReadLine());
                    }
                }
                else if (command == 3)
                {
                    Console.WriteLine("Wie viel willst du einzahlen?");
                    float einzahlSumme=float.Parse(Console.ReadLine());
                    Konto.einzahlen(einzahlSumme);
                    Console.WriteLine("Wähle 1 für Kontostand,2 für Abheben, 3 für einzahlen oder 4 für Abbruch");
                    command = int.Parse(Console.ReadLine());
                }
                else if (command == 4)
                {
                    break;
                }
            }
        }
    }
}

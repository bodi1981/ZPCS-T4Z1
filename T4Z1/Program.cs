using System;

namespace T4Z1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Podaj liczbę: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    if (number % 2 == 0)
                        Console.WriteLine($"{number} jest liczbą parzystą");
                    else
                        Console.WriteLine($"{number} jest liczbą nieparzystą");
                }
                else
                    Console.WriteLine($"Nie podano prawidłowej liczby");

                Console.WriteLine($"Naciśnij dowolny klawisz aby kontunować, w aby wyjść");
                if (Char.ToUpper(Console.ReadKey(true).KeyChar) == 'W')
                    return;
            }
        }
    }
}

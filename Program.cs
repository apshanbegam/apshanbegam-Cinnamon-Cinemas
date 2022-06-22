using System;
using System.Collections.Generic;
using System.Linq;
using Models.Ticket.Enums;
namespace Models.Ticket
{
    public class Program
    {
        static void Main(string[] args)
        {

            var cinema = new Cinema();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Print all Seats in Cinema");
                Console.WriteLine("2. Seed some sample booked seats");
                Console.WriteLine("3. Print empty/available seats");
                Console.WriteLine("4. Print taken seats");
                var opt = Console.ReadLine();
                switch (opt)
                {
                    case "1":
                        cinema.PrintCompleteSeats();
                        break;
                    case "2":
                        cinema.SeedCinemaSeats();
                        break;
                    case "3":
                        cinema.PrintEmptySeats();
                        break;
                    case "4":
                        cinema.PrintTakenSeats();
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
            }

        }
    }
}


using System;
using System.Collections.Generic;
using System. Linq;
using Models.Ticket.Enums;

namespace Models.Ticket
{
	public class Cinema 
    {
        public List<Seat> seats;

        public Cinema()
        {
            // Maximum number of seat of any cinema is 30.
            seats = new List<Seat>(15);
            GenerateCompleteSeats();

        }

        public void GenerateCompleteSeats()
        {
            int totalRow = 3;
            int totalCol = 5;
            for (int i = 0; i < totalRow; i++)
            {
                for (int y = 0; y < totalCol; y++)
                {
                    seats.Add(new Seat(i + 1, y + 1));
                }
            }
        }

        public void PrintSeats(List<Seat> s)
        {

            foreach (var item in s)
            {
                Console.WriteLine($"Row: {item.Row}. Col: {item.Col}. Status: {item.Status}");
            }
        }

        public void PrintCompleteSeats()
        {
            Console.WriteLine("Total seats: " + seats.Count);

            PrintSeats(seats);
        }

        public void SeedCinemaSeats()
        {
            int totalTakenSeatsNeeded = 15;
            int totalGeneratedEmptySeats = 0;

            if (totalGeneratedEmptySeats==15)
            {
                Console.WriteLine("Seats are already full");
            }
            else
            {
                while (totalGeneratedEmptySeats != totalTakenSeatsNeeded)
                {
                    // Generate a random number
                    Random r = new Random();
                    var randomNo = r.Next(1, 3);
                    Console.WriteLine(randomNo);
                    // Get a random seat

                    var randomSeat = seats[r.Next(seats.Count)];

                    // Remove random seat
                    //seats.Remove(randomSeat);

                    // Update random seat status
                    if (randomSeat.Status == EStatus.Empty)
                    {
                        randomSeat.Status = EStatus.Taken;

                        totalGeneratedEmptySeats++;
                    }

                }
            }

            
        }

        public void PrintEmptySeats()
        {

            var empty = seats.Where(s => s.Status == EStatus.Empty);
            Console.WriteLine("Total Seats: " + empty.Count());
            PrintSeats(empty.ToList());

        }

        public void PrintTakenSeats()
        {

            var taken = seats.Where(s => s.Status == EStatus.Taken);
            Console.WriteLine("Total Seats: " + taken.Count());
            PrintSeats(taken.ToList());
        }
    }
}


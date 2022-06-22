using System;
using Models.Ticket.Enums;

namespace Models.Ticket
{
	public class Seat
	{
        public int Row { get; }
        public int Col { get; }
        public EStatus Status { get; set; }


        public Seat(int row, int col)
        {
            Row = row;
            Col = col;
            Status = EStatus.Empty;
        }
    }
}


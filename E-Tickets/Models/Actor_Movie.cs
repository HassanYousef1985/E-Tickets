﻿using E_Tickets.Data;
using E_Tickets.Models;

namespace E_Tickets.Models
{
    public class Actor_Movie
    {
        public int MovieId { get; set; }
        public Movie? Movie { get; set; }

        public int ActorId { get; set; }
        public Actor? Actor { get; set; }
    }
}

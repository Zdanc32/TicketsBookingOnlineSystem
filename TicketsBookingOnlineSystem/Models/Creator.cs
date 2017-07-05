﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketsBookingOnlineSystem.Models
{
    public class Creator
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Deleted { get; set; }

        public virtual List<CreatorImage> CreatorImages { get; set; }
        public virtual List<Film> Films { get; set; }
    }
}
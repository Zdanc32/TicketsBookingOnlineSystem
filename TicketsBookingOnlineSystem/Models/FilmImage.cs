﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketsBookingOnlineSystem.Models
{
    public class FilmImage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Alt { get; set; }
        public string Description { get; set; }
        public bool Deleted { get; set; }

        public virtual Film Film { get; set; }
    }
}
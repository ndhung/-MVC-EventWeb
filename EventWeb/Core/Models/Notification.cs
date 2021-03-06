﻿using System;
using System.ComponentModel.DataAnnotations;

namespace EventWeb.Core.Models
{
    public class Notification
    {
        public int Id { get; private set; }
        public DateTime DateTime { get; private set; }
        public NotifycationType Type { get; private set; }
        public DateTime? OriginalDateTime { get; set; }
        public string OriginalVenue { get; set; }

        [Required]
        public Gig Gig { get; set; }


        public Notification()
        {
            
        }

        public Notification(Gig gig, NotifycationType type)
        {
            if (gig == null)
                throw new ArgumentNullException("gig");

            Gig = gig;
            Type = type;
            DateTime = DateTime.Now;
        }
    }
}
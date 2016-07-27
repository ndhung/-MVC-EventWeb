﻿using System.Collections.Generic;
using EventWeb.Models;

namespace EventWeb.ViewModels
{
    public class GigsViewModel
    {
        public GigsViewModel()
        {
        }

        public IEnumerable<Gig> UpComingGigs { get; set; }
        public bool ShowData { get; set; }
        public string Heading { get; set; }
        public object SearchKey { get; set; }
    }
}
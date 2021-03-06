﻿using System.Collections.Generic;
using System.Linq;
using EventWeb.Core.Models;

namespace EventWeb.Core.ViewModels
{
    public class GigsViewModel
    {
        public GigsViewModel()
        {
        }

        public IEnumerable<Gig> UpComingGigs { get; set; }
        public bool ShowData { get; set; }
        public string Heading { get; set; }
        public string SearchKey { get; set; }
        public ILookup<int, Attendance> AttendanceLookup { get; set; }
        public ILookup<string, Following> FollowingLookup { get; set; }
    }
}
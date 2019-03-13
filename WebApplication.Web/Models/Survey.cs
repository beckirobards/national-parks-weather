﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Web.Models
{
    public class Survey
    {
        public int Id { get; set; }

        public string ParkCode { get; set; }

        public string EmailAddress { get; set; }

        public string State { get; set; }

        public string ActivityLevel { get; set; }

        IList<Park> parks { get; set; } = new List<Park>();
    }
}

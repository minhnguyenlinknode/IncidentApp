﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObject
{
    public class Incident
    {
        public int Id { get; set; }
        public string IncidentName { get; set; }
        public DateTime CreatedDate { get; set; }
        public int NumberPeople { get; set; }
        public bool IsUrgent { get; set; }
        public int? IncidentType { get; set; }
    }
}

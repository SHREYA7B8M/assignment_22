﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_22
{
    public class Destination
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string MissionAcceptance { get; set; }

        public bool PrevMissionAccomplished { get; set; }
    }
}

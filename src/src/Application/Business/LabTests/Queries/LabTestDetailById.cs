﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Business.LabTests.Queries
{
    public class LabTestDetailById
    {
        public bool IsFastingRequired { get; set; }
        public string? Description { get; set; }
        public string? TubeType { get; set; } 
        public string? SampleType { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SyntaxMatching.Models.Rating
{
    public class RatingDetail
    {
        public int Id { get; set; }
        public double Value { get; set; }
        public bool IsUserOwned { get; set; }
    }
}
﻿using CarBook.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Results.CarFeatureResults
{
    public class GetCarFeatureByCarIdQueryResult
    {
        public int CarFeatureId { get; set; }
        public int FeatureID { get; set; }
        public string  FeatureName { get; set; }
        public bool Available { get; set; }
    }
}
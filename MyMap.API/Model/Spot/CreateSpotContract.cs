﻿using System;

namespace MyMap.API.Model.Spot
{
    public class CreateSpotContract 
    {
        public CreateSpotContract()
        {
        }

        public Guid Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public string Name { get; set; }

        public float? Height { get; set; }

        public decimal? Latitude { get; set; }

        public decimal? Longitude { get; set; }

        public int Type { get; set; }
    }
}
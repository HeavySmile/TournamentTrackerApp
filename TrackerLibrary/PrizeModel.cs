﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents what the prize is for the given place.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// The numeric identifier for the place.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// The friendly name for the place (second place, first runner up, etc.)
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// The fixed amount this place earns or zero if it is not used.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// The number that represents the percentage of the overall take or 
        /// zero if it is not used. The percentage is a fraction of 1 (0.5 for 50%). 
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}

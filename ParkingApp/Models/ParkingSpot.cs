﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingApp.Models
{
    public class ParkingSpot
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Display(Name = "City")]
        public string City { get; set; }
        [Display(Name = "State")]
        public string State { get; set; }
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }
        [Display(Name = "Hourly Rate")]
        public double HourlyRate { get; set; }
        [Display(Name = "Covered Spot")]
        public bool CoveredSpot { get; set; }
        [ForeignKey("ReservationId")]
        public int ReservationId { get; set; }
        public Reservation Reservation { get; set; }
        [Display(Name = "Notes")]
        public string Notes { get; set; }
        
        public bool IsPaid { get; set; }


        public DateTime EntryTime { get; set; }
        public DateTime ExitTime { get; set; }
    }
}

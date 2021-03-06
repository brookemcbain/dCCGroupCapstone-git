﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingApp.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Reservation Date")]
        public DateTime ReservationDate { get; set; }
        [Display(Name ="Start Time")]
        public DateTime StartTime { get; set; }
        [Display(Name = "End Time")]
        public DateTime EndTime { get; set; }
        public DateTime DateBooked { get; set; }
        public double EstimatedCost { get; set; }
        public Customer Customer { get; set; }
        
    }
}

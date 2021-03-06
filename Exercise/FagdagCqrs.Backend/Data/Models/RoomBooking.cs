﻿using System;
using FagdagCqrs.Database.Contracts;

namespace FagdagCqrs.Backend.Data.Models
{
    public class RoomBooking
    {
        public RoomBooking(Guid id, RoomType roomType, DateTime fromDate, int duration,
            decimal? price = null, RoomBookingStatus status = RoomBookingStatus.Draft)
        {
            Id = id;
            RoomType = roomType;
            FromDate = fromDate;
            Duration = duration;
            Price = price;
            Status = status;
        }

        public Guid Id { get; set; }
        public RoomType RoomType { get; set; }
        public DateTime FromDate { get; set; }
        public int Duration { get; set; }
        public RoomBookingStatus Status { get; set; }
        public decimal? Price { get; set; }
    }
}
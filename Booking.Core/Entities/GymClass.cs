﻿namespace Booking.Core.Entities
{
//#nullable disable
    public class GymClass
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public DateTime StartTime { get; set; }
        public TimeSpan Duration { get; set; }
        //public DateTime EndTime { get { return StartTime + Duration; } }
        DateTime EndTime { get => StartTime + Duration; }
        public String Description { get; set; } = string.Empty;

        public ICollection<ApplicationUserGymClass> AttendingMembers { get; set; } = new List<ApplicationUserGymClass>();


    }
}
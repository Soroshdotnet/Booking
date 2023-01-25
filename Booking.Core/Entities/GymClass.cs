namespace Booking.Core.Entities
{
//#nullable disable
    public class GymClass
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
        DateTime StartTime { get; set; }
        TimeSpan Duration { get; set; }
        //DateTime EndTime { get { return StartTime + Duration; } }
        DateTime EndTime { get => StartTime + Duration; }
        String Description { get; set; } = string.Empty;

        public ICollection<ApplicationUserGymClass> AttendingMembers { get; set; } = new List<ApplicationUserGymClass>();


    }
}
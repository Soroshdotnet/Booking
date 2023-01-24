using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Core.Entities
{
#nullable disable
    public class ApplicationUserGymClass
    {
        public string ApplicationUserId { get; set; }
        public int GymClassId { get; set; }

        //Navigation prop.
        public ApplicationUser ApplicationUser { get; set; }
        public GymClass GymClass { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    internal class TimeTable
    {
        public int TimetableID { get; set; }
        public int SubjectID { get; set; }
        public int RoomId { get; set; }
        public string TimeSlot { get; set; }

    }
}

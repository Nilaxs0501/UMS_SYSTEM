using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    internal class Timetable
    {
        public int TimetableID { get; set; }
        public int SubjectID { get; set; }
        public int RoomID { get; set; }
        public string TimeSlot { get; set; }
        public string GroupName { get; set; }   
        public int LecturerID { get; set; }    

    }
}

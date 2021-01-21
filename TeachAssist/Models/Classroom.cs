using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeachAssist.Models
{
    public class Classroom
    {
        public int Id { get; set; }
        public Widget[] Widgets { get; set; }

        public void LoadClassroom(int ID)
        {
            // Connect to DB and load Classroom data for ID

            // Set new ID and Widgets
        }

        public void SaveClassroom()
        {
            // Save the currently loaded widgets to the DB with current ID
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeachAssist.Models;

namespace TeachAssist.Models
{
    public class Widget
    {
        public int Id { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public WidgetCreationHelper[] WidgetCreationHelpers { get; set; }

        public void LoadClassroom(int ID)
        {
            // Temporary code.  Delete after finishing real code

            this.Id = ID;


            // Connect to DB and load Classroom data for ID

            // Set new ID and Widgets
        }

        public void SaveClassroom()
        {
            // Save the currently loaded widgets to the DB with current ID
        }
    }
}


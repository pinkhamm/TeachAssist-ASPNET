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
            this.Id = ID;

            // Temporary code.  Delete after finishing real code
            fakeLoadClassroom();

            // Connect to DB and load Classroom data for ID

        }

        public void SaveClassroom()
        {
            // Save the currently loaded widgets to the DB with current ID
        }

        private void fakeLoadClassroom()
        {
            Widgets = new Widget[4];
            Widget widgetOne = new Widget(0, "Widget 1", 1, 1);
            Widget widgetTwo = new Widget(1, "Widget 2", 1, 1);
            Widget widgetThree = new Widget(2, "Widget 3", 1, 1);
            Widget widgetFour = new Widget(3, "Widget 4", 1, 1);

            Widgets[0] = widgetOne;
            Widgets[1] = widgetTwo;
            Widgets[2] = widgetThree;
            Widgets[3] = widgetFour;
        }
    }
}

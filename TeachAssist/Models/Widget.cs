using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeachAssist.Models;

namespace TeachAssist.Models
{
    public class Widget
    {
        public int Id { get;}
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public WidgetCreationHelper[] WidgetCreationHelpers { get; set; }

        public Widget(int id, string name, int width, int height)
        {
            this.Id = id;
            this.Name = name;
            this.Width = width;
            this.Height = height;
        }

    }
}


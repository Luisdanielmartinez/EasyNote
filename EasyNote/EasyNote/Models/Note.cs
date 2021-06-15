using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace EasyNote.Models
{
   public class Note
    {
        public Note(string title, string location, DateTime time, Color color)
        {
            Title = title;
            Location = location;
            Time = time;
            Color = color;
        }

        public string Title { get; }
        public string Location { get; }
        public DateTime Time { get; }
        public Color Color { get; }
    }
}

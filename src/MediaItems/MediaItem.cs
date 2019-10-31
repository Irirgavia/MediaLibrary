using System;
using System.Collections.Generic;
using System.Text;

namespace MediaLibrary.MediaItems
{
    public abstract class MediaItem
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Size { get; private set; }

        public string Type { get; private set; }

        public MediaItem(
            int id,
            string name,
            double size,
            string type)
        { }
    }
}

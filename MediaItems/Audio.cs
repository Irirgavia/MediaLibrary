using System;
using System.Collections.Generic;
using System.Text;

namespace MediaLibrary.MediaItems
{
    public class Audio : MediaItem
    {
        public Audio(
            int id,
            string name,
            double size,
            string type) : base(id, name, size, type)
        { }
    }
}
 
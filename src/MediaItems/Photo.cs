using System;
using System.Collections.Generic;
using System.Text;

namespace MediaLibrary.MediaItems
{
    public class Photo : MediaItem
    {
        public Photo(
            int id,
            string name,
            double size,
            string type) : base(id, name, size, type) 
        { }
    }
}

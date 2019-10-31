using System;
using System.Collections.Generic;
using System.Text;

namespace MediaLibrary.MediaItems
{
    public class Video : Audio
    {
        public Video(
            int id,
            string name,
            double size,
            string type) : base(id, name, size, type)
        { }
    }
}

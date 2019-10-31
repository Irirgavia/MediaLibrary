using MediaLibrary.src.MediaItems.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaLibrary.MediaItems
{
    public class Audio : MediaItem, IAudio
    {
        public Audio(
            int id,
            string name,
            double size,
            string type) : base(id, name, size, type)
        { }

        public void Pause() { }
        public void Stop() { }
        public void Speed() { }
        public void SpeedChange() { }
    }
}
 
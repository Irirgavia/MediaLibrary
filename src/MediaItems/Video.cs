using MediaLibrary.src.MediaItems.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaLibrary.MediaItems
{
    public class Video : MediaItem, IVideo
    {
        public Video(
            int id,
            string name,
            double size,
            string type) : base(id, name, size, type)
        { }


        public void Zoom() { }
        public void Rotate() { }
        public void Pause() { }
        public void Speed() { }
        public void SpeedChange() { }

        public void AddSub() { }
        public void RemoveSum() { }
    }
}
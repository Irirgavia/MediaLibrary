using MediaLibrary.MediaItems;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaLibrary
{
    public class Album
    {
        public string Name { get; set; }
        public string Author { get; private set; }
        public List<MediaItem> MediaItems { get; set; } 

        public Album(
            string name,
            string author,
            List<MediaItem> mediaItems)
        { }

        public void AddItem(MediaItem mediaItem) { }
        public void RemoveItem(MediaItem mediaItem) { }

        public MediaItem Find (MediaItem mediaItem) { }
    }
}

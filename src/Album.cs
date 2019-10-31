using MediaLibrary.MediaItems;
using MediaLibrary.src;
using MediaLibrary.src.MediaItems.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaLibrary.src
{
    public class Album : IMediaList, IMediaItem
    {
        public string Name { get; set; }
        public string Author { get; private set; }
        public List<MediaItem> MediaItems { get; set; } 

        public Album(
            string name,
            string author,
            List<MediaItem> mediaItems)
        { }

        public void Open() { }
        public void Close() { }
        public void GetInfo() { }

        public void Count() { }
        public void Next() { }
        public void Previus() { }

        public void Pause() { }
        public void Stop() { }
        public void Sort() { }
        public void GetAllItems() {}
        public void AddItem(MediaItem mediaItem) { }
        public void RemoveItem(MediaItem mediaItem) { }
        public void Find (MediaItem mediaItem) { }
    }
}

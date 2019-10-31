using MediaLibrary.MediaItems;
using MediaLibrary.src;
using MediaLibrary.src.MediaItems.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaLibrary
{
    public class MediaPlayer : IMediaPlayer, IMediaItem
    {
        public void Play(MediaItem mediaItem) { }
        public void Play(Album album) { }

        public void Open() { }
        public void Close() { }
        public void GetInfo() { }
    }
}

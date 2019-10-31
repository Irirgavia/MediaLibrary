using MediaLibrary.MediaItems;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaLibrary.src
{
    interface IMediaPlayer
    {
        void Play(MediaItem mediaItem);
        void Play(Album album);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MediaLibrary.src.MediaItems.Interfaces
{
    public interface IVideo : IMediaItem, IAudio, IPhoto
    {
        void AddSub();
        void RemoveSum();
    }
}

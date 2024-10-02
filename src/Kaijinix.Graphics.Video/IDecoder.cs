using System;

namespace Kaijinix.Graphics.Video
{
    public interface IDecoder : IDisposable
    {
        bool IsHardwareAccelerated { get; }

        ISurface CreateSurface(int width, int height);
    }
}

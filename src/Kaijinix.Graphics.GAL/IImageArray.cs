using System;

namespace Kaijinix.Graphics.GAL
{
    public interface IImageArray : IDisposable
    {
        void SetImages(int index, ITexture[] images);
    }
}

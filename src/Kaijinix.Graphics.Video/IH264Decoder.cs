using System;

namespace Kaijinix.Graphics.Video
{
    public interface IH264Decoder : IDecoder
    {
        bool Decode(ref H264PictureInfo pictureInfo, ISurface output, ReadOnlySpan<byte> bitstream);
    }
}

using System;

namespace Kaijinix.Graphics.Video
{
    public readonly record struct Plane(IntPtr Pointer, int Length);
}

using Kaijinix.Graphics.OpenGL.Helper;
using System;

namespace Kaijinix.Graphics.OpenGL
{
    public interface IOpenGLContext : IDisposable
    {
        void MakeCurrent();

        bool HasContext();
    }
}

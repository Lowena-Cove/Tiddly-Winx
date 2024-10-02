using System;

namespace Kaijinix.Graphics.GAL
{
    public interface IProgram : IDisposable
    {
        ProgramLinkStatus CheckProgramLink(bool blocking);

        byte[] GetBinary();
    }
}

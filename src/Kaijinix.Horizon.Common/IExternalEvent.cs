using System;

namespace Kaijinix.Horizon.Common
{
    public interface IExternalEvent
    {
        void Signal();
        void Clear();
    }
}

using System;
using System.Collections.Concurrent;

namespace Kaijinix.HLE.HOS.Services.Am.AppletAE
{
    interface IAppletFifo<T> : IProducerConsumerCollection<T>
    {
        event EventHandler DataAvailable;
    }
}

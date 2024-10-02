using Kaijinix.Horizon.Arp;
using Kaijinix.Horizon.Audio;
using Kaijinix.Horizon.Bcat;
using Kaijinix.Horizon.Friends;
using Kaijinix.Horizon.Hshl;
using Kaijinix.Horizon.Ins;
using Kaijinix.Horizon.Lbl;
using Kaijinix.Horizon.LogManager;
using Kaijinix.Horizon.MmNv;
using Kaijinix.Horizon.Ngc;
using Kaijinix.Horizon.Ovln;
using Kaijinix.Horizon.Prepo;
using Kaijinix.Horizon.Psc;
using Kaijinix.Horizon.Ptm;
using Kaijinix.Horizon.Sdk.Arp;
using Kaijinix.Horizon.Srepo;
using Kaijinix.Horizon.Usb;
using Kaijinix.Horizon.Wlan;
using System.Collections.Generic;
using System.Threading;

namespace Kaijinix.Horizon
{
    public class ServiceTable
    {
        private int _readyServices;
        private int _totalServices;

        private readonly ManualResetEvent _servicesReadyEvent = new(false);

        public IReader ArpReader { get; internal set; }
        public IWriter ArpWriter { get; internal set; }

        public IEnumerable<ServiceEntry> GetServices(HorizonOptions options)
        {
            List<ServiceEntry> entries = new();

            void RegisterService<T>() where T : IService
            {
                entries.Add(new ServiceEntry(T.Main, this, options));
            }

            RegisterService<ArpMain>();
            RegisterService<AudioMain>();
            RegisterService<BcatMain>();
            RegisterService<FriendsMain>();
            RegisterService<HshlMain>();
            RegisterService<HwopusMain>(); // TODO: Merge with audio once we can start multiple threads.
            RegisterService<InsMain>();
            RegisterService<LblMain>();
            RegisterService<LmMain>();
            RegisterService<MmNvMain>();
            RegisterService<NgcMain>();
            RegisterService<OvlnMain>();
            RegisterService<PrepoMain>();
            RegisterService<PscMain>();
            RegisterService<SrepoMain>();
            RegisterService<TsMain>();
            RegisterService<UsbMain>();
            RegisterService<WlanMain>();

            _totalServices = entries.Count;

            return entries;
        }

        internal void SignalServiceReady()
        {
            if (Interlocked.Increment(ref _readyServices) == _totalServices)
            {
                _servicesReadyEvent.Set();
            }
        }

        public void WaitServicesReady()
        {
            _servicesReadyEvent.WaitOne();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _servicesReadyEvent.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}

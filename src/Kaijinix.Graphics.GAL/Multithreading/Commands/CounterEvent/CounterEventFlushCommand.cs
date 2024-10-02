using Kaijinix.Graphics.GAL.Multithreading.Model;
using Kaijinix.Graphics.GAL.Multithreading.Resources;

namespace Kaijinix.Graphics.GAL.Multithreading.Commands.CounterEvent
{
    struct CounterEventFlushCommand : IGALCommand, IGALCommand<CounterEventFlushCommand>
    {
        public readonly CommandType CommandType => CommandType.CounterEventFlush;
        private TableRef<ThreadedCounterEvent> _event;

        public void Set(TableRef<ThreadedCounterEvent> evt)
        {
            _event = evt;
        }

        public static void Run(ref CounterEventFlushCommand command, ThreadedRenderer threaded, IRenderer renderer)
        {
            command._event.Get(threaded).Base.Flush();
        }
    }
}

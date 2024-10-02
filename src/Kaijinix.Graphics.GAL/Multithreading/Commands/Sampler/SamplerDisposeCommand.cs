using Kaijinix.Graphics.GAL.Multithreading.Model;
using Kaijinix.Graphics.GAL.Multithreading.Resources;

namespace Kaijinix.Graphics.GAL.Multithreading.Commands.Sampler
{
    struct SamplerDisposeCommand : IGALCommand, IGALCommand<SamplerDisposeCommand>
    {
        public readonly CommandType CommandType => CommandType.SamplerDispose;
        private TableRef<ThreadedSampler> _sampler;

        public void Set(TableRef<ThreadedSampler> sampler)
        {
            _sampler = sampler;
        }

        public static void Run(ref SamplerDisposeCommand command, ThreadedRenderer threaded, IRenderer renderer)
        {
            command._sampler.Get(threaded).Base.Dispose();
        }
    }
}

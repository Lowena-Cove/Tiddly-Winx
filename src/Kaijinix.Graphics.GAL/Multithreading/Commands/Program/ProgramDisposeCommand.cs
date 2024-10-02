using Kaijinix.Graphics.GAL.Multithreading.Model;
using Kaijinix.Graphics.GAL.Multithreading.Resources;

namespace Kaijinix.Graphics.GAL.Multithreading.Commands.Program
{
    struct ProgramDisposeCommand : IGALCommand, IGALCommand<ProgramDisposeCommand>
    {
        public readonly CommandType CommandType => CommandType.ProgramDispose;
        private TableRef<ThreadedProgram> _program;

        public void Set(TableRef<ThreadedProgram> program)
        {
            _program = program;
        }

        public static void Run(ref ProgramDisposeCommand command, ThreadedRenderer threaded, IRenderer renderer)
        {
            command._program.Get(threaded).Base.Dispose();
        }
    }
}

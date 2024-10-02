using Kaijinix.Graphics.GAL.Multithreading.Model;
using Kaijinix.Graphics.GAL.Multithreading.Resources;

namespace Kaijinix.Graphics.GAL.Multithreading.Commands.Program
{
    struct ProgramGetBinaryCommand : IGALCommand, IGALCommand<ProgramGetBinaryCommand>
    {
        public readonly CommandType CommandType => CommandType.ProgramGetBinary;
        private TableRef<ThreadedProgram> _program;
        private TableRef<ResultBox<byte[]>> _result;

        public void Set(TableRef<ThreadedProgram> program, TableRef<ResultBox<byte[]>> result)
        {
            _program = program;
            _result = result;
        }

        public static void Run(ref ProgramGetBinaryCommand command, ThreadedRenderer threaded, IRenderer renderer)
        {
            byte[] result = command._program.Get(threaded).Base.GetBinary();

            command._result.Get(threaded).Result = result;
        }
    }
}

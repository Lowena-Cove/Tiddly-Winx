using Kaijinix.Graphics.GAL.Multithreading.Model;
using Kaijinix.Graphics.GAL.Multithreading.Resources;

namespace Kaijinix.Graphics.GAL.Multithreading.Commands.Texture
{
    struct TextureReleaseCommand : IGALCommand, IGALCommand<TextureReleaseCommand>
    {
        public readonly CommandType CommandType => CommandType.TextureRelease;
        private TableRef<ThreadedTexture> _texture;

        public void Set(TableRef<ThreadedTexture> texture)
        {
            _texture = texture;
        }

        public static void Run(ref TextureReleaseCommand command, ThreadedRenderer threaded, IRenderer renderer)
        {
            command._texture.Get(threaded).Base.Release();
        }
    }
}

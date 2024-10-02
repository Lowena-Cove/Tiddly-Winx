using System.IO;

namespace Kaijinix.HLE.HOS.Diagnostics.Demangler.Ast
{
    public class DtorName : ParentNode
    {
        public DtorName(BaseNode name) : base(NodeType.DtOrName, name) { }

        public override void PrintLeft(TextWriter writer)
        {
            writer.Write("~");
            Child.PrintLeft(writer);
        }
    }
}

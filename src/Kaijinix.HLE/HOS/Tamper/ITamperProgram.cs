using Kaijinix.HLE.HOS.Services.Hid;

namespace Kaijinix.HLE.HOS.Tamper
{
    interface ITamperProgram
    {
        bool IsEnabled { get; set; }
        string Name { get; }
        bool TampersCodeMemory { get; set; }
        ITamperedProcess Process { get; }
        void Execute(ControllerKeys pressedKeys);
    }
}

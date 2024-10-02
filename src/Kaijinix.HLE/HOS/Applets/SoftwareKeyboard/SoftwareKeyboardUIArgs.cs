using Kaijinix.HLE.HOS.Applets.SoftwareKeyboard;

namespace Kaijinix.HLE.HOS.Applets
{
    public struct SoftwareKeyboardUIArgs
    {
        public KeyboardMode KeyboardMode;
        public string HeaderText;
        public string SubtitleText;
        public string InitialText;
        public string GuideText;
        public string SubmitText;
        public int StringLengthMin;
        public int StringLengthMax;
    }
}

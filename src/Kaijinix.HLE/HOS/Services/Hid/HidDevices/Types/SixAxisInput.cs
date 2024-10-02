using System.Numerics;

namespace Kaijinix.HLE.HOS.Services.Hid
{
    public struct SixAxisInput
    {
        public PlayerIndex PlayerId;
        public Vector3 Accelerometer;
        public Vector3 Gyroscope;
        public Vector3 Rotation;
        public float[] Orientation;
    }
}

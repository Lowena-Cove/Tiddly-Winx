using Kaijinix.Horizon.Common;
using Kaijinix.Horizon.Sdk.Sf;

namespace Kaijinix.Horizon.Sdk.Ts
{
    interface ISession : IServiceObject
    {
        Result GetTemperatureRange(out int minimumTemperature, out int maximumTemperature);
        Result GetTemperature(out int temperature);
        Result SetMeasurementMode(byte measurementMode);
    }
}

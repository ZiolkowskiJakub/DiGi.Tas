using DiGi.Analytical.Building.HVAC.Enums;

namespace DiGi.Tas.TIC
{
    public static partial class Convert
    {
        public static ThermostatProfileType ToDiGi_ThermostatProfileType(this global::TIC.Profiles profiles)
        {
            switch(profiles)
            {
                case global::TIC.Profiles.ticLL:
                    return ThermostatProfileType.LowerLimit;

                case global::TIC.Profiles.ticUL:
                    return ThermostatProfileType.UpperLimit;

                case global::TIC.Profiles.ticHLL:
                    return ThermostatProfileType.HumidityLowerLimit;

                case global::TIC.Profiles.ticHUL:
                    return ThermostatProfileType.HumidityUpperLimit;

            }

            return ThermostatProfileType.Undefined;
        }
    }
}
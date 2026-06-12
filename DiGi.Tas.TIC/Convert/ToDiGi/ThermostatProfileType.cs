using DiGi.Analytical.Building.HVAC.Enums;

namespace DiGi.Tas.TIC
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a TIC profile type to the corresponding DiGi thermostat profile type.
        /// </summary>
        /// <param name="profiles">The TIC profiles enumeration value to convert.</param>
        /// <returns>The equivalent <see cref="ThermostatProfileType"/> value, or <see cref="ThermostatProfileType.Undefined"/> if no mapping is found.</returns>
        public static ThermostatProfileType ToDiGi_ThermostatProfileType(this global::TIC.Profiles profiles)
        {
            switch (profiles)
            {
                case global::TIC.Profiles.ticLL:
                    return ThermostatProfileType.LowerLimit;

                case global::TIC.Profiles.ticUL:
                    return ThermostatProfileType.UpperLimit;

                case global::TIC.Profiles.ticHLL:
                    return ThermostatProfileType.HumidityLowerLimit;

                case global::TIC.Profiles.ticHUL:
                    return ThermostatProfileType.HumidityUpperLimit;

                default:
                    break;
            }

            return ThermostatProfileType.Undefined;
        }
    }
}
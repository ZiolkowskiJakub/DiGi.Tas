using DiGi.Analytical.Building.HVAC.Enums;

namespace DiGi.Tas.TIC
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a TIC thermostat instance to its corresponding DiGi analytical building HVAC thermostat representation.
        /// </summary>
        /// <param name="thermostat">The source TIC thermostat instance to be converted.</param>
        /// <returns>A converted <see cref="Analytical.Building.HVAC.Classes.Thermostat"/> instance, or <c>null</c> if the provided <paramref name="thermostat"/> is null.</returns>
        public static Analytical.Building.HVAC.Classes.Thermostat? ToDiGi(this global::TIC.IThermostat? thermostat)
        {
            if (thermostat == null)
            {
                return null;
            }

            Analytical.Building.HVAC.Classes.Thermostat? result = new()
            {
                Name = thermostat.name,
                Description = thermostat.description,
            };

            foreach (global::TIC.Profiles profiles in System.Enum.GetValues(typeof(global::TIC.Profiles)))
            {
                ThermostatProfileType thermostatProfileType = profiles.ToDiGi_ThermostatProfileType();
                if (thermostatProfileType == ThermostatProfileType.Undefined)
                {
                    continue;
                }

                result[thermostatProfileType] = thermostat.GetProfile((int)profiles)?.ToDiGi();
            }

            return result;
        }
    }
}
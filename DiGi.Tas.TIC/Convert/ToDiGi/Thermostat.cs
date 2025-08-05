using DiGi.Analytical.Building.HVAC.Enums;

namespace DiGi.Tas.TIC
{
    public static partial class Convert
    {
        public static Analytical.Building.HVAC.Classes.Thermostat ToDiGi(this global::TIC.IThermostat thermostat)
        {
            if(thermostat == null)
            {
                return null;
            }

            Analytical.Building.HVAC.Classes.Thermostat result = new Analytical.Building.HVAC.Classes.Thermostat()
            {
                Name = thermostat.name,
                Description = thermostat.description,
            };

            foreach(global::TIC.Profiles profiles in System.Enum.GetValues(typeof(global::TIC.Profiles)))
            {
                ThermostatProfileType thermostatProfileType = profiles.ToDiGi_ThermostatProfileType();
                if(thermostatProfileType == ThermostatProfileType.Undefined)
                {
                    continue;
                }

                result[thermostatProfileType] = thermostat.GetProfile((int)profiles)?.ToDiGi();
            }

            return result;
        }
    }
}
using DiGi.Analytical.Building.HVAC;

namespace DiGi.Tas.TIC
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a TIC internal condition to its corresponding DiGi analytical building representation.
        /// </summary>
        /// <param name="internalCondition">The source TIC internal condition instance.</param>
        /// <returns>The converted <see cref="Analytical.Building.Classes.InternalCondition"/> object, or <c>null</c> if the input is null.</returns>
        public static Analytical.Building.Classes.InternalCondition? ToDiGi(this global::TIC.IInternalCondition? internalCondition)
        {
            if (internalCondition == null)
            {
                return null;
            }

            Analytical.Building.Classes.InternalCondition result = new(internalCondition.name)
            {
                Description = internalCondition.description,
            };

            result.SetValue(Enums.InternalConditionParameter.IncludeSolarInMeanRadiantTemperature, internalCondition.includeSolarInMRT, new DiGi.Core.Parameter.Classes.SetValueSettings(true, false));

            global::TIC.IInternalGain internalGain = internalCondition.GetInternalGain();
            if (internalGain != null)
            {
                result.SetInternalGain(internalGain.ToDiGi());
                result.SetSystemProperties(internalGain.ToDiGi_SystemProperties());
            }

            global::TIC.IThermostat thermostat = internalCondition.GetThermostat();
            if (thermostat != null)
            {
                result.SetThermostat(thermostat.ToDiGi());
            }

            result.SetValue(Enums.InternalConditionParameter.UniqueId, internalCondition.CalculateDataChecksum());

            return result;
        }
    }
}
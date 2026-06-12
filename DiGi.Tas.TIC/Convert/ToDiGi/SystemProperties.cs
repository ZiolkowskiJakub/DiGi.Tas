namespace DiGi.Tas.TIC
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="global::TIC.IInternalGain"/> instance to an <see cref="Analytical.Building.HVAC.Classes.SystemProperties"/> instance.
        /// </summary>
        /// <param name="internalGain">The internal gain source object to convert.</param>
        /// <returns>A mapped <see cref="Analytical.Building.HVAC.Classes.SystemProperties"/> object, or <c>null</c> if the provided <paramref name="internalGain"/> is null.</returns>
        public static Analytical.Building.HVAC.Classes.SystemProperties? ToDiGi_SystemProperties(this global::TIC.IInternalGain internalGain)
        {
            if (internalGain == null)
            {
                return null;
            }

            Analytical.Building.HVAC.Classes.SystemProperties result = new()
            {
                MetabolicRate = internalGain.personGain,
                DomesticHotWater = internalGain.domesticHotWater,
                OutsideAir = internalGain.freshAirRate,
                TargetIlluminance = internalGain.targetIlluminance,
            };

            return result;
        }
    }
}
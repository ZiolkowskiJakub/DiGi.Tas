namespace DiGi.Tas.TIC
{
    public static partial class Convert
    {
        public static Analytical.Building.HVAC.Classes.SystemProperties ToDiGi_SystemProperties(this global::TIC.IInternalGain internalGain)
        {
            if(internalGain == null)
            {
                return null;
            }

            Analytical.Building.HVAC.Classes.SystemProperties result = new Analytical.Building.HVAC.Classes.SystemProperties()
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
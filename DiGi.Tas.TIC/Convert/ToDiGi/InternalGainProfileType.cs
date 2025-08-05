using DiGi.Analytical.Building.HVAC.Enums;

namespace DiGi.Tas.TIC
{
    public static partial class Convert
    {
        public static InternalGainProfileType ToDiGi_InternalGainProfileType(this global::TIC.Profiles profiles)
        {
            switch(profiles)
            {
                case global::TIC.Profiles.ticI:
                    return InternalGainProfileType.Infiltration;

                case global::TIC.Profiles.ticESG:
                    return InternalGainProfileType.EquipmentSensibleGain;

                case global::TIC.Profiles.ticELG:
                    return InternalGainProfileType.EquipmentLatentGain;

                case global::TIC.Profiles.ticCOG:
                    return InternalGainProfileType.PollutantGeneration;

                case global::TIC.Profiles.ticV:
                    return InternalGainProfileType.Ventilation;

                case global::TIC.Profiles.ticOLG:
                    return InternalGainProfileType.OccupancyLatentGain;

                case global::TIC.Profiles.ticOSG:
                    return InternalGainProfileType.OccupancySensibleGain;

                case global::TIC.Profiles.ticLG:
                    return InternalGainProfileType.LightingGain;
            }

            return InternalGainProfileType.Undefined;
        }
    }
}
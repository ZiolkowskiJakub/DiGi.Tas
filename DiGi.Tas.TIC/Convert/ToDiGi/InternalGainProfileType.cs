using DiGi.Analytical.Building.HVAC.Enums;

namespace DiGi.Tas.TIC
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a TIC profile type to the corresponding DiGi internal gain profile type.
        /// </summary>
        /// <param name="profiles">The TIC profiles enumeration value to convert.</param>
        /// <returns>The mapped <see cref="InternalGainProfileType"/>, or <see cref="InternalGainProfileType.Undefined"/> if no mapping is found or the input is null.</returns>
        public static InternalGainProfileType ToDiGi_InternalGainProfileType(this global::TIC.Profiles? profiles)
        {
            switch (profiles)
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

                default:
                    break;
            }

            return InternalGainProfileType.Undefined;
        }
    }
}
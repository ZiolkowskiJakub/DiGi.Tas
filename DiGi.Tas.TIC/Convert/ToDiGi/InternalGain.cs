using DiGi.Analytical.Building.HVAC.Enums;

namespace DiGi.Tas.TIC
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a TIC internal gain object to its corresponding DiGi analytical building HVAC representation.
        /// </summary>
        /// <param name="internalGain">The source internal gain instance from the TIC namespace.</param>
        /// <returns>A converted <see cref="Analytical.Building.HVAC.Classes.InternalGain"/> instance, or <c>null</c> if the input is null.</returns>
        public static Analytical.Building.HVAC.Classes.InternalGain? ToDiGi(this global::TIC.IInternalGain? internalGain)
        {
            if (internalGain == null)
            {
                return null;
            }

            Analytical.Building.HVAC.Classes.InternalGain result = new()
            {
                Name = internalGain.name,
                Description = internalGain.description,
                LightingRadiantProportion = internalGain.lightingRadProp,
                OccupantRadiantProportion = internalGain.occupantRadProp,
                EquipmentRadiantProportion = internalGain.equipmentRadProp,
                LightingViewCoefficient = internalGain.lightingViewCoefficient,
                OccupantViewCoefficient = internalGain.occupantViewCoefficient,
                EquipmentViewCoefficient = internalGain.equipmentViewCoefficient,
            };

            foreach (global::TIC.Profiles? profiles in System.Enum.GetValues(typeof(global::TIC.Profiles)))
            {
                InternalGainProfileType internalGainProfileType = profiles.ToDiGi_InternalGainProfileType();
                if (internalGainProfileType == InternalGainProfileType.Undefined)
                {
                    continue;
                }

                result[internalGainProfileType] = internalGain.GetProfile((int)profiles)?.ToDiGi();
            }

            return result;
        }
    }
}
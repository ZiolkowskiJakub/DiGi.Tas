using DiGi.Analytical.Building.HVAC.Enums;

namespace DiGi.Tas.TIC
{
    public static partial class Convert
    {
        public static Analytical.Building.HVAC.Classes.InternalGain ToDiGi(this global::TIC.IInternalGain internalGain)
        {
            if(internalGain == null)
            {
                return null;
            }

            Analytical.Building.HVAC.Classes.InternalGain result = new Analytical.Building.HVAC.Classes.InternalGain()
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

            foreach(global::TIC.Profiles profiles in System.Enum.GetValues(typeof(global::TIC.Profiles)))
            {
                InternalGainProfileType internalGainProfileType = profiles.ToDiGi_InternalGainProfileType();
                if(internalGainProfileType == InternalGainProfileType.Undefined)
                {
                    continue;
                }

                result[internalGainProfileType] = internalGain.GetProfile((int)profiles)?.ToDiGi();
            }

            return result;
        }
    }
}
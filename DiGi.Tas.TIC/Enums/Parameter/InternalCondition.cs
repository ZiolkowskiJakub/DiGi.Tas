using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Parameter.Classes;
using DiGi.Tas.Core.Classes;
using System.ComponentModel;


namespace DiGi.Tas.TIC.Enums
{
    [AssociatedTypes(typeof(IInternalCondition)), Description("Internal condition parameter")]
    public enum InternalConditionParameter
    {
        [ParameterProperties("a8ada50c-1aa5-4874-9909-679007b207e9", "UniqueId", "UniqueId"), StringParameterValue()] UniqueId,
        [ParameterProperties("82afb6a0-14ab-4d03-ab29-72b48c71f52c", "FolderPath", "Folder path"), ObjectParameterValue(true, false, typeof(FolderPath))] FolderPath,
        [ParameterProperties("96fcb6ad-9260-4049-b517-a792a9e63ba2", "IncludeSolarInMeanRadiantTemperature", "Include solar in mean radiant temperature (MRT)"), BooleanParameterValue(false)] IncludeSolarInMeanRadiantTemperature,
    }
}

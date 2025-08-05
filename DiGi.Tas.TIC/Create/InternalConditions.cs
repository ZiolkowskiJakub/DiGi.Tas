using DiGi.Tas.Core.Classes;
using DiGi.Tas.TIC.Classes;
using System.Collections.Generic;

namespace DiGi.Tas.TIC
{
    public static partial class Create
    {
        public static List<Analytical.Building.Classes.InternalCondition> InternalConditions(this Document document)
        {
            global::TIC.Document document_TIC = document?.Value;
            if(document_TIC == null)
            {
                return null;
            }

            List<Analytical.Building.Classes.InternalCondition> result = new List<Analytical.Building.Classes.InternalCondition>();

            global::TIC.InternalConditionFolder internalConditionFolder = document_TIC.internalConditionRoot;
            if(internalConditionFolder == null)
            {
                return result;
            }

            return InternalConditions(internalConditionFolder, true, new FolderPath(internalConditionFolder.name));
        }

        public static List<Analytical.Building.Classes.InternalCondition> InternalConditions(this global::TIC.InternalConditionFolder internalConditionFolder, bool includeNested = true, FolderPath folderPath = null)
        {
            if(internalConditionFolder == null)
            {
                return null;
            }

            FolderPath folderPath_Temp = folderPath == null ? null : new FolderPath(internalConditionFolder.name, folderPath);

            List<Analytical.Building.Classes.InternalCondition> result = new List<Analytical.Building.Classes.InternalCondition>();

            int i = 0;

            global::TIC.IInternalCondition internalCondition_TIC = internalConditionFolder.internalConditions(i);
            
            while(internalCondition_TIC != null)
            {
                Analytical.Building.Classes.InternalCondition internalCondition = internalCondition_TIC.ToDiGi();
                if (internalCondition != null)
                {
                    internalCondition.SetValue(Enums.InternalConditionParameter.FolderPath, folderPath_Temp, new DiGi.Core.Parameter.Classes.SetValueSettings(true, false));
                    result.Add(internalCondition);
                }

                i++;
                internalCondition_TIC = internalConditionFolder.internalConditions(i);
            }

            if(!includeNested)
            {
                return result;
            }

            i = 0;

            global::TIC.InternalConditionFolder internalConditionFolder_Child = internalConditionFolder.childFolders(i);
            while(internalConditionFolder_Child != null)
            {
                List<Analytical.Building.Classes.InternalCondition> internalConditions = internalConditionFolder.InternalConditions(includeNested, folderPath_Temp);
                if(internalConditions != null)
                {
                    result.AddRange(internalConditions);
                }
            }

            return result;
        }
    }
}

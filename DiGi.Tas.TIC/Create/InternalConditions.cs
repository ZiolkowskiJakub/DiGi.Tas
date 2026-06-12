using DiGi.Tas.Core.Classes;
using DiGi.Tas.TIC.Classes;
using System.Collections.Generic;

namespace DiGi.Tas.TIC
{
    public static partial class Create
    {
        /// <summary>
        /// Retrieves a list of internal conditions from the specified document.
        /// </summary>
        /// <param name="document">The document to extract internal conditions from.</param>
        /// <returns>A list of <see cref="Analytical.Building.Classes.InternalCondition"/> objects, or <c>null</c> if the document is null.</returns>
        public static List<Analytical.Building.Classes.InternalCondition>? InternalConditions(this Document? document)
        {
            global::TIC.Document? document_TIC = document?.Value;
            if (document_TIC == null)
            {
                return null;
            }

            List<Analytical.Building.Classes.InternalCondition> result = [];

            global::TIC.InternalConditionFolder internalConditionFolder = document_TIC.internalConditionRoot;
            if (internalConditionFolder == null)
            {
                return result;
            }

            return InternalConditions(internalConditionFolder, true);
        }

        /// <summary>
        /// Retrieves a list of internal conditions from the specified folder, optionally including those in nested child folders.
        /// </summary>
        /// <param name="internalConditionFolder">The folder to extract internal conditions from.</param>
        /// <param name="includeNested">A boolean value indicating whether to recursively include conditions from child folders.</param>
        /// <param name="folderPath">The current path context for the folder hierarchy.</param>
        /// <returns>A list of <see cref="Analytical.Building.Classes.InternalCondition"/> objects, or <c>null</c> if the folder is null.</returns>
        public static List<Analytical.Building.Classes.InternalCondition>? InternalConditions(this global::TIC.InternalConditionFolder? internalConditionFolder, bool includeNested = true, FolderPath? folderPath = null)
        {
            if (internalConditionFolder == null)
            {
                return null;
            }

            FolderPath folderPath_Temp = folderPath == null ? new FolderPath(internalConditionFolder.name) : new FolderPath(internalConditionFolder.name, folderPath);

            List<Analytical.Building.Classes.InternalCondition> result = [];

            int i = 1;

            global::TIC.IInternalCondition internalCondition_TIC = internalConditionFolder.internalConditions(i);

            while (internalCondition_TIC != null)
            {
                Analytical.Building.Classes.InternalCondition? internalCondition = internalCondition_TIC.ToDiGi();
                if (internalCondition != null)
                {
                    internalCondition.SetValue(Enums.InternalConditionParameter.FolderPath, folderPath_Temp, new DiGi.Core.Parameter.Classes.SetValueSettings(true, false));
                    result.Add(internalCondition);
                }

                i++;
                internalCondition_TIC = internalConditionFolder.internalConditions(i);
            }

            if (!includeNested)
            {
                return result;
            }

            i = 1;

            global::TIC.InternalConditionFolder internalConditionFolder_Child = internalConditionFolder.childFolders(i);
            while (internalConditionFolder_Child != null)
            {
                List<Analytical.Building.Classes.InternalCondition>? internalConditions = internalConditionFolder.InternalConditions(includeNested, folderPath_Temp);
                if (internalConditions != null)
                {
                    result.AddRange(internalConditions);
                }
            }

            return result;
        }
    }
}
using DiGi.Core.Classes;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Tas.Core.Classes
{
    public class FolderPath : ObjectPath<FolderPath>
    {
        public FolderPath(IEnumerable<string> names)
            : base(names)
        {

        }

        public FolderPath(string name)
            : base(name)
        {

        }

        public FolderPath(string name, FolderPath folderPath)
            : base(name, folderPath)
        {

        }

        public FolderPath(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        protected override FolderPath Create(string name)
        {
            return new FolderPath(name);
        }
    }
}

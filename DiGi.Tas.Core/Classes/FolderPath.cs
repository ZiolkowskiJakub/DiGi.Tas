using DiGi.Core.Classes;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Tas.Core.Classes
{
    /// <summary>
    /// Represents a path to a folder within the object hierarchy.
    /// </summary>
    public class FolderPath : ObjectPath<FolderPath>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FolderPath"/> class using a collection of segment names.
        /// </summary>
        /// <param name="names">The collection of segment names to include in the path.</param>
        public FolderPath(IEnumerable<string> names)
            : base(names)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderPath"/> class with a single segment name.
        /// </summary>
        /// <param name="name">The name of the path segment.</param>
        public FolderPath(string name)
            : base(name)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderPath"/> class by appending a name to an existing folder path.
        /// </summary>
        /// <param name="name">The name of the segment to append.</param>
        /// <param name="folderPath">The existing folder path to which the name is appended.</param>
        public FolderPath(string name, FolderPath folderPath)
            : base(name, folderPath)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderPath"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the path.</param>
        public FolderPath(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Creates a new instance of the <see cref="FolderPath"/> class.
        /// </summary>
        /// <param name="name">The name of the segment.</param>
        /// <returns>A new instance of <see cref="FolderPath"/>.</returns>
        protected override FolderPath Create(string name)
        {
            return new FolderPath(name);
        }
    }
}
using DiGi.Tas.Core.Classes;
using System.IO;

namespace DiGi.Tas.TBD.Classes
{
    /// <summary>
    /// Provides functionality for managing TBD documents, including loading, saving, and closing operations.
    /// </summary>
    public class Document : Document<global::TBD.TBDDocument>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Document"/> class.
        /// </summary>
        public Document()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Document"/> class with a specified file path and read-only status.
        /// </summary>
        /// <param name="path">The file system path to the document.</param>
        /// <param name="readOnly">Indicates whether the document should be opened in read-only mode.</param>
        public Document(string path, bool readOnly = false)
            : base(path, readOnly)
        {
        }

        /// <summary>
        /// Closes the underlying TBD document instance.
        /// </summary>
        public override void Close()
        {
            value?.close();
        }

        /// <summary>
        /// Saves the current state of the TBD document to disk.
        /// </summary>
        /// <returns><c>true</c> if the document was saved successfully; otherwise, <c>false</c>.</returns>
        public override bool Save()
        {
            if (ReadOnly || value == null)
            {
                return false;
            }

            return value.save() == 1;
        }

        /// <summary>
        /// Loads a TBD document from the specified path or creates a new one if it does not exist.
        /// </summary>
        /// <param name="path">The optional file system path to load. If null or empty, no loading is performed.</param>
        /// <returns><c>true</c> if the operation was successful or skipped; otherwise, <c>false</c>.</returns>
        protected override bool Load(string? path = null)
        {
            value ??= new global::TBD.TBDDocument();

            if (string.IsNullOrWhiteSpace(path))
            {
                return true;
            }

            if (File.Exists(path))
            {
                if (DiGi.Core.IO.Query.Locked(new FileInfo(path)))
                {
                    readOnly = true;
                }

                try
                {
                    if (readOnly)
                    {
                        value.openReadOnly(path);
                    }
                    else
                    {
                        value.open(path);
                    }
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                try
                {
                    value.create(path);
                }
                catch
                {
                    return false;
                }
            }

            return false;
        }
    }
}
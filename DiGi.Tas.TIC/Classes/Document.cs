using DiGi.Tas.Core.Classes;
using System.IO;

namespace DiGi.Tas.TIC.Classes
{
    /// <summary>
    /// Represents a document wrapper for TIC documents, providing functionality to load, save, and close the underlying document resource.
    /// </summary>
    public class Document : Document<global::TIC.Document>
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
        /// <param name="path">The physical path to the document file.</param>
        /// <param name="readOnly">A value indicating whether the document should be opened in read-only mode.</param>
        public Document(string path, bool readOnly = false)
            : base(path, readOnly)
        {
        }

        /// <summary>
        /// Closes the underlying TIC document resource.
        /// </summary>
        public override void Close()
        {
            value?.close();
        }

        /// <summary>
        /// Saves the current state of the document to the disk if it is not read-only and exists.
        /// </summary>
        /// <returns><c>true</c> if the document was saved successfully; otherwise, <c>false</c>.</returns>
        public override bool Save()
        {
            if (readOnly || value == null)
            {
                return false;
            }

            return value.save();
        }

        /// <summary>
        /// Loads the document from the specified path or creates a new one if the file does not exist.
        /// </summary>
        /// <param name="path">The optional path to the document file to be loaded.</param>
        /// <returns><c>true</c> if the load operation was successful; otherwise, <c>false</c>.</returns>
        protected override bool Load(string? path = null)
        {
            value ??= new global::TIC.Document();

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
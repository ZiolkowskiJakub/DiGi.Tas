using DiGi.Tas.Core.Interfaces;
using System;

namespace DiGi.Tas.Core.Classes
{
    /// <summary>
    /// Provides a base abstract class for document handling with support for loading, saving, and disposal of resources.
    /// </summary>
    /// <typeparam name="T">The type of the value contained within the document.</typeparam>
    public abstract class Document<T> : IDocument, IDisposable
    {
        protected bool readOnly = false;
        protected T? value;
        private bool disposed = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="Document{T}"/> class with default settings.
        /// </summary>
        public Document()
            : this(null, false)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Document{T}"/> class using the specified path and read-only status.
        /// </summary>
        /// <param name="path">The file path to load the document from. Can be null.</param>
        /// <param name="readOnly">A value indicating whether the document is opened in read-only mode.</param>
        public Document(string? path, bool readOnly)
        {
            this.readOnly = readOnly;
            Load(path);
        }

        ~Document()
        {
            Dispose(false);
        }

        /// <summary>
        /// Gets a value indicating whether the document is read-only.
        /// </summary>
        public bool ReadOnly
        {
            get
            {
                return readOnly;
            }
        }

        /// <summary>
        /// Gets the underlying value of the document.
        /// </summary>
        public virtual T? Value
        {
            get
            {
                return value;
            }
        }

        /// <summary>
        /// Implicitly converts a <see cref="Document{T}"/> instance to its underlying value.
        /// </summary>
        /// <param name="document">The document instance to convert.</param>
        /// <returns>The value of the document, or the default value of type <typeparamref name="T"/> if the document is null.</returns>
        public static implicit operator T?(Document<T>? document)
        {
            return document == null ? default : document.Value;
        }

        /// <summary>
        /// Closes the document and releases associated resources.
        /// </summary>
        public abstract void Close();

        // This code added to correctly implement the disposable pattern.
        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Saves the current state of the document to its source.
        /// </summary>
        /// <returns>True if the save operation was successful; otherwise, false.</returns>
        public abstract bool Save();

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    if (value != null)
                    {
                        Close();
                        DiGi.Core.Modify.ReleaseCOMObject(value);
                        value = default;
                    }
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposed = true;
            }
        }

        protected abstract bool Load(string? path = null);
    }
}
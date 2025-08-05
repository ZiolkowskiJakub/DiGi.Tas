using DiGi.Tas.Core.Interfaces;
using System;

namespace DiGi.Tas.Core.Classes
{
    public abstract class Document<T> : IDocument, IDisposable
    {
        protected bool readOnly = false;
        protected T value;
        private bool disposed = false;

        public Document()
            : this(null, false)
        {

        }

        public Document(bool readOnly)
            : this(null, readOnly)
        {

        }

        public Document(string path, bool readOnly)
        {
            this.readOnly = readOnly;
            Load(path);
        }

        ~Document()
        {
            Dispose(false);
        }

        public bool ReadOnly
        {
            get
            {
                return readOnly;
            }
        }

        public virtual T Value
        {
            get
            {
                return value;
            }
        }

        public static implicit operator T(Document<T> document)
        {
            return document == null ? default : document.value;
        }

        public abstract void Close();

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
        }

        public abstract bool Save(string path = null);

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

        protected abstract bool Load(string path = null);
    }
}

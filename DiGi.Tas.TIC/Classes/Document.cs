using DiGi.Tas.Core.Classes;
using System.IO;

namespace DiGi.Tas.TIC.Classes
{
    public class Document : Document<global::TIC.Document>
    {
        public Document()
        {
        }

        public Document(string path, bool readOnly = false)
            : base(path, readOnly)
        {
        }

        public override void Close()
        {
            value?.close();
        }

        public override bool Save()
        {
            if (readOnly || value == null)
            {
                return false;
            }

            return value.save();
        }

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
using DiGi.Tas.Core.Classes;
using System.IO;


namespace DiGi.Tas.TBD.Classes
{
    public class Document : Document<global::TBD.TBDDocument>
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
            if (ReadOnly || value == null)
            {
                return false;
            }

            return value.save() == 1;
        }

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

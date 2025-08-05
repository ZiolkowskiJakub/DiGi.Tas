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

        public Document(bool readOnly = false)
            : base(readOnly)
        {

        }

        public override void Close()
        {
            value?.close();
        }

        public override bool Save(string path = null)
        {
            if (ReadOnly || value == null)
            {
                return false;
            }

            return value.save() == 1;
        }

        protected override bool Load(string path = null)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                return false;
            }

            if (File.Exists(path))
            {
                FileInfo fileInfo = new FileInfo(path);

                if (DiGi.Core.IO.Query.Locked(fileInfo))
                {
                    readOnly = true;
                }
            }

            try
            {
                value = new global::TBD.TBDDocument();
                if (readOnly)
                {
                    value.openReadOnly(path);
                }
                else
                {
                    value.open(path);
                }

                return true;
            }
            catch
            {

            }

            return false;
        }
    }
}

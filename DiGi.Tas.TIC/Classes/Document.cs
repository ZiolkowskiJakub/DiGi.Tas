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
            if (ReadOnly)
            {
                return false;
            }

            if(value == null)
            {
                value = new global::TIC.Document();
            }

            return path == null ? value.save() : value.create(path);
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
                value = new global::TIC.Document();
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

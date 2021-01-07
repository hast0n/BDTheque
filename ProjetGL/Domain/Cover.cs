using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Cover
    {
        public virtual int Id { get; set; }
        public virtual byte[] File  { get; set; }

        public Cover()
        {

        }

        public Cover(string photoFilePath)
        {
            File = GetPhoto(photoFilePath);
        }
        // **** Read Image into Byte Array from Filesystem
        public static byte[] GetPhoto(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            byte[] photo = br.ReadBytes((int)fs.Length);

            br.Close();
            fs.Close();

            return photo;
        }
    }
}
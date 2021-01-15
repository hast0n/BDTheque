using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Album
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Isbn { get; set; }
        public virtual string Publisher { get; set; }
        public virtual string Description { get; set; }
        public virtual IList<Author> Authors { get; set; }
        public virtual IList<Genre> Genres { get; set; }
        public virtual Series Series { get; set; }
        public virtual Category Category { get; set; }
        public virtual byte[] Cover { get; set; }
        
        public Album()
        {

        }

        public Album(
            string title,
            string isbn,
            string publisher,
            string description,
            List<Author> authors,
            List<Genre> genres,
            Category category,
            Series series)
        {
            Title = title;
            Isbn = isbn;
            Publisher = publisher;
            Description = description;
            Authors = authors;
            Genres = genres;
            Series = series;
            Category = category;
        }

        // **** Read Image into Byte Array from Filesystem
        public static byte[] GetByteArrayFromImage(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            byte[] photo = br.ReadBytes((int)fs.Length);

            br.Close();
            fs.Close();

            return photo;
        }

        public override string ToString() => $"{Title}, {string.Join(" & ", Category)}, {Publisher}";
    }
}

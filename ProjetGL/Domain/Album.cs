using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        //public virtual IList<Cover> CoverList { get; set; }

        //public virtual Cover Cover
        //{
        //    get { if (CoverList.Count != 0)
        //        {
        //            return CoverList[0];
        //        }
        //        else { return null; }
        //        }
        //    set { CoverList[0] = value;  }
        //}

        public Album()
        {
            //CoverList = new List<Cover>();
            //CoverList.Add(new Cover());
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

        public override string ToString() => $"{Title}, {string.Join(" & ", Category)}, {Publisher}";
    }
}

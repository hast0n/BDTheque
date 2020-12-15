using System;
using System.Collections.Generic;
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
        public virtual DateTime ReleaseDate { get; set; }
        public virtual string Publisher { get; set; }
        public virtual List<Author> Authors { get; set; }
        public virtual List<Genre> Genres { get; set; }
        public virtual Series Series { get; set; }
        public virtual Category Category { get; set; }

        public Album()
        {
            
        }

        public Album(DateTime releaseDate,
            string title,
            string isbn,
            string publisher,
            List<Author> authors,
            List<Genre> genres,
            Category category,
            Series series)
        {
            Title = title;
            Isbn = isbn;
            ReleaseDate = releaseDate;
            Publisher = publisher;
            Authors = authors;
            Genres = genres;
            Series = series;
        }

        public override string ToString() => $"{Title}, <A définir>";
    }
}

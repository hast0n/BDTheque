using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Category
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<Album> Albums { get; set; }

        public Category()
        {

        }

        public Category(string name, IList<Album> albums)
        {
            Name = name;
            Albums = albums;
        }

        public override string ToString() => Name;
    }
}

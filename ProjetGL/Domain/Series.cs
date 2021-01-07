using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Series
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual List<Album> Albums { get; set; }

        public Series()
        {

        }

        public Series(string name)
        {
            Name = name;
        }

        public override string ToString() => Name;
    }
}

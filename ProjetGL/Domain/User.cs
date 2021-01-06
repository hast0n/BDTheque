using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public enum Privilege
    {
        Administrator, 
        User
    }

    public class User
    {
        public virtual int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Email { get; set; }
        public virtual string PasswordHash { get; set; }
        public virtual Privilege Privilege { get; set; }
        public virtual IList<Album> LikedAlbums { get; set; }
        public virtual IList<Album> WishedAlbums { get; set; }
        public virtual IList<Album> OwnedAlbums { get; set; }
        
        public User()
        {

        }

        public User(string firstName, string lastName, string mail, Privilege privilege, string passwordHash)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = mail;
            Privilege = privilege;
            PasswordHash = passwordHash;
        }

        public override string ToString() => $"{FirstName} {LastName}";
    }
}

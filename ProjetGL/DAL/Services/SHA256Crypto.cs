using System.Security.Cryptography;
using System.Text;

namespace DAL.Services
{
    public static class SHA256Crypto
    {
        public static string GetHash(string clear)
        {
            // https://stackoverflow.com/a/17001289
            StringBuilder Sb = new StringBuilder();

            using (SHA256 hash = SHA256.Create())
            {
                Encoding enc = Encoding.UTF8;
                byte[] result = hash.ComputeHash(enc.GetBytes(clear));

                foreach (byte b in result) Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }
    }
}

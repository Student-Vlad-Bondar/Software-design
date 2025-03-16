using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public sealed class Authenticator
    {
        private static readonly Lazy<Authenticator> _instance =
            new Lazy<Authenticator>(() => new Authenticator());

        public static Authenticator Instance => _instance.Value;

        private Authenticator() { }

        public void Authenticate(string user, string password)
        {
            Console.WriteLine($"User {user} authenticated.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Ynov.TU.Mikado.Tests.Factories
{
    public class FakeUserFactory
    {
        public static int GetDummyIdUser() => 1;

        public static int GetFakeDummyId() => 999;

        public static (string email, string password, bool isLibrarian) GetDummyUser()
            =>
                ("dummy@toto.fr", "azerty", false);
        
        public static (string email, string password, bool isLibrarian) GetBadDummyUser() 
            => ("dummy@toto.fr", "ytreza", true);

        public static (string email, string password, bool isLibrarian) GetDummyLibrarianUser()
            =>
                ("dummy@librari.an", "azerty", true);

    }
}

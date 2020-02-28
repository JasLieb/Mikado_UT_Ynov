using System;
using Ynov.TU.Mikado.Models;

namespace Ynov.TU.Mikado.Tests.Medias
{
    internal static class FakeMediaFactory
    {

        public static string GetTotoName() => "toto";
        public static (string name, MediaCategory category) GetTotoBookMedia() => (GetTotoName(), MediaCategory.Book);
        public static int GetTotoIdMedia() => 1;
        public static int GetFakeMediaId() => 999;
    }
}
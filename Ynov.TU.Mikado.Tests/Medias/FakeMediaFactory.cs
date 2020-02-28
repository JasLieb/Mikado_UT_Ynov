using System;
using Ynov.TU.Mikado.Models;

namespace Ynov.TU.Mikado.Tests.Medias
{
    internal static class FakeMediaFactory
    {

        public static string GetTotoName() => "toto";
        public static (string name, MediaCategory category) GetTotoBook() => (GetTotoName(), MediaCategory.Book);
        public static (int id, string name, MediaCategory category) GetTotoBookWithId() => (1, GetTotoName(), MediaCategory.Book);

        public static int GetFakeId() => 999;
    }
}
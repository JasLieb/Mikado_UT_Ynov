namespace Ynov.TU.Mikado.Tests.Medias
{
    internal static class MediaHelper
    {
        public static (string name, int category) GetWellformedMediaParameters() =>
            ("toto", 1);

        public static string GetNotWellFormedMediaParameters() => "toto";

    }
}
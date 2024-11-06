namespace DLWMS.WinApp.Helpers
{
    public static class Ekstenzije
    {
        public static bool IsSet(this string text)
        {
            return !string.IsNullOrWhiteSpace(text);
        }
    }
}

using System.Text.RegularExpressions;

namespace ByteBuzz.Helpers
{
    public static class RemoveHtmlTagHelper
    {
        public static string RemoveHtmlTags(string input)
        {
            return Regex.Replace(input, "<.*?>|&.*?;", string.Empty);
        }
    }
}

namespace Ex01StringBuilderExtensionSubstring
{
    using System.Text;

    public static class Extensions
    {
        public static string Substring(this StringBuilder builder, int index)
        {
            var substring = new StringBuilder();

            for (int i = index; i < builder.Length; i++)
            {
                substring.Append(builder[i]);
            }

            return substring.ToString();
        }

        public static string Substring(this StringBuilder builder, int index, int length)
        {
            var substring = new StringBuilder();

            for (int i = index; i < index + length; i++)
            {
                substring.Append(builder[i]);
            }

            return substring.ToString();
        }
    }
}
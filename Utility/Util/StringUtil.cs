namespace Utility.Util
{
    public static class StringUtil
    {

        public static string GetString(object? obj)
        {
            if (obj is null)
            {
                return string.Empty;
            }
            else
            {
                return obj.ToString() ?? string.Empty; // Ensure no null return value  
            }
        }

        public static string GetString(string str, int length)
        {
            if (str.Length > length)
            {
                return str.Substring(0, length);
            }
            else
            {
                return str;
            }
        }

        public static string GetString(string str, int length, string suffix)
        {
            if (str.Length > length)
            {
                return str.Substring(0, length) + suffix;
            }
            else
            {
                return str;
            }
        }

        public static string GetString(string suffix, string str, int length)
        {
            if (str.Length > length)
            {
                return suffix + str.Substring(0, length);
            }
            else
            {
                return str;
            }
        }
    }
}

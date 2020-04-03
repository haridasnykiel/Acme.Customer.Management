using System.Text.RegularExpressions;
using System;
using System.Text;

namespace Acme.Common.Extensions
{
    public static class StringHandler
    {
        public static string SplitName(this string name) 
        {
            if (string.IsNullOrWhiteSpace(name))
                return "";

            StringBuilder newText = new StringBuilder(name.Length * 2);

            newText.Append(name[0]);

            for (int i = 1; i < name.Length; i++)
            {
                if (char.IsUpper(name[i]) && name[i - 1] != ' ')
                {
                    newText.Append(' ');
                }
                newText.Append(name[i]);
            }

            return newText.ToString();
        }
    }
}
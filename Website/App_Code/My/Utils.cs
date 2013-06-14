using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace My
{
    public class Utils
    {
        public Utils()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public static string convertToUnSign(string s)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(System.Text.NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }

        public static string convertToUrl(string title)
        {
            const string autoRemoveChars = @",./\?#!""@+'`´*():;$%&=¦§";
            var generated = new System.Text.StringBuilder();

            foreach (var c in title.Where(c => autoRemoveChars.IndexOf(c) == -1))
            {
                generated.Append(c);
            }

            var url = generated.ToString().Replace(" ", "-");

            return convertToUnSign(url.ToLower());
        }

        public static string PathInfoString(int segment)
        {
            string pathInfo = Composite.Core.Routing.Pages.C1PageRoute.GetPathInfo() ?? string.Empty;
            string[] segments = pathInfo.Split('/');
            return segments.Skip(segment + 1).FirstOrDefault();
        }

        public static string TruncateAtWord(string input, int length)
        {
            if (input == null || input.Length < length)
                return input;
            int iNextSpace = input.LastIndexOf(" ", length);
            return string.Format("{0}...", input.Substring(0, (iNextSpace > 0) ? iNextSpace : length).Trim());
        }
    }
}
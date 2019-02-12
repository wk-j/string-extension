using System;

namespace StringExtension {
    public static class Extensions {

        public static string ToEmptyIfNull(this string str) =>
            string.IsNullOrEmpty(str) ? string.Empty : str;

        public static string ToDefaultIfNullOrEmpty(this string str, string value) =>
            string.IsNullOrEmpty(str) ? value : str;

    }
}

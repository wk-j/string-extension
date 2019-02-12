using System;

namespace StringExtension {
    public static class Extensions {
        public static string ToEmptyIfNull(this string str) {
            return string.IsNullOrEmpty(str) ? string.Empty : str;
        }
    }
}

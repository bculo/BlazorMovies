using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMovie.Shared.Utilities
{
    public static class StringUtilities
    {
        public static string CutstomToUpper(string value) => value?.ToUpper() ?? throw new ArgumentNullException(nameof(value));
    }
}

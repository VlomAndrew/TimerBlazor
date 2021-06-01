using System;

namespace WebClient.Shared.Extentions
{
    public static class TimeSpanExtention
    {
        public static string CustomFormat(this TimeSpan span)
        {
            return span.ToString(@"hh\:mm\:ss");
        }
    }
}
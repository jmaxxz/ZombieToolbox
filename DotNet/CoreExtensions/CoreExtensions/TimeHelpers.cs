using System;

namespace ZombieToolbox.System
{
    public static class TimeHelpers
    {
        public static DateTime Ago(this TimeSpan span)
        {
            return DateTime.Now - span;
        }

        public static DateTime UtcAgo(this TimeSpan span)
        {
            return DateTime.UtcNow - span;
        }

        public static TimeSpan Days(this int count)
        {
            return TimeSpan.FromDays(count);
        }

        public static TimeSpan Hours(this int count)
        {
            return TimeSpan.FromHours(count);
        }

        public static TimeSpan Minutes(this int count)
        {
            return TimeSpan.FromMinutes(count);
        }

        public static TimeSpan Seconds(this int count)
        {
            return TimeSpan.FromSeconds(count);
        }
    }
}


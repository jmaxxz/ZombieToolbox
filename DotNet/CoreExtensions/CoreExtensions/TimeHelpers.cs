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
    }
}


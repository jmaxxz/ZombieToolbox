using System;

namespace ZombieToolbox.System
{
    /// <summary>
    /// Extension methods which provide a fluent interface for interacting
    /// with time in DotNet
    /// </summary>
    public static class FluentTimeHelpers
    {
        /// <summary>
        /// Gets a time which is <see cref="span"/> ago
        /// </summary>
        /// <param name='span'>
        /// How far in the past the returned time should be.
        /// </param>
        public static DateTime Ago(this TimeSpan span)
        {
            return DateTime.Now - span;
        }

        /// <summary>
        /// Gets a time which is <see cref="span"/> ago (in UTC)
        /// </summary>
        /// <param name='span'>
        /// How far in the past the returned time should be.
        /// </param>
        public static DateTime UtcAgo(this TimeSpan span)
        {
            return DateTime.UtcNow - span;
        }

        /// <summary>
        /// Gets a timespan which is <see cref="count"/> days long
        /// </summary>
        /// <param name='count'>
        /// The length of the returned timespan in days
        /// </param>
        public static TimeSpan Days(this int count)
        {
            return TimeSpan.FromDays(count);
        }

        /// <summary>
        /// Gets a timespan which is <see cref="count"/> hours long
        /// </summary>
        /// <param name='count'>
        /// The length of the returned timespan in hours
        /// </param>
        public static TimeSpan Hours(this int count)
        {
            return TimeSpan.FromHours(count);
        }

        /// <summary>
        /// Gets a timespan which is <see cref="count"/> minutes long
        /// </summary>
        /// <param name='count'>
        /// The length of the returned timespan in minutes
        /// </param>
        public static TimeSpan Minutes(this int count)
        {
            return TimeSpan.FromMinutes(count);
        }

        /// <summary>
        /// Gets a timespan which is <see cref="count"/> seconds long
        /// </summary>
        /// <param name='count'>
        /// The length of the returned timespan in seconds
        /// </param>
        public static TimeSpan Seconds(this int count)
        {
            return TimeSpan.FromSeconds(count);
        }
    }
}


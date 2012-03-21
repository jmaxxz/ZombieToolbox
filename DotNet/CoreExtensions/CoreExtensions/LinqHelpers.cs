using System;
using System.Linq;
using System.Collections.Generic;

namespace ZombieToolbox.System
{
    /// <summary>
    /// Extension methods which help to make linq more useful
    /// </summary>
    public static class LinqHelpers
    {
        /// <summary>
        /// Converts a single value to an enumeration. (null values are
        /// converted to empty enumerations)
        /// </summary>
        /// <param name='val'>
        /// The value to be converted
        /// </param>
        /// <typeparam name='T'>
        /// The type of the value
        /// </typeparam>
        public static IEnumerable<T> Enumerable<T>(this T val)
        {
            if(val != null)
            {
                yield return val;
            }
        }

        /// <summary>
        /// Converts an enumeration of predicates to a single predicate which indicates
        /// if any of the predicates in the orginal enumeration evaluates to true.
        /// </summary>
        /// <returns>
        /// A single predicate which indicates if any of the predicates in the orginal
        /// enumeration evaluates to true.
        /// </returns>
        /// <param name='predicates'>
        /// An enumeration of predicates.
        /// </param>
        /// <typeparam name='T'>
        /// The type on which each of <see cref="predicates"/> act.
        /// </typeparam>
        public static Predicate<T> MatchesAny<T>(this IEnumerable<Predicate<T>> predicates)
        {
            return y=>predicates.Any(x=>x(y));
        }

        /// <summary>
        /// Converts an enumeration of predicates to a single predicate which indicates
        /// if all of the predicates in the orginal enumeration evaluates to true.
        /// </summary>
        /// <returns>
        /// A single predicate which indicates if all of the predicates in the orginal
        /// enumeration evaluates to true.
        /// </returns>
        /// <param name='predicates'>
        /// An enumeration of predicates.
        /// </param>
        /// <typeparam name='T'>
        /// The type on which each of <see cref="predicates"/> act.
        /// </typeparam>
        public static Predicate<T> MatchesAll<T>(this IEnumerable<Predicate<T>> predicates)
        {
            return y=>predicates.All(x=>x(y));
        }
    }
}


using System;

namespace ZombieToolbox.System
{
    public static class ObjectHelpers
    {
        /// <summary>
        /// Throws if <see cref="o"/> is <see langword="null" />.
        /// This method should ONLY be used if <see cref="o"/> is a parameter
        /// passed to the caller.
        /// </summary>
        /// <param name='o'>
        /// O.
        /// </param>
        /// <param name='parameterName'>
        /// Parameter name.
        /// </param>
        /// <exception cref='ArgumentNullException'>
        /// Is thrown when o is <see langword="null" /> .
        /// </exception>
        public static void ThrowIfNull(this object o, string parameterName)
        {
            if(o == null)
            {
                throw new ArgumentNullException(parameterName);
            }
        }
    }
}


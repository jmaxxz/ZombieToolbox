using System;
using NUnit.Framework;
using System.Linq;
using ZombieToolbox.System;

namespace CoreExtensionsTests
{
    [TestFixture]
    public class ObjectHelpersTests
    {
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ThrowIfNull_Throws_When_Null()
        {
            object obj = null;
            obj.ThrowIfNull("obj");
        }

        [Test]
        public void ThrowIfNull_Does_Not_Throws_When_Not_Null()
        {
            object obj = new object();
            obj.ThrowIfNull("obj");
        }
    }
}


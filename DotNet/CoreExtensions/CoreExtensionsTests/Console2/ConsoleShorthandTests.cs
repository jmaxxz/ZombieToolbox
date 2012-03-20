using System;
using System.IO;
using System.Text;
using NUnit.Framework;
using ZombieToolbox.System.Console2;

namespace CoreExtensionsTests
{
    [TestFixture]
    public class ConsoleShorthandTests
    {
        [Test]
        public void Wl_Shorthand()
        {
            var builder = new StringBuilder();
            var writer = new StringWriter(builder);
            Console.SetOut(writer);
            "Tada!".Wl();
            var  result = builder.ToString();

            //Assert
            Assert.AreEqual("Tada!"+Environment.NewLine, result);
        }

        [Test]
        public void W_Shorthand()
        {
            var builder = new StringBuilder();
            var writer = new StringWriter(builder);
            Console.SetOut(writer);
            "Tada!".W();
            var  result = builder.ToString();

            //Assert
            Assert.AreEqual("Tada!", result);
        }
    }
}


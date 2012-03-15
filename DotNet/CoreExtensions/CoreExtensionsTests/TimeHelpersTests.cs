using System;
using ZombieToolbox.System;
using NUnit.Framework;

namespace CoreExtensionsTests
{
    [TestFixture]
    public class TimeHelpersTests
    {
        [Test]
        public void Day_Count_To_Timespan()
        {
            TimeSpan t = 5.Days();
            Assert.AreEqual(t.TotalDays, 5);
        }

        [Test]
        public void Time_Ago_test()
        {
            var date = TimeSpan.FromDays(10).Ago();

            var resultDaysAgo = (DateTime.Now - date).TotalDays;
            Assert.That( resultDaysAgo, Is.EqualTo(10.0).Within(0.005));
        }

        [Test]
        public void Time_AgoUtc_test()
        {
            var date = TimeSpan.FromDays(15).UtcAgo();

            var resultDaysAgo = (DateTime.UtcNow - date).TotalDays;
            Assert.That( resultDaysAgo, Is.EqualTo(15.0).Within(0.005));
        }
    }
}


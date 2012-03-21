using System;
using NUnit.Framework;
using System.Linq;
using ZombieToolbox.System;

namespace CoreExtensionsTests
{
    [TestFixture]
    public class LinqHelpersTests
    {
        [Test]
        public void Covert_5_To_Enumerable()
        {
            var x = 5.Enumerable();

            Assert.AreEqual(x.Single(), 5);
        }

        [Test]
        public void Covert_Null_To_Enumerable()
        {
            object src = null;
            var x = src.Enumerable();

            Assert.AreEqual(x.Count(), 0);
        }

        [Test]
        public void MatchesAny_PositiveTest()
        {
            Predicate<string>[] predicates = new Predicate<string>[]
            {
                x=>x=="foo",
                x=>x.Length ==30,
            };

            var matchesAny = predicates.MatchesAny();

            Assert.IsTrue(matchesAny("foo"));

        }

        [Test]
        public void MatchesAny_NegativeTest()
        {
            Predicate<string>[] predicates = new Predicate<string>[]
            {
                x=>x=="fool",
                x=>x.Length ==30,
            };

            var matchesAny = predicates.MatchesAny();

            Assert.IsFalse(matchesAny("foo"));
        }

        [Test]
        public void MatchesAll_PositiveTest()
        {
            Predicate<string>[] predicates = new Predicate<string>[]
            {
                x=>x=="foo",
                x=>x.Length ==3,
            };

            var matchesAll = predicates.MatchesAll();

            Assert.IsTrue(matchesAll("foo"));

        }

        public void MatchesAll_NegativeTest()
        {
            Predicate<string>[] predicates = new Predicate<string>[]
            {
                x=>x=="foo",
                x=>x.Length ==4,
            };

            var matchesAll = predicates.MatchesAll();

            Assert.IsFalse(matchesAll("foo"));
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace MotsunabeZombieProject.Test
{
    [TestFixture]
    public class TweetCategorizerTest
    {
        [Test]
        public void 通常のツイート()
        {
            var ct = new TweetCategorizer();
            Assert.That(ct.Categorize("nakaji\tほげ"), Is.EqualTo("Normal"));
        }
    }
}

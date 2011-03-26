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
        private readonly TweetCategorizer ct = new TweetCategorizer();

        [Test]
        public void 通常のツイート()
        {
            string result = ct.Categorize("nakaji\tほげ");
            Assert.That(result, Is.EqualTo("Normal"));
        }

        [Test]
        public void ハッシュタグを含むツイート()
        {
            string result = ct.Categorize("nakaji\tほげ #hoge");
            Assert.That(result, Is.EqualTo("ContainHashTag"));
        }

        [TestCase("nakaji\t@piyo ほげ1", "Reply")]
        [TestCase("nakaji\t.@piyo ほげ2", "Normal")]
        [TestCase("nakaji\t@ piyo ほげ3", "Normal")]
        public void リプライを含むツイート(string body, string expectedCategory)
        {
            string result = ct.Categorize(body);
            Assert.That(result, Is.EqualTo(expectedCategory));
        }
    }
}

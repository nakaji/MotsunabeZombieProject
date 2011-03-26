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

        [TestCase("nakaji\tほげ", "Normal")]
        public void 通常のツイート(string body, string expectedCategory)
        {
            string result = ct.Categorize(body);
            Assert.That(result, Is.EqualTo(expectedCategory));
        }

        [TestCase("nakaji\tほげ #hoge", "ContainHashTag")]
        public void ハッシュタグを含むツイート(string body, string expectedCategory)
        {
            string result = ct.Categorize(body);
            Assert.That(result, Is.EqualTo(expectedCategory));
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MotsunabeZombieProject
{
    public class TweetCategorizer
    {
        public string Categorize(string tweet)
        {
            if (tweet.Contains("#"))
            {
                return "ContainHashTag";
            }
            if (Regex.IsMatch(tweet, "\t@[a-zA-Z]"))
            {
                return "Reply";
            }
            return "Normal";
        }
    }
}

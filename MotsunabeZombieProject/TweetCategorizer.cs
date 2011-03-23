using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            return "Normal";
        }
    }
}

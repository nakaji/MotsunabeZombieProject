using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MotsunabeZombieProject
{
    public class TweetCategorizer
    {
        public object Categorize(string p)
        {
            if (p.Contains("#"))
            {
                return "ContainHashTag";
            }
            return "Normal";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CallofDutyConsole.Models
{
    public class Player
    {
        public Player()
        {}
            public int wins { get; set; }
            public int kills { get; set; }
            public decimal kdRatio { get; set; }
            public int topTwentyFive { get; set; }
            public int topTen { get; set; }
            public int topFive { get; set; }
            public int revives { get; set; }
            public int score { get; set; }
            public int gamesPlayed { get; set; }
            public decimal scorePerMinute { get; set; }
            public int deaths { get; set; }
    }
}

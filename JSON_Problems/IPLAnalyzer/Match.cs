using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSON_Problems.IPLAnalyzer
{
    public class Match
    {
        public int match_id { get; set; }
        public string team1 { get; set; }
        public string team2 { get; set; }
        public string winner { get; set; }
        public string player_of_match { get; set; }
    }

}
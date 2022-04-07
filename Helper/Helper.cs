using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueScores.Helper
{
    public class Helper
    {
        public Dictionary<string, int> OrderByPointsDesc(Dictionary<string,int> data) {

            var sortedLog = data.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            return sortedLog;
        }

        public Dictionary<string, int> OrderByTeamNamesDesc(Dictionary<string, int> data)
        {

            var sortedLog = data.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            return sortedLog;
        }
    }
}

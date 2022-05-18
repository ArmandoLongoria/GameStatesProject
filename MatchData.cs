using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStatTest
{
    class MatchData
    {
        private int matchKills;
        private int matchDeaths;
        private double matchKd;
        private int matchXp;
        private const int KillPoints = 50;

        public MatchData(int matchKills, int matchDeaths)
        {
            this.matchDeaths = matchDeaths;
            this.matchKills = matchKills;
            matchKd = matchKills / matchDeaths;
            matchXp = matchKills * KillPoints;
        }

        public override string ToString()
        {
            return String.Format("\nKills: {0}\nDeaths: {1}\nK/D: {2}\nXP: {3}\n", matchKills, matchDeaths, matchKd, matchXp);
        }

        public int currentMatchKills { get { return matchKills; }}
        public int currentMatchDeaths { get { return matchDeaths; }}
        public int currentMatchXp { get { return matchXp; }}

    }
}

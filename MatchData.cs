using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStatTest
{
    class MatchData
    {
        private double matchKills;
        private double matchDeaths;
        private double matchKd;
        private double matchXp;
        private const double KillPoints = 50;

        public MatchData(double matchKills, double matchDeaths)
        {
            this.matchDeaths = matchDeaths;
            this.matchKills = matchKills;
            matchKd = matchKills / matchDeaths;
            matchXp = matchKills * KillPoints;
        }

        public override string ToString()
        {
            return String.Format("\nKills: {0}\nDeaths: {1}\nK/D: {2}\nXP: {3}\n", matchKills, matchDeaths, matchKd.ToString("N2"), matchXp);
        }

        public double currentMatchKills { get { return matchKills; }}
        public double currentMatchDeaths { get { return matchDeaths; }}
        public double currentMatchXp { get { return matchXp; }}

    }
}

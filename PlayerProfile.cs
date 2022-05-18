using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStatTest
{
    class PlayerProfile
    {
        private string userName;
        private int userId;
        private int level;
        private int xp;
        private int totalKills;
        private int totalDeaths;
        private int careerKd;

        public PlayerProfile(string userName, int userId, int level, int xp, int totalKills, int totalDeaths, int careerKd)
        {
            this.userName = userName;
            this.userId = userId;
            this.level = level;
            this.xp = xp;
            this.totalKills = totalKills;
            this.totalDeaths = totalDeaths;
            this.careerKd = careerKd;
        }

        public override string ToString()
        {
            return String.Format("\nUsername: {0}\nLevel: {1}\nCareer Kills: {2}\nCareer Deaths: {3}\nCareer K/D: {4}\nXP: {5}\n", userName, level, totalKills, totalDeaths, careerKd, xp);
        }

        public string MyUserName { get { return userName; } set { userName = value; } }
        public int MyUserId { get { return userId; } set { userId = value; } }
        public int MyLevel { get { return level; } set { level = value; } }
        public int MyXp { get { return xp; } set { xp = value; } }
        public int MyTotalKills { get { return totalKills; } set { totalKills = value; } }
        public int MyTotalDeaths { get { return totalDeaths; } set { totalDeaths = value; } }
        public int MyCareerKd { get { return careerKd; } set { careerKd = value; } }

        public void UpdateStats(MatchData matchData)
        {
            MyTotalKills = MyTotalKills + matchData.currentMatchKills;
            MyTotalDeaths = MyTotalDeaths + matchData.currentMatchDeaths;
            MyXp = MyXp + matchData.currentMatchXp;
            MyCareerKd = MyTotalDeaths / MyTotalKills;
        }

    }
}

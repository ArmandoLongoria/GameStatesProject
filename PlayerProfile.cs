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
        private double level;
        private double xp;
        private const double baseXP = 1000;
        private double xpToLevelUp;
        private double xpLeftToLevelUp;
        private double totalKills;
        private double totalDeaths;
        private double careerKd;
        private const double killPoints = 50;
        private bool doneLeveling;

        public PlayerProfile(string userName, int userId, double level, double totalKills, double totalDeaths)
        {
            this.userName = userName;
            this.userId = userId;
            this.level = level;
            this.totalKills = totalKills;
            this.totalDeaths = totalDeaths;          
            xp = totalKills * killPoints;
            xpToLevelUp = baseXP * level;
            xpLeftToLevelUp = xpToLevelUp - xp;
            careerKd = totalKills / totalDeaths;
        }

        public override string ToString()
        {
            return String.Format("\nUsername: {0}\nLevel: {1}\nCareer Kills: {2}\nCareer Deaths: {3}\nCareer K/D: {4}\nXP: {5}\n", userName, level, totalKills, totalDeaths, careerKd.ToString("N2"), xp);
        }

        public string MyUserName { get { return userName; } set { userName = value; } }
        public int MyUserId { get { return userId; } set { userId = value; } }
        public double MyLevel { get { return level; } set { level = value; } }
        public double MyXp { get { return xp; } set { xp = value; } }
        public double MyTotalKills { get { return totalKills; } set { totalKills = value; } }
        public double MyTotalDeaths { get { return totalDeaths; } set { totalDeaths = value; } }
        public double MyCareerKd { get { return careerKd; } set { careerKd = value; } }

        public void UpdateStats(MatchData matchData)
        {
            MyTotalKills = MyTotalKills + matchData.currentMatchKills;
            MyTotalDeaths = MyTotalDeaths + matchData.currentMatchDeaths;
            MyXp = MyXp + matchData.currentMatchXp;
            MyCareerKd = MyTotalKills / MyTotalDeaths;
            doneLeveling = false;
            while (doneLeveling == false)
            {
                if(MyXp >= xpToLevelUp)
                {
                    MyLevel++;
                    xpToLevelUp = baseXP * level;
                }
                else
                {
                    doneLeveling = true;
                }
            }
        }

    }
}

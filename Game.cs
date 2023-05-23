using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    public class Game
    {
        private Team team1;
        private Team team2;
        private Referee referee;
        private Referee assistent1;
        private Referee assistent2;
        private List<Goal> goals;
        private string result;
        private Team winner;

        public Team Team1
        {
            get { return team1; }
            private set
            {
                if (IsValidTeam(value) == true) { team1 = value; }
                else { throw new ArgumentException("The first team must consist of 11 players."); }
            }
        }
        public Team Team2
        {
            get { return team2; }
            private set
            {
                if (IsValidTeam(value) == true) { team2 = value; }
                else { throw new ArgumentException("The second team must consist of 11 players."); }
            }
        }
        public Referee Referee { get; private set; }
        public Referee Assistent1 { get; private set; }
        public Referee Assistent2 { get; private set; }
        public List<Goal> Goals { get;}
        public string Result { get; }
        public Team Winner
        {
            get
            {
                return PlayFootball();
            }
        }

        public Game(Team teamA, Team teamB, Referee reff, Referee assistRef1,Referee assistRef2)
        {
            Team1 = teamA;
            Team2 = teamB;
            Referee = reff;
            Assistent1 = assistRef1;
            Assistent2 = assistRef2;
        }
        private bool IsValidTeam(Team team)
        {
            if (team.FootballPlayers.Count == 11) { return true; }
            else { return false; }
        }
        public Team PlayFootball()
        {
            Team teamA = Team1;
            Team teamB = Team2;
            Striker goalMaker;
            Team winner;
            int timer = 0;
            int goalMinute = 0;
            do
            {
                FootballPlayer playerA = GetRandomPlayer(teamA.FootballPlayers);
                FootballPlayer playerB = GetRandomPlayer(teamA.FootballPlayers);
                if(playerA is Striker && playerB is Goalkeeper)


                timer++;
            }
            while (timer == 90);


            return winner;
        }

        private FootballPlayer GetRandomPlayer(List<FootballPlayer> players)
        {
            Random random = new Random();
            int randomPlayer = random.Next(players.Count);
            return players[randomPlayer];
        }

    }
}

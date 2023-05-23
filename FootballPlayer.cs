using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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
        public List<Goal> Goals { get; private set; }
        public string Result { get; private set; }
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
            
            FootballPlayer attacker = GetRandomPlayer(Team1.FootballPlayers);
            FootballPlayer defender = GetRandomPlayer(Team2.FootballPlayers);
            bool team1HasBall = true;
            List<Goal> goalsTeam1 = new List<Goal>();
            List<Goal> goalsTeam2 = new List<Goal>();
            int timer = 0;
            do
            {
                int scoreA = attacker.Attack();
                int scoreD = defender.Defend();

                if (scoreA > scoreD) 
                { 
                    team1HasBall = true; 
                }
                else if(scoreA < scoreD) 
                { 
                    team1HasBall = false;
                    FootballPlayer temp = attacker;
                    attacker = defender;
                    defender = temp;
                }

                if (attacker is Striker && defender is Goalkeeper)
                {
                    if(scoreA > scoreD)
                    {
                        Goal goal = new Goal(timer, attacker);
                        Goals.Add(goal);
                        if(team1HasBall)
                        {
                            goalsTeam1.Add(goal);
                        }
                        else
                        {
                            goalsTeam2.Add(goal);
                        }
                    }
                    
                }
                timer++;

            }
            while (timer == 90);

            this.Result = $"Team 1: {goalsTeam1.Count} - {goalsTeam2.Count} : Team 2";
            Team winner;
            if(goalsTeam1.Count > goalsTeam2.Count)
            {
                winner = Team1;
            }
            else
            {
                winner = Team2;
            }

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

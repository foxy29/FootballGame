using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<FootballPlayer> listTeamA = new List<FootballPlayer>()
            {
                new Striker("StrikerOne", 10, 25, 1.90),
                new Striker("StrikerTwo", 13, 24, 2.10),
                new Defender("DefenderOne", 17, 24, 2.0),
                new Defender("DefenderTwo", 6, 25, 1.94),
                new Defender("DefenderThree", 45, 23, 1.94),
                new Striker("StrikerThree", 9, 25, 1.95),
                new Midfield("MidfieldFour", 23, 21, 1.89),
                new Midfield("MidfieldThree", 89, 22, 1.99),
                new Midfield("MidfieldTwo", 65, 25, 1.90),
                new Midfield("MidfieldOne", 11, 25, 1.94),
                new Goalkeeper("Goalkeeper", 8, 25, 1.94)

             };

            List<FootballPlayer> listTeamB = new List<FootballPlayer>()
            {
                new Striker("StrikerOne", 10, 25, 1.90),
                new Striker("StrikerTwo", 13, 24, 2.10),
                new Defender("DefenderOne", 17, 24, 2.0),
                new Defender("DefenderTwo", 6, 25, 1.94),
                new Defender("DefenderThree", 45, 23, 1.94),
                new Striker("StrikerThree", 9, 25, 1.95),
                new Midfield("MidfieldFour", 23, 21, 1.89),
                new Midfield("MidfieldThree", 89, 22, 1.99),
                new Midfield("MidfieldTwo", 65, 25, 1.90),
                new Midfield("MidfieldOne", 11, 25, 1.94),
                new Goalkeeper("Goalkeeper", 8, 25, 1.94)

             };

            Team teamA = new Team(new Coach("CoachOne", 40),listTeamA);
            Team teamB = new Team(new Coach("CoachTwo", 42), listTeamB);

            Game game = new Game(teamA,teamB, new Referee("Refer",50), new Referee("AssistaOne", 45), new Referee("AssistaTwo",43));
            Console.WriteLine(game.Result);
            Console.WriteLine(game.Winner);

        }
    }
}

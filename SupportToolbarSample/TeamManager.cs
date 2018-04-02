using System;
using System.Collections.Generic;
using System.Linq;

namespace SupportToolbarSample
{
    public static class TeamManager
    {
        public static List<Team> Teams { get; private set; }

        static TeamManager()
        {
            var temp = new List<Team>();
            AddTeams(temp);

            Teams = temp.OrderBy(t => t.Name).ToList();
        }


        static void AddTeams(List<Team> teams)
        {
            teams.Add(new Team()
            {
                Name="Manchester City",
                Home="Etihad Stadium",
                ChestURL="mancity.png"
            });
            teams.Add(new Team()
            {
                Name = "Manchester United",
                Home = "Old Trafford",
                ChestURL="manunited.png"
            });
            teams.Add(new Team()
            {
                Name = "Liverpool",
                Home = "Anfield",
                ChestURL="liverpool.png"
            });
            teams.Add(new Team()
            {
                Name = "Tottenham",
                Home = "White Hart Lane",
                ChestURL="tottenham.png"
            });
            teams.Add(new Team()
            {
                Name = "Chelsea",
                Home = "Stanford Bridge",
                ChestURL="chelsea.png"
            });
            teams.Add(new Team()
            {
                Name = "Arsenal",
                Home = "Emirates Stadium",
                ChestURL="arsenal.png"
            });
            teams.Add(new Team()
            {
                Name = "Burnley",
                Home = "Turf Moor",
                ChestURL="burnley.jpg"
            });
            teams.Add(new Team()
            {
                Name = "Leicester",
                Home = "King Power Stadium",
                ChestURL="leicester.jpg"
            });
            teams.Add(new Team()
            {
                Name = "Watford",
                Home = "Vicarage Road",
                ChestURL="watford.png"
            });
            teams.Add(new Team()
            {
                Name = "Brighton",
                Home = "Amex Stadium",
                ChestURL="brigthon.jpg"
            });
            teams.Add(new Team()
            {
                Name = "Everton",
                Home = "Goodison Park",
                ChestURL="everton.png"
            });
            teams.Add(new Team()
            {
                Name = "AFC Bournemouth",
                Home = "Vitality Stadium",
                ChestURL="bournemouth.png"
            });
            teams.Add(new Team()
            {
                Name = "Swansea City",
                Home = "Liberty Stadium",
                ChestURL="swansea.png"
            });
            teams.Add(new Team()
            {
                Name = "West Ham United",
                Home = "London Stadium",
                ChestURL ="westham.png"
            });
            teams.Add(new Team()
            {
                Name = "Huddersfield Town",
                Home = "John Smith's Stadium",
                ChestURL="huddersfield.png"
            });
            teams.Add(new Team()
            {
                Name = "Newcastle United",
                Home = "St.James Park",
                ChestURL="newcastle.png"
            });
            teams.Add(new Team()
            {
                Name = "Southampton",
                Home = "St.Mary's Stadium",
                ChestURL="southampton.png"
            });
            teams.Add(new Team()
            {
                Name = "Chrystal Palace",
                Home = "Selhurst Park",
                ChestURL="crystalpalace.png"
            });
            teams.Add(new Team()
            {
                Name = "Stoke City",
                Home = "bet365 Stadium",
                ChestURL="stoke.png"
            });
            teams.Add(new Team()
            {
                Name = "West Bromwich Albion",
                Home = "The Hawthorns",
                ChestURL="stoke.png"
            });

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoszykowkaStr774.Model;
using System.Collections.ObjectModel;

namespace KoszykowkaStr774.ViewModel
{
    class LeagueViewModel
    {
        public RosterViewModel BriansTeam { get; set; }
        public RosterViewModel JimmysTeam { get; set; }

        public LeagueViewModel()
        {
            Roster briansRoster = new Roster("Bomibiarze", GetBomberPlayers());
            BriansTeam = new RosterViewModel(briansRoster);

            Roster jimmysRoster = new Roster("Wspaniali", GetAmazinPlayers());
            JimmysTeam = new RosterViewModel(jimmysRoster);
        }

        private IEnumerable<Player> GetBomberPlayers()
        {
            List<Player> bomberPlayers = new List<Player>() {
                new Player("Damian", 31, true),
                new Player("Ludwig", 23, true),
                new Player("Krystian",6, true),
                new Player("Maciek", 0, true),
                new Player("Janek", 42, true),
                new Player("Hubert",32, false),
                new Player("Ferdek",8, false),
            };
            return bomberPlayers;
        }

        private IEnumerable<Player> GetAmazinPlayers()
        {
            List<Player> amazinPlayers = new List<Player>() {
                new Player("Kuba",42, true),
                new Player("Heniek",11, true),
                new Player("Robert",4, true),
                new Player("Lucek", 18, true),
                new Player("Kim", 16, true),
                new Player("Bartek", 23, false),
                new Player("Edek",21,  false),
            };
            return amazinPlayers;
        }
    }
}


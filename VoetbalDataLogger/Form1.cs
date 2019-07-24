using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace VoetbalDataLogger
{
    public partial class VoetbalDataLogger : Form
    {
        XmlSerializer xMLGames, xMLComps;
        List<Game> Games;
        List<Competition> Competitions;
        public VoetbalDataLogger()
        {
            InitializeComponent();
            xMLGames = new XmlSerializer(typeof(List<Game>));
            xMLComps = new XmlSerializer(typeof(List<Competition>));
            Games = new List<Game>();
            Competitions = new List<Competition>();
        }

        private void GameButton_Click(object sender, EventArgs e)
        {
            if (CompList.SelectedValue != null && Team1.SelectedValue != null && Team2.SelectedValue != null)
            {
                Competition comp = (Competition)CompList.SelectedValue;
                Team home = (Team)Team1.SelectedValue;
                Team away = (Team)Team2.SelectedValue;
                int homeScore = (int)HomeScore.Value;
                int awayScore = (int)AwayScore.Value;
                AddGame(comp, home, away, homeScore, awayScore);
            }
            else
            {
                MessageBox.Show("Choose a competition and teams for this match");
            }
        }

        private void TeamButton_Click(object sender, EventArgs e)
        {
            if (CompList.SelectedItem != null &! String.IsNullOrEmpty(Name.Text))
            {
                Competition comp = (Competition)CompList.SelectedValue;
                string teamName = Name.Text;
                AddClub(comp, teamName);
                CompList.DataSource = Competitions;
                Name.Clear();
                CompConfirm_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Choose a name and competition for this team");
            }
        }

        private void CompButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Name.Text))
            {
                string compName = Name.Text;
                AddCompetition(compName);
                CompList.DataSource = null;
                CompList.DataSource = Competitions;
                Name.Clear();
                CompConfirm_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Choose a name for this competition");
            }
        }

        private void CompConfirm_Click(object sender, EventArgs e)
        {
            if (CompList != null && CompList.SelectedValue != null)
            {
                Competition comp = (Competition)CompList.SelectedValue;
                Team1.DataSource = null;
                Team2.DataSource = null;
                Team1.DataSource = comp.HomeTeams;
                Team2.DataSource = comp.AwayTeams;
            }
        }

        private void Save_Click(object sender, EventArgs e) //write data to xml-files
        {
            //games-file
            FileStream fileStream = new FileStream("games.xls", FileMode.Create, FileAccess.Write);
            xMLGames.Serialize(fileStream, Games);
            fileStream.Close();
     
            //competitions-file
            fileStream = new FileStream("competitions.xls", FileMode.Create, FileAccess.Write);
            xMLComps.Serialize(fileStream, Competitions);
            fileStream.Close();
            }

        private void Load_Click(object sender, EventArgs e) //read data from xml-files
        {
            //games-file
            FileStream fileStream;
            fileStream = new FileStream("games.xls", FileMode.Open, FileAccess.Read);
            Games = (List<Game>)xMLGames.Deserialize(fileStream);
            fileStream.Close();
            
            //competitions-file
            fileStream = new FileStream("competitions.xls", FileMode.Open, FileAccess.Read);
            Competitions = (List<Competition>)xMLComps.Deserialize(fileStream);
            fileStream.Close();

            //update the lists
            CompList.DataSource = null;
            CompList.DataSource = Competitions;


        }

        void AddGame(Competition comp, Team home, Team away, int scoreHome, int scoreAway)
        {
            Game game = new Game(comp, home, away, scoreHome, scoreAway);
            Games.Add(game);
            LatestMatchLabel.Text = Games[Games.Count-1].ToString();
        }

        void AddCompetition(string name)
        {
            Competition competition = new Competition(name);
            Competitions.Add(competition);
        }

        void AddClub(Competition comp, string name)
        {
            Team team = new Team(name);
            comp.AddTeam(team);
        }
    }

    public class Game
    {
        [XmlIgnore]
        public Competition competition;
        public string competitionName;
        public Team homeTeam;
        public Team awayTeam;
        public int homeScore;
        public int awayScore;

        public Game()
        {

        }

        public Game(Competition comp, Team home, Team away, int homescore, int awayscore)
        {
            competition = comp;
            competitionName = comp.ToString();
            homeTeam = home;
            awayTeam = away;
            homeScore = homescore;
            awayScore = awayscore;
        }
        public override string ToString()
        {
            return competition.ToString() + ": " + homeTeam.ToString() + " " + homeScore + ":" + awayScore + " " + awayTeam.ToString();
        }
    }

    public class Team
    {
        public string name;

        public Team()
        {

        }

        public Team(string s)
        {
            name = s;
        }

        public override string ToString()
        {
            return name;
        }
    }

    public class Competition
    {
        public string Name;
        [XmlArrayItem("HomeTeam")]
        public List<Team> HomeTeams;
        public List<Team> AwayTeams;

        public Competition()
        {

        }

        public Competition(string s)
        {
            Name = s;
            HomeTeams = new List<Team>();
            AwayTeams = new List<Team>();
        }

        public void AddTeam(Team t)
        {
            HomeTeams.Add(t);
            AwayTeams.Add(t);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

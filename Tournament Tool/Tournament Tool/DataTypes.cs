using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Tool
{

    public class User
    {
        public int ID; //unique ID to identify a specific user
        public string Username;
        string Password;
        List<int> TournamentIDs;// list of tournaments the user is entered
        int Type; // 0: Guest, 1: Player, 2: TO
        bool Flag; // successful account creation

        //need a way to verify ID is not a duplicate
        public User()
        {
            ID = 0;
            Username = "Guest";
            Password = "";
            TournamentIDs = new List<int>();
            Type = 0;
            Flag = true;
        }

        public User(string u, string p, int t)
        {
            Username = u;
            Password = p;
            TournamentIDs = new List<int>();
            Type = t;
            Flag = false;
        }

        public bool isValid()
        {
            //Need to make method that verifies that an account has been made and added to the database
            return Flag;
        }
        public void AddTournament(int id)
        {
            TournamentIDs.Add(id);
        }
        public bool RemoveTournament(int id)
        {
            return TournamentIDs.Remove(id);
        }
    }

    public class Tournament
    {
        int ID;//unique identifier
        string Name;//title of the event
        string Game; //game being playerd
        DateTime Date;//when
        string Location;//where
        int Status;//upcoming, happening, done
        int EntryFee; //how much per bracket or whatever
        List<Entrant> Entrants= new List<Entrant>();//objects that have players and all their match data
        int MaxEntrants;
        bool Flag;
        int Style;
        List<Match> Winners;
        List<Match> Losers;
        public Tournament(string n, string g, DateTime d, string l, int e, int m, int id)
        {
            Name = n;
            Game = g;
            Date = d;
            Location = l;
            EntryFee = e;
            MaxEntrants = m;
            Flag = false;
            Status = Date.CompareTo(DateTime.Now);
            ID = id;

        }
        public Tournament(int id)
        {
            Flag = false;
            ID = id;
        }

        public bool AddEntrant(Entrant e)
        {
            if (Entrants.Count() + 1 <= MaxEntrants)
            {
                Entrants.Add(e);
                return true;
            }
            return false;
        }
        public bool RemoveEntrant(int id)
        {
            return Entrants.Remove(Entrants.Find(x => x.GetUserID().Equals(id)));
        }

        public void GenerateMatches()
        {
            Winners.Add(new Match(Entrants.ElementAt(0), Entrants.ElementAt((Entrants.Count-1))));
        }

        public void setStyle(int i)
        {
            Style = i;
        }

        public void setName(string i)
        {
            Name = i;
        }

        public void setGame(string i)
        {
            Game = i;
        }
        public void setDate(DateTime i)
        {
            Date = i;
        }
        public void setLocation(string i)
        {
            Location = i;
        }
        public void setEntry(int i)
        {
            EntryFee = i;
        }
        public void setMaxEntrants(int i)
        {
            MaxEntrants = i;
        }
        public void setFlag()
        {
            Flag = true;
        }
        public bool GetFlag()
        {
            return Flag;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetGame()
        {
            return Game;
        }
        public DateTime GetDate()
        {
            return Date;
        }
        public string GetLocation()
        {
            return Location;
        }
        public int GetEntryFee()
        {
            return EntryFee;
        }
        public int GetMaxEntrants()
        {
            return MaxEntrants;
        }
        public int GetStyle()
        {
            return Style;
        }

        public int GetID()
        {
            return ID;
        }
        public void setID(int i)
        {
            ID = i;
        }
        public int GetTotalEntrants()
        {
            return Entrants.Count;
        }
        public List<Entrant> GetEntrants()
        {
            return Entrants;
        }
        public DataTable ConvertToDatatable()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Tag");
            dt.Columns.Add("UserID");

            foreach (Entrant item in Entrants)
            {
                var row = dt.NewRow();

                row["Tag"] = item.GetTag();
                row["UserID"] = item.GetUserID();

                dt.Rows.Add(row);
            }

            return dt;
        }




    }


    public class Entrant
    {
        User User;
        String Tag;
        int Standing;
        //Seed should be based on index in the Tournaments List
        public Entrant(User u)
        {
            User = u;
            Tag = User.Username;
        }

        public Entrant(User u, string s)
        {
            User = u;
            Tag = s;
        }

        public Entrant(string s)
        {
            Tag = s;
        }
        public string GetTag()
        {
            return Tag;
        }
        public int GetUserID()
        {
            return User.ID;
        }
        
    }
    public class Match {
        int[] Score;
        Entrant[] Players = new Entrant[2];
        int ID;
        Entrant Winner;
        Entrant Loser;
        
        public Match(Entrant a, Entrant b)
    {
            Players[0] = a;
            Players[1] = b;
            //generate ID
    }
   }

    

}

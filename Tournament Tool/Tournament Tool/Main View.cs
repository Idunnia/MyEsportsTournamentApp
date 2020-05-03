using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tournament_Tool
{
    public partial class Form1 : Form
    {
        List<Tournament> t = new List<Tournament>();// info from the database
        List<User> u;
        DataTable TournamentTable = new DataTable();
        User me = new User();
        Random x = new Random();
        public Form1()
        {
            InitializeComponent();
            t.Add(new Tournament("Justin's Event", "Smash", System.DateTime.Now, "My House", 3, 44,x.Next(0,100000)));
            t.Add(new Tournament("Jeremey's Event", "Tekken", new DateTime(2020,5,1), "Bathroom", 2, 44, x.Next(0, 100000)));
            t.Add(new Tournament("Wrestlemanina", "WWE 2k", new DateTime(2020,4,27), "Gym", 1, 44, x.Next(0, 100000)));
            t.Add(new Tournament("Fight Night", "Mortal Kombat", System.DateTime.Now, "Dark Alley", 4, 44, x.Next(0, 100000)));
            TournamentTable = ConvertToDatatable(t);
            this.DisplayUserTournaments.DataSource = TournamentTable;
            this.DisplayTournamentGrid.DataSource = TournamentTable;

        }



        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            //get that date and only display tournaments on this  date in the list view
            DateDisplayBox.Text = monthCalendar1.SelectionStart.Date.ToString()+" - "+monthCalendar1.SelectionEnd.Date.ToString();
            
        }

        private void DateDisplayBox_MouseClick(object sender, MouseEventArgs e)
        {
            DateDisplayBox.Text = "Calendar";
        }

        private void CreateNewButton_Click(object sender, EventArgs e)
        {
            Tournament temp = new Tournament(x.Next(0, 100000));
            TournamentCreationForm a = new TournamentCreationForm(temp);
            a.FormClosed += new FormClosedEventHandler(Form1_FormClosed);

            void Form1_FormClosed(object s, FormClosedEventArgs el)
            {
                // Do something
                if (temp.GetFlag())
            {
                t.Add(temp);
            }
            UpdateUserTournaments();
            }
            
        
        }


        private void tabTO_Enter(object sender, EventArgs e)
        {
            UpdateUserTournaments();
        }

        public void UpdateUserTournaments()
        {
            TournamentTable = ConvertToDatatable(t);
            DisplayUserTournaments.DataSource = TournamentTable;
            DisplayUserTournaments.Update();
            DisplayUserTournaments.Refresh();

        }

        public void UpdateDisplayTournaments()
        {
            TournamentTable = ConvertToDatatable(t);
            DisplayTournamentGrid.DataSource = TournamentTable;
            DisplayTournamentGrid.Update();
            DisplayTournamentGrid.Refresh();

        }

        static DataTable ConvertToDatatable(List<Tournament> list)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Name");
            dt.Columns.Add("Game");
            dt.Columns.Add("Date");
            dt.Columns.Add("Location");
            dt.Columns.Add("Entry Fee");
            dt.Columns.Add("Max Entrants");
            dt.Columns.Add("ID");
           

            foreach (Tournament item in list)
            {
                var row = dt.NewRow();

                row["Name"] = item.GetName();
                row["Game"] = item.GetGame();
                row["Date"] = item.GetDate();
                row["Location"] = item.GetLocation();
                row["Entry Fee"] = item.GetEntryFee();
                row["Max Entrants"] = item.GetMaxEntrants();
                row["ID"] = item.GetID();

                dt.Rows.Add(row);
            }

            return dt;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if(!(DisplayUserTournaments.CurrentRow == null))
            {
                DataRow current = ((DataRowView)DisplayUserTournaments.CurrentRow.DataBoundItem).Row;
                Tournament jam = t.Find(x => x.GetID().Equals(int.Parse(current.ItemArray[6].ToString())));
                TournamentCreationForm a = new TournamentCreationForm(jam, true);
                a.FormClosed += new FormClosedEventHandler(Form1_FormClosed);

                void Form1_FormClosed(object send, FormClosedEventArgs el)
                {
                    // Do something
                    UpdateUserTournaments();
                }
                
            }
        }

        private void DisplayTournamentGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RegisterButton.Enabled = true;
        }


        private void filterButton_Click(object sender, EventArgs e)
        {
            if (filterButton.Text.Equals("Filter"))
            {
                filterButton.Text = "Unfilter";
                List<DataRow> temp = new List<DataRow>();
                var currentSelection = monthCalendar1.SelectionRange;
                
                foreach(DataRow r in TournamentTable.Rows)
                {
                    DateTime d = DateTime.Parse(r.ItemArray[2].ToString());
                    
                    if(currentSelection.Start == currentSelection.End)
                    {
                        if((d.DayOfYear == currentSelection.Start.DayOfYear))
                        {
                            temp.Add(r);
                        }
                    }
                    else if((d > currentSelection.Start) && (d < currentSelection.End))
                    {
                        temp.Add(r);
                    }
                }
                int rc = TournamentTable.Rows.Count;
                foreach(DataRow r in temp)
                {
                    TournamentTable.ImportRow(r);
                }
                for(int i = 0; i<rc; i++)
                {
                    TournamentTable.Rows.RemoveAt(0);
                }
                DisplayTournamentGrid.DataSource = TournamentTable;
                DisplayTournamentGrid.Update();
                DisplayTournamentGrid.Refresh();
                myTmntButton.Enabled = false;


            } else if (filterButton.Text.Equals("Unfilter"))
            {
                filterButton.Text = "Filter";
                myTmntButton.Enabled = true;
                UpdateDisplayTournaments();
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (!(DisplayTournamentGrid.CurrentRow == null))
            {
                DataRow current = ((DataRowView)DisplayTournamentGrid.CurrentRow.DataBoundItem).Row;
                Tournament jam = t.Find(x => x.GetID().Equals(int.Parse(current.ItemArray[6].ToString())));
                TournamentViewer a = new TournamentViewer(jam, me);


            }
        }

        private void myTmntButton_Click(object sender, EventArgs e)
        {
            List<Tournament> temp = new List<Tournament>();
            foreach(Tournament r in t)
            {
                if(r.GetEntrants().Exists(x => x.GetUserID().Equals(me.ID)))
                {
                    temp.Add(r);
                }
                
                
            }
                DisplayTournamentGrid.DataSource = ConvertToDatatable(temp);
                DisplayTournamentGrid.Update();
                DisplayTournamentGrid.Refresh();
            myTmntButton.Enabled = false;
            filterButton.Text = "Unfilter";

        }

        private void tabTournament_Enter(object sender, EventArgs e)
        {
            UpdateDisplayTournaments();
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            UpdateDisplayTournaments();
            UpdateUserTournaments();
        }
    }
}

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
    public partial class TournamentViewer : Form
    {
        Tournament t;
        User me;
        public TournamentViewer(Tournament j, User i)
        {
            t = j;
            me = i;
            InitializeComponent();

            label1.Text = t.GetName();
            label2.Text = t.GetGame();
            switch (t.GetStyle())
            {
                case 0:
                    label3.Text = "Double Elimination";
                    break;
                case 1:
                    label3.Text = "Single Elimination";
                    break;
                case 2:
                    label3.Text = "Round Robin";
                    break;
            }
            label4.Text = t.GetDate().ToString();
            label5.Text = t.GetLocation();
            label6.Text = t.GetEntryFee().ToString();
            label7.Text = t.GetMaxEntrants().ToString();
            label8.Text = t.GetTotalEntrants().ToString();
            if(t.GetEntrants().Exists(x => x.GetUserID().Equals(me.ID)))
            {
                textBox1.Text = t.GetEntrants().Find(x => x.GetUserID().Equals(me.ID)).GetTag();
                Register.Text = "Unregister";
            }
            UpdateDisplayEntrants();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //check that fields have been filed in
            //add ID to the users list
            if (Register.Text.Equals("Unregister"))
            {
                t.RemoveEntrant(me.ID);
                me.RemoveTournament(t.GetID());
                Register.Text = "Register";
            }
            else if(textBox1.Text.Any() && Register.Text == "Register")
            {
                //add tag checking
                t.AddEntrant(new Entrant(me, textBox1.Text));
                me.AddTournament(t.GetID());
                Register.Text = "Unregister";
            }
            else
            {
                label9.Text = "Please Enter a Tag";
            }
            UpdateDisplayEntrants();
            //otherwise remove the id and the user from the list of entrants
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void UpdateDisplayEntrants()
        {
            DisplayEntrants.DataSource = t.ConvertToDatatable();
            DisplayEntrants.Update();
            DisplayEntrants.Refresh();

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            label8.Text = t.GetTotalEntrants().ToString();
            UpdateDisplayEntrants();
        }
    }
}

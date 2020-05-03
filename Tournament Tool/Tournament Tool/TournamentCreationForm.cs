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
    public partial class TournamentCreationForm : Form
    {
        Tournament a;
        public TournamentCreationForm(Tournament b)
        {
            InitializeComponent();
            a = b;
            this.Show();
        }
        public TournamentCreationForm(Tournament b,bool f)
        {
            InitializeComponent();
            a = b;
            if (f)
            {
                textBox1.Text = b.GetName();
                textBox2.Text = b.GetGame();
                comboBox1.SelectedIndex = b.GetStyle();
                dateTimePicker1.Value = b.GetDate();
                textBox4.Text = b.GetLocation();
                textBox5.Text = b.GetEntryFee().ToString();
                textBox6.Text = b.GetMaxEntrants().ToString();
            }
            this.Show();
        }

        private void TournamentCreationForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //check if required fields have something in them
            //(, , dateTimePicker1.Value, textBox4.Text, int.Parse(textBox5.Text), int.Parse(textBox6.Text));
            if (textBox1.Text.Any())
            {
                if (textBox2.Text.Any())
                {
                    if(comboBox1.SelectedIndex != -1)
                    {
                        if (textBox4.Text.Any())
                        {
                            if (textBox6.Text.Any())
                            {
                            //modify the Tournaments values after an are you sure dialog box
                                    a.setName(textBox1.Text);
                                    a.setGame(textBox2.Text);
                                    a.setStyle(comboBox1.SelectedIndex);
                                    a.setDate(dateTimePicker1.Value);
                                    a.setLocation(textBox4.Text);
                                    a.setEntry(int.Parse(textBox5.Text));
                                    a.setMaxEntrants(int.Parse(textBox6.Text));
                                    a.setFlag();
                                this.Close();
                            }
                            else
                            {
                                label8.Text = "Please give a Max Entrant cap.";
                            }
                        }
                        else
                        {
                            label8.Text = "Please set a location.";
                        }
                    }
                    else
                    {
                        label8.Text = "Please select a bracket type.";
                    }
                    
                }
                else
                {
                    label8.Text = "No game selected.";
                }
            }
            else
            {
                label8.Text = "You need to name the event.";
            }
            
        }

        
    }
}

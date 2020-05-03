namespace Tournament_Tool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sideTab = new System.Windows.Forms.TabControl();
            this.tabTournament = new System.Windows.Forms.TabPage();
            this.panelTournament = new System.Windows.Forms.Panel();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.DisplayTournamentGrid = new System.Windows.Forms.DataGridView();
            this.DateDisplayBox = new System.Windows.Forms.TextBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tabTO = new System.Windows.Forms.TabPage();
            this.EditButton = new System.Windows.Forms.Button();
            this.DisplayUserTournaments = new System.Windows.Forms.DataGridView();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CreateNewButton = new System.Windows.Forms.Button();
            this.tabBracket = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.myTmntButton = new System.Windows.Forms.Button();
            this.sideTab.SuspendLayout();
            this.tabTournament.SuspendLayout();
            this.panelTournament.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayTournamentGrid)).BeginInit();
            this.tabTO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayUserTournaments)).BeginInit();
            this.tabBracket.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideTab
            // 
            this.sideTab.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.sideTab.Controls.Add(this.tabTournament);
            this.sideTab.Controls.Add(this.tabTO);
            this.sideTab.Controls.Add(this.tabBracket);
            this.sideTab.ItemSize = new System.Drawing.Size(100, 25);
            this.sideTab.Location = new System.Drawing.Point(-1, 27);
            this.sideTab.Multiline = true;
            this.sideTab.Name = "sideTab";
            this.sideTab.Padding = new System.Drawing.Point(3, 3);
            this.sideTab.SelectedIndex = 0;
            this.sideTab.Size = new System.Drawing.Size(1266, 653);
            this.sideTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.sideTab.TabIndex = 2;
            // 
            // tabTournament
            // 
            this.tabTournament.Controls.Add(this.panelTournament);
            this.tabTournament.Location = new System.Drawing.Point(29, 4);
            this.tabTournament.Name = "tabTournament";
            this.tabTournament.Padding = new System.Windows.Forms.Padding(3);
            this.tabTournament.Size = new System.Drawing.Size(1233, 645);
            this.tabTournament.TabIndex = 0;
            this.tabTournament.Text = "Find a Tourney";
            this.tabTournament.UseVisualStyleBackColor = true;
            this.tabTournament.Enter += new System.EventHandler(this.tabTournament_Enter);
            // 
            // panelTournament
            // 
            this.panelTournament.Controls.Add(this.myTmntButton);
            this.panelTournament.Controls.Add(this.RegisterButton);
            this.panelTournament.Controls.Add(this.DisplayTournamentGrid);
            this.panelTournament.Controls.Add(this.DateDisplayBox);
            this.panelTournament.Controls.Add(this.filterButton);
            this.panelTournament.Controls.Add(this.textBox1);
            this.panelTournament.Controls.Add(this.monthCalendar1);
            this.panelTournament.Location = new System.Drawing.Point(3, 1);
            this.panelTournament.Name = "panelTournament";
            this.panelTournament.Size = new System.Drawing.Size(1223, 646);
            this.panelTournament.TabIndex = 5;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Enabled = false;
            this.RegisterButton.Location = new System.Drawing.Point(292, 591);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(142, 36);
            this.RegisterButton.TabIndex = 10;
            this.RegisterButton.Text = "Register / View Entrants";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // DisplayTournamentGrid
            // 
            this.DisplayTournamentGrid.AllowUserToAddRows = false;
            this.DisplayTournamentGrid.AllowUserToDeleteRows = false;
            this.DisplayTournamentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayTournamentGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DisplayTournamentGrid.Location = new System.Drawing.Point(259, 5);
            this.DisplayTournamentGrid.MultiSelect = false;
            this.DisplayTournamentGrid.Name = "DisplayTournamentGrid";
            this.DisplayTournamentGrid.ReadOnly = true;
            this.DisplayTournamentGrid.ShowEditingIcon = false;
            this.DisplayTournamentGrid.Size = new System.Drawing.Size(961, 568);
            this.DisplayTournamentGrid.TabIndex = 9;
            this.DisplayTournamentGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DisplayTournamentGrid_CellClick);
            // 
            // DateDisplayBox
            // 
            this.DateDisplayBox.Location = new System.Drawing.Point(20, 5);
            this.DateDisplayBox.Name = "DateDisplayBox";
            this.DateDisplayBox.ReadOnly = true;
            this.DateDisplayBox.Size = new System.Drawing.Size(227, 20);
            this.DateDisplayBox.TabIndex = 8;
            this.DateDisplayBox.Text = "Calendar";
            this.DateDisplayBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DateDisplayBox_MouseClick);
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(20, 211);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(75, 23);
            this.filterButton.TabIndex = 7;
            this.filterButton.Text = "Filter";
            this.filterButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 375);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(20, 37);
            this.monthCalendar1.MaxSelectionCount = 31;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // tabTO
            // 
            this.tabTO.Controls.Add(this.EditButton);
            this.tabTO.Controls.Add(this.DisplayUserTournaments);
            this.tabTO.Controls.Add(this.DeleteButton);
            this.tabTO.Controls.Add(this.CreateNewButton);
            this.tabTO.Location = new System.Drawing.Point(29, 4);
            this.tabTO.Name = "tabTO";
            this.tabTO.Padding = new System.Windows.Forms.Padding(3);
            this.tabTO.Size = new System.Drawing.Size(1233, 645);
            this.tabTO.TabIndex = 1;
            this.tabTO.Text = "Your Tournaments";
            this.tabTO.UseVisualStyleBackColor = true;
            this.tabTO.Enter += new System.EventHandler(this.tabTO_Enter);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(614, 107);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DisplayUserTournaments
            // 
            this.DisplayUserTournaments.AllowUserToAddRows = false;
            this.DisplayUserTournaments.AllowUserToDeleteRows = false;
            this.DisplayUserTournaments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayUserTournaments.Location = new System.Drawing.Point(19, 16);
            this.DisplayUserTournaments.Name = "DisplayUserTournaments";
            this.DisplayUserTournaments.ReadOnly = true;
            this.DisplayUserTournaments.Size = new System.Drawing.Size(573, 516);
            this.DisplayUserTournaments.TabIndex = 3;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(614, 148);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // CreateNewButton
            // 
            this.CreateNewButton.Location = new System.Drawing.Point(614, 64);
            this.CreateNewButton.Name = "CreateNewButton";
            this.CreateNewButton.Size = new System.Drawing.Size(75, 23);
            this.CreateNewButton.TabIndex = 1;
            this.CreateNewButton.Text = "Create";
            this.CreateNewButton.UseVisualStyleBackColor = true;
            this.CreateNewButton.Click += new System.EventHandler(this.CreateNewButton_Click);
            // 
            // tabBracket
            // 
            this.tabBracket.Controls.Add(this.panel1);
            this.tabBracket.Controls.Add(this.comboBox1);
            this.tabBracket.Location = new System.Drawing.Point(29, 4);
            this.tabBracket.Name = "tabBracket";
            this.tabBracket.Padding = new System.Windows.Forms.Padding(3);
            this.tabBracket.Size = new System.Drawing.Size(1233, 645);
            this.tabBracket.TabIndex = 2;
            this.tabBracket.Text = "Bracket";
            this.tabBracket.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(353, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(456, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // myTmntButton
            // 
            this.myTmntButton.Location = new System.Drawing.Point(508, 591);
            this.myTmntButton.Name = "myTmntButton";
            this.myTmntButton.Size = new System.Drawing.Size(138, 36);
            this.myTmntButton.TabIndex = 11;
            this.myTmntButton.Text = "My Registered Events";
            this.myTmntButton.UseVisualStyleBackColor = true;
            this.myTmntButton.Click += new System.EventHandler(this.myTmntButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.sideTab);
            this.Name = "Form1";
            this.Text = "Esports Tournament Tool";
            this.Enter += new System.EventHandler(this.Form1_Enter);
            this.sideTab.ResumeLayout(false);
            this.tabTournament.ResumeLayout(false);
            this.panelTournament.ResumeLayout(false);
            this.panelTournament.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayTournamentGrid)).EndInit();
            this.tabTO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayUserTournaments)).EndInit();
            this.tabBracket.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl sideTab;
        private System.Windows.Forms.TabPage tabTournament;
        private System.Windows.Forms.TabPage tabTO;
        private System.Windows.Forms.TabPage tabBracket;
        private System.Windows.Forms.Panel panelTournament;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox DateDisplayBox;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DisplayUserTournaments;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CreateNewButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DisplayTournamentGrid;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button myTmntButton;
    }

    public class BracketCell
    {
        string winner, player1, player2, score1, score2;
        System.Windows.Forms.Button modify;
    }
}


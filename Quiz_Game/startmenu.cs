using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Quiz_Game
{
    public partial class startmenu : Form
    {
        public static string question_type;
        public startmenu()
        {
            InitializeComponent();
            //loads all avilable quiz types into the selector
            #region Get all question type
            List<string> data = new List<string>(); //creates a multi dimentional array of all men and their prefrences on their counterparts
            string file_location = Application.StartupPath + "\\questions.accdb";//gets file path
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + file_location;
            string strSQL = "SELECT * FROM data";
            // Create a connection  
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Create a command and set its connection  
                OleDbCommand command = new OleDbCommand(strSQL, connection);
                // Open the connection and execute the select command.  
                try
                {
                    // Open connecton  
                    connection.Open();
                    // Execute command  
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.Add(reader["Question Type"].ToString());
                            //creates a user profile to be analysed by system
                        }
                        connection.Close();
                    }
                }
                catch (Exception)
                {

                }
            }
            data.Sort();
            int index = 0;
            while (index < data.Count - 1)
            {
                if (data[index] == data[index + 1])
                    data.RemoveAt(index);
                else
                    index++;
            }
            topiclist.Items.AddRange(data.ToArray());
            #endregion
        }

        private void topiclist_SelectedIndexChanged(object sender, EventArgs e)
        {
            //makes buttons to begin appear when a topic is selected
            startquiz_btn.Visible = true;
            startquiz_btn.Enabled = true;
            leaderboard_btn.Visible = true;
            leaderboard_btn.Enabled = true;
            question_type = topiclist.Text;
        }

        private void startquiz_btn_Click(object sender, EventArgs e)
        {
            //if the person wants to start a quiz
            quizgame.question_number = 1;
            Form quiz = new quizgame();
            quiz.Show();
            this.Hide();
        }

        private void leaderboard_btn_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["leaderboard"] == null)
            {
                Form Lead = new leaderboard();
                Lead.Show();
                this.Hide();
            }
        }

        private void suggestions_btn_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["suggest"]==null)
            {
                if (suggest.suggestions_left != 0)
                {
                    Form suggestions = new suggest();
                    suggestions.Show();
                }
                else
                {
                    MessageBox.Show("You have reached your suggestion limit, a limit is in place to stop spam", "No more suggestions allowed");
                }
            }
        }

        private void startmenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void topiclist_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

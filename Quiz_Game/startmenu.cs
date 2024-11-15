using System.Data.OleDb;

namespace Quiz_Game
{
    public partial class StartMenu : Form
    {
        public static string? question_type;
        public StartMenu()
        {
            InitializeComponent();
            //loads all avilable quiz types into the selector
            #region Get all question type
            List<string> data = []; //creates a multi dimentional array of all men and their prefrences on their counterparts
            string file_location = Application.StartupPath + "\\questions.accdb";//gets file path
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + file_location;
            string strSQL = "SELECT * FROM data";
            // Create a connection  
            using (OleDbConnection connection = new(connectionString))
            {
                // Create a command and set its connection  
                OleDbCommand command = new(strSQL, connection);
                // Open the connection and execute the select command.  
                try
                {
                    // Open connecton  
                    connection.Open();
                    // Execute command  
                    using OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        data.Add(reader["Question Type"].ToString() ?? "");
                        //creates a user profile to be analysed by system
                    }
                    connection.Close();
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
            topiclist.Items.AddRange([.. data]);
            #endregion
        }

        private void TopicListSelectedIndexChanged(object sender, EventArgs e)
        {
            //makes buttons to begin appear when a topic is selected
            startquiz_btn.Visible = true;
            startquiz_btn.Enabled = true;
            leaderboard_btn.Visible = true;
            leaderboard_btn.Enabled = true;
            question_type = topiclist.Text;
        }

        private void StartQuizBtnClick(object sender, EventArgs e)
        {
            //if the person wants to start a quiz
            QuizGame.question_number = 1;
            Form quiz = new QuizGame();
            quiz.Show();
            this.Hide();
        }

        private void LeaderboardBtnClick(object sender, EventArgs e)
        {
            if (Application.OpenForms["leaderboard"] == null)
            {
                Form Lead = new Leaderboard();
                Lead.Show();
                this.Hide();
            }
        }

        private void SuggestionsBtnClick(object sender, EventArgs e)
        {
            if (Application.OpenForms["suggest"] == null)
            {
                if (Suggest.suggestions_left != 0)
                {
                    Form suggestions = new Suggest();
                    suggestions.Show();
                }
                else
                {
                    MessageBox.Show("You have reached your suggestion limit, a limit is in place to stop spam", "No more suggestions allowed");
                }
            }
        }

        private void StartMenuFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TopicListKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

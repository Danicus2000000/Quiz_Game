using System.Data.OleDb;

namespace Quiz_Game
{
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
            InitializeComponent();
            title_lbl.Text = "Leaderboard for " + StartMenu.question_type + ":";
            List<List<string>> data = []; //creates a multi dimentional array of all men and their prefrences on their counterparts
            string file_location = Application.StartupPath + "\\questions.accdb";//gets file path
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + file_location;
            string strSQL = "SELECT * FROM scores WHERE [question type]='" + StartMenu.question_type + "' ORDER BY [score] DESC";
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
                        data.Add([reader["p_name"].ToString() ?? "", reader["score"].ToString() ?? ""]);
                        //creates a user profile to be analysed by system
                    }
                    connection.Close();
                }
                catch (Exception)
                {

                }
            }
            scores_lbl.Text = "";
            if (data.Count != 0)
            {
                for (int i = 0; i < data.Count; i++)
                {
                    scores_lbl.Text += i + 1 + ") " + data[i][0] + ": " + data[i][1] + "\n";
                }
            }
            else
            {
                scores_lbl.Text = "There are no scores in this catagory yet!";
            }
        }

        private void LeaderboardFormClosed(object sender, FormClosedEventArgs e)
        {
            Form start = new StartMenu();
            start.Show();
        }
    }
}

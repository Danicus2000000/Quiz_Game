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
using System.Media;
//To Do:
//More questions
namespace Quiz_Game
{
    public partial class quizgame : Form
    {
        public quizgame()
        {
            InitializeComponent();
        }
        private static bool is_correct(string answer, string correct_answer)
        {
            if (answer == correct_answer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static void Sound_Play(string value)
        {
            SoundPlayer sound = new SoundPlayer();
            if (value == "wrong")
            {
                sound.SoundLocation = Application.StartupPath + "\\Donald Trump Wrong.wav";
            }
            else if (value == "right")
            {
                sound.SoundLocation = Application.StartupPath + "\\Correct sfx.wav";
            }
            sound.Play();
            sound.Dispose();
        }
        private static void game_complete(int score)
        {
            string response=Microsoft.VisualBasic.Interaction.InputBox("Please enter a name for the leaderboard!", "Name Entry");
            if (response != "")
            {
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\questions.accdb";
                string sql = null;
                using (OleDbConnection cnn = new OleDbConnection(connectionString))
                {
                    sql = "insert into scores ([p_name], [score], [question type]) values(@first,@second,@third)";
                    cnn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(sql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@first", response);
                        cmd.Parameters.AddWithValue("@second", score+"/"+max_points);
                        cmd.Parameters.AddWithValue("@third", startmenu.question_type);
                        cmd.ExecuteNonQuery();
                        cnn.Close();
                    }
                }
            }
        }
        private static List<List<string>> data;
        private static string correct_answer;
        private static int points = 0;
        public static int question_number = 1;
        private static int max_points;
        private void quizgame_Load(object sender, EventArgs e)
        {
            #region Data Load
            data = new List<List<string>>(); //creates a multi dimentional array of all men and their prefrences on their counterparts
            string file_location = Application.StartupPath + "\\questions.accdb";//gets file path
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + file_location;
            string strSQL = "SELECT * FROM data WHERE [Question Type]='"+startmenu.question_type+"'";
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
                            data.Add(new List<string> { reader["Question"].ToString(),reader["Answer1"].ToString(), reader["Answer2"].ToString(), reader["Answer3"].ToString(),reader["Answer4"].ToString(),reader["Correct Answer"].ToString()});
                            //creates a user profile to be analysed by system
                        }
                        connection.Close();
                    }
                }
                catch (Exception)
                {
                }
                // The connection is automatically closed becasuse of using block.  

            }
            #endregion
            Random choose = new Random();//gets the random number generator ready
            int questionnum=choose.Next(0, data.Count);//selects the question to start on
            question.Text = "Question "+question_number+": "+data[questionnum][0];
            correct_answer = data[questionnum][5];
            max_points = data.Count;
            List<string> answers = new List<string> { data[questionnum][1], data[questionnum][2], data[questionnum][3], data[questionnum][4]};
            Answer1.Text = answers[choose.Next(0, answers.Count)];
            answers.Remove(Answer1.Text);
            Answer2.Text = answers[choose.Next(0, answers.Count)];
            answers.Remove(Answer2.Text);
            Answer3.Text = answers[choose.Next(0, answers.Count)];
            answers.Remove(Answer3.Text);
            Answer4.Text = answers[choose.Next(0, answers.Count)];
            answers.Remove(Answer4.Text);
            data.Remove(data[questionnum]);
        }

        private void Answer1_Click(object sender, EventArgs e)
        {
            if (is_correct(Answer1.Text, correct_answer) == true) 
            {
                points++;
                Sound_Play("right");
                score.Text = "Score: " + points;
                if (data.Count != 0)
                {
                    question_number++;
                    Random choose = new Random();
                    int questionnum = choose.Next(0, data.Count);
                    question.Text = "Question " + question_number + ": " + data[questionnum][0];
                    correct_answer = data[questionnum][5];
                    List<string> answers = new List<string> { data[questionnum][1], data[questionnum][2], data[questionnum][3], data[questionnum][4] };
                    Answer1.Text = answers[choose.Next(0, answers.Count)];
                    answers.Remove(Answer1.Text);
                    Answer2.Text = answers[choose.Next(0, answers.Count)];
                    answers.Remove(Answer2.Text);
                    Answer3.Text = answers[choose.Next(0, answers.Count)];
                    answers.Remove(Answer3.Text);
                    Answer4.Text = answers[choose.Next(0, answers.Count)];
                    answers.Remove(Answer4.Text);
                    data.Remove(data[questionnum]);
                }
                else
                {
                    game_complete(points);
                    MessageBox.Show("You win!\nScore:" + points+"/"+max_points,"Winner!");
                    Form start = new startmenu();
                    start.Show();
                    this.FormClosed -= new System.Windows.Forms.FormClosedEventHandler(this.quizgame_FormClosed);
                    this.Close();
                }
            }
            else 
            {
                lives.Text = lives.Text.Substring(0, lives.Text.Length-2);
                Sound_Play("wrong");
                if (lives.Text == "Lives:")
                {
                    game_complete(points);
                    MessageBox.Show("Game Over!\nFinal Score:" + points + "/" + max_points, "You lose");
                    Form start = new startmenu();
                    start.Show();
                    this.FormClosed -= new System.Windows.Forms.FormClosedEventHandler(this.quizgame_FormClosed);
                    this.Close();
                }
            }
        }

        private void Answer2_Click(object sender, EventArgs e)
        {
            if (is_correct(Answer2.Text, correct_answer) == true)
            {
                points++;
                Sound_Play("right");
                score.Text = "Score: " + points;
                if (data.Count != 0)
                {
                    question_number++;
                    Random choose = new Random();
                    int questionnum = choose.Next(0, data.Count);
                    question.Text = "Question " + question_number + ": " + data[questionnum][0];
                    correct_answer = data[questionnum][5];
                    List<string> answers = new List<string> { data[questionnum][1], data[questionnum][2], data[questionnum][3], data[questionnum][4] };
                    Answer1.Text = answers[choose.Next(0, answers.Count)];
                    answers.Remove(Answer1.Text);
                    Answer2.Text = answers[choose.Next(0, answers.Count)];
                    answers.Remove(Answer2.Text);
                    Answer3.Text = answers[choose.Next(0, answers.Count)];
                    answers.Remove(Answer3.Text);
                    Answer4.Text = answers[choose.Next(0, answers.Count)];
                    answers.Remove(Answer4.Text);
                    data.Remove(data[questionnum]);
                }
                else
                {
                    game_complete(points);
                    MessageBox.Show("You win!\nScore:" + points + "/" + max_points, "Winner!");
                    Form start = new startmenu();
                    start.Show();
                    this.FormClosed -= new System.Windows.Forms.FormClosedEventHandler(this.quizgame_FormClosed);
                    this.Close();
                }
            }
            else
            {
                lives.Text = lives.Text.Substring(0, lives.Text.Length - 2);
                Sound_Play("wrong");
                if (lives.Text == "Lives:")
                {
                    game_complete(points);
                    MessageBox.Show("Game Over!\nFinal Score:" + points + "/" + max_points, "You lose");
                    Form start = new startmenu();
                    start.Show();
                    this.FormClosed -= new System.Windows.Forms.FormClosedEventHandler(this.quizgame_FormClosed);
                    this.Close();
                }
            }
        }

        private void Answer3_Click(object sender, EventArgs e)
        {
            if (is_correct(Answer3.Text, correct_answer) == true)
            {
                points++;
                Sound_Play("right");
                score.Text = "Score: " + points;
                if (data.Count != 0)
                {
                    question_number++;
                    Random choose = new Random();
                    int questionnum = choose.Next(0, data.Count);
                    question.Text = "Question " + question_number + ": " + data[questionnum][0];
                    correct_answer = data[questionnum][5];
                    List<string> answers = new List<string> { data[questionnum][1], data[questionnum][2], data[questionnum][3], data[questionnum][4] };
                    Answer1.Text = answers[choose.Next(0, answers.Count)];
                    answers.Remove(Answer1.Text);
                    Answer2.Text = answers[choose.Next(0, answers.Count)];
                    answers.Remove(Answer2.Text);
                    Answer3.Text = answers[choose.Next(0, answers.Count)];
                    answers.Remove(Answer3.Text);
                    Answer4.Text = answers[choose.Next(0, answers.Count)];
                    answers.Remove(Answer4.Text);
                    data.Remove(data[questionnum]);
                }
                else
                {
                    game_complete(points);
                    MessageBox.Show("You win!\nScore:" + points + "/" + max_points, "Winner!");
                    Form start = new startmenu();
                    start.Show();
                    this.FormClosed -= new System.Windows.Forms.FormClosedEventHandler(this.quizgame_FormClosed);
                    this.Close();
                }
            }
            else
            {
                lives.Text = lives.Text.Substring(0, lives.Text.Length - 2);
                Sound_Play("wrong");
                if (lives.Text == "Lives:")
                {
                    game_complete(points);
                    MessageBox.Show("Game Over!\nFinal Score:" + points + "/" + max_points, "You lose");
                    Form start = new startmenu();
                    start.Show();
                    this.FormClosed -= new System.Windows.Forms.FormClosedEventHandler(this.quizgame_FormClosed);
                    this.Close();
                }
            }
        }

        private void Answer4_Click(object sender, EventArgs e)
        {
            if (is_correct(Answer4.Text, correct_answer) == true)
            {
                points++;
                Sound_Play("right");
                score.Text = "Score: " + points;
                if (data.Count != 0)
                {
                    question_number++;
                    Random choose = new Random();
                    int questionnum = choose.Next(0, data.Count);
                    question.Text = "Question " + question_number + ": " + data[questionnum][0];
                    correct_answer = data[questionnum][5];
                    List<string> answers = new List<string> { data[questionnum][1], data[questionnum][2], data[questionnum][3], data[questionnum][4] };
                    Answer1.Text = answers[choose.Next(0, answers.Count)];
                    answers.Remove(Answer1.Text);
                    Answer2.Text = answers[choose.Next(0, answers.Count)];
                    answers.Remove(Answer2.Text);
                    Answer3.Text = answers[choose.Next(0, answers.Count)];
                    answers.Remove(Answer3.Text);
                    Answer4.Text = answers[choose.Next(0, answers.Count)];
                    answers.Remove(Answer4.Text);
                    data.Remove(data[questionnum]);
                }
                else
                {
                    game_complete(points);
                    MessageBox.Show("You win!\nScore:" + points + "/" + max_points, "Winner!");
                    Form start = new startmenu();
                    start.Show();
                    this.FormClosed -= new System.Windows.Forms.FormClosedEventHandler(this.quizgame_FormClosed);
                    this.Close();
                }
            }
            else
            {
                lives.Text = lives.Text.Substring(0, lives.Text.Length - 2);
                Sound_Play("wrong");
                if (lives.Text == "Lives:")
                {
                    game_complete(points);
                    MessageBox.Show("Game Over!\nFinal Score:" + points+"/"+max_points, "You lose");
                    Form start = new startmenu();
                    start.Show();
                    this.FormClosed -= new System.Windows.Forms.FormClosedEventHandler(this.quizgame_FormClosed);
                    this.Close();
                }
            }
        }

        private void quizgame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void quizgame_FormClosing(object sender, FormClosingEventArgs e)
        {
            points = 0;
        }
    }
}

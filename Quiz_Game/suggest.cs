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
    public partial class suggest : Form
    {
        public suggest()
        {
            InitializeComponent();
            suggestleft_lbl.Text = "Suggestions left: " + suggestions_left;
        }
        public static int suggestions_left = 3;
        private void submit_btn_Click(object sender, EventArgs e)
        {
            if(subject_txt.Text!="" && question_txt.Text!="" && answer1_txt.Text!="" && answer2_txt.Text!="" && answer3_txt.Text!="" && answer4_txt.Text != "" && correactanswer_txt.Text!="")
            {
                if (suggestions_left != 0)
                {
                    string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath+"\\questions.accdb";
                    string sql = null;
                    using (OleDbConnection cnn = new OleDbConnection(connectionString))
                    {
                        sql = "insert into suggestions ([Question], [Answer1], [Answer2], [Answer3],[Answer4],[Correct Answer],[Question Type]) values(@first,@second,@third,@fourth,@fifth,@sixth,@seventh)";
                        cnn.Open();
                        using (OleDbCommand cmd = new OleDbCommand(sql, cnn))
                        {
                            cmd.Parameters.AddWithValue("@first", question_txt.Text);
                            cmd.Parameters.AddWithValue("@second", answer1_txt.Text);
                            cmd.Parameters.AddWithValue("@third", answer2_txt.Text);
                            cmd.Parameters.AddWithValue("@fourth", answer3_txt.Text);
                            cmd.Parameters.AddWithValue("@fifth", answer4_txt.Text);
                            cmd.Parameters.AddWithValue("@sixth",correactanswer_txt.Text);
                            cmd.Parameters.AddWithValue("@seventh", subject_txt.Text);
                            cmd.ExecuteNonQuery();
                            cnn.Close();
                        }
                    }
                    suggestions_left--;
                    suggestleft_lbl.Text = "Suggestions left: " + suggestions_left;
                    MessageBox.Show("Thank you for your suggestion!", "Message Sent");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("You have reached your suggestion limit, a limit is in place to stop spam", "No more suggestions allowed");
                }
            }
            else
            {
                MessageBox.Show("One or more fields are empty!","Empty Field");
            }
        }
    }
}

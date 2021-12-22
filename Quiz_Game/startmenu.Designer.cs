namespace Quiz_Game
{
    partial class startmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startmenu));
            this.topiclist = new System.Windows.Forms.ComboBox();
            this.title_lbl = new System.Windows.Forms.Label();
            this.startquiz_btn = new System.Windows.Forms.Button();
            this.leaderboard_btn = new System.Windows.Forms.Button();
            this.suggestions_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topiclist
            // 
            this.topiclist.FormattingEnabled = true;
            this.topiclist.Location = new System.Drawing.Point(124, 50);
            this.topiclist.Margin = new System.Windows.Forms.Padding(2);
            this.topiclist.Name = "topiclist";
            this.topiclist.Size = new System.Drawing.Size(224, 21);
            this.topiclist.TabIndex = 0;
            this.topiclist.Text = "Please select a topic";
            this.topiclist.SelectedIndexChanged += new System.EventHandler(this.topiclist_SelectedIndexChanged);
            this.topiclist.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.topiclist_KeyPress);
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.Location = new System.Drawing.Point(117, 7);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(245, 39);
            this.title_lbl.TabIndex = 1;
            this.title_lbl.Text = "QUIZ INSANITY!";
            // 
            // startquiz_btn
            // 
            this.startquiz_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.startquiz_btn.Enabled = false;
            this.startquiz_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startquiz_btn.ForeColor = System.Drawing.Color.Black;
            this.startquiz_btn.Location = new System.Drawing.Point(124, 84);
            this.startquiz_btn.Margin = new System.Windows.Forms.Padding(2);
            this.startquiz_btn.Name = "startquiz_btn";
            this.startquiz_btn.Size = new System.Drawing.Size(86, 46);
            this.startquiz_btn.TabIndex = 2;
            this.startquiz_btn.Text = "Start Quiz";
            this.startquiz_btn.UseVisualStyleBackColor = false;
            this.startquiz_btn.Visible = false;
            this.startquiz_btn.Click += new System.EventHandler(this.startquiz_btn_Click);
            // 
            // leaderboard_btn
            // 
            this.leaderboard_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.leaderboard_btn.Enabled = false;
            this.leaderboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leaderboard_btn.Location = new System.Drawing.Point(265, 84);
            this.leaderboard_btn.Margin = new System.Windows.Forms.Padding(2);
            this.leaderboard_btn.Name = "leaderboard_btn";
            this.leaderboard_btn.Size = new System.Drawing.Size(83, 46);
            this.leaderboard_btn.TabIndex = 3;
            this.leaderboard_btn.Text = "Leaderboard";
            this.leaderboard_btn.UseVisualStyleBackColor = false;
            this.leaderboard_btn.Visible = false;
            this.leaderboard_btn.Click += new System.EventHandler(this.leaderboard_btn_Click);
            // 
            // suggestions_btn
            // 
            this.suggestions_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.suggestions_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suggestions_btn.Location = new System.Drawing.Point(318, 171);
            this.suggestions_btn.Margin = new System.Windows.Forms.Padding(2);
            this.suggestions_btn.Name = "suggestions_btn";
            this.suggestions_btn.Size = new System.Drawing.Size(169, 83);
            this.suggestions_btn.TabIndex = 4;
            this.suggestions_btn.Text = "Suggest a question";
            this.suggestions_btn.UseVisualStyleBackColor = false;
            this.suggestions_btn.Click += new System.EventHandler(this.suggestions_btn_Click);
            // 
            // startmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(488, 255);
            this.Controls.Add(this.suggestions_btn);
            this.Controls.Add(this.leaderboard_btn);
            this.Controls.Add(this.startquiz_btn);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.topiclist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "startmenu";
            this.Text = "Quiz Insanity";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.startmenu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox topiclist;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Button startquiz_btn;
        private System.Windows.Forms.Button leaderboard_btn;
        private System.Windows.Forms.Button suggestions_btn;
    }
}
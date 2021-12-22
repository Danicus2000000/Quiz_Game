namespace Quiz_Game
{
    partial class quizgame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quizgame));
            this.question = new System.Windows.Forms.Label();
            this.Answer1 = new System.Windows.Forms.Button();
            this.Answer2 = new System.Windows.Forms.Button();
            this.Answer3 = new System.Windows.Forms.Button();
            this.Answer4 = new System.Windows.Forms.Button();
            this.score = new System.Windows.Forms.Label();
            this.lives = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.question.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.question.Location = new System.Drawing.Point(9, 9);
            this.question.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(130, 32);
            this.question.TabIndex = 0;
            this.question.Text = "Question";
            this.question.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Answer1
            // 
            this.Answer1.Location = new System.Drawing.Point(16, 325);
            this.Answer1.Margin = new System.Windows.Forms.Padding(4);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(131, 106);
            this.Answer1.TabIndex = 1;
            this.Answer1.Text = "Answer1";
            this.Answer1.UseVisualStyleBackColor = true;
            this.Answer1.Click += new System.EventHandler(this.Answer1_Click);
            // 
            // Answer2
            // 
            this.Answer2.Location = new System.Drawing.Point(282, 325);
            this.Answer2.Margin = new System.Windows.Forms.Padding(4);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(131, 106);
            this.Answer2.TabIndex = 2;
            this.Answer2.Text = "Answer2";
            this.Answer2.UseVisualStyleBackColor = true;
            this.Answer2.Click += new System.EventHandler(this.Answer2_Click);
            // 
            // Answer3
            // 
            this.Answer3.Location = new System.Drawing.Point(544, 325);
            this.Answer3.Margin = new System.Windows.Forms.Padding(4);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(131, 106);
            this.Answer3.TabIndex = 3;
            this.Answer3.Text = "Answer3";
            this.Answer3.UseVisualStyleBackColor = true;
            this.Answer3.Click += new System.EventHandler(this.Answer3_Click);
            // 
            // Answer4
            // 
            this.Answer4.Location = new System.Drawing.Point(804, 325);
            this.Answer4.Margin = new System.Windows.Forms.Padding(4);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(131, 106);
            this.Answer4.TabIndex = 4;
            this.Answer4.Text = "Answer4";
            this.Answer4.UseVisualStyleBackColor = true;
            this.Answer4.Click += new System.EventHandler(this.Answer4_Click);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.score.Location = new System.Drawing.Point(8, 459);
            this.score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(143, 39);
            this.score.TabIndex = 5;
            this.score.Text = "Score: 0";
            // 
            // lives
            // 
            this.lives.AutoSize = true;
            this.lives.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lives.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lives.Location = new System.Drawing.Point(372, 435);
            this.lives.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lives.Name = "lives";
            this.lives.Size = new System.Drawing.Size(220, 39);
            this.lives.TabIndex = 6;
            this.lives.Text = "Lives:❤️❤️❤️";
            // 
            // quizgame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(948, 511);
            this.Controls.Add(this.lives);
            this.Controls.Add(this.score);
            this.Controls.Add(this.Answer4);
            this.Controls.Add(this.Answer3);
            this.Controls.Add(this.Answer2);
            this.Controls.Add(this.Answer1);
            this.Controls.Add(this.question);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "quizgame";
            this.Text = "Quiz insanity";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.quizgame_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.quizgame_FormClosed);
            this.Load += new System.EventHandler(this.quizgame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Button Answer1;
        private System.Windows.Forms.Button Answer2;
        private System.Windows.Forms.Button Answer3;
        private System.Windows.Forms.Button Answer4;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label lives;
    }
}


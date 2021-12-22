namespace Quiz_Game
{
    partial class suggest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(suggest));
            this.title_lbl = new System.Windows.Forms.Label();
            this.descriptions_lbl = new System.Windows.Forms.Label();
            this.subject_txt = new System.Windows.Forms.TextBox();
            this.question_txt = new System.Windows.Forms.TextBox();
            this.answer1_txt = new System.Windows.Forms.TextBox();
            this.answer2_txt = new System.Windows.Forms.TextBox();
            this.answer3_txt = new System.Windows.Forms.TextBox();
            this.answer4_txt = new System.Windows.Forms.TextBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.suggestleft_lbl = new System.Windows.Forms.Label();
            this.correactanswer_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.Location = new System.Drawing.Point(72, 7);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(279, 36);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "Suggest a question:";
            // 
            // descriptions_lbl
            // 
            this.descriptions_lbl.AutoSize = true;
            this.descriptions_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptions_lbl.Location = new System.Drawing.Point(1, 61);
            this.descriptions_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptions_lbl.Name = "descriptions_lbl";
            this.descriptions_lbl.Size = new System.Drawing.Size(145, 312);
            this.descriptions_lbl.TabIndex = 1;
            this.descriptions_lbl.Text = "  Subject:\r\n\r\nQuestion:\r\n\r\nAnswer 1:\r\n\r\nAnswer 2:\r\n\r\nAnswer 3:\r\n\r\nAnswer 4:\r\n\r\nCo" +
    "rrect Answer:";
            this.descriptions_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // subject_txt
            // 
            this.subject_txt.Location = new System.Drawing.Point(122, 72);
            this.subject_txt.Name = "subject_txt";
            this.subject_txt.Size = new System.Drawing.Size(304, 20);
            this.subject_txt.TabIndex = 0;
            // 
            // question_txt
            // 
            this.question_txt.Location = new System.Drawing.Point(122, 363);
            this.question_txt.Name = "question_txt";
            this.question_txt.Size = new System.Drawing.Size(304, 20);
            this.question_txt.TabIndex = 6;
            // 
            // answer1_txt
            // 
            this.answer1_txt.Location = new System.Drawing.Point(122, 129);
            this.answer1_txt.Name = "answer1_txt";
            this.answer1_txt.Size = new System.Drawing.Size(304, 20);
            this.answer1_txt.TabIndex = 1;
            // 
            // answer2_txt
            // 
            this.answer2_txt.Location = new System.Drawing.Point(122, 185);
            this.answer2_txt.Name = "answer2_txt";
            this.answer2_txt.Size = new System.Drawing.Size(304, 20);
            this.answer2_txt.TabIndex = 3;
            // 
            // answer3_txt
            // 
            this.answer3_txt.Location = new System.Drawing.Point(122, 248);
            this.answer3_txt.Name = "answer3_txt";
            this.answer3_txt.Size = new System.Drawing.Size(304, 20);
            this.answer3_txt.TabIndex = 4;
            // 
            // answer4_txt
            // 
            this.answer4_txt.Location = new System.Drawing.Point(122, 307);
            this.answer4_txt.Name = "answer4_txt";
            this.answer4_txt.Size = new System.Drawing.Size(304, 20);
            this.answer4_txt.TabIndex = 5;
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(122, 457);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(97, 51);
            this.submit_btn.TabIndex = 8;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // suggestleft_lbl
            // 
            this.suggestleft_lbl.AutoSize = true;
            this.suggestleft_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suggestleft_lbl.Location = new System.Drawing.Point(225, 457);
            this.suggestleft_lbl.Name = "suggestleft_lbl";
            this.suggestleft_lbl.Size = new System.Drawing.Size(182, 20);
            this.suggestleft_lbl.TabIndex = 9;
            this.suggestleft_lbl.Text = "Suggestions Remaining:";
            // 
            // correactanswer_txt
            // 
            this.correactanswer_txt.Location = new System.Drawing.Point(185, 418);
            this.correactanswer_txt.Name = "correactanswer_txt";
            this.correactanswer_txt.Size = new System.Drawing.Size(258, 20);
            this.correactanswer_txt.TabIndex = 7;
            // 
            // suggest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(455, 587);
            this.Controls.Add(this.correactanswer_txt);
            this.Controls.Add(this.suggestleft_lbl);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.answer4_txt);
            this.Controls.Add(this.answer3_txt);
            this.Controls.Add(this.answer2_txt);
            this.Controls.Add(this.answer1_txt);
            this.Controls.Add(this.question_txt);
            this.Controls.Add(this.subject_txt);
            this.Controls.Add(this.descriptions_lbl);
            this.Controls.Add(this.title_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(471, 626);
            this.Name = "suggest";
            this.Text = "Suggestion Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Label descriptions_lbl;
        private System.Windows.Forms.TextBox subject_txt;
        private System.Windows.Forms.TextBox question_txt;
        private System.Windows.Forms.TextBox answer1_txt;
        private System.Windows.Forms.TextBox answer2_txt;
        private System.Windows.Forms.TextBox answer3_txt;
        private System.Windows.Forms.TextBox answer4_txt;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Label suggestleft_lbl;
        private System.Windows.Forms.TextBox correactanswer_txt;
    }
}
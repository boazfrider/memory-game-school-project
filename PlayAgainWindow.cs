using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class PlayAgainWindow : WindowMessage
    {
        private System.Windows.Forms.Label ScoreMsg;
        private System.Windows.Forms.Button againBtn;
        private System.Windows.Forms.Button scoreBtn;
        private System.Windows.Forms.Button mainBtn;
        MainGame f;
        startWindow g;

        public PlayAgainWindow(string s, MainGame f):base()
        {
            this.ScoreMsg = new System.Windows.Forms.Label();
            this.againBtn = new System.Windows.Forms.Button();
            this.scoreBtn = new System.Windows.Forms.Button();
            this.mainBtn=new  System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScoreMsg
            // 
            this.ScoreMsg.AutoSize = true;
            this.ScoreMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ScoreMsg.Location = new System.Drawing.Point(34, 18);
            this.ScoreMsg.Name = "ScoreMsg";
            this.ScoreMsg.Size = new System.Drawing.Size(57, 20);
            this.ScoreMsg.TabIndex = 0;
            this.ScoreMsg.Text = "label1";
            this.ScoreMsg.Click += new System.EventHandler(this.ScoreMsg_Click);
            // 
            // againBtn
            // 
            this.againBtn.Location = new System.Drawing.Point(29, 55);
            this.againBtn.Name = "againBtn";
            this.againBtn.Size = new System.Drawing.Size(93, 36);
            this.againBtn.TabIndex = 1;
            this.againBtn.Text = "Play again";
            this.againBtn.UseVisualStyleBackColor = true;
            this.againBtn.Click += new System.EventHandler(this.againBtn_Click);
            // 
            // scoreBtn
            // 
            this.scoreBtn.Location = new System.Drawing.Point(163, 55);
            this.scoreBtn.Name = "scoreBtn";
            this.scoreBtn.Size = new System.Drawing.Size(87, 36);
            this.scoreBtn.TabIndex = 2;
            this.scoreBtn.Text = "Table score";
            this.scoreBtn.UseVisualStyleBackColor = true;
            this.scoreBtn.Click += new System.EventHandler(this.scoreBtn_Click);
            againBtn.Click += new EventHandler(f.startbtn_Click);
            this.f = f;

            ///mainBtn
           this.mainBtn.Location = new System.Drawing.Point(270, 55);
            this.mainBtn.Name = "mainBtn";
            this.mainBtn.Size = new System.Drawing.Size(81, 36);
            this.mainBtn.TabIndex = 1;
            this.mainBtn.Text = "Main menu";
            this.mainBtn.UseVisualStyleBackColor = true;
            this.mainBtn.Click += new System.EventHandler(this.mainBtn_Click);

            ScoreMsg.Text = s;
            base.Controls.Add(againBtn);
            base.Controls.Add(scoreBtn);
            base.Controls.Add(ScoreMsg);
            base.Controls.Add(mainBtn);
        }
      

        private void PlayAgainWindow_Load(object sender, EventArgs e)
        {

        }
        private void againBtn_Click(object sender, EventArgs e)
        {
            f.reset();
        }

        private void ScoreMsg_Click(object sender, EventArgs e)
        {

        }

        private void scoreBtn_Click(object sender, EventArgs e)
        {

            TableScore S = new TableScore();
            S.ReadScore();
            S.Show();


        }
        private void mainBtn_Click(object sender, EventArgs e)
        {
            this.g = new startWindow();
            this.f.Close();
            g.Show();
           


        }

        private void playAgain_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // PlayAgainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(386, 112);
            this.Name = "PlayAgainWindow";
            this.Load += new System.EventHandler(this.PlayAgainWindow_Load_1);
            this.ResumeLayout(false);

        }

        private void PlayAgainWindow_Load_1(object sender, EventArgs e)
        {

        }
       
    }
}

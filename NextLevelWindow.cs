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
   public class NextLevelWindow:WindowMessage
    {
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Label msglabel;
        string level;
        MainGame f;


        public NextLevelWindow(string level,MainGame f)
            : base()//פעולה שבונה את כל תכונות החלון
        {
            this.nextBtn = new System.Windows.Forms.Button();
            this.msglabel = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.nextBtn.Location = new System.Drawing.Point(93, 55);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 0;
            this.nextBtn.Text = "Next level";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // msglabel
            // 
            this.msglabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.msglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.msglabel.ForeColor = System.Drawing.Color.Black;
            this.msglabel.Location = new System.Drawing.Point(51, 9);
            this.msglabel.Name = "msglabel";
            this.msglabel.Size = new System.Drawing.Size(159, 34);
            this.msglabel.TabIndex = 1;
            this.msglabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.msglabel.Click += new System.EventHandler(this.msglabel_Click);

            base.Controls.Add(msglabel);
            base.Controls.Add(nextBtn);
            this.level = level;
            this.f = f;

            msglabel.Text = level;
            nextBtn.Click += new EventHandler(f.startbtn_Click);


        }

        private void nextBtn_Click(object sender, EventArgs e)
        {

        }
        private void msglabel_Click(object sender, EventArgs e)
        {

        }

       //הגדרות עיצוב ראשוניות של החלון
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // NextLevelWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(278, 90);
            this.Name = "NextLevelWindow";
            this.Load += new System.EventHandler(this.NextLevelWindow_Load);
            this.ResumeLayout(false);

        }

        private void NextLevelWindow_Load(object sender, EventArgs e)
        {

        }
    }
}

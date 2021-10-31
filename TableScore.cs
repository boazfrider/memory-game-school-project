using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class TableScore : Form
    {
        List<ReadTableScore> lst;

        public TableScore()
        {
            InitializeComponent();
            lst = new List<ReadTableScore>();
        }

        public Label getlabel(string value)
        {
            Label label1 = new Label();
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(26, 5);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(35, 13);
            label1.TabIndex = 0;
            label1.Text = value;
            return label1;
        }
        public void ReadScore()
        {
            StreamReader s = new StreamReader("TableScore", true);
            List<ReadTableScore> lst = new List<ReadTableScore>();
            while (s.EndOfStream == false)
            {
                string l = s.ReadLine();
                int score = int.Parse(s.ReadLine());
                ReadTableScore read = new ReadTableScore(l, score);
                lst.Add(read);


            }
            s.Close();

            ReadTableScore[] arr = lst.ToArray();
            ReadTableScore temp;

            //סידור של הניקוד מהגבוה לנמוך במערך
            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = 0; k < arr.Length; k++)
                {
                    if (arr[i].GetScore() > arr[k].GetScore())
                    {
                        temp = arr[k];
                        arr[k] = arr[i];
                        arr[i] = temp;

                    }



                }

            }

            //הורשה

            //הצגת שם והניקוד
            for (int i = 0; i < 10 && i < arr.Length; i++)
            {

                tableLayoutPanel1.Controls.Add(getlabel((arr[i].GetName()).ToString()));



                tableLayoutPanel1.Controls.Add(getlabel((arr[i].GetScore()).ToString()));
            }
        }

        private void TableScore_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}

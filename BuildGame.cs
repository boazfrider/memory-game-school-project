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
    class BuildGame
    {
        int row, column;// variables that representing our coordinates board.
        PictureBox[,] array;// our board.
        MainGame a;

        public BuildGame(int row, int column,MainGame a)
        {
            this.row = row;
            this.column = column;
            this.a = a;
        }

        //placing the cards and placing the background.
        //Constructor to build our 2d array by row number and col.
        public  PictureBox[,] BuildBoard()
        {
            this.array = new PictureBox[row, column];

            for (int i = 0; i < row; ++i)
            {
                for (int j = 0; j < column; j++)
                {
                    array[i, j] = new PictureBox();
                    array[i, j].Location = new System.Drawing.Point((25 + (75 * i)), ((75 * j) + 25));
                    array[i, j].Size = new System.Drawing.Size(40, 40);
                    array[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    string str = Directory.GetCurrentDirectory() + @"\picture\btn.jpg";
                    array[i, j].BackgroundImage = Image.FromFile(str);
                    array[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                    array[i, j].Click += new System.EventHandler(a.ClickImage);
                    a.Controls.Add(array[i, j]);
                }
            }
            return array;
        }

        public PictureBox[,] GameArray
        {
            get
            {
                return array;
            }
        }
        public int getarraylength()
        {
            return array.Length;
        }
    }
}

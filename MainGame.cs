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
    public partial class MainGame : Form
    {
        string namePlayer;//name of player.
        bool t = true;
        BuildGame b;//עצם של בונה
        int level = 0;
 int ClickCount = 0;//מספר לחיצות על הלוח
 int point ;//צובר את הניקוד
 NextLevelWindow f=null;
 PlayAgainWindow g = null;
        List<int> row, column;//משתני עזר
        Stack<string> SamePicClicked;//משתנה עזר

 
       
          
        public MainGame(string name)
        {
            InitializeComponent();
           point=0;//צובר את הניקוד
           SamePicClicked = new Stack<string>();
           SamePicClicked.Push("null");
           namePlayer = name;
        }
        public void ClickImage(object sender, EventArgs e)
        {
            PictureBox pic =(PictureBox)sender;

            SamePicClicked.Push(pic.Name);
           
             ClickCount++;
             pic.ImageLocation = pic.Name;
             pic.Enabled = false;
             string s1 = SamePicClicked.Pop();//מוציא את השם הנוכחי של התמונה שנלחצה הרגע
             string s2 = SamePicClicked.Pop();//מוציא את השם של התמונה שנלחצה לאחרונה
             if (s1== s2)//אם השם הנוכחי של התמונה שווה לשם הקודם ניקוד כפול
             {
                 point = point + 100;

             }
            point = point + 50;
            PointLabel.Text = (Convert.ToString(point));
            SamePicClicked.Push(s2);
            SamePicClicked.Push(s1);
           

            //אם נלחץ על פצצה
            if (pic.Name == Directory.GetCurrentDirectory() + @"\picture\0.jpg")
            {
                //הצגת חלון ניקוד
                g = new PlayAgainWindow(string.Format("game over, your score is:{0}",point),this);
                //שמירה השם והניקוד 
                saveScore(point, namePlayer);
                 g.ShowDialog();
                
                
            }

            //בדיקה האם כל התמונות שהם לא פצצות נפתחו
            if (b.getarraylength()-ClickCount==level)
            {
                f = new NextLevelWindow(string.Format("level {0} complete", level), this);
                
                f.ShowDialog();
              
              
                ClickCount = 0;//איפוס של התמונות שנלחצו לאפס
            }

            //החזרה לפי הסדר למחסנית
            SamePicClicked.Push(s2);
            SamePicClicked.Push(s1);
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startbtn.Hide();

         
            
            Random picNum = new Random();//עצם שישמש להגרת הכתובות מתוך המערך מחרוזות 
            Random PlaceINArray = new Random();// עצם שתגריל מספר שמייצג קובייה במערך הדו מימדי
            string[] url = new string[5];

            //הכנסה של הכתובות של התמונות למערך המחרוזת
            for (int i = 0; i < url.Length; i++)
            {
                url[i] = Directory.GetCurrentDirectory() + @"\picture\" + i + ".jpg";
            }

            //פתיחה של הקלפים וסגירה  
            #region קטע שמטפל בהגרלה של התמונות והפצצה

            

            if (t == true)
            {
                //הצבה של תמונות רגילות על כל הלוח
                for (int i = 0; i < b.GameArray.GetLength(0); ++i)//שורה
                {
                    for (int j = 0; j < b.GameArray.GetLength(1); ++j)//עמודה
                    {

                        b.GameArray[i, j].Name = url[picNum.Next(1, url.Length)];
                      
                        b.GameArray[i, j].ImageLocation = b.GameArray[i, j].Name;
                        b.GameArray[i, j].Enabled = false;

                    }
                }
                int BombPlaceColumn;//משתנה שייצג את מספר העמודה שבה נציב את הפצצה
                int BombPlaceRow;

                row = new List<int>();
                column = new List<int>();
                bool existalredy;//משתנה שיגיד לנו למקרה שנציב יותר מפצצה אחת באותו המקום
                for (int a = 0; a <= level - 1;a++)
                    {
                        BombPlaceColumn = PlaceINArray.Next(b.GameArray.GetLength(0) - 1);//משתנה שייצג את מספר העמודה שבה נציב את הפצצה
                        BombPlaceRow = PlaceINArray.Next(b.GameArray.GetLength(1) - 1);
                        existalredy = false;//הנחה שלא קיים

                    //לולאה שתבדוק אם כבר היה את המיקומים
                    //הוא ישווה את מערכי המיקומים של Xו Y
                        for (int k = 0; k < row.Count; k++)
                        {
                            if (row[k] == BombPlaceRow && column[k] == BombPlaceColumn)
                            {
                                existalredy = true;
                                break;
                            }

                        }

                        if (existalredy == true)
                        {
                           a--; //יבצע שוב את הלולאה
                        }
                        else
                        {
                            column.Add(BombPlaceColumn);//הוספת המיקום 
                            row.Add(BombPlaceRow);//הוספת המיקום

                            //הוספת הפצצה למיקום הרנדומלי שנבחר
                            b.GameArray[BombPlaceColumn, BombPlaceRow].Name = Directory.GetCurrentDirectory() + @"\picture\0.jpg";
                            b.GameArray[BombPlaceColumn, BombPlaceRow].ImageLocation = b.GameArray[BombPlaceColumn, BombPlaceRow].Name;
                        }
                    }



               

                t = false;
            }

            else
            {
                for (int i = 0; i < b.GameArray.GetLength(0); ++i)
                {
                    for (int j = 0; j < b.GameArray.GetLength(1); ++j)
                    {
                        b.GameArray[i, j].ImageLocation = "";
                        b.GameArray[i, j].Enabled = true;

                    }
                }
                timer1.Stop();
                t = true;
               //שינוי לאמת כדי שיהיה אפשר שוב ללחוץ על אמת

            #endregion



            } 
           
        }
        
            int x=0, y=0;
        public void startbtn_Click(object sender, EventArgs e)
        {
          
            if (f != null)
            {
                f.Close();
               
                
                f = null;
               
            }
            if (g != null)
            {
                g.Close();
                g = null;
            }
            Controls.Clear();
            
            InitializeComponent();
            PointLabel.Text = point.ToString();
            //בנייה של הלוח(ריבוע-מלבן-ריבוע-מלבן(
            if (x == y)
            {
                x++;
            }
            else
            {
                y++;
            }
            //בנייה של הלוח לפי איקס ו Y
            b = new BuildGame(2 + x, 2 + y,this);
            b.BuildBoard(); //תפעיל פעולה 
            //הצגה של השלב ב label
            levelShow.Text = (level+1).ToString();
            level++;
            timer1_Tick(null, null);
            timer1.Start();
              
        }

        private void MainGame_Load(object sender, EventArgs e)
        {

        }

        private void PointLabel_Click(object sender, EventArgs e)
        {

        }

        public void reset()
        {
            this.x = 0;
            this.y = 0;
            this.t = true;
            //  PictureBox[,] array ,array2;
          
          this.level = 0;
           this.ClickCount = 0;
           this.point=0;//צובר את הניקוד
           this. f = null;
      
        }
        public void saveScore(int point,string name)
        {
            StreamWriter ScoreWrtie;
            if (File.Exists("TableScore") == false)
            {
                ScoreWrtie = new StreamWriter("TableScore");
            }
            else
            {
                ScoreWrtie = new StreamWriter("TableScore", true);
            }
            ScoreWrtie.WriteLine( name);
             ScoreWrtie.WriteLine(point);
            ScoreWrtie.Close();
        }

        public void levelShow_Click(object sender, EventArgs e)
        {
            levelShow.Text = level.ToString();
        }


       
        

       
    }
}

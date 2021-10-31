using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
  public class ReadTableScore
    {
       
        string name;//
        int score;//
        public ReadTableScore(string name, int score)
        {
            this.name = name;
            this.score = score;
        }
        public string GetName()
        {
            return name;
        }
        public int GetScore()
        {
            return score;
        }





    }
}

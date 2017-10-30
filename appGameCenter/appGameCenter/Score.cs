using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appGameCenter
{
    public class Score
    {
        private string nickname;

        public string Nickname
        {
            get { return nickname; }            
        }
        private int points;

        public int Points
        {
            get { return points; }
            set { points = value; }
        }
       
        public Score(string nickname, int points)
        {
            this.nickname = nickname;
            this.points = points;
        }
        
        public Score(string nickname, string email, Countries country, int points)
        {
            this.points = points;
        }

        public Score() : base()
        {

        }

        public Score(Player player1, int points)
        {

            this.points = points;
        }
        public override string ToString()
        {
            string resp = "";
            resp = string.Format("{0}-{1}", this.Nickname, this.Points);
            return resp;
        }
    }
}

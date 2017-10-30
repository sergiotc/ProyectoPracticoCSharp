using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appGameCenter
{
    public class Ranking
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
    private  List<Score> scores;
    public List<Score> Scores
    {
        get { return scores; }
        set { scores = value; }
    }
    
    
     public Ranking(string name, List<Score> scores)
        {
            this.name = name;
            this.scores = scores;
        }
     public Ranking()
        {
            this.name = "";
            this.scores = null;
        }

     public override string ToString()
        {
            string res = "";
            res = string.Format("Ranking:{0}\n", this.Name);
            for (int e = 0; e < Scores.Count; i++)
            {
                res += string.Format("{0}.{1}\n", Scores[e].ToString());
            }
            return res;
        }
}

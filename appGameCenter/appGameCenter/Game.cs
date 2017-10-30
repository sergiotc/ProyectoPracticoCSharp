using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appGameCenter
{
    public class Game
    {
        private string name;

        public string Name
        {
            get { return name; }
            
        }
        private Genres genre;

        public Genres Genre
        {
            get { return genre; }
            
        }
        private List<Platforms> platforms;

        public List<Platforms> Platforms
        {
            get { return platforms; }
            
        }
        private int releasedate;

        public int Releasedate
        {
            get { return releasedate; }
            
        }
        private Dictionary<Platforms, Ranking> rankings;

        public Dictionary<Platforms, Ranking> Rankings
        {
            get { return rankings; }

           
        }
        public Game (string name, Genres genre, List<Platforms> platforms, int releasedate, Dictionary<Platforms> rankings)
        {
            this.name = name;
            this.genre = genre;
            this.platforms = platforms;
            if (releasedate >= 1980 && releasedate <= 2018)
            {
                this.releasedate = releasedate;
            }
            this.rankings = rankings;
        }
        


        public override bool Equals(object obj)
        {
            bool f = false;
            if (obj is Game )
            {
                Game aux = (Game)obj;
               f = genre.name == this.Name;
            }
            return f;
            
        }
        public override string ToString()
        {
             string s = "";
            s = string.Format("---{0}({1}-)", this.Name, this.ReleaseDate);
            foreach (Platforms plataform in this.Platforms)
            {
                s += string.Format("{0},", plataform);
            }
            s += string.Format("-{0}---", this.Genre);
            foreach (Platforms ranking in this.Rankings.Keys)
            {
                s += string.Format("-{0}({1})", this.Rankings[ranking].Name, this.Rankings[ranking].Scores.Count);
            }
            return s;
        }
    }
}

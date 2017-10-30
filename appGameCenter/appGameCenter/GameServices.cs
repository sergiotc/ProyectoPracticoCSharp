﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appGameCenter
{
    public static class GameServices
    {   
        private static string PATH = "../../data.txt";

        private static List<Player> players = new List<Player>();
        public static List<Player> Players
        {
            get { return GameServices.players; }
        }

        private static List<Game> games = new List<Game>();
        public static List<Game> Games
        {
            get { return GameServices.games; }
        }

        public static void Export()
        {
            string playerData = ConvertPlayerToString();
            string gameData = ConvertGameToString();
            string rankingData = ConvertRankingToString();
            try
            {
                StreamWriter file = File.CreateText(PATH);
                string allData = playerData + "\n*+*+*+*\n" + gameData + "\n*+*+*+*\n" + rankingData;
                file.Write(allData);
                file.Close();
                Console.WriteLine("Datos creados en Data.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al crear Data.txt" + e);
            }

        }

        private static string ConvertPlayerToString()
        {
            string s = "";
            foreach (Player player in Players)
            {
                s += string.Format("{0}\n", player.ToString());
            }
            return s;
        }

        private static string ConvertGameToString()
        {
            string s = "";
            foreach (Game game in Games)
            {
                s += string.Format("{0}-{1}-{2}", game.Name, game.Genre, game.ReleaseDate);
                foreach (Platforms platform in game.Platforms)
                {
                    s += string.Format("{0},", platform);
                }
            }
            s += "\n";
            return s;
        }
        private static string ConvertRankingToString()
        {
            string s = "";
            foreach (Game game in Games)
            {
                foreach (Platforms ranking in game.Rankings.Keys)
                {
                    s += string.Format("{0}-{1}", game.Name, game.Rankings[ranking].Name);
                    foreach (Score score in game.Rankings[ranking].Scores)
                    {
                        s += string.Format("{0}-{1}", score.Nickname, score.Points);
                    }
                    s += "\n";
                }
            }
            return s;
        }
        public static void Import()
        {
            List<string> lines = ReadFile(PATH);
            List<string> playerLines = new List<string>();
            List<string> gameLines = new List<string>();
            List<string> rankingLines = new List<string>();

            bool isGame = false;
            bool isPlayer = false;
            bool isRanking = false;

            foreach (string line in lines)
            {
                if (line == "*+*+*+*")
                {
                    isGame = true;
                }
                else
                {
                    if (!isPlayer)
                    {
                        playerLines.Add(line);
                    }
                    else
                    {
                        gameLines.Add(line);
                    }
                }
            }
            games = new List<Game>();
            players = new List<Player>();
            foreach (string line in playerLines)
            {
                Players s = new Player(line);
                players.Add(s);
            }
            foreach (string line in gameLines)
            {
                Games l = new Game(line);
                games.Add(l);
            }


        }

 

      
        public static Game OldestGame()
        {
            Game OldestGame = null;
            int year = int.MaxValue;
            foreach (Game game in Games)
            {
                int y = game.ReleaseDate;
                if (year > y)
                {
                    OldestGame = game;
                    year = y;
                }
            }
            return OldestGame;
        }
       

        public static string ScoreCount(string (Game) Name, List<Ranking> scores)
        {
            return;
        }

    
        public static int gamesCountByGenre(Genres genre, string genrename)
        {
            Genres genres = GetGenreByName(genrename);
            int count = 0;
            foreach (Game game in Games)
            {
                if (game.Genre == genre)
                {
                    count++;
                }
            }
            return count;
        }
        



     



    }
}

﻿using LeagueScores.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueScores.Service
{
    public class FileService : IFileService
    {
        public Dictionary<string, int> ReadFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            string line;
            Dictionary<string,int> Log = new Dictionary<string,int>();
            while ((line = sr.ReadLine()) != null)
            {
                string[] row = row = line.Split(',');
                var teamAndScore1 = row[0].ToCharArray();
                var teamAndScore2 = row[1].ToCharArray();
                string score1 ="";
                string score2 = "";
                string team1 = row[0];
                string team2 = row[1];
                int numericValue; 
                for(var i = teamAndScore1.Length-1; i > 0; i--)
                {
                    Console.WriteLine(teamAndScore1[i]);
                    Console.WriteLine("index "+ i);
                    if (teamAndScore1[i] ==' ') {
                        break;
                    }
                    score1 +=teamAndScore1[i];
                }

                for (var i = teamAndScore2.Length - 1; i > 0; i--)
                {
                    Console.WriteLine(teamAndScore2[i]);
                    Console.WriteLine("index " + i);
                    if (teamAndScore2[i] == ' ')
                    {
                        break;
                    }
                    score2 += teamAndScore2[i];
                }

                int score1Index = row[0].IndexOf(score1);
                int score2Index = row[1].IndexOf(score2);
                team1 = row[0].Remove(score1Index);
                team2 = row[1].Remove(score2Index);

                if (int.Parse(score1) > int.Parse(score2))
                {
                    //TEAM A WIN
                    if (Log.ContainsKey(team1))
                    {
                        //update value
                        Log[team1] += 3;

                    }
                    else
                    {
                        Log.Add(team1, 3);

                    }
                }
                else if (int.Parse(score1) == int.Parse(score2))
                {
                    //TEAM A
                    if (Log.ContainsKey(team1))
                    {
                        //update value
                        Log[team1] += 1;

                    }
                    else {
                        Log.Add(team1, 1);

                    }

                    //TEAM B
                    if (Log.ContainsKey(team2))
                    {
                        //update value
                        Log[team2] += 1;

                    } else
                    {
                        //add team
                        Log.Add(team2, 1);
                    }
                }
                else if (int.Parse(score2) > int.Parse(score1))
                {
                    //TEAM A WIN
                    if (Log.ContainsKey(team2))
                    {
                        //update value
                        Log[team2] += 3;

                    }
                    else
                    {
                        Log.Add(team2, 3);

                    }
                }

            
                    
            }
            var sortedLog = Log.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value); ;

            return sortedLog;
        }

        void IFileService.WriteFile(Dictionary<string, int> log)
        {
            throw new NotImplementedException();
        }


    }
}

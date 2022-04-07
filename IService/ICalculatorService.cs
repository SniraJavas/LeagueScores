using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueScores.IService
{
    public interface ICalculatorService
    {
        Dictionary<string, int> CalculateScores(string fileContent);
        void OrderByPoints(Dictionary<string,int> Scores);
    }
}

using LeagueScores.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueScores.Service
{
    internal class CalculatorService : ICalculatorService
    {
        Dictionary<string, int> ICalculatorService.CalculateScores(string fileContent)
        {
            throw new NotImplementedException();
        }

        void ICalculatorService.OrderByPoints(Dictionary<string, int> Scores)
        {
            throw new NotImplementedException();
        }
    }
}

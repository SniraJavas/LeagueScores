using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueScores.IService
{
    public interface IFileService
    {
        public Dictionary<string, int> ReadFile(string path);
        public void WriteFile(Dictionary<string, int> Log);
    }
}

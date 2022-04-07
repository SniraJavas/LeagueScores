// See https://aka.ms/new-console-template for more information
using LeagueScores.Helper;
using LeagueScores.Service;
using System.Reflection;

public class Program{

   public void Run()
    {
        FileService fileService = new FileService();
        Helper helper = new Helper();
        Console.Write("Please enter the file Path : ");
        string path = Console.ReadLine();
        if (path != "")
        {
            Dictionary<string, int> data = fileService.ReadScoreFile(path);
            var ordereResults = helper.OrderByPointsAndNamesDesc(data);
            fileService.WriteScoreResults(ordereResults);

        }
        else
        {
            Console.WriteLine("Please provide a valid Path");
        }

    }

  

    static public void Main()
    {
        Program p = new Program();
        p.Run();
        Console.WriteLine("Main Method");
    }
}




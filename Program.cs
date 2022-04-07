// See https://aka.ms/new-console-template for more information
using LeagueScores.Service;


FileService fileService = new FileService();
Console.Write("Please enter the file Path : ");
string path = Console.ReadLine();
if (path != "")
{
    Dictionary<string,int> data =fileService.ReadFile(path);

}
else {
    Console.WriteLine("Please provide a valid Path");
}


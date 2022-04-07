using LeagueScores.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Reflection;

namespace LogScoreTests
{
    [TestClass]
    public class ScoreTest
    {


        string currentDir = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location).Replace("\\bin\\Debug\\net6.0","\\Data\\DrawScores.csv");


        [TestMethod]
        public void Win_Bayern()
        {
            //arrange
            Program program = new Program();
            string path = "C:\\Users\\SinikiweJumba\\source\\repos\\TestLogCalculator\\Data\\WinBayern.csv";

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var stringReader = new StringReader(path);
            Console.SetIn(stringReader);

            //act
            program.Run();

            //assert
            var output = stringWriter.ToString();
            Assert.AreEqual($"Please enter the file Path : 1. Bayern Munich , 3 pts\r\n2. Barcelona , 0 pts\r\n", output);

        }

        [TestMethod]
        public void Lose_Barcelona()
        {
            //arrange
            Program program = new Program();
            string path = "C:\\Users\\SinikiweJumba\\source\\repos\\TestLogCalculator\\Data\\WinBayern.csv";

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var stringReader = new StringReader(path);
            Console.SetIn(stringReader);

            //act
            program.Run();

            //assert
            var output = stringWriter.ToString();
            Assert.AreEqual($"Please enter the file Path : 1. Bayern Munich , 3 pts\r\n2. Barcelona , 0 pts\r\n", output);

        }

        [TestMethod]
        public void Order_By_Team_Points_Equal()
        {
            //arrange
            Program program = new Program();
            string path = "C:\\Users\\SinikiweJumba\\source\\repos\\TestLogCalculator\\Data\\DrawScores.csv";

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var stringReader = new StringReader(path);
            Console.SetIn(stringReader);

            //act
            program.Run();

            //assert
            var output = stringWriter.ToString();
            Assert.AreEqual($"Please enter the file Path : 1. FC Awesome , 3 pts\r\n2. Grouches , 3 pts\r\n3. Lions , 3 pts\r\n4. Snakes , 3 pts\r\n5. Tarantulas , 3 pts\r\n6. Cheaters , 1 pts\r\n", output);

        }

        [TestMethod]
        public void Order_By_Names()
        {
            //arrange
            Program program = new Program();
            string path = "C:\\Users\\SinikiweJumba\\source\\repos\\TestLogCalculator\\Data\\OrderByNames.csv";

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var stringReader = new StringReader(path);
            Console.SetIn(stringReader);

            //act
            program.Run();

            //assert
            var output = stringWriter.ToString();
            Assert.AreEqual($"Please enter the file Path : 1. Apple FC , 2 pts\r\n2. Banana Republic , 2 pts\r\n3. Duck , 2 pts\r\n4. Eve FC , 2 pts\r\n", output);

        }









    }
}

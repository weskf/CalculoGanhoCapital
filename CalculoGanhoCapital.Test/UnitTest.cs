using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculoGanhoCapital.Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethodCase01()
        {
            string jsonInput = @"[{""operation"":""buy"", ""unit-cost"":10.00, ""quantity"": 100},
                                  {""operation"":""sell"", ""unit-cost"":15.00, ""quantity"": 50},
                                  {""operation"":""sell"", ""unit-cost"":15.00, ""quantity"": 50}]";

            Program.CalculaGanhoCapital(jsonInput);
        }

        [TestMethod]
        public void TestMethodCase02()
        {
            string jsonInput = @"[{""operation"":""buy"", ""unit-cost"":10.00, ""quantity"": 10000},
                                  {""operation"":""sell"", ""unit-cost"":20.00, ""quantity"": 5000},
                                  {""operation"":""sell"", ""unit-cost"":5.00, ""quantity"": 5000}]";

            Program.CalculaGanhoCapital(jsonInput);
        }

        [TestMethod]
        public void TestMethodCase0102()
        {
            string jsonInput = @"[{""operation"":""buy"", ""unit-cost"":10.00, ""quantity"": 100},
                                  {""operation"":""sell"", ""unit-cost"":15.00, ""quantity"": 50},
                                  {""operation"":""sell"", ""unit-cost"":15.00, ""quantity"": 50}]
                                  [{""operation"":""buy"", ""unit-cost"":10.00, ""quantity"": 10000},
                                  {""operation"":""sell"", ""unit-cost"":20.00, ""quantity"": 5000},
                                  {""operation"":""sell"", ""unit-cost"":5.00, ""quantity"": 5000}]";

            Program.CalculaGanhoCapital(jsonInput);
        }

        [TestMethod]
        public void TestMethodCase03()
        {
            string jsonInput = @"[{""operation"":""buy"", ""unit-cost"":10.00, ""quantity"": 10000},
                                  {""operation"":""sell"", ""unit-cost"":5.00, ""quantity"": 5000},
                                  {""operation"":""sell"", ""unit-cost"":20.00, ""quantity"": 3000}]";

            Program.CalculaGanhoCapital(jsonInput);
        }

        [TestMethod]
        public void TestMethodCase04()
        {
            string jsonInput = @"[{""operation"":""buy"", ""unit-cost"":10.00, ""quantity"": 10000},
                                  {""operation"":""buy"", ""unit-cost"":25.00, ""quantity"": 5000},
                                  {""operation"":""sell"", ""unit-cost"":15.00, ""quantity"": 10000}]";

            Program.CalculaGanhoCapital(jsonInput);
        }

        [TestMethod]
        public void TestMethodCase05()
        {
            string jsonInput = @"[{""operation"":""buy"", ""unit-cost"":10.00, ""quantity"": 10000},
                                  {""operation"":""buy"", ""unit-cost"":25.00, ""quantity"": 5000},
                                  {""operation"":""sell"", ""unit-cost"":15.00, ""quantity"": 10000},
                                  {""operation"":""sell"", ""unit-cost"":25.00, ""quantity"": 5000}]";

            Program.CalculaGanhoCapital(jsonInput);
        }

        [TestMethod]
        public void TestMethodCase06()
        {
            string jsonInput = @"[{""operation"":""buy"", ""unit-cost"":10.00, ""quantity"": 10000},
                                  {""operation"":""sell"", ""unit-cost"":2.00, ""quantity"": 5000},
                                  {""operation"":""sell"", ""unit-cost"":20.00, ""quantity"": 2000},
                                  {""operation"":""sell"", ""unit-cost"":20.00, ""quantity"": 2000},
                                  {""operation"":""sell"", ""unit-cost"":25.00, ""quantity"": 1000}]";

            Program.CalculaGanhoCapital(jsonInput);
        }

        [TestMethod]
        public void TestMethodCase07()
        {
            string jsonInput = @"[{""operation"":""buy"", ""unit-cost"":10.00, ""quantity"": 10000},
                                  {""operation"":""sell"", ""unit-cost"":2.00, ""quantity"": 5000},
                                  {""operation"":""sell"", ""unit-cost"":20.00, ""quantity"": 2000},
                                  {""operation"":""sell"", ""unit-cost"":20.00, ""quantity"": 2000},
                                  {""operation"":""sell"", ""unit-cost"":25.00, ""quantity"": 1000},
                                  {""operation"":""buy"", ""unit-cost"":20.00, ""quantity"": 10000},
                                  {""operation"":""sell"", ""unit-cost"":15.00, ""quantity"": 5000},
                                  {""operation"":""sell"", ""unit-cost"":30.00, ""quantity"": 4350},
                                  {""operation"":""sell"", ""unit-cost"":30.00, ""quantity"": 650}]";

            Program.CalculaGanhoCapital(jsonInput);
        }

        [TestMethod]
        public void TestMethodCase08()
        {
            string jsonInput = @"[{""operation"":""buy"", ""unit-cost"":10.00, ""quantity"": 10000},
                                  {""operation"":""sell"", ""unit-cost"":50.00, ""quantity"": 10000},
                                  {""operation"":""buy"", ""unit-cost"":20.00, ""quantity"": 10000},
                                  {""operation"":""sell"", ""unit-cost"":50.00, ""quantity"": 10000}]";

            Program.CalculaGanhoCapital(jsonInput);
        }
    }
}
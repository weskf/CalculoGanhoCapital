using CalculoGanhoCapital.Business;
using CalculoGanhoCapital.Model;
using CalculoGanhoCapital.Util;
using System.Text.Json;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a json operation Value: ");

        string inputOperation = Console.ReadLine();

        CalculaGanhoCapital(inputOperation);    
    }

    public static void CalculaGanhoCapital(string inputOperation)
    {
        foreach (var input in JsonConvert.Operations(inputOperation))
        {
            List<Tax> lstTaxes = (CalculateBusiness.CalculateOperation(input));

            foreach (Tax tax in lstTaxes)
            {
                Console.WriteLine(JsonSerializer.Serialize(tax));
            }
        }      
    }
    
}

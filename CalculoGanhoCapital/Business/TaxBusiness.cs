using CalculoGanhoCapital.Model;

namespace CalculoGanhoCapital.Business
{
    public class TaxBusiness
    {
        public static Tax TaxCalculated(Operation operation)
        {
            Tax tax = new Tax();
            tax.TaxCalculate = 0.00;
            
            if (HasGain(operation) && HasTax(operation))
                tax.TaxCalculate = CalculateTax(operation);

            return tax;
        }

        private static double CalculateTax(Operation operation)
        {
            double percTax = 0.20;
            return Convert.ToDouble(operation.Gain) * percTax;
        }

        private static bool HasGain(Operation operation)
        {
            if(operation.Gain > operation.weightedAverage)
                return true;

            return false;
        }

        private static bool HasTax(Operation operation)
        {
            decimal valueOperation = 20000;
            return (operation.UnitCost * operation.Quantity) > valueOperation;
        }
    }
}

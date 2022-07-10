using CalculoGanhoCapital.Model;

namespace CalculoGanhoCapital.Business
{
    public class CalculateBusiness
    {
        public static List<Tax> CalculateOperation(string inputOperation)
        {
            List<Operation> operations = new List<Operation>();
            var lstOperation = OperationBusiness.DeserializeOperation(inputOperation);

            return TaxesCalculated(lstOperation);
        }

        private static List<Tax> TaxesCalculated(List<Operation> lstOperation)
        {
            List<Tax> lstTaxes = new List<Tax>();

            foreach (Operation op in OperationBusiness.GainCalculated(lstOperation))
            {
                lstTaxes.Add(TaxBusiness.TaxCalculated(op));
            }

            return lstTaxes;
        }
    }
}

using CalculoGanhoCapital.Model;
using CalculoGanhoCapital.Util;
using System.Text.Json;

namespace CalculoGanhoCapital.Business
{
    public class OperationBusiness
    {
        public static List<Operation> DeserializeOperation(string inputOperation)
        {
            var lstOperation = JsonSerializer.Deserialize<List<Operation>>(inputOperation);
            int seq = 1;

            foreach(var operation in lstOperation)
            {
                operation.Seq = seq++;
            }
            return lstOperation;
        }

        public static List<Operation> GainCalculated(List<Operation> lstOperation)
        {
            decimal weightedAverage = 0;
            decimal gainOperation = 0;

            int quantityTotal = 0;
            int quantityInitialBuy = 0;

            foreach (var operation in lstOperation)
            {
                if (operation.TypeOperation == EnumOperation.OperationType.buy.ToString())
                {
                    if (operation.Seq == 1)
                    {
                        weightedAverage = CalculateWeightedAverage(operation);
                        operation.weightedAverage = weightedAverage;
                        quantityInitialBuy = operation.Quantity;
                    }
                    else
                    {
                        weightedAverage = RecalculateWeightedAverage(weightedAverage, quantityInitialBuy, quantityTotal, operation);
                        operation.weightedAverage = weightedAverage;
                    }
                    quantityTotal += operation.Quantity;
                    gainOperation = 0;
                }

                if (operation.TypeOperation == EnumOperation.OperationType.sell.ToString())
                {
                    quantityTotal -= operation.Quantity;

                    gainOperation = CalculateGainOperation(gainOperation, weightedAverage, operation);
                    operation.Gain = gainOperation;
                }
            }

            return lstOperation;
        }

        private static decimal CalculateWeightedAverage(Operation operation)
        {
            return (operation.Quantity * operation.UnitCost) / operation.Quantity;
        }

        private static decimal RecalculateWeightedAverage(decimal weightedAverage, int quantityInitialBuy, int quantityTotal, Operation operation)
        {
            return ((quantityTotal * weightedAverage) + (operation.Quantity * operation.UnitCost)) / (operation.Quantity + quantityTotal);
        }

        private static decimal CalculateGainOperation(decimal gainOperation, decimal weightedAverage, Operation operation)
        {
            decimal gainOperationCurrent = 0;

            gainOperationCurrent = (operation.UnitCost - weightedAverage) * operation.Quantity;
            if (gainOperationCurrent > 0)
                gainOperation += gainOperationCurrent;
            else
                gainOperation = gainOperationCurrent;

            return gainOperation;
        }

    }
}

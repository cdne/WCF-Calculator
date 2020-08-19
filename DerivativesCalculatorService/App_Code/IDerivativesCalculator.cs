using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DerivativesCalculatorService
{
    [ServiceContract]
    public interface IDerivativesCalculator
    {
        [OperationContract]
        decimal CalculateDerivative(int days, string[] symbols, string[] functions);
    }
}

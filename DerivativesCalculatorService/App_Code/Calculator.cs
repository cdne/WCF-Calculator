using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivativesCalculatorService.App_Code
{
    internal class Calculator : IDerivativesCalculator
    {
        #region IDerivativesCalculator Members
        public decimal CalculateDerivative(int days, string[] symbols, string[] functions)
        {
            return DateTime.Now.Millisecond;
        }
        #endregion
    }
}

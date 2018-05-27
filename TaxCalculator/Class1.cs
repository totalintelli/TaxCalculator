using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    public enum TaxYear
    {
        Year2013,
        Year2014
    }

    public class TaxHelper
    {
        private readonly TaxYear _taxYear;

        public TaxHelper(TaxYear taxYear)
        {
            this._taxYear = taxYear;
        }

        public decimal Calculate(decimal salary)
        {
            // To Do : 2013 = 10%, 2014 = 20%
            return -1;
        }
    }
}

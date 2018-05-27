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

    // 연봉에서 현재 나라에 내야 하는 Tax를 뺀 연봉의 실수령액을 계산해서 반환해주는 프로그램을 만드시오.
    // 단, Tax 계산 연도가 2013년일때는 10%를 2014년일 때는 20%를 적용하시오.
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
            int taxRate = 0;
            switch (_taxYear)
            {
                case TaxYear.Year2013:
                    taxRate = 10;
                    break;
                case TaxYear.Year2014:
                    taxRate = 20;
                    break;
                default:
                    throw new ArgumentException();
            }
            return salary * (100 - taxRate) / 100;
        }
    }
}

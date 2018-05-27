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
        private readonly ITaxRepository _taxRepo;

        public TaxHelper(TaxYear taxYear, ITaxRepository taxRepo)
        {
            this._taxYear = taxYear;
            this._taxRepo = taxRepo;
        }

        public decimal Calculate(decimal salary)
        {
            // To Do : 2013 = 10%, 2014 = 20%
            int taxRate = _taxRepo.GetTaxRate(_taxYear);
            return salary * (100 - taxRate) / 100;
        }
    }

    public interface ITaxRepository
    {
        int GetTaxRate(TaxYear taxYear);
    }

    // 세금 비율을 DB에 저장해서 연도 별로 가져오도록 수정
    public class TaxRepository : ITaxRepository
    {
        public int GetTaxRate(TaxYear taxYear)
        {
            // To Do
            return -1;
        }
    }

    public class StubTaxRepository : ITaxRepository
    {
        public int TaxRate { get; set; }

        public int GetTaxRate(TaxYear taxYear)
        {
            return TaxRate;
        }
    }

}

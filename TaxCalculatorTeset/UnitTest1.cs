﻿using System;
using NUnit.Framework;
using TaxCalculator;

namespace TaxCalculatorTest
{
    [TestFixture]
    public class TaxCalculatorTest
    {
        [Test]
        public void When2013_ShouldRetrun90Percent()
        {
            // Arrange
            var taxHelper = new TaxHelper(TaxYear.Year2013);
            const int salaryExpected = 900;

            // Act
            var salaryResulted = taxHelper.Calculate(1000);

            // Assert
            Assert.That(salaryResulted, Is.EqualTo(salaryExpected));
        }

        [Test]
        public void When2014_ShouldReturn80Percent()
        {
            // Arrange
            var taxHelper = new TaxHelper(TaxYear.Year2014);
            const int salaryExpected = 800;

            // Aact
            var salaryResulted = taxHelper.Calculate(1000);

            // Assert
            Assert.That(salaryResulted, Is.EqualTo(salaryExpected));
        }

        [TestCase(TaxYear.Year2013)]
        [TestCase(TaxYear.Year2014)]
        public void WhenSalaryIsZero_ShouldReturnZero(TaxYear taxYear)
        {
            // Arrange
            var taxHelper = new TaxHelper(taxYear);
            const int salaryExpected = 0;

            // Act
            var salaryResulted = taxHelper.Calculate(0);

            // Assert
            Assert.That(salaryResulted, Is.EqualTo(salaryExpected));
        }
    }
}

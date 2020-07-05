using FiCalc.Server.Enums;
using FiCalc.Server.Pages;
using NUnit.Framework;

namespace FiCalc.Test.PagesTest
{
    public class TaxRateCalcTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(7854.52, .1)]
        [TestCase(11235.54, .12)]
        [TestCase(74589.92, .22)]
        [TestCase(104258.36, .24)]
        [TestCase(184534.28, .32)]
        [TestCase(254875.36, .35)]
        [TestCase(687541.47, .37)]
        public void TestGetTaxRate_Single(decimal income, decimal assertRate)
        {
            var rate = TaxRateCalcBase.GetTaxRate(income, FileStatusEnum.Single);
            Assert.AreEqual(rate, assertRate);
        }

        [TestCase(7854.52, .1)]
        [TestCase(22512.25, .12)]
        [TestCase(104582.54, .22)]
        [TestCase(186547.24, .24)]
        [TestCase(375487.25, .32)]
        [TestCase(584102.22, .35)]
        [TestCase(745895.12, .37)]
        public void TestGetTaxRate_MarriedJoint(decimal income, decimal assertRate)
        {
            var rate = TaxRateCalcBase.GetTaxRate(income, FileStatusEnum.MarriedJointly);
            Assert.AreEqual(rate, assertRate);
        }
    }
}
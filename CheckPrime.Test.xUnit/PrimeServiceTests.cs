
using Xunit;

namespace CheckPrime.Test.xUnit
{
    public class PrimeServiceTests
    {
        readonly Services _primeService;

        public PrimeServiceTests() => _primeService = new Services();

        [Theory]
        [InlineData(3), InlineData(7), InlineData(1), InlineData(0)]
        public void IsPrime_ValuesLessThan2_ReturnTrue(int value) =>
            Assert.True(_primeService.IsPrimeV2(value), $"{value} should be prime");

        //[Theory]
        //[InlineData(15)]
        //public void IsPrime_ValuesLessThan2_ReturnFalse(int value) =>
        //    Assert.False(_primeService.IsPrimeV2(value), $"{value} should not be prime");

        //[Theory]
        //[InlineData(2), InlineData(3), InlineData(5), InlineData(7)]
        //public void IsPrime_PrimesLessThan10_ReturnTrue(int value) =>
        //    Assert.True(_primeService.IsPrime(value), $"{value} should be prime");

        //[Theory]
        //[InlineData(4), InlineData(6), InlineData(8), InlineData(9)]
        //public void IsPrime_NonPrimesLessThan10_ReturnFalse(int value) =>
        //    Assert.False(_primeService.IsPrime(value), $"{value} should not be prime");
    }
}

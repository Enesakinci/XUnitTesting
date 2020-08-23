using Calculator;
using Xunit;

namespace TestProject
{
    public class UnitTest
    {
        [Fact]
        public void Test1()
        {
            //Hazırlama Aşaması
            Calculators calculator = new Calculators();

            //Hareket Aşaması - Act
            decimal calculatedHour = calculator.GetHourWithMinute(60);

            //İddia Etme Aşaması - Assert
            Assert.Equal(1, calculatedHour);
        }

        [Fact]
        public void Test2()
        {
            Calculators calculator = new Calculators();

            decimal calculatedMinute = calculator.GetMinuteWithHour(3);

            Assert.Equal(180, calculatedMinute);
        }
    }
}

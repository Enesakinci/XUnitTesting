namespace Calculator
{
    public class Calculators
    {
        public decimal GetHourWithMinute(decimal minuteClock) => minuteClock / 60;

        public decimal GetMinuteWithHour(decimal hourClock) => hourClock * 60;

    }
}

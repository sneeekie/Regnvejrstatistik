namespace Regnvejr
{
    class Porgram
    {

        static void Main(string[] args)
        {
            int day = default;
            List<double> periodCombine = new List<double>();

            Console.WriteLine("amount of days:");
            day = int.Parse(Console.ReadLine());

            int[] time = new int[day];
            periodCombine = Rain(time);
            RainResult(periodCombine);
        }
        static List<double> Rain(int[] _period)
        {
            List<double> _amount = new List<double>();
            try
            {
                for (int i = 0; i < _period.Length; i++)
                {
                    Console.WriteLine($"type amount of rain for day {i + 1}, in mm :");
                    _amount.Add(double.Parse(Console.ReadLine()));
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("type in a value.. type \"0\" if there has been no rain: ");
            }
            return _amount;
        }

        static void RainResult(List<double> maxAmount)
        {
            double totalAmountRain = 0;
            Console.WriteLine("* dag: \tNedbør:*");

            for (int i = 0; i < maxAmount.Count; i++)
            {
                Console.WriteLine($"*\t{i + 1}: \t{maxAmount[i]}*");
                totalAmountRain += maxAmount[i];
            }
            Console.WriteLine($"* Gennemtsnit: {totalAmountRain / maxAmount.Count:N2} Minimum: {maxAmount.Min<double>()} Maximum: {maxAmount.Max<double>()} *");
        }
    }
}
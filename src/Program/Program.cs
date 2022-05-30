namespace Regnvejr
{
    class Porgram
    {

        static void Main(string[] args)
        {
            int day = default;
            List<double> periodAmount = new List<double>();

            Console.WriteLine("amount of days:");
            day = int.Parse(Console.ReadLine());

            int[] period = new int[day];
            periodAmount = Rain(period);
            RainResult(periodAmount);
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

        static void RainResult(List<double> allAmount)
        {
            double totalAmountRain = 0;
            Console.WriteLine("* dag: \t\tNedbør:*");

            for (int i = 0; i < allAmount.Count; i++)
            {
                Console.WriteLine($"*\t{i + 1}: \t\t{allAmount[i]}*");
                totalAmountRain += allAmount[i];
            }
            Console.WriteLine($"* Gennemtsnit: {totalAmountRain / allAmount.Count:N2} \tMinimum: {allAmount.Min<double>()} \tMaximum: {allAmount.Max<double>()} \t*");
        }
    }
}
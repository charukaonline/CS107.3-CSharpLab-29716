using System;

class TemperatureTracker
{
    private double[] temperatures;

    public TemperatureTracker()
    {
        temperatures = new double[7];
    }

    public void InputTemperatures()
    {
        for (int i = 0; i < temperatures.Length; i++)
        {
            Console.Write($"Enter temperature for day {i + 1}: ");
            temperatures[i] = Convert.ToDouble(Console.ReadLine());
        }
    }

    public void DisplayTemperatureReport()
    {
        Console.WriteLine("Weekly Temperature Report:");
        for (int i = 0; i < temperatures.Length; i++)
        {
            Console.WriteLine($"Day {i + 1}: {temperatures[i]}°C");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        TemperatureTracker tracker = new TemperatureTracker();
        tracker.InputTemperatures();
        tracker.DisplayTemperatureReport();
    }
}

namespace _2bränsleanvändningProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("Please enter your fuelrange in Liter");
            int fuelRange = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please eneter your droven miles");
            int milesDroven = Convert.ToInt32(Console.ReadLine());

            Fordon fordon = new Fordon();

            fordon.miltal = milesDroven;
            fordon.bränsleVolym = fuelRange;

            int efficiency = fordon.CalculateFuelEfficiensy();
            Console.WriteLine($"Your fuelefficiency is {efficiency}");

            Console.WriteLine("Please enter your fuelrange in Liter");
            int fuelRangeCar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please eneter your droven miles");
            int milesDrovenCar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please eneter your batteryrange in miles");
            int batteryMiles = Convert.ToInt32(Console.ReadLine());

            ElectricCar car = new ElectricCar();

            car.miltal = milesDrovenCar;
            car.bränsleVolym = fuelRangeCar;
            car.batteri = batteryMiles;

            int efficiencyCar = car.CalculateFuelEfficiensy();
            Console.WriteLine($"Your fuel efficiency for car is {efficiencyCar}");



        }
    }
}

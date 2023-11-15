namespace Carfleet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Fr2333", "Merco", "Ivo", "22321321");
            Truck truck = new Truck("Fr2333", "Merco", "Ivo", "22321321");
        }

        static private void DisplayCar(Car car)
        {
            Console.WriteLine(car.ToString());
        }

        static private void DisplayTruck(Truck truck)
        {
            Console.WriteLine(truck.ToString());
        }
    }
}
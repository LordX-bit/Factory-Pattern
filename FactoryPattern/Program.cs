namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            int wheelCount;
            bool input = false;
            do
            {
                Console.WriteLine("enter the amount of tires for the vehicle you want to create");

                input = int.TryParse(Console.ReadLine(), out wheelCount);
            } while (!input);
            var vehicle = Vehicle_Factory.GetVehicle(wheelCount);
            vehicle.Drive();
            Console.WriteLine("your on your way");
        }
    }
}

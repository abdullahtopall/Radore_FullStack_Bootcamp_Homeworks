using odev1_cars.concretes;

namespace odev1_cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bmw bmw = new Bmw();
            Mercedes mercedes = new Mercedes();
            Porsche porsche = new Porsche();

            bmw.fly();
            bmw.swim();
            bmw.goingFast();

            mercedes.fly();
            mercedes.swim();

            porsche.goingFast();
        }
    }
}

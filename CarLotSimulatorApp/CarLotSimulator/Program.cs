using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot carLot = new CarLot();

            Car car1 = new Car();
            car1.Year = 2017;
            car1.Make = "Honda";
            car1.Model = "Pilot";
            car1.EngineNoise = "skurr";
            car1.HonkNoise = "toot toot";
            car1.IsDriveable = true;
            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);

            carLot.CarList.Add(car1);

            Car car2 = new Car(2020, "Ford", "Bronco", "rumble", "Beep Beep", false);
            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);

            carLot.CarList.Add(car2);

            Car car3 = new Car()
            {
                Year = 2025,
                Make = "BMW",
                Model = "I8",
                EngineNoise = "rattle rattle",
                HonkNoise = "meep meep",
                IsDriveable = false
            };
            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);

            carLot.CarList.Add(car3);

            foreach (Car car in carLot.CarList) 
            {
                Console.WriteLine(car.Model);
                Console.WriteLine(car.Year);
                Console.WriteLine(car.Make);
            }


        }
    }
}

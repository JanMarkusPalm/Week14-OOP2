using System;

namespace OOPCar
{
    class Program
    {
        class Car
        {
            string name;
            string model;
            string regNum;
            string color;
            int odometer;
            int fuel;


            public Car(string _name, string _model, string _regNum, string _color) //constructor
            {
                name = _name;
                model = _model;
                regNum = _regNum;
                color = _color;
                odometer = 0;
                fuel = 60;
                Console.WriteLine($"You've made your {color} car {_name}, {_model}, {_regNum}!");
            }

            public void ShowCarInfo()
            {
                Console.WriteLine($"");
                Console.WriteLine($"car name: {name}");
                Console.WriteLine($"car model: {model}");
                Console.WriteLine($"registration number: {regNum}");
                Console.WriteLine($"car color: {color}");
                Console.WriteLine($"car's odometer: {odometer}");
                Console.WriteLine($"car's fuel tank: {fuel}");
            }

            public string Model
            {
                get { return model; }
            }
            public string Name
            {
                get { return name; }
            }
            public string RegNum
            {
                get { return regNum; }
            }
            public string Color
            {
                get { return color; }
            }
            public int Odometer
            {
                get { return odometer; }
            }
            public int Fuel
            {
                get { return fuel; }
            }


            public void drive()
            {
                fuel -= 5;
                odometer += 100;
                Console.WriteLine("VRUMMMMMMMMMMMMM");
            }
        }
        static void Main(string[] args)
        {
            Car newcar = new Car("BFC", "Lamp", "420ASS", "Bright pink");
            while (newcar.Fuel > 0)
            {
               newcar.drive();
               Console.WriteLine($"fuel after drive : {newcar.Fuel}");
            }
            newcar.ShowCarInfo();

        }





        //{
        //    car newcar = new car("Pätt");
        //    mycat.ShowPetInfo();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        mycat.Eat();
        //        Console.WriteLine($"current fatness : {mycat.Weight}");
        //        if (mycat.Weight >= 0.7)
        //        {

        //            while (mycat.Weight > 0.7)
        //            {
        //                mycat.run();
        //                Console.WriteLine($"fatness after workout : {mycat.Weight}");
        //            }

        //        }

        //    }
        //}
    }
}

using System;

namespace Car
{
    class Program
    {

        class Car
        {
            string mark;
            string model;
            string regNumber;
            string color;
            int odo;
            int fuelTank;

            public Car(string _mark, string _model, string _regNumber, string _color)
            {
                mark = _mark;
                model = _model;
                regNumber = _regNumber;
                color = _color;
                odo = 0;
                fuelTank = 60;

                Console.WriteLine($"{color} {mark} {model} {regNumber} has been created.");
            }
        }
        static void Main(string[] args)
        {
            Car myCar = new Car("Toyota", "Celica", "777BTJ", "Red");
        }
    }
}

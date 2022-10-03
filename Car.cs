using System;

namespace HelloWorld
{
    public class Car
    {
        private string _brand;
        private string _name;
        private string _color;
        private int _countOfDoors;

        public string Brand
        {
            get {return _brand;}
            set {_brand = value;}
        }
        public string Name
        {
            get { return _name;}
            set {_name = value;}
        }
        public string Color
        {
            get {return _color;}
            set {_color = value;}
        }
        public int CountOfDoors
        {
            get {return _countOfDoors;}
            set {_countOfDoors = value;}
        }
        public Car(string b, string n, string c, int d)
        {
            Brand = b;
            Name = n;
            Color = c;
            CountOfDoors = d;
        }
        public void PrintCar()
        {
           Console.WriteLine($"The car is {Brand} {Name}, the color of it is {Color}; the car contains {CountOfDoors} doors.");
        }
        public override string ToString()
        {
             return $"The car is {Brand} {Name}, the color of it is {Color}; the car contains {CountOfDoors} doors.";
         }
        public Car()
        {

        }
    }
}

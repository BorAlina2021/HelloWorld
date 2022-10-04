using HelloWorld.Enums;

namespace HelloWorld
{
    public class ExampleClassPerson1
    {

        public string _FirstName { get; set; }
        public string _LastName { get; set; }
        public string _Occupation { get; set; }
        public string _LivingPlace { get; set; }
        public int _Age { get; set; }
        public double _Height { get; set; }
        public double _Weight { get; set; }
        public string _ColorHair { get; set; }
        public string _ColorEyes { get; set; }
        Gender _gender;
        public string _Gender { get; set; }
        public string SetGender(Gender gender)
        {
            if (gender == Gender.Male)
            {
                return "he";
            }
            else
            {
                return "she";
            }
        }
        public Car Car { get; set; }
        public ExampleClassPerson1(Gender gender, string _FirstName, string _LastName, string _Occupation, string _LivingPlace, int _Age, double _Height, double _Weight, string _ColorHair, string _ColorEyes)
        {
            this._gender = gender;
            this._FirstName = _FirstName;
            this._LastName = _LastName;
            this._Occupation = _Occupation;
            this._LivingPlace = _LivingPlace;
            this._Age = _Age;
            this._Height = _Height;
            this._Weight = _Weight;
            this._ColorHair = _ColorHair;
            this._ColorEyes = _ColorEyes;
        }

        public string GetGender()
        {
            return _gender.ToString();
        }
        public string GetFullName()
        {
            return _FirstName + " " + _LastName;

        }
        public string GetOccupation()
        {
            return _Occupation;
        }
        public string GetLivingPlace()
        {
            return _LivingPlace;
        }
        public int GetAge()
        {
            return _Age;
        }
        public int GetYearOfBirth()
        {
            return DateTime.Now.AddYears(-_Age).Year;
        }
        public double GetHeight()
        {
            return _Height;
        }
        public double GetWeight()
        {
            return _Weight;
        }
        public string GetColorHair()
        {
            return _ColorHair;
        }
        public string GetColorEyes()
        {
            return _ColorEyes;
        }
        public void DisplayCar()
        {
            Console.WriteLine($"This is {GetFullName()}'s {Car}");
        }

        public ExampleClassPerson1()
        {

        }
    }
}

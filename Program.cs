namespace OOP01
{
    internal class Program
    {
        class car
        {
            public string Manufacturer;
            public string Model;
            public int Year;
            public string Color;
            public int NumberOfWheels;
            public int MaximumSpeed;
            public int CurrentSpeed;
            public int FuelType;



            public car()
            {
                //default construcutor
            }
            public car (string Manufacturer, string Model, int Year, string Color, int NumberOfWheels, int MaximumSpeed, int CurrentSpeed, int FuelType )
            {
                this.Manufacturer = Manufacturer;
                this.Model= Model;
                this.Year = Year;
                this.Color = Color;
                this.NumberOfWheels = NumberOfWheels;
                this.MaximumSpeed = MaximumSpeed;
                this.CurrentSpeed = CurrentSpeed;
                this.FuelType = FuelType;
                
            }
            public car (string Manufacturer, string Color)
            {
                this.Manufacturer= Manufacturer;
                this.Color = Color;
            }
            public car (int Year, string Color)
            {
                this.Year= Year;    
                this.Color = Color;
            }
            public car (int FuelType, int Year, string Color)
            {
                this.FuelType= FuelType;
                this.Year= Year;
                this.Color = Color;
            }
            public void DisplayInfo()
            {
                Console.WriteLine("Manufacturer: {0}, Model: {1}, Year: {2}, Color: {3}, Number of wheels: {4}, MaximumSpeed: {5}, CuurentSpeed: {6}, FuelType: {7} ", this.Manufacturer, this.Model, this.Year, this.Color, this.NumberOfWheels, this.MaximumSpeed, this.CurrentSpeed, this.FuelType);
            }
            public void Speed()
            {
                Console.WriteLine("Current Speed: {0}, Maximum Speed: {1}", this.CurrentSpeed, this.MaximumSpeed);
            }
            public void Type()
            {
                Console.WriteLine("Manufacturer: {0}, Model: {1}", this.Manufacturer, this.Model);
            }
            public void Details()
            { 
            Console.WriteLine("Year: {0}, Color: {1} " + this.Year, this.Color);
            }
            public void Control()
            { Console.WriteLine("Stop the car!"); }
        }
        static void Main(string[] args)
        {
            car p1 = new car("Merceds", "C200", 2020, "Black", 4, 220, 100,90);
            p1.DisplayInfo();
            Console.ReadKey();
        }
    }
}
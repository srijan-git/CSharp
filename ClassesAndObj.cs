using System;
namespace Fundamentals
{
    public class ClassesAndObj
    {
        private string carName;
        private string carCompany;
        private string carColor;
        private int carSpeed;
        private int carPrice;

        //Getters and Setters
        private string CarName { get { return carName; } set { carName = value.ToUpper(); } }
        private string CarCompany { get { return carCompany; } set { carCompany = value.ToUpper(); } }
        private string CarColor { get { return carColor; } set { carColor = value.ToUpper(); } }
        private int CarSpeed { get { return carSpeed; } set { if (value > 500) { carSpeed = 500; } else { carSpeed = value; } } }
        private int CarPrice { get { return carPrice; } set { carPrice = value; } }





        public ClassesAndObj(string carName, string carCompany, string carColor, int carSpeed, int carPrice)
        {
            this.CarName = carName;
            this.CarCompany = carCompany;
            this.CarColor = carColor;
            this.CarSpeed = carSpeed;
            this.CarPrice = carPrice;
        }


        public void display()
        {
            Console.WriteLine("Car details are: ");
            Console.WriteLine("Car name: " + this.CarName + " company: " + this.CarCompany + " color: " + this.CarColor +
                " speed: " + this.CarSpeed + " price:" + this.CarPrice);

        }
    }
}


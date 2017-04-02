using System;

namespace Cars_names
{
    class Summer
    {
        string CarName;
        int CarNum;
        double CarCost;
        

        public void CarNumber()
        {
            CarName = "Mazeratti";
            CarNum = 3;
            CarCost = 12.220;
        }

        public double CarsCostCalc()
        {
            return CarNum * CarCost;
        }

        public void ShowResults()
        {
            Console.WriteLine("In our shop we have got a {0} cars", CarName);
            Console.WriteLine("Their number is: {0}", CarNum);
            Console.WriteLine("Their cost is: {0}", CarsCostCalc());
        }

    }
    class Program
    {


        static void Main(string[] args)
        {
            Summer NewSummer = new Summer();
            NewSummer.CarNumber();
            NewSummer.CarsCostCalc();
            NewSummer.ShowResults();
            Console.ReadKey();
        }
    }
}

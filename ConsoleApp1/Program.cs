using System;
namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Rular rular = new Rular(10);
            rular.Run();
        }   //Main
    }   //Program

    public class Rular 
    {
        private const float ONE_INCH = 2.54f;
        public int Centimeter { get; set; } = 0;
        public float Inch 
        {
            get { return Centimeter *ONE_INCH; }
            private set { Centimeter = (int)(value / ONE_INCH); }
        }
        public Rular(int cmValue) { Centimeter = cmValue; }
        public void Run() 
        {
            Console.WriteLine($"{Centimeter}cm 는 {Inch}inch 입니다. ");
        }
    }   //class Ruler
}
using System;

namespace helloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // { 2023.01.05 add new feature user input / Beta
            string userInput = string.Empty;
            Console.WriteLine("This program convert cm to Inch");
            Console.Write("Input cm value : ");
            userInput = Console.ReadLine();

            int cmInput = 0;
            int.TryParse(userInput,out cmInput);

            Ruler ruler = new Ruler(10);
            ruler.Run();
            // } 2023.01.05 add new feature user input / Beta
        }
    }
    public class Ruler
    {
        private const float ONE_INCH = 2.54f;
        private int Centimeter { get; set; } = 0;
        public float Inch
        {
            get { return Centimeter * ONE_INCH; }
            private set { Centimeter = (int)(value / ONE_INCH); }
        }
        public Ruler(int cmvalue) { Centimeter = cmvalue; }

        public void Run()
        {
            Console.WriteLine($"{Centimeter}cm 는 {Inch}inch 입니다.");
        }
    } //    class ruler
}
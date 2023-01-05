using System;

namespace helloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ruler ruler = new Ruler(10);
            ruler.Run();
        }

        public class Ruler
        {
            private const float ONE_INCH = 2.54f;
            private int Centimeter { get; set; } = 0;
            public float Inch
            {
                get { return Centimeter * ONE_INCH; }
            // {    2023.01.05  Add new feature Set Inch Func / Gamma
                private set { SetInch(value); }
            // }    2023.01.05  Add new feature Set Inch Func / Gamma
            }
            public Ruler(int cmvalue) { Centimeter = cmvalue; }

            public void Run()
            {
                Console.WriteLine($"{Centimeter}cm 는 {Inch}inch 입니다.");
            }

            // {    2023.01.05  Add new feature Set Inch Func / Gamma
            private void SetInch(float inchvalue)
            {
                Centimeter = (int)(inchvalue / ONE_INCH);
            }
            // }    2023.01.05  Add new feature Set Inch Func / Gamma
        } //    class ruler
    }
}
﻿using System;

namespace helloworld
{
    // { 2023.01.05. Modified class position / Alpha
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
    // } 2023.01.05. Modified class position / Alpha

    internal class Program
    {
        static void Main(string[] args)
        {
            Ruler ruler = new Ruler(10);
            ruler.Run();
        }
    }
}
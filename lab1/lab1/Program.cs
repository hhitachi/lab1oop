﻿//Variant 12
using System;
class GetX{
    static void Main(){
        Console.WriteLine("Введіть початкове значення x: ");
        string sxMin = Console.ReadLine();
        Console.WriteLine("Введіть кінцеве значення x: ");
        string sxMax = Console.ReadLine();
        Console.Write("Введіть dx: ");
        string sdx = Console.ReadLine();

        double xMin = Double.Parse(sxMin);
        double xMax = Double.Parse(sxMax);
        double dx = double.Parse(sdx);
        
        double x = xMin;
        double y;
        double finalCos = 0;
        while (x <= xMax){
            y = Math.Pow(x, 2);
            finalCos += Math.Sin(x);
            Console.WriteLine("x = {0}\t\t y = {1}", x, y);
            x += dx;
        }
        if (Math.Abs (x - xMax - dx) > 0.0001){
            y = Math.Pow(xMax, 2);
            finalCos += Math.Sin(x);
            Console.WriteLine("x = {0}\t\t y = {1}",xMax, y);
        }

        Console.WriteLine("Сума всіх сінусів від х = {0}", finalCos);

        Console.WriteLine("\nПерейти до наступної задачі?(y/n): ");
        string a = Console.ReadLine();
        if (a == "y"){
            Console.Clear();
            GetY();
        } else if (a == "n"){
            Console.ReadKey();
        } else Console.WriteLine("Неправильне значення");

    }
    static void GetY(){
        Console.WriteLine("\nВведіть перше значення x1: ");
        string sx1 = Console.ReadLine();
        Console.WriteLine("Введіть друге значення x2: ");
        string sx2 = Console.ReadLine();

        int x1 = Int32.Parse(sx1);
        int x2 = int.Parse(sx2);
        
        double y = (3*x2 - Math.Pow(x1, 2))/Math.Pow(Math.Cos(Math.Exp((x1+2*x2+9)/(0.37))), 3);
        
        Console.WriteLine(y);

        Console.ReadKey();
    }
}
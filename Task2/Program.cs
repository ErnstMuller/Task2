using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение радиуса чтобы вычислить площадь вписанного в окружность квадрата и правильного треугольника");
            
            double r = double.Parse(Console.ReadLine());
            double Exponent = 2;
            double Result = Math.Pow(r, Exponent);
            Console.WriteLine("Площадь вписанного квадрата");
            Console.WriteLine(Result * 2);

            double FormulaNumber = 3;
            double SecondExponent = 1.5;
            double Formula = Math.Pow(FormulaNumber, SecondExponent);
            Console.WriteLine("Площадь правильного вписанного треугольника");
            Console.WriteLine(Result * Formula / 4);
            Console.ReadLine();
        }
    }

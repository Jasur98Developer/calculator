using System;
System.Console.WriteLine("Type list number: ");
int firstNumber=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Type 2nd number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"First number is greater than 2nd number: {firstNumber>secondNumber}");
System.Console.WriteLine($"First number is greater than or equal to 2nd number: {firstNumber>=secondNumber}");
System.Console.WriteLine($"First number is less than 2nd number: {firstNumber<secondNumber}");
System.Console.WriteLine($"First number is less than or equal to 2nd number: {firstNumber<=secondNumber}");
System.Console.WriteLine($"Numbers are equal: {firstNumber==secondNumber}");
System.Console.WriteLine($"Numbers are not equal: {firstNumber!=secondNumber}");
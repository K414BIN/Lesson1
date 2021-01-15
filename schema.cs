using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schema
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите целое число: ");
			int n =  Convert.ToInt32(Console.ReadLine());
			if  (isPrimeNumber(n)) Console.WriteLine("Это простое число.");
			else Console.WriteLine("Это не простое число.");
			Console.ReadLine();
		}
	static bool isPrimeNumber( int number)
	{
		int d=0;
		int i=2;
		do {
		    if (number%i==0) d++;
			i++;
		} while (i<number);
		if (d==0) return true ;
		else return false;
	}
	}
}

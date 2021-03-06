﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling1
{
	class Program
	{
		static void Main(string[] args)
		{
			//Напишите консольное приложение, которое выводит на экран первый из введенных символов каждой строки ввода.
			//Опишите корректное поведение приложения, если пользователь ввел пустую строку.
			Console.WriteLine("Enter your lines of the text. Type '-q' for the exit ");
			StringBuilder sb = new StringBuilder();
			otherMain();
			try
			{
				

				while (true)
				{
					var str = Console.ReadLine();
					if (string.IsNullOrWhiteSpace(str))
					{
						throw new NullReferenceException("str is empty");
					}
					if (str.IndexOf("-q", StringComparison.Ordinal) != -1)
					{
						break;
					}
					
					sb.Append(str[0]);
					sb.Append(" ");						
				}

			}
			catch (NullReferenceException nullEx)
			{
				Console.WriteLine("We catched a null reference:"  + nullEx.Message);
			}
			finally
			{
				Console.WriteLine("Result is: ");
				Console.WriteLine(sb.ToString());
				Console.ReadKey();
			}
		}

		static void otherMain()
		{
				var str = Console.ReadLine();
				var t = str[0];
		}
	}
}

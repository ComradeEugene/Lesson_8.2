using System;
using System.Collections.Generic;
using static System.Console;

namespace Lesson_8._2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, string> phonebook = new Dictionary<string, string>();
			
			do
			{
				Clear();
				WriteLine("1 - добавить контакт\n2 - найти контакт\n3 - выход");
				string temp = ReadLine();
				if (temp == "1")
				{
					AddContact(phonebook);
				}
				else if (temp == "2")
				{
					FindContact(phonebook);
				}
				else
				{
					break;
				}
			} while (true);
			ReadKey();
		}
		static void AddContact(Dictionary<string, string> phonebook)
		{
			Clear();
			string value;
			string key;

			WriteLine("Телефон: ");
			key = ReadLine();
			WriteLine("ФИО: ");
			value = ReadLine();
			phonebook.Add(key, value);
		}
		static void FindContact(Dictionary<string, string> phonebook) 
		{
			Clear();
			WriteLine("Введите номер");
			string num = ReadLine();
			string value;
			if (phonebook.TryGetValue(num, out value))
			{
				WriteLine(value);
			}
			else
			{
				WriteLine("Такого контакта нет");
			}
			ReadKey();
		}
	}
}

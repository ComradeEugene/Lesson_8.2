using System;
using System.Collections.Generic;
using static System.Console;

namespace Lesson_8._2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<List<uint>, string> phonebook = new Dictionary<List<uint>, string>();
            
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
		static void AddContact(Dictionary<List<uint>, string> phonebook)
		{
			Clear();
			List<uint> keyList = new List<uint>();
			int count =0;
			uint key = 0;
			string temp;

			WriteLine("Телефон(толь цифры): ");
			while ((temp = ReadLine()) != "")
			{
				keyList.Add(uint.Parse(temp));
			}
			WriteLine("ФИО: ");
			temp = ReadLine();
			phonebook.Add(keyList, temp);
		}
		static void FindContact(Dictionary<List<uint>, string> phonebook) 
		{
			Clear();
            WriteLine("Введите номер");
			uint num = uint.Parse(ReadLine());
            foreach (var e in phonebook)
            {
                if (e.Key.IndexOf(num) != -1)
                {
                    WriteLine(e.Value);
					ReadKey();
					return;
                }
            }
            WriteLine("Такого контакта не существует");
			ReadKey();
		}
	}
}

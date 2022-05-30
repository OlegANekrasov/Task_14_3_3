using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_14_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // создаём пустой список с типом данных Contact
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

            Console.WriteLine("Исходный список:");

            foreach (var contact in phoneBook)
            {
                Console.WriteLine($"Имя: {contact.Name}\t Фамилия: {contact.LastName}\t");
            }

            Console.WriteLine("\nСортировка через Операторы LINQ:");

            var sortedPhoneBook = from s in phoneBook orderby s.Name, s.LastName select s;
            foreach (var contact in sortedPhoneBook)
            {
                Console.WriteLine($"Имя: {contact.Name}\t Фамилия: {contact.LastName}\t");
            }

            Console.WriteLine("\nСортировка через Методы расширений LINQ:"); 

            var contacts = phoneBook.OrderBy(o => o.Name).ThenBy(o => o.LastName);
            foreach(var contact in contacts)
            {
                Console.WriteLine($"Имя: {contact.Name}\t Фамилия: {contact.LastName}\t");
            }

            Console.ReadLine();
        }
    }
}

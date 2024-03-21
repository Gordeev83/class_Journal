using System;

namespace class__Journal
{
    public class Journal
    {
        private string name;
        private int year;
        private string description;
        private string phonenumber;
        private string email;

        // методы для ввода данных
        public void EnterName()
        {
            Console.WriteLine("Введите название журнала:");
            name = Console.ReadLine();
        }

        public void EnterYear()
        {
            Console.WriteLine("Введите год основания:");
            year = int.Parse(Console.ReadLine());
        }

        public void EnterDescription()
        {
            Console.WriteLine("Введите описание журнала:");
            description = Console.ReadLine();
        }

        public void EnterPhoneNumber()
        {
            Console.WriteLine("Введите контактный телефон:");
            phonenumber = Console.ReadLine();
        }

        public void EnterEmail()
        {
            Console.WriteLine("Введите контактный email:");
            email = Console.ReadLine();
        }

        // методы для вывода данных
        public void DisplayInfo()
        {
            Console.WriteLine($"Название журнала: {name}");
            Console.WriteLine($"Год основания: {year}");
            Console.WriteLine($"Описание журнала: {description}");
            Console.WriteLine($"Контактный телефон: {phonenumber}");
            Console.WriteLine($"Контактный email: {email}");
        }

        // методы для доступа к отдельным полям через методы класса
        public string GetName()
        {
            return name;
        }

        public int GetYear()
        {
            return year;
        }

        public string GetDescription()
        {
            return description;
        }

        public string GetPhoneNumber()
        {
            return phonenumber;
        }

        public string GetEmail()
        {
            return email;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            journal.EnterName();
            journal.EnterYear();
            journal.EnterDescription();
            journal.EnterPhoneNumber();
            journal.EnterEmail();

            Console.WriteLine("Данные журнала:");
            journal.DisplayInfo();
        }
    }


}


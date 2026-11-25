using System;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
//Вариант 1
//•  Создайте класс Phone, который содержит переменные number, model и weight. 
//•  Создайте три экземпляра этого класса.  
//•  Выведите на консоль значения их переменных.  
//•  Добавить в класс Phone методы: receiveCall, имеет один параметр – имя звонящего. Выводит на консоль сообщение “Звонит {name}”. Метод getNumber – возвращает номер телефона. Вызвать эти методы для каждого из объектов. 
//•  Добавить конструктор в класс Phone, который принимает на вход три параметра для инициализации переменных класса - number, model и weight.  
//•  Создать метод sendMessage с аргументами переменной длины. Данный метод принимает на вход номера телефонов, которым будет отправлено сообщение. Метод выводит на консоль номера этих телефонов.

namespace ConsoleApp1
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Phone Phone1 = new Phone();

            Console.WriteLine($"Phone1: Number: {Phone1.Number}"); 
            Console.WriteLine($"Phone1  Model: {Phone1.Model}");
            Console.WriteLine($"Phone1: Weight: {Phone1.Weight}");
            Console.WriteLine($"Phone1: getNumber: {Phone1.getNumber()}");
            Console.WriteLine();

            Phone Phone2 = new Phone("+7914999111", "Xiomi", 30 );

            Console.WriteLine($"Phone2: Number: {Phone2.Number}");
            Console.WriteLine($"Phone2  Model: {Phone2.Model}");
            Console.WriteLine($"Phone2: Weight: {Phone2.Weight}");
            Console.WriteLine($"Phone2: getNumber: {Phone2.getNumber()}");
            Console.WriteLine();

            Phone2.sendMessage("111", "222");
        }
    }

    public class Phone
    {
        private string number;
        private string model;
        private int weight;
        public string Number
        {
            get => number;
            set => number = value;
        }
        public string Model
        {
            get => model;
            set => model = value;
        }
        public int Weight
        {
            get => weight;
            set => weight = value;
        }

        public Phone()
        {
            number = "+7914999888";
            model = "iPhone";
            weight = 20;
        }
        public Phone(string number, string model, int weight)
        {
            this.number = number;
            this.model = model;
            this.weight = weight;
        }

        public void receiveCall(string name)
        {
            Console.WriteLine($"Звонит {name}");
        }
        public string getNumber()
        {
            return number;
        }
        public void sendMessage(params string[] nums)
        {
            int i = 0;
            foreach (string n in nums)
            {
                i += 1;
                Console.WriteLine($"{i} тел. {n}");
            }
            
        }
    }
}

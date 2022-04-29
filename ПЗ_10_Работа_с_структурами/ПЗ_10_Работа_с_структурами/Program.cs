﻿using System;

namespace ПЗ_10_Работа_С_СТРУКТУРАМИ
{
    struct NOTE
    {
        public int TELE;      //поле телефона
        public string NAME; //поле имени, фамилии
        public string BDAY; //массив из трёх чисел

        public void Show() //метод структуры
        {
            Console.WriteLine($"Номер телефона {NAME}: {TELE} , день рождения {BDAY}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            NOTE pupil1 = new NOTE();     //создание экземпляра структуры
            NOTE[] BLOCKNOTE = new NOTE[8];
            Console.WriteLine("Запись данных людей в массив структур");
            for (int i = 0; i < BLOCKNOTE.Length; i++)
            {
                Console.WriteLine("Имя пользователя");
                BLOCKNOTE[i].NAME = Console.ReadLine(); //запись в поле структуры
                Console.WriteLine("номер телефона");
                BLOCKNOTE[i].TELE = Convert.ToInt32(Console.ReadLine()); //запись в поле структуры
                Console.WriteLine("ввод даты");
                BLOCKNOTE[i].BDAY = Console.ReadLine();
                Console.WriteLine("____________________________________________");
            }
            

            Console.WriteLine("Кого хотите найти. Введите имя");
            string person = Console.ReadLine();

            for (int i = 0; i < BLOCKNOTE.Length; i++)
            {
                pupil1.NAME = BLOCKNOTE[i].NAME;
                pupil1.BDAY = BLOCKNOTE[i].BDAY;
                pupil1.TELE = BLOCKNOTE[i].TELE;
                if (BLOCKNOTE[i].NAME == person)
                {
                    pupil1.Show();
                }
                else
                {
                    //тут короче баг(выводит 2 строчки, первая "Такого пользователя нет", а вторая в зависимости от результата сравнения либо по-новой, либо строчку с данными). Не знаю как фиксить
                    Console.WriteLine("Такого пользователя нет");
                }
            }
            Console.WriteLine("____________________________________________");

        }
    }
}

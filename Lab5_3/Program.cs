using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            DocumentWorker documentWorker = new DocumentWorker();

            Console.WriteLine("Наразі Ви використовуєте безконштовну версію програми" + "\nЩоб отримати розширений доступ до програми потрібен активації." + "\nПродовжити?(y/n)");

            if (Console.ReadLine() == "y")
            {
                Console.WriteLine("Введіть ключ активації продукту:");
                string key = Console.ReadLine();
                if (key == documentWorker.ExpertKey)
                {
                    ExpertDocumentWorker expertDocumentWorker = new ExpertDocumentWorker();
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Продукт успішно активовано до версіі Expert.");
                        Console.WriteLine("Обреріть дію." + "\nНатисніть 1 для Відкриття файлу" + "\nНатисніть 2 для Правки файлу" + "\nНатисніть 3 для Збереження файлу");
                        string answer = Console.ReadLine();
                        switch (answer)
                        {
                            case "1":
                                expertDocumentWorker.OpenDocument();
                                break;
                            case "2":
                                expertDocumentWorker.EditDocument();
                                break;
                            case "3":
                                expertDocumentWorker.SaveDocument();
                                break;
                            default:
                                Console.WriteLine("Невірная дія.");
                                break;
                        }
                        Console.ReadLine();
                    }
                    return;
                }
                if (key == documentWorker.ProKey)
                {
                    ProDocumentWorker proDocumentWorker = new ProDocumentWorker();
                    while (true)
                    {
                        Console.Clear();
                    Console.WriteLine("Продукт успішно активовано до версіі Pro.");
                        Console.WriteLine("Обреріть дію." + "\nНатисніть 1 для Відкриття файлу" + "\nНатисніть 2 для Правки файлу" + "\nНатисніть 3 для Збереження файлу");
                        string answer = Console.ReadLine();
                        switch (answer)
                        {
                            case "1":
                                proDocumentWorker.OpenDocument();
                                break;
                            case "2":
                                proDocumentWorker.EditDocument();
                                break;
                            case "3":
                                proDocumentWorker.SaveDocument();
                                break;
                            default:
                                Console.WriteLine("Невірная дія.");
                                break;
                        }
                        Console.ReadLine();
                    }
                    return;
                }
                else
                {
                    Console.WriteLine("Помилка! Хибний ключ активаціі.");
                    Console.WriteLine("Сбій активації продукту.");

                }
            }
            else
            {
                while (true)
                {
                    Console.Clear();
                Console.WriteLine("Обреріть дію." + "\nНатисніть 1 для Відкриття файлу" + "\nНатисніть 2 для Правки файлу" + "\nНатисніть 3 для Збереження файлу");
                string answer = Console.ReadLine();
                    switch (answer)
                    {
                        case "1":
                            documentWorker.OpenDocument();
                            break;
                        case "2":
                            documentWorker.EditDocument();
                            break;
                        case "3":
                            documentWorker.SaveDocument();
                            break;
                        default:
                            Console.WriteLine("Невірная дія.");
                            break;
                    }
                        Console.ReadLine();
                }
            }

        }
    }
}

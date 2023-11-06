using System.Transactions;

namespace Less_8_Itogi_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answerUser;
            string pathDir;
            Console.WriteLine("Уважаемый пользователь!");
            Console.WriteLine("Вы вошли в программу, которая подсчитывает размер (объем памяти) директории на  диске!");
            Console.Write("Вы хотите продолжить? (Ответте ДА или нажмите любую клавишу): ");
            answerUser = Console.ReadLine();

            if (answerUser == "ДА")
            {
                Console.Write("Введите путь до нужной папки: ");
                pathDir = Console.ReadLine();

                try
                {
                    if (Directory.Exists(pathDir))
                    {
                        CalculateVolume calculateVolume = new CalculateVolume();
                        Console.WriteLine("Занимаемый объем составляет " + calculateVolume.calcVol(pathDir) + " байт");
                        calculateVolume.calcVol(pathDir);
                    }
                    else
                    {
                        Console.WriteLine("По данному адресу указанной папки не обнаружено! Перезапустите программу!");
                    }
                }
                catch
                {
                    Console.WriteLine("Вы ввели некоректный адрес или возможна другая ошибка! Пожаллуйста перезапустите программу!");
                }
            }
            else 
            {
                Console.WriteLine("Нажмите любую клавишу для  выхода их программы!");
                Console.ReadKey();
            }

        }
    }
}
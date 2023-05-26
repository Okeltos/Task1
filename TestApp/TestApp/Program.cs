using System;
namespace TestApp
{
    class Program
    {  
        static void Main(string[] args) 
        {
            // Task 1
            string nameString = "hello";
            string nameString2 = "world";
            Console.WriteLine(nameString + nameString2);

            //Task 2 
            int userNumber = 12;
            int userNumber2 = 2;
            Console.WriteLine(userNumber + userNumber2);
            Console.WriteLine(userNumber - userNumber2);
            Console.WriteLine(userNumber * userNumber2);
            Console.WriteLine(userNumber / userNumber2);
            // Task 3
            Console.WriteLine("Введите имя");
            string userName = Console.ReadLine();
            Console.WriteLine("Введите Фамилию");
            string userSurname = Console.ReadLine();
            Console.WriteLine("Введите отчество");
            string userFaName = Console.ReadLine();
            Console.WriteLine($"{userName} {userSurname} {userFaName}");
            // Task 4
            int userHealh = 100;
            int userArmor = 24;
            int userDamage = 4;
            int mobHealh = 360; 
            int mobArmor = 10;
            int mobDamage = 12;
            userHealh += userArmor;
            userHealh = userHealh - mobDamage;
            Console.WriteLine("Здоровье игрока: {0}", userHealh);
            Console.WriteLine("Здоровье монстра: {0}", mobHealh);
            Console.WriteLine("Урон от игрока: {0}", userDamage);
            Console.WriteLine("Урон от монстра:{0}", mobDamage);
        }
    }
}
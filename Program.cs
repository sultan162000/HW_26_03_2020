using System;

namespace HW_26_03
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////Задача который решили в классе
            /* 
            decimal userBalance = 300m;
            string basket = "";
            start:
            Console.WriteLine($"Ваш баланс - {userBalance}");
            if(userBalance<=0){
                Console.WriteLine("У вас недостаточно средств");
                goto End;
            }

            Console.Write(""+
            "1. Кола - 10 сомон\n"+
            "2. Чипсы - 14 сомон\n"+
            "3. M&Ms - 6 сомон\n"+
            "4. Snikers - 7 сомон\n"+
            "5. Орд - 190 сомон\n"+
            "Выберите по индексу: "
            );

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                {
                    if(userBalance - 10 >= 0){
                    basket += "Кола, ";
                    userBalance -= 10;
                    }else{
                        Console.WriteLine("НЕдостаточно средст");
                        goto End;
                    }
                    Console.Write("Вы хотите продолжите? д/н");
                    if(Console.ReadLine().ToLower()=="д")goto start;
                    else goto End;

                }
                case 2:
                {
                    if(userBalance - 14 >= 0){
                    basket += "Чипсы, ";
                    userBalance -= 14;
                    }else{
                        Console.WriteLine("НЕдостаточно средст");
                        goto End;
                    }
                    Console.Write("Вы хотите продолжите? д/н");
                    if(Console.ReadLine().ToLower()=="д")goto start;
                    else goto End;

                }
                case 3:
                {
                    if(userBalance - 6 >= 0){
                    basket += "M&Ms, ";
                    userBalance -= 6;
                    }else{
                        Console.WriteLine("НЕдостаточно средст");
                        goto End;
                    }
                    Console.Write("Вы хотите продолжите? д/н");
                    if(Console.ReadLine().ToLower()=="д")goto start;
                    else goto End;

                }
                case 4:
                {
                    if(userBalance - 7 >= 0){
                    basket += "Snikers, ";
                    userBalance -= 7;
                    }else{
                        Console.WriteLine("НЕдостаточно средст");
                        goto End;
                    }
                    Console.Write("Вы хотите продолжите? д/н");
                    if(Console.ReadLine().ToLower()=="д")goto start;
                    else goto End;
                }
                case 5:
                {
                    if(userBalance - 190 >= 0){
                    basket += "Орд, ";
                    userBalance -= 190;
                    }else{
                        Console.WriteLine("НЕдостаточно средст");
                        goto End;
                    }
                    Console.Write("Вы хотите продолжите? д/н: ");
                    if(Console.ReadLine().ToLower()=="д")goto start;
                    else goto End;
                }
                default:
                goto start;
                
            }
            
            End:
            Console.Write($"Ваша покупка: {basket}\nВаш баланс {userBalance}");
            */

            /////////////// Задание 2
            
            double userBalance = 666;
            double disc = 0;
            if(userBalance >= 500 && userBalance < 1000)
            disc = userBalance * 3 / 100;
            else if(userBalance >= 1000)
            disc = userBalance * 5 /100;
            else Console.WriteLine("В вашей сумме не полагается скидка.");

            Console.WriteLine($"Ваша скидка {disc}");
            /////////////////////////////
            //////////////// Задача 3
            int a = 66, b = 84, c = 15, d = 43;
            int min = a;

            if(a==b&&a==c&&a==d)Console.WriteLine(a*b*c*d);
            else if(a<b&&b<c&&c<d)Console.WriteLine("Числа расположены по возрастанию");
            else{
                if(b<min)min = b;
                if(c<min)min = c;
                if(d<min)min = d;
                Console.WriteLine($"Мин. число: {min}");
            }
            //////////////////////////
            /////////////Задача 4
            int a1 = 5, b1 = 10, c1 =15;
            int max = a1, min1 = a1;
            int mid = a1;

            if(b1>max)max = b1;
            if(c1>max)max = c1;

            if(b1<min1)min1 = b1;
            if(c1<min1)min1 = c1;

            if(a1!=max&&a1!=min1)mid = a1;
            if(b1!=max&&b1!=min1)mid = b1;
            if(c1!=max&&c1!=min1)mid = c1;


            a1 = max;
            b1 = mid;
            c1 = min1;
            Console.WriteLine(a1+" "+b1+" "+c1);


            Console.ReadKey();
        }
    }
}
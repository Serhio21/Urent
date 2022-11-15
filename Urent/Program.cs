static class MyClass
{
    static byte minute, straxovka;
    static int tarif, scooter, i, sum, discount, pass;
    static int[] arrScoot;
    static string[] arrPromo = { "Promo2022", "Serhio", "PROMO" };
    static string choose, promo, promo2, login;
    static void Main()
    {
        Enter();

        for (i = 1; i <= scooter; i++)
        {
            Straxovka();
            Tarif();
            Travel();

            arrScoot[i] = straxovka + (minute * tarif);
            sum += arrScoot[i];
            Console.WriteLine($"Сумма за поездку на самокате = {arrScoot[i]}");
            Console.WriteLine();
        }
        Promo();

    }

    static void Enter()
    {
        Console.WriteLine("Вход в аккаунт");
        Console.Write("Введите имя пользователя: ");
        login = Console.ReadLine();
        Console.Write("Введите пароль: ");
        pass = int.Parse(Console.ReadLine());

        if(login == "Sergei" && pass == 21)
            {
            Console.Clear();
            Hello();
            }
        else
        {
            Console.WriteLine("Аккаунта с такими данными нет. Попробуйте еще раз!");
            Enter();
        }

    }

    static void Hello()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("WELCOME TO URENT");
        Console.WriteLine();
        Console.ResetColor();

        Console.WriteLine($"Сколько самокатов вы хотите взять?");

        scooter = int.Parse(Console.ReadLine());
        Console.WriteLine();

        arrScoot = new int[scooter + 1];

    }

    static void Tarif()
    {
        Random rand = new Random();
        tarif = rand.Next(6, 8);
        Console.WriteLine($"Тариф: {tarif} рублей в минуту");
    }

    static void Straxovka()
    {
        Console.WriteLine($"Вы хотите взять страховку для {i}-ого самоката?");
        string msg = Console.ReadLine();

        if (msg == "Да" || msg == "да")
        {
            straxovka = 35;
            Console.WriteLine($"Страховка = {straxovka}");
        }
        else if (msg == "Нет" || msg == "нет")
        {
            straxovka = 0;
            Console.WriteLine($"Страховка = {straxovka}");

        }

    }

    static void Travel()
    {
        Console.Write("Катаемся");

        for (int i = 0; i < 10; i++)
        {
            Console.Write('.');
            Thread.Sleep(200);
        }

        Console.WriteLine("\nВведите сколько вы проехали на самокате в минутах: ");
        minute = byte.Parse(Console.ReadLine());
    }

    static void Promo()
    {
        Console.WriteLine("Есть ли у вас промокод?");
        promo = Console.ReadLine();

        if (promo == "Да" || promo == "да")
        {
            Console.WriteLine("Ввдеите промокод: ");
            promo2 = Console.ReadLine();
            for (int i = 0; i < arrPromo.Length; i++)
            {
                if (promo2 == arrPromo[i])
                {
                    discount = 100;
                    Console.WriteLine($"Ваша скидка = {discount}%");
                    sum = 0;
                    Console.WriteLine($"Сумма к оплате = {sum}");
                    i = arrPromo.Length;
                }
            }
            if (promo2 != arrPromo[i])
            {
                Console.WriteLine("Такого промокода не существует!");
                Console.WriteLine($"Сумма к оплате = {sum}");
            }
        }
        else if (promo == "Нет" || promo == "нет")
        {
            Console.WriteLine($"Сумма к оплате {sum} рублей");
        }
        Console.ReadKey();
    }

}
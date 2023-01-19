using System;

namespace blackjack
{
    class Program
    {
        /// <summary>
        /// Выбирает карту
        /// </summary>
        /// <returns></returns>

        static string Cards()
        {
            Random rand = new Random();
            string[,] cards;
            cards = new string[4, 13];

            //Бубы
            cards[0, 0] = "ace";
            cards[0, 1] = "two";
            cards[0, 2] = "three";
            cards[0, 3] = "four";
            cards[0, 4] = "five";
            cards[0, 5] = "six";
            cards[0, 6] = "seven";
            cards[0, 7] = "eight";
            cards[0, 8] = "nine";
            cards[0, 9] = "ten";
            cards[0, 10] = "jack";
            cards[0, 11] = "queen";
            cards[0, 12] = "king";

            //Черви
            cards[1, 0] = "ace";
            cards[1, 1] = "two";
            cards[1, 2] = "three";
            cards[1, 3] = "four";
            cards[1, 4] = "five";
            cards[1, 5] = "six";
            cards[1, 6] = "seven";
            cards[1, 7] = "eight";
            cards[1, 8] = "nine";
            cards[1, 9] = "ten";
            cards[1, 10] = "jack";
            cards[1, 11] = "queen";
            cards[1, 12] = "king";

            //Трефы 
            cards[2, 0] = "ace";
            cards[2, 1] = "two";
            cards[2, 2] = "three";
            cards[2, 3] = "four";
            cards[2, 4] = "five";
            cards[2, 5] = "six";
            cards[2, 6] = "seven";
            cards[2, 7] = "eight";
            cards[2, 8] = "nine";
            cards[2, 9] = "ten";
            cards[2, 10] = "jack";
            cards[2, 11] = "queen";
            cards[2, 12] = "king";

            //Пики
            cards[3, 0] = "ace";
            cards[3, 1] = "two";
            cards[3, 2] = "three";
            cards[3, 3] = "four";
            cards[3, 4] = "five";
            cards[3, 5] = "six";
            cards[3, 6] = "seven";
            cards[3, 7] = "eight";
            cards[3, 8] = "nine";
            cards[3, 9] = "ten";
            cards[3, 10] = "jack";
            cards[3, 11] = "queen";
            cards[3, 12] = "king";

            string card = cards[rand.Next(0, 4), rand.Next(0, 13)];

            if (card == "ace")
            {
                //Console.WriteLine("Выпал Туз");
                return "ace";


            }
            if (card == "two")
            {
                //Console.WriteLine("Выпало Два");
                return "two";
            }
            if (card == "three")
            {
                //Console.WriteLine("Выпало Три");
                return "three";
            }
            if (card == "four")
            {
                //Console.WriteLine("Выпало Четыре");
                return "four";
            }
            if (card == "five")
            {
                //Console.WriteLine("Выпало Пять");
                return "five";
            }
            if (card == "six")
            {
                //Console.WriteLine("Выпало Шесть");
                return "six";
            }
            if (card == "seven")
            {
                //Console.WriteLine("Выпало Семь");
                return "seven";
            }
            if (card == "eight")
            {
                //Console.WriteLine("Выпало Восем");
                return "eight";
            }
            if (card == "nine")
            {
                //Console.WriteLine("Выпало Девять");
                return "nine";
            }
            if (card == "ten")
            {
                //Console.WriteLine("Выпало Десять");
                return "ten";
            }
            if (card == "jack")
            {
                //Console.WriteLine("Выпал Валет");
                return "jack";
            }
            if (card == "queen")
            {
                //Console.WriteLine("Выпала Дама");
                return "queen";
            }
            else
            {
                //Console.WriteLine("Выпал Король");
                return "king";
            }

        }

        /// <summary>
        /// Считает номер карты
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        static int numofcard(string result)
        {
            if (result == "ace")
            {
                return 1;
            }
            else if (result == "two")
            {
                return 2;
            }
            else if (result == "three")
            {
                return 3;
            }
            else if (result == "four")
            {
                return 4;
            }
            else if (result == "five")
            {
                return 5;
            }
            else if (result == "six")
            {
                return 6;
            }
            else if (result == "seven")
            {
                return 7;
            }
            else if (result == "eight")
            {
                return 8;
            }
            else if (result == "nine")
            {
                return 9;
            }
            else if (result == "ten")
            {
                return 10;
            }
            else if (result == "jack")
            {
                return 10;
            }
            else if (result == "queen")
            {
                return 10;
            }
            else if (result == "king")
            {
                return 10;
            }
            return 0;
        }

        static void Main()
        {
            int Diller = 0;
            int Player = 0;
            int resultnum = 0;
            for (int i = 0; ; i++)
            {
                for (int j = 0; ; j++)
                {
                    string result = "";


                    result = Cards();

                    resultnum = numofcard(result);

                    Console.WriteLine("Первая карта Игрока: " + result);
                    if (resultnum == 1)
                    {
                        Console.Write("Выберите 1 или 11: ");
                        resultnum = Convert.ToInt32(Console.ReadLine());

                    }
                    Player = Player + resultnum;
                    Console.WriteLine("Игрок: " + Player);

                    if (Player > 21)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Выйграл Диллер!");

                        Diller = 0;
                        Player = 0;
                        break;
                    }


                    result = Cards();

                    resultnum = numofcard(result);


                    if (resultnum == 1)
                    {
                        if (Diller < 11)
                        {
                            Diller = Diller + 11;
                        }
                        else { Diller = Diller + resultnum; }
                    }
                    else
                    {
                        Diller = Diller + resultnum;
                    }

                    Console.WriteLine("Первая карта диллера: " + result);
                    Console.WriteLine("Диллер: " + Diller);




                    result = Cards();

                    resultnum = numofcard(result);

                    Console.WriteLine("Вторая карта Игрока: " + result);
                    if (resultnum == 1)
                    {
                        Console.Write("Выберите 1 или 11: ");
                        resultnum = Convert.ToInt32(Console.ReadLine());

                    }
                    Player = Player + resultnum;
                    Console.WriteLine("Игрок: " + Player);

                    if (Player > 21)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Выйграл Диллер!");

                        Diller = 0;
                        Player = 0;
                        break;
                    }


                    result = Cards();

                    resultnum = numofcard(result);


                    if (resultnum == 1)
                    {
                        if (Diller < 11)
                        {
                            Diller = Diller + 11;
                        }
                        else { Diller = Diller + resultnum; }
                    }
                    else
                    {
                        Diller = Diller + resultnum;
                    }

                    Console.WriteLine("Вторая карта диллера: " + result);
                    Console.WriteLine("Диллер: " + Diller);
                    resultnum = 0;





                    for (int k = 3; ; k++)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Вы хотите взять еще карту?");
                        Console.Write("Ответ: ");
                        string answer = Console.ReadLine();
                        Console.WriteLine();


                        if (answer == "Нет")
                        {
                            Console.WriteLine("Диллеру выпало: " + Diller);
                            Console.WriteLine();

                            if (Diller > Player && Diller < 22)
                            {
                                Console.WriteLine("Выйграл Диллер!");
                            }
                            else if (Diller == Player && Diller < 22)
                            {
                                Console.WriteLine("Ничия!");
                            }
                            else
                            {
                                Console.WriteLine("Выйграл Игрок!");
                            }
                            Diller = 0;
                            Player = 0;
                            break;
                        }

                        else
                        {
                            result = Cards();

                            resultnum = numofcard(result);

                            Console.WriteLine(k + " карта Игрока: " + result);
                            if (resultnum == 1)
                            {
                                Console.Write("Выберите 1 или 11: ");
                                resultnum = Convert.ToInt32(Console.ReadLine());

                            }
                            Player = Player + resultnum;
                            Console.WriteLine("Игрок: " + Player);

                            if (Player > 21)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Выйграл Диллер!");

                                Diller = 0;
                                Player = 0;
                                break;
                            }


                            result = Cards();

                            resultnum = numofcard(result);


                            if (resultnum == 1)
                            {
                                if (Diller < 11)
                                {
                                    Diller = Diller + 11;
                                }
                                else { Diller = Diller + resultnum; }
                            }
                            else
                            {
                                Diller = Diller + resultnum;
                            }

                            Console.WriteLine(k + " карта диллера: " + Diller);
                            Console.WriteLine("Диллер: " + Diller);

                        }


                        if (Diller > 21)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Выйграл Игрок!");
                            Diller = 0;
                            Player = 0;
                            break;
                        }


                    }

                    Console.WriteLine();
                    Console.WriteLine("Если хотите выйти напишите 'Exit'");
                    Console.WriteLine("Если хотите остаться для следужего раунда нажмите 'Enter'");
                    string Exit = Console.ReadLine();
                    if (Exit == "Exit")
                    {
                        break;
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                }
                break;
            }


        }
    }
}
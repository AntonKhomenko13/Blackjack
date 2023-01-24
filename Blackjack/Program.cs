using System;

namespace blackjack
{
    class Program
    {

        static string Cards()
        {
            Random rand = new Random();
            string[,] cards;
            cards = new string[4, 13];

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
                return "ace";


            }
            else if (card == "two")
            {
                return "two";
            }
            else if (card == "three")
            {
                return "three";
            }
            else if (card == "four")
            {
                return "four";
            }
            else if (card == "five")
            {
                return "five";
            }
            else if (card == "six")
            {
                return "six";
            }
            else if (card == "seven")
            {
                return "seven";
            }
            else if (card == "eight")
            {
                return "eight";
            }
            else if (card == "nine")
            {
                return "nine";
            }
            else if (card == "ten")
            {
                return "ten";
            }
            else if (card == "jack")
            {
                return "jack";
            }
            else if (card == "queen")
            {
                return "queen";
            }
            else
            {
                return "king";
            }

        }

        
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

                    //The first card of player
                    result = Cards();

                    resultnum = numofcard(result);

                    Console.WriteLine("The first card of player: " + result);
                    if (resultnum == 1)
                    {
                        for (int u = 0; ; u++)
                        {
                            Console.Write("Choose 1 or 11: ");
                            string resultstr = Console.ReadLine();
                            if (int.TryParse(resultstr, out _))
                            {
                                resultnum = Convert.ToInt32(resultstr);
                                if (resultnum == 1)
                                {
                                    break;
                                }
                                else if (resultnum == 11)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("You entered the wrong number.");
                                    continue;
                                }
                            }
                            else
                            {
                                Console.WriteLine("You entered the wrong format, numeric value is exoected.");
                                continue;
                            }
                        }

                    }
                    Player = Player + resultnum;
                    Console.WriteLine("Player: " + Player);



                    //The first card of bank
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

                    Console.WriteLine("The first card of bank: " + result);
                    Console.WriteLine("Bank: " + Diller);



                    //The second card of player
                    result = Cards();

                    resultnum = numofcard(result);

                    Console.WriteLine("The second card of player: " + result);
                    if (resultnum == 1)
                    {
                        for (int u = 0; ; u++)
                        {
                            Console.Write("Choose 1 or 11: ");
                            string resultstr = Console.ReadLine();
                            if (int.TryParse(resultstr, out _))
                            {
                                resultnum = Convert.ToInt32(resultstr);
                                if (resultnum == 1)
                                {
                                    break;
                                }
                                else if (resultnum == 11)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("You entered the wrong number.");
                                    continue;
                                }
                            }
                            else
                            {
                                Console.WriteLine("You entered the wrong format, numeric value is exoected.");
                                continue;
                            }
                        }
                    }
                    Player = Player + resultnum;
                    Console.WriteLine("Player: " + Player);


                    //The second card of bank
                    result = Cards();

                    resultnum = numofcard(result);

                    string second_card_of_bank = result;

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

                    Console.WriteLine("Bank took 2 card");
                    resultnum = 0;


                    
                    for (int k = 0; ; k++)
                    {
                        int num_of_take_card = 3;
                        Console.WriteLine();
                        Console.WriteLine("Do you want to take another card?");
                        Console.WriteLine("Yes or No");
                        Console.Write("Answer: ");
                        string answer = Console.ReadLine();
                        Console.WriteLine();

                        
                        if (answer.ToLower() == "no")
                        {
                            Console.WriteLine("The second card of bank: " + second_card_of_bank);
                            Console.WriteLine("Bank: " + Diller);
                            Console.WriteLine();
                            for (int o = 0; ; o++)
                            {
                                if (Diller < 16)
                                {
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

                                    Console.WriteLine("The " + num_of_take_card + " card of bank: " + result);
                                    Console.WriteLine("Bank: " + Diller);
                                    num_of_take_card++;
                                }
                                else break;
                            }

                            if (Diller > Player && Diller < 22)
                            {
                                Console.WriteLine("Bank win!");
                            }
                            else if (Diller == Player && Diller < 22)
                            {
                                Console.WriteLine("Draw!");
                            }
                            else
                            {
                                Console.WriteLine("Player win!");
                            }
                            Diller = 0;
                            Player = 0;
                            break;
                        }

                        // The third card of player
                        else if (answer.ToLower() == "yes")
                        {
                            result = Cards();

                            resultnum = numofcard(result);

                            Console.WriteLine("The " + num_of_take_card + " card of player: " + result);
                            if (resultnum == 1)
                            {
                                for (int u = 0; ; u++)
                                {
                                    Console.Write("Choose 1 or 11: ");
                                    string resultstr = Console.ReadLine();
                                    if (int.TryParse(resultstr, out _))
                                    {
                                        resultnum = Convert.ToInt32(resultstr);
                                        if (resultnum == 1)
                                        {
                                            break;
                                        }
                                        else if (resultnum == 11)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("You entered the wrong number.");
                                            continue;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("You entered the wrong format, numeric value is exoected.");
                                        continue;
                                    }
                                }
                            }
                            Player = Player + resultnum;
                            Console.WriteLine("Player: " + Player);

                            if (Player > 21)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Bank win!");

                                Diller = 0;
                                Player = 0;
                                break;
                            }                            
                            num_of_take_card++;
                        }
                        else
                        {
                            Console.WriteLine("There is no such answer. Try again.");

                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine("If you want to leave write 'Exit'");
                    Console.WriteLine("If you want to stay for a next round click 'Enter'");
                    string Exit = Console.ReadLine();
                    if (Exit == "Exit")
                    {
                        break;
                    }

                    for (int writeline = 0; writeline < 5; writeline++)
                    {
                        Console.WriteLine();
                    }


                }
                break;
            }


        }
    }
}
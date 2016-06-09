using System;

namespace _4.Print_a_Deck_of_52_Cards
{
    class PrintADeckof52Cards
    {
        static void Main()
        {

            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            int colors = 4;
            int setOfCards = 13;

            for (int i = 0; i < setOfCards; i += 1)
            {
                string card = cards[i];

                for (int j = 1; j <= colors; j += 1)
                {
                    switch (j)
                    {
                        case 1: Console.Write("{0,2}\u2663", card);
                            break;
                        case 2: Console.Write("{0,2}\u2666", card);
                            break;
                        case 3: Console.Write("{0,2}\u2665", card);
                            break;
                        case 4: Console.WriteLine("{0,2}\u2660", card);
                            break;
                        default:
                            break;
                    }
                }
            }

            //string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            //string[] colors = { "of Clubs", "of Diamonds", "of Hearts", "of Spades" };

            //for (int i = 2; i < cards.Length; i++)
            //{
            //    for (int y = 0; y <= colors.Length; y++)
            //    {
            //        switch (i)
            //        {
            //            case 2:
            //                Console.Write("Two card ");
            //                break;
            //            case 3:
            //                Console.Write("Three card ");
            //                break;
            //            case 4:
            //                Console.Write("Four card ");
            //                break;
            //            case 5:
            //                Console.Write("Five card ");
            //                break;
            //            case 6:
            //                Console.Write("Six card ");
            //                break;
            //            case 7:
            //                Console.Write("Seven card ");
            //                break;
            //            case 8:
            //                Console.Write("Eight card ");
            //                break;
            //            case 9:
            //                Console.Write("Nine card ");
            //                break;
            //            case 10:
            //                Console.Write("Ten card ");
            //                break;
            //            case 11:
            //                Console.Write("Jack card ");
            //                break;
            //            case 12:
            //                Console.Write("Queen card ");
            //                break;
            //            case 13:
            //                Console.Write("King card ");
            //                break;
            //            case 14:
            //                Console.Write("Ace card ");
            //                break;
            //            default:
            //                Console.WriteLine("");
            //                break;
            //        }
            //        switch (y)
            //        {
            //            case 1:
            //                Console.WriteLine(colors[0]);
            //                break;
            //            case 2:
            //                Console.WriteLine(colors[1]);
            //                break;
            //            case 3:
            //                Console.WriteLine(colors[2]);
            //                break;
            //            case 4:
            //                Console.WriteLine(colors[3]);
            //                break;
            //            default:
            //                Console.WriteLine("");
            //                break;
            //        }
            //    }
            //}
        }
    }
}

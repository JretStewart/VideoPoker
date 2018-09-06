using Azara_Video_Poker.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azara_Video_Poker
{
    class DeckOfCards
    {

        private Card[] deck;
        public const int NUMBER_OF_CARDS = 52;
        private int nCurrentCard = 0;

        /// <summary>
        /// Creates a fresh deck of cards
        /// </summary>
        public DeckOfCards()
        {
            //all faces and suits in two parallel arrays
            Image[] cardImages = { Resources.AClubs, Resources._2Clubs, Resources._3Clubs, Resources._4Clubs, Resources._5Clubs, Resources._6Clubs, Resources._7Clubs, Resources._8Clubs, Resources._9Clubs, Resources._10Clubs, Resources.JClubs, Resources.QClubs, Resources.KClubs,
                                   Resources.ASpades, Resources._2Spades, Resources._3Spades, Resources._4Spades, Resources._5Spades, Resources._6Spades, Resources._7Spades, Resources._8Spades, Resources._9Spades, Resources._10Spades, Resources.JSpades, Resources.QSpades, Resources.KSpades,
                                   Resources.AHearts, Resources._2Hearts, Resources._3Hearts, Resources._4Hearts, Resources._5Hearts, Resources._6Hearts, Resources._7Hearts, Resources._8Hearts, Resources._9Hearts, Resources._10Hearts, Resources.JHearts, Resources.QHearts, Resources.KHearts,
                                   Resources.ADiamonds, Resources._2Diamonds, Resources._3Diamonds, Resources._4Diamonds, Resources._5Diamonds, Resources._6Diamonds, Resources._7Diamonds, Resources._8Diamonds, Resources._9Diamonds, Resources._10Diamonds, Resources.JDiamonds, Resources.QDiamonds, Resources.KDiamonds};

            int[] value = { 14, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};
            string[] suit = { "Clubs", "Spades", "Hearts", "Diamonds" };

            //set deck object equal to new array of Card objects
            deck = new Card[NUMBER_OF_CARDS];

            //populate entire deck array with Card objects
            for (int i = 0; i < deck.Length; i++)
            {
                deck[i] = new Card(cardImages[i], value[i % 13], suit[i / 13]);
            }

        }//End DeckOfCards

        /// <summary>
        /// Shuffles the deck of cards
        /// </summary>
        public void ShuffleDeck()
        {
            Random randNum = new Random();
            int nSecond;
            //loop thru deck and swap every card with another randomly picked card
            for (int nFirst = 0; nFirst < deck.Length; nFirst++)
            {
                nSecond = randNum.Next(NUMBER_OF_CARDS);

                //Swap card at nFirst with card at nSecond
                Card temp = deck[nFirst];
                deck[nFirst] = deck[nSecond];
                deck[nSecond] = temp;
            }//End for loop

        }//End ShuffleDeck

        /// <summary>
        /// Deals Cards
        /// </summary>
        /// <returns></returns>
        public Card DealCard()
        {
            if (nCurrentCard < deck.Length)
            {
                return deck[nCurrentCard++];
            }
            else
            {
                return null;
            }
        }//End DealCard
        //Imported from Jason Monroe
    }//End class
}//End namespace

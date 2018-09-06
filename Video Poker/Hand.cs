using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azara_Video_Poker
{
    class Hand
    {
        Card cardA, cardB, cardC, cardD, cardE;
        int nBet;
        int nWinnings;

        List<int> lstWinnings;
        List<int> hand;
        /// <summary>
        /// Sets the hand to test based on the Card being displayed
        /// </summary>
        /// <param name="card1"></param>
        /// <param name="card2"></param>
        /// <param name="card3"></param>
        /// <param name="card4"></param>
        /// <param name="card5"></param>
        public void setHand(Card card1, Card card2, Card card3, Card card4, Card card5, int nSetBet)
        {
            cardA = card1;
            cardB = card2;
            cardC = card3;
            cardD = card4;
            cardE = card5;
            hand = new List<int> { card1.nValue, card2.nValue, card3.nValue, card4.nValue, card5.nValue };
            hand.Sort();
            nBet = nSetBet;
        }//End setHand AA && JS

        /// <summary>
        /// Check to if there is a winning hand
        /// </summary>
        /// <returns></returns>
        public string checkHand()
        {
            switch (nBet)
            {
                case 1:
                    lstWinnings = new List<int> { 800, 50, 25, 8, 6, 4, 3, 2, 1 };
                    break;
                case 2:
                    lstWinnings = new List<int> { 1600, 100, 50, 16, 12, 8, 6, 4, 2 };
                    break;
                case 3:
                    lstWinnings = new List<int> { 2400, 150, 75, 24, 18, 12, 9, 6, 3 };
                    break;
                case 4:
                    lstWinnings = new List<int> { 3200, 200, 100, 32, 24, 16, 12, 8, 4 };
                    break;
                case 5:
                    lstWinnings = new List<int> { 4000, 250, 125, 40, 30, 20, 15, 10, 5 };
                    break;
            }//End switch AA

            if (isRoyalFlush())
            {
                nWinnings = lstWinnings.ElementAt(0);
                return "Royal Flush: " + nWinnings.ToString();
            }
            else if (isStraightFlush())
            {
                nWinnings = lstWinnings.ElementAt(1);
                return "Straight Flush: " + nWinnings.ToString();
            }
            else if (isFourOfKind())
            {
                nWinnings = lstWinnings.ElementAt(2);
                return "Four of a Kind: " + nWinnings.ToString();
            }
            else if (isFullHouse())
            {
                nWinnings = lstWinnings.ElementAt(3);
                return "Full House: " + nWinnings.ToString();
            }
            else if (isFlush())
            {
                nWinnings = lstWinnings.ElementAt(4);
                return "Flush: " + nWinnings.ToString();
            }
            else if (isStraight())
            {
                nWinnings = lstWinnings.ElementAt(5);
                return "Straight: " + nWinnings.ToString();
            }
            else if (isThreeOfKind())
            {
                nWinnings = lstWinnings.ElementAt(6);
                return "Three of a Kind: " + nWinnings.ToString();
            }
            else if (isTwoPair())
            {
                nWinnings = lstWinnings.ElementAt(7);
                return "Two Pair: " + nWinnings.ToString();
            }
            else if (isPair())
            {
                nWinnings = lstWinnings.ElementAt(8);
                return "Pair: " + nWinnings.ToString();
            }
            else
            {
                nWinnings = 0;
                return "No Winning Hand!";
            }
        }//End checkHand AA && JS

        /// <summary>
        /// Adds winnings to amount displayed
        /// </summary>
        /// <returns></returns>
        public int setWinnings()
        {
            return nWinnings; 
        }//End setWinnings

        /// <summary>
        /// Returns true if player has pair
        /// </summary>
        /// <returns></returns>
        private bool isPair()
        {
            
            if (hand.ElementAt(0) == hand.ElementAt(1) || hand.ElementAt(1) == hand.ElementAt(2) || hand.ElementAt(2) == hand.ElementAt(3) || hand.ElementAt(3) == hand.ElementAt(4))
            {
                return true;
            }
            else
            {
                return false;
            }
        }//End isPair AA && JS

        /// <summary>
        /// Returns true if player has two pair
        /// </summary>
        /// <returns></returns>
        private bool isTwoPair()
        {
           
            if (hand.ElementAt(0) == hand.ElementAt(1) && hand.ElementAt(2) == hand.ElementAt(3) || hand.ElementAt(0) == hand.ElementAt(1) && hand.ElementAt(3) == hand.ElementAt(4) || hand.ElementAt(1) == hand.ElementAt(2) && hand.ElementAt(3) == hand.ElementAt(4))
            {
                return true;
            }
           
            else
            {
                return false;
            }

        }//End isTwoPair AA && JS

        /// <summary>
        /// Returns true if player has Three of a Kind
        /// </summary>
        /// <returns></returns>
        private bool isThreeOfKind()
        {
            if (hand.ElementAt(0)==hand.ElementAt(1) && hand.ElementAt(1) ==hand.ElementAt(2)|| hand.ElementAt(1) == hand.ElementAt(2) && hand.ElementAt(2) == hand.ElementAt(3)|| hand.ElementAt(2) == hand.ElementAt(3) && hand.ElementAt(3) == hand.ElementAt(4))
            {
                return true;
            }
            else
            {
                return false;
            }
        }//End isThreeOfKind AA && JS

        /// <summary>
        /// Returns true if player has a Straight
        /// </summary>
        /// <returns></returns>
        private bool isStraight()
        {
            
            if ((hand.ElementAt(4) - 13 == hand.ElementAt(0) - 1) && (hand.ElementAt(0) == hand.ElementAt(1) - 1) && (hand.ElementAt(1) == hand.ElementAt(2) - 1) && (hand.ElementAt(2) == hand.ElementAt(3) - 1))
            {
                return true;
            }
            else if ((hand.ElementAt(0) == hand.ElementAt(1) - 1) && (hand.ElementAt(1) == hand.ElementAt(2) - 1) && (hand.ElementAt(2) == hand.ElementAt(3) - 1) && (hand.ElementAt(3) == hand.ElementAt(4) - 1))
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }//End isStraight AA

        /// <summary>
        /// Returns true if player has a flush
        /// </summary>
        /// <returns></returns>
        private bool isFlush()
        {
            if (cardA.strSuit == cardB.strSuit && cardB.strSuit == cardC.strSuit && cardC.strSuit == cardD.strSuit && cardD.strSuit == cardE.strSuit)
            {
                return true;
            }
            else
            {
                return false;
            }

        }//End isFlush AA && JS

        /// <summary>
        /// Returns true if player has full house
        /// </summary>
        /// <returns></returns>
        private bool isFullHouse()
        {
            if (hand.ElementAt(0)==hand.ElementAt(1) && hand.ElementAt(1) == hand.ElementAt(2) && hand.ElementAt(3) == hand.ElementAt(4))
            {
                return true;
            }
            else if (hand.ElementAt(0) == hand.ElementAt(1) && hand.ElementAt(2) == hand.ElementAt(3) && hand.ElementAt(3) == hand.ElementAt(4))
            {
                return true;
            }
            else
            {
                return false;
            }
        }//End isFullHouse AA && JS

        /// <summary>
        /// Returns true if player has Four of a Kind
        /// </summary>
        /// <returns></returns>
        private bool isFourOfKind()
        {

            if (hand.ElementAt(0) == hand.ElementAt(1) && hand.ElementAt(1) == hand.ElementAt(2) && hand.ElementAt(2) == hand.ElementAt(3))
            {
                return true;
            }
            else if (hand.ElementAt(1) == hand.ElementAt(2) && hand.ElementAt(2) == hand.ElementAt(3) && hand.ElementAt(3) == hand.ElementAt(4))
            {
                return true;
            }
            else
            {
                return false;
            }
        }//End isFourOfKind AA && JS

        /// <summary>
        /// Returns true if the player has a straight flush
        /// </summary>
        /// <returns></returns>
        private bool isStraightFlush()
        {
            if (isFlush() && isStraight())
            {
                return true;
            }
            else
            {
                return false;
            }
        }//End isStraightFlush AA && JS

        /// <summary>
        /// Returns true if the player has a royal flush
        /// </summary>
        /// <returns></returns>
        private bool isRoyalFlush()
        {
            if ((cardA.nValue >= 10 && cardA.nValue <= 14) && (cardB.nValue >= 10 && cardB.nValue <= 14) && (cardC.nValue >= 10 && cardC.nValue <= 14) && (cardD.nValue >= 10 && cardD.nValue <= 14) && (cardE.nValue >= 10 && cardE.nValue <= 14) && isFlush())
            {
                return true;
            }
            else
            {
                return false;
            }
        }//End isRoyalFlush AA && JS
    }//End class
}//End namespace

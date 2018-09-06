using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
AA
*/
namespace Azara_Video_Poker
{
    class Poker
    {
        //Instance variables
        DeckOfCards newDeck = new DeckOfCards();
        public List<Card> deckCard = new List<Card>();
        int cardIndex = 52;

        public Poker()
        {
            //Shuffle deck
            newDeck.ShuffleDeck();

            //Gives the cards to the "dealer"
            for (int i = 0; i < cardIndex; i++)
            {
                deckCard.Add(newDeck.DealCard());
            }
        }//End Poker
    }//End class
}//End namespace

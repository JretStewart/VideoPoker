using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azara_Video_Poker
{
    class Card
    {
        /// <summary>
        /// Gets and sets the Card Image
        /// </summary>
        public Image CardImage { get; set; }

        /// <summary>
        /// Gets and Sets the Value of the card 14 = Ace, 13 = King, etc...
        /// </summary>
        public int nValue { get; set; }

        /// <summary>
        /// Gets and Sets the Suit of the card
        /// </summary>
        public string strSuit { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Card() { }

        public Card(Image card, int value, string suit)
        {
            CardImage = card;
            nValue = value;
            strSuit = suit;
        }
        //Imported from Jason Monroe
    }//End class
}//End namespace

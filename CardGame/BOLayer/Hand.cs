using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Kyra Bolster
 * OOP - Card Game
 * April 12, 2020
 */
namespace BOLayer
{
    public class Hand
    {
        private List<Card> cards = new List<Card>();

        public int Count
        {
            get
            {
                return cards.Count();
            }
        }

        public Card this[int index]
        {
            get
            {
                return cards[index];
            }
        }

        public void AddCard(Card newCard)
        {
            if (ContainsCard(newCard))
            {
                throw new ConstraintException(newCard.FaceValue.ToString() + " of " +
                    newCard.Suit.ToString() + " already exists in the Hands");
            }

            cards.Add(newCard);
        }


        private bool ContainsCard(Card cardToCheck)
        {
            return cards.Where(card => card.FaceValue == cardToCheck.FaceValue && card.Suit == cardToCheck.Suit).Count() != 0;
        }

        /// <summary>
        /// Verify that the top card in the discard pile matches the suit or face value of the selected card
        /// </summary>
        /// <param name="selectedCard"></param>
        /// <returns></returns>
        public bool isValidDiscard(Card selectedCard)
        {
            return cards.Where(card => card.FaceValue == selectedCard.FaceValue  || card.Suit == selectedCard.Suit).Count() != 0;
        }

        public void RemoveCard(Card theCard)
        {
            if(!cards.Contains(theCard))
            {
                throw new ConstraintException(theCard.FaceValue.ToString() + " of " +
                    theCard.Suit.ToString() + " does not exist in the Hands");
            }

            cards.Remove(theCard);
        }

        /// <summary>
        /// Verify if card's face value is 8
        /// </summary>
        /// <param name="selectedCard"></param>
        /// <returns></returns>
        public bool isEight(Card selectedCard)
        {
            return (selectedCard.FaceValue == FaceValue.Eight);
        }

        public bool isTwo(Card selectedCard)
        {
            return (selectedCard.FaceValue == FaceValue.Two);
        }

        public bool isJack(Card selectedCard)
        {
            return (selectedCard.FaceValue == FaceValue.Jack);
        }

        public void RemoveCard(int index)
        {
            if (index < 0 || index > cards.Count - 1)
            {
                throw new DataException("A card does not exist at the index specified.");
            }

            cards.RemoveAt(index);
        }

        public void RemoveCard(Suit theSuit, FaceValue theFaceValue)
        {
            Card card = cards.Where(c => c.FaceValue == theFaceValue &&
                c.Suit == theSuit).FirstOrDefault();

            if(card == null)
            {
                throw new ConstraintException(theFaceValue.ToString() + " of " +
                    theSuit.ToString() + " does not exist in the hand.");
            }

            cards.Remove(card);
        }

        /// <summary>
        /// Verify if hand is empty
        /// </summary>
        /// <returns></returns>
        public bool NoCardsLeft()
        {
            return cards.Count == 0;
        }

        public void Clear()
        {
            this.cards.Clear();
        }
    }
}

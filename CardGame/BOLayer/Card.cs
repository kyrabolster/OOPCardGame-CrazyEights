﻿using System;
using System.Collections.Generic;
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
    public class Card
    {
        /// <summary>
        /// Constructs a card by passing the facevalue and suit
        /// </summary>
        /// <param name="newSuit"></param>
        /// <param name="newValue"></param>
        public Card(Suit newSuit, FaceValue newValue)
        {
            Suit = newSuit;
            FaceValue = newValue;
        }

        /// <summary>
        /// Gets the suit of the card
        /// </summary>
        public Suit Suit { get; set; }

        /// <summary>
        /// Gets the face value of the card.
        /// </summary>
        public FaceValue FaceValue { get; }
    }
}

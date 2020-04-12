using System;
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
    public enum Suit
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades
    }

    public enum FaceValue
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    /// <summary>
    /// Keep track of whose turn it is
    /// </summary>
    public enum Turn 
    { 
        Player1,
        Player2
    }
}

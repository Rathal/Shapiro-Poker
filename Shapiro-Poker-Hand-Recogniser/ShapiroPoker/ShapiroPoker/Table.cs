﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker_AI_Game
{
    class Table
    {
        List<Card> presentOnTable = new List<Card>();
        public int currentPot = 0;
        public int highestBet = 0;

        //Add cards to the table -- the dealer
        public void AddCardsToTable(Card[] toPlace)
        {
            foreach (Card card in toPlace)
            {
                presentOnTable.Add(card);
            }
        }

        //Reset Table for next round
        public void RefreshTable()
        {
            presentOnTable.Clear();
            currentPot = 0;
            highestBet = 0;
        }

        public void PrintTable()
        {
            for (int i = 0; i < presentOnTable.Count; i++)
            {
                Console.WriteLine("In Position " + i + " is the " + presentOnTable[i].rank + " of " + presentOnTable[i].suit);
            }
        }


        // Returns the number of cards on the table
        public int GetNoCardsOnTable()
        {
            return presentOnTable.Count();
        }

        // Returns the card in position 'pos'
        public Card GetCardInPosition(int pos)
        {
            return presentOnTable[pos];
        }
    }
}